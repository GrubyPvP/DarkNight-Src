using System;
using System.Reflection;

namespace bizibitirdinbe
{
	// Token: 0x020000C9 RID: 201
	public static class ReflectionVariables
	{
		// Token: 0x04000403 RID: 1027
		public static BindingFlags PublicInstance = BindingFlags.Instance | BindingFlags.Public;

		// Token: 0x04000404 RID: 1028
		public static BindingFlags publicInstance = BindingFlags.Instance | BindingFlags.NonPublic;

		// Token: 0x04000405 RID: 1029
		public static BindingFlags PublicStatic = BindingFlags.Static | BindingFlags.Public;

		// Token: 0x04000406 RID: 1030
		public static BindingFlags publicStatic = BindingFlags.Static | BindingFlags.NonPublic;

		// Token: 0x04000407 RID: 1031
		public static BindingFlags Everything = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
