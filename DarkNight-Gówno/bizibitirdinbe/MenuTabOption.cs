using System;
using System.Collections.Generic;

namespace bizibitirdinbe
{
	// Token: 0x020000CD RID: 205
	public class MenuTabOption
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00004786 File Offset: 0x00002986
		public MenuTabOption(string name, MenuTabOption.MenuTab tab)
		{
			this.tab = tab;
			this.name = name;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000479D File Offset: 0x0000299D
		public static void Add(MenuTabOption tab)
		{
			MenuTabOption.tabs.Add(tab);
		}

		// Token: 0x04000415 RID: 1045
		public static MenuTabOption CurrentTab;

		// Token: 0x04000416 RID: 1046
		public static List<MenuTabOption> tabs = new List<MenuTabOption>();

		// Token: 0x04000417 RID: 1047
		public bool enabled;

		// Token: 0x04000418 RID: 1048
		public string name;

		// Token: 0x04000419 RID: 1049
		public MenuTabOption.MenuTab tab;

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x0600035D RID: 861
		public delegate void MenuTab();
	}
}
