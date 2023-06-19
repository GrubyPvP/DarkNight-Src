using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace bizibitirdinbe
{
	// Token: 0x0200006A RID: 106
	public static class AttributeManager
	{
		// Token: 0x06000254 RID: 596 RVA: 0x000162BC File Offset: 0x000144BC
		public static void Init()
		{
			List<Type> list = new List<Type>();
			List<MethodInfo> list2 = new List<MethodInfo>();
			List<MethodInfo> list3 = new List<MethodInfo>();
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				if (type.IsDefined(typeof(ComponentAttribute), false))
				{
					bizibitirdinbecls.oko.AddComponent(type);
				}
				if (type.IsDefined(typeof(SpyComponentAttribute), false))
				{
					list.Add(type);
				}
				MethodInfo[] methods = type.GetMethods(ReflectionVariables.Everything);
				for (int j = 0; j < methods.Length; j++)
				{
					AttributeManager.<>c__DisplayClass0_0 CS$<>8__locals1 = new AttributeManager.<>c__DisplayClass0_0();
					CS$<>8__locals1.methodInfo_0 = methods[j];
					if (CS$<>8__locals1.methodInfo_0.IsDefined(typeof(InitializerAttribute), false))
					{
						CS$<>8__locals1.methodInfo_0.Invoke(null, null);
					}
					if (CS$<>8__locals1.methodInfo_0.IsDefined(typeof(OverrideAttribute), false))
					{
						new OverrideManager().LoadOverride(CS$<>8__locals1.methodInfo_0);
					}
					if (CS$<>8__locals1.methodInfo_0.IsDefined(typeof(OnSpyAttribute), false))
					{
						list2.Add(CS$<>8__locals1.methodInfo_0);
					}
					if (CS$<>8__locals1.methodInfo_0.IsDefined(typeof(OffSpyAttribute), false))
					{
						list3.Add(CS$<>8__locals1.methodInfo_0);
					}
					if (CS$<>8__locals1.methodInfo_0.IsDefined(typeof(ThreadAttribute), false))
					{
						new Thread(new ThreadStart(CS$<>8__locals1.method_0)).Start();
					}
				}
			}
			SpyManager.Components = list;
			SpyManager.PostSpy = list3;
			SpyManager.PreSpy = list2;
		}
	}
}
