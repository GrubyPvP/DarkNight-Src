using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000018 RID: 24
	public class SettingsTab
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00009D30 File Offset: 0x00007F30
		public static void Tab()
		{
			GUILayout.BeginArea(new Rect(300f, 0f, 940f, 40f), "TabBtn");
			SettingsTab.Select = (SettingsOptions)GUI.Toolbar(new Rect(15f, 10f, 700f, 40f), (int)SettingsTab.Select, Main.buttons4.ToArray(), "TabBtn");
			GUILayout.EndArea();
			Rect rect = new Rect(345f, 70f, 310f, 560f);
			GUIStyle guistyle = "box";
			GUILayout.BeginArea(rect, string.Format("<size=15>{0}</size>", SettingsTab.Select), guistyle);
			SettingsTab.vector2_0 = GUILayout.BeginScrollView(SettingsTab.vector2_0, Array.Empty<GUILayoutOption>());
			switch (SettingsTab.Select)
			{
			case SettingsOptions.GUISkins:
			{
				SettingsTab.vector2_4 = GUILayout.BeginScrollView(SettingsTab.vector2_4, Array.Empty<GUILayoutOption>());
				int count = AssetUtilities.GetSkins(false).Count;
				if (GUILayout.Button("Load Default GUI", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					MiscOptions.UISkin = "";
					AssetUtilities.Skin = AssetUtilities.VanillaSkin;
				}
				foreach (string text in AssetUtilities.GetSkins(false))
				{
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				break;
			}
			case SettingsOptions.Hitmarker:
				SettingsTab.vector2_1 = GUILayout.BeginScrollView(SettingsTab.vector2_1, Array.Empty<GUILayoutOption>());
				if (GUILayout.Button("None", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.HitmarkerSoundStatus = false;
					WeaponOptions.csgo = false;
					WeaponOptions.skeet = false;
					WeaponOptions.rust = false;
				}
				if (GUILayout.Button("Bonk Sound", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.HitmarkerSoundStatus = true;
					WeaponOptions.csgo = false;
					WeaponOptions.skeet = false;
					WeaponOptions.rust = false;
				}
				if (GUILayout.Button("Rust HeadShot Sound", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.HitmarkerSoundStatus = false;
					WeaponOptions.csgo = false;
					WeaponOptions.skeet = false;
					WeaponOptions.rust = true;
				}
				if (GUILayout.Button("Skeet Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.HitmarkerSoundStatus = false;
					WeaponOptions.csgo = false;
					WeaponOptions.skeet = true;
					WeaponOptions.rust = false;
				}
				if (GUILayout.Button("Csgo Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.HitmarkerSoundStatus = false;
					WeaponOptions.csgo = true;
					WeaponOptions.skeet = false;
					WeaponOptions.rust = false;
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				break;
			case SettingsOptions.Font:
				SettingsTab.vector2_1 = GUILayout.BeginScrollView(SettingsTab.vector2_1, Array.Empty<GUILayoutOption>());
				if (GUILayout.Button("Minecraft2", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = AssetUtilities.Fonts["MinecraftFont"];
				}
				if (GUILayout.Button("Montserrat-Medium", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = AssetUtilities.Fonts["Montserrat-Medium"];
				}
				if (GUILayout.Button("Minecraft", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = AssetUtilities.Fonts["Minecraft"];
				}
				if (GUILayout.Button("Gamer", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = AssetUtilities.Fonts["Gamer"];
				}
				if (GUILayout.Button("Font", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = AssetUtilities.Fonts["font"];
				}
				if (GUILayout.Button("Arial", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPComponent.ESPFont = Font.CreateDynamicFontFromOSFont("Arial", 11);
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				break;
			case SettingsOptions.Config:
				if (GUILayout.Button("Save Config", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ConfigManager.ConfigPath = ConfigManager.appdata + "/DarkNight/" + ConfigManager.current + ".cfg";
					ConfigManager.SaveConfig();
				}
				ConfigManager.current = GUILayout.TextField(ConfigManager.current, Array.Empty<GUILayoutOption>());
				GUILayout.EndArea();
				break;
			case SettingsOptions.EspStyle:
				SettingsTab.vector2_1 = GUILayout.BeginScrollView(SettingsTab.vector2_1, Array.Empty<GUILayoutOption>());
				if (GUILayout.Button("Esp Style", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = true;
					ESPOptions.EspStyle1 = false;
					ESPOptions.EspStyle2 = false;
					ESPOptions.EspStyle3 = false;
					ESPOptions.EspStyle4 = false;
					ESPOptions.EspStyle5 = false;
				}
				if (GUILayout.Button("Esp Style1", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = false;
					ESPOptions.EspStyle1 = true;
					ESPOptions.EspStyle2 = false;
					ESPOptions.EspStyle3 = false;
					ESPOptions.EspStyle4 = false;
					ESPOptions.EspStyle5 = false;
				}
				if (GUILayout.Button("Esp Style2", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = false;
					ESPOptions.EspStyle1 = false;
					ESPOptions.EspStyle2 = true;
					ESPOptions.EspStyle3 = false;
					ESPOptions.EspStyle4 = false;
					ESPOptions.EspStyle5 = false;
				}
				if (GUILayout.Button("Esp Style3", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = false;
					ESPOptions.EspStyle1 = false;
					ESPOptions.EspStyle2 = false;
					ESPOptions.EspStyle3 = true;
					ESPOptions.EspStyle4 = false;
					ESPOptions.EspStyle5 = false;
				}
				if (GUILayout.Button("Esp Style4", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = false;
					ESPOptions.EspStyle1 = false;
					ESPOptions.EspStyle2 = false;
					ESPOptions.EspStyle3 = false;
					ESPOptions.EspStyle4 = true;
					ESPOptions.EspStyle5 = false;
				}
				if (GUILayout.Button("Esp Style5", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					ESPOptions.EspStyle = false;
					ESPOptions.EspStyle1 = false;
					ESPOptions.EspStyle2 = false;
					ESPOptions.EspStyle3 = false;
					ESPOptions.EspStyle4 = false;
					ESPOptions.EspStyle5 = true;
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				break;
			case SettingsOptions.KillSounds:
				SettingsTab.vector2_1 = GUILayout.BeginScrollView(SettingsTab.vector2_1, Array.Empty<GUILayoutOption>());
				if (GUILayout.Button("None", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = false;
					WeaponOptions.Ez4ence = false;
				}
				if (GUILayout.Button("Roblox Kill Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = true;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = false;
				}
				if (GUILayout.Button("Coin Kill Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = true;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = false;
				}
				if (GUILayout.Button("Hypiexl Kill Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = true;
				}
				if (GUILayout.Button("Sigma", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = true;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = false;
				}
				if (GUILayout.Button("EZ4ENCE", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = false;
					WeaponOptions.hypixe = false;
					WeaponOptions.Ez4ence = true;
				}
				if (GUILayout.Button("COD kill Sounds", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					WeaponOptions.OofOnDeath = false;
					WeaponOptions.coin = false;
					WeaponOptions.sigma = false;
					WeaponOptions.Cod = true;
					WeaponOptions.hypixe = false;
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
				break;
			case SettingsOptions.Info:
				GUILayout.Label("Status: CHÓJ GÓWNO KUTAS", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Version: 2.1.3.7", Array.Empty<GUILayoutOption>());
				GUILayout.Label("Cracked by: @coopyy and i like men", Array.Empty<GUILayoutOption>());
				GUILayout.Label("what a dogshit paste lmao fr", Array.Empty<GUILayoutOption>());
				GUILayout.EndArea();
				break;
			}
			GUILayout.EndArea();
			Rect rect2 = new Rect(670f, 70f, 310f, 560f);
			guistyle = "box";
			GUILayout.BeginArea(rect2, string.Format("<size=15>{0}</size>", SettingsTab.Select), guistyle);
			switch (SettingsTab.Select)
			{
			case SettingsOptions.GUISkins:
				SettingsTab.vector2_4 = GUILayout.BeginScrollView(SettingsTab.vector2_4, Array.Empty<GUILayoutOption>());
				if (AssetUtilities.GetSkins(false).Count == 0)
				{
					GUILayout.Label("You have no GuiSkins", Array.Empty<GUILayoutOption>());
				}
				foreach (string text2 in AssetUtilities.GetSkins(false))
				{
					string text3 = text2;
					if (text3 == MiscOptions.UISkin)
					{
						text3 = "<b>" + text3 + "</b>";
					}
					if (GUILayout.Button(text3, "verticalslider", Array.Empty<GUILayoutOption>()))
					{
						AssetUtilities.smethod_0(text2);
					}
				}
				GUILayout.EndScrollView();
				break;
			case SettingsOptions.Hitmarker:
				GUILayout.Label("Hitmarker Sound Volume: " + WeaponOptions.HitmarkerSoundVolume.ToString(), Array.Empty<GUILayoutOption>());
				WeaponOptions.HitmarkerSoundVolume = (float)((int)GUILayout.HorizontalSlider(WeaponOptions.HitmarkerSoundVolume, 0f, 50f, Array.Empty<GUILayoutOption>()));
				break;
			case SettingsOptions.Config:
				SettingsTab.vector2_4 = GUILayout.BeginScrollView(SettingsTab.vector2_4, Array.Empty<GUILayoutOption>());
				foreach (string text4 in SettingsTab.GetConfigs(false))
				{
					if (GUILayout.Button(text4.Replace(".cfg", ""), "verticalslider", Array.Empty<GUILayoutOption>()))
					{
						ConfigManager.current = text4.Replace(".cfg", "");
						ConfigManager.ConfigPath = ConfigManager.appdata + "/DarkNight/" + text4;
						ConfigManager.Init();
						SkinsUtilities.ApplyFromConfig();
					}
				}
				GUILayout.EndScrollView();
				break;
			case SettingsOptions.KillSounds:
				GUILayout.Label("Kill Sound Volume: " + WeaponOptions.KillSoundVolume.ToString(), Array.Empty<GUILayoutOption>());
				WeaponOptions.KillSoundVolume = (float)((int)GUILayout.HorizontalSlider(WeaponOptions.KillSoundVolume, 0f, 50f, Array.Empty<GUILayoutOption>()));
				break;
			}
			GUILayout.EndArea();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000A76C File Offset: 0x0000896C
		public static List<string> GetConfigs(bool Extensions = false)
		{
			List<string> list = new List<string>();
			foreach (FileInfo fileInfo in new DirectoryInfo(ConfigManager.appdata + "/DarkNight/").GetFiles("*.cfg"))
			{
				if (Extensions)
				{
					list.Add(fileInfo.Name.Substring(0, fileInfo.Name.Length));
				}
				else
				{
					list.Add(fileInfo.Name.Substring(0, fileInfo.Name.Length));
				}
			}
			return list;
		}

		// Token: 0x040000B2 RID: 178
		public static string configname = "";

		// Token: 0x040000B3 RID: 179
		public static string SelectedColorIdentifier = "";

		// Token: 0x040000B4 RID: 180
		private static Vector2 vector2_0 = new Vector2(0f, 0f);

		// Token: 0x040000B5 RID: 181
		private static Vector2 vector2_1 = new Vector2(0f, 0f);

		// Token: 0x040000B6 RID: 182
		private static Vector2 vector2_2 = new Vector2(0f, 0f);

		// Token: 0x040000B7 RID: 183
		public static SettingsOptions Select = SettingsOptions.Info;

		// Token: 0x040000B8 RID: 184
		private static string string_0 = "New Config";

		// Token: 0x040000B9 RID: 185
		private static Vector2 vector2_3 = new Vector2(0f, 0f);

		// Token: 0x040000BA RID: 186
		private static Vector2 vector2_4 = new Vector2(0f, 0f);
	}
}
