using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace bizibitirdinbe
{
	// Token: 0x0200006C RID: 108
	public class ConfigManager
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public static void Init()
		{
			Directory.CreateDirectory(ConfigManager.appdata + "\\DarkNight");
			ConfigManager.LoadConfig(ConfigManager.GetConfig());
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001649C File Offset: 0x0001469C
		public static Dictionary<string, object> CollectConfig()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"Version",
					ConfigManager.ConfigVersion
				}
			};
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes().Where(new Func<Type, bool>(ConfigManager.<>c.<>c_0.method_0)).ToArray<Type>())
			{
				foreach (FieldInfo fieldInfo in type.GetFields().Where(new Func<FieldInfo, bool>(ConfigManager.<>c.<>c_0.method_1)).ToArray<FieldInfo>())
				{
					dictionary.Add(type.Name + "_" + fieldInfo.Name, fieldInfo.GetValue(null));
				}
			}
			return dictionary;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001657C File Offset: 0x0001477C
		public static Dictionary<string, object> GetConfig()
		{
			if (!File.Exists(ConfigManager.ConfigPath))
			{
				ConfigManager.SaveConfig();
			}
			Dictionary<string, object> result = new Dictionary<string, object>();
			try
			{
				result = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(ConfigManager.ConfigPath), new JsonSerializerSettings
				{
					Formatting = 1
				});
			}
			catch
			{
				ConfigManager.SaveConfig();
			}
			return result;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003CD3 File Offset: 0x00001ED3
		public static void SaveConfig()
		{
			ColorOptions.ColorDict = ColorOptions.ColorDict;
			File.WriteAllText(ConfigManager.ConfigPath, JsonConvert.SerializeObject(ConfigManager.CollectConfig(), 1));
			T.AddNotification("Save Config - " + ConfigManager.current);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000165DC File Offset: 0x000147DC
		public static void LoadConfig(Dictionary<string, object> Config)
		{
			if (File.Exists(ConfigManager.ConfigPath))
			{
				foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
				{
					foreach (FieldInfo fieldInfo in type.GetFields().Where(new Func<FieldInfo, bool>(ConfigManager.<>c.<>c_0.method_2)))
					{
						string key = string.Format("{0}_{1}", type.Name, fieldInfo.Name);
						Type fieldType = fieldInfo.FieldType;
						object value = fieldInfo.GetValue(null);
						if (!Config.ContainsKey(key))
						{
							Config.Add(key, value);
						}
						try
						{
							if (Config[key].GetType() == typeof(JArray))
							{
								Config[key] = ((JArray)Config[key]).ToObject(fieldInfo.FieldType);
							}
							if (Config[key].GetType() == typeof(JObject))
							{
								Config[key] = ((JObject)Config[key]).ToObject(fieldInfo.FieldType);
							}
							fieldInfo.SetValue(null, fieldInfo.FieldType.IsEnum ? Enum.ToObject(fieldInfo.FieldType, Config[key]) : Convert.ChangeType(Config[key], fieldInfo.FieldType));
						}
						catch
						{
							Config[key] = value;
						}
					}
				}
				Main.Initialize();
				T.AddNotification("Load Config - " + ConfigManager.current);
			}
		}

		// Token: 0x040001E3 RID: 483
		public static string ConfigPath = string.Format("{0}/DarkNight/DarkNightDefault.cfg", Environment.ExpandEnvironmentVariables("%appdata%"));

		// Token: 0x040001E4 RID: 484
		public static string appdata = Environment.ExpandEnvironmentVariables("%appdata%/");

		// Token: 0x040001E5 RID: 485
		public static string current = "DarkNightDefault";

		// Token: 0x040001E6 RID: 486
		public static string ConfigVersion = "31";
	}
}
