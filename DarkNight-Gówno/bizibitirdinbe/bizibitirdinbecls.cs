using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000002 RID: 2
	public static class bizibitirdinbecls
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002245 File Offset: 0x00000445
		public static void bizibitirdinbevd()
		{
			bizibitirdinbecls.oko = new GameObject();
			Object.DontDestroyOnLoad(bizibitirdinbecls.oko);
			bizibitirdinbecls.oko.AddComponent<Manager>();
		}

		// Token: 0x04000002 RID: 2
		public static GameObject oko;

		// Token: 0x04000003 RID: 3
		public static string Name = "Coopyy";

		// Token: 0x04000004 RID: 4
		public static string Discord = "";

		// Token: 0x04000005 RID: 5
		public static int int_0 = 999999;

		// Token: 0x04000006 RID: 6
		public static string assett = "https://cdn.discordapp.com/attachments/1116789894417752096/1116839194589937674/DarkNight";

		// Token: 0x04000007 RID: 7
		public static string logg = "";

		// Token: 0x04000008 RID: 8
		public static string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		// Token: 0x04000009 RID: 9
		public static string appdata2 = Environment.ExpandEnvironmentVariables("%appdata%");
	}
}
