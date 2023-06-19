using System;
using System.Reflection;

// Token: 0x020000D1 RID: 209
internal class Class2
{
	// Token: 0x06000375 RID: 885 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
	internal static void smethod_0(int typemdt)
	{
		Type type = Class2.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class2.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x04000423 RID: 1059
	internal static Module module_0 = typeof(Class2).Assembly.ManifestModule;

	// Token: 0x020000D2 RID: 210
	// (Invoke) Token: 0x06000379 RID: 889
	internal delegate void Delegate0(object o);
}
