using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace bizibitirdinbe
{
	// Token: 0x0200006E RID: 110
	public class OverrideManager
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00003D43 File Offset: 0x00001F43
		public Dictionary<OverrideAttribute, OverrideWrapper> Overrides
		{
			get
			{
				return OverrideManager._overrides;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00016824 File Offset: 0x00014A24
		public void OffHook()
		{
			foreach (OverrideWrapper overrideWrapper in this.Overrides.Values)
			{
				overrideWrapper.Revert();
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001687C File Offset: 0x00014A7C
		public void LoadOverride(MethodInfo method)
		{
			try
			{
				OverrideManager.<>c__DisplayClass3_0 CS$<>8__locals1 = new OverrideManager.<>c__DisplayClass3_0();
				CS$<>8__locals1.overrideAttribute_0 = (OverrideAttribute)Attribute.GetCustomAttribute(method, typeof(OverrideAttribute));
				if (this.Overrides.Count(new Func<KeyValuePair<OverrideAttribute, OverrideWrapper>, bool>(CS$<>8__locals1.method_0)) <= 0)
				{
					OverrideWrapper overrideWrapper = new OverrideWrapper(CS$<>8__locals1.overrideAttribute_0.Method, method, CS$<>8__locals1.overrideAttribute_0, null);
					overrideWrapper.Override();
					this.Overrides.Add(CS$<>8__locals1.overrideAttribute_0, overrideWrapper);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00016918 File Offset: 0x00014B18
		public void InitHook()
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				foreach (MethodInfo methodInfo in types[i].GetMethods())
				{
					if (methodInfo.Name == "OV_GetKey" && methodInfo.IsDefined(typeof(OverrideAttribute), false))
					{
						this.LoadOverride(methodInfo);
					}
				}
			}
		}

		// Token: 0x040001EB RID: 491
		public static Dictionary<OverrideAttribute, OverrideWrapper> _overrides = new Dictionary<OverrideAttribute, OverrideWrapper>();
	}
}
