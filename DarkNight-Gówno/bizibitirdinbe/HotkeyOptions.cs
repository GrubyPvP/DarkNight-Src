using System;
using System.Collections.Generic;

namespace bizibitirdinbe
{
	// Token: 0x0200008C RID: 140
	public static class HotkeyOptions
	{
		// Token: 0x040002D5 RID: 725
		[Save]
		public static Dictionary<string, Dictionary<string, Hotkey>> HotkeyDict = new Dictionary<string, Dictionary<string, Hotkey>>();

		// Token: 0x040002D6 RID: 726
		[Save]
		public static Dictionary<string, Hotkey> UnorganizedHotkeys = new Dictionary<string, Hotkey>();
	}
}
