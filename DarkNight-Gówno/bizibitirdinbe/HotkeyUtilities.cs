using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000AE RID: 174
	public static class HotkeyUtilities
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0001A3E8 File Offset: 0x000185E8
		public static void AddHotkey(string Group, string Name, string Identifier, params KeyCode[] DefaultKeys)
		{
			if (!HotkeyOptions.HotkeyDict.ContainsKey(Group))
			{
				HotkeyOptions.HotkeyDict.Add(Group, new Dictionary<string, Hotkey>());
			}
			Dictionary<string, Hotkey> dictionary = HotkeyOptions.HotkeyDict[Group];
			if (!dictionary.ContainsKey(Identifier))
			{
				Hotkey value = new Hotkey
				{
					Name = Name,
					Keys = DefaultKeys
				};
				dictionary.Add(Identifier, value);
				HotkeyOptions.UnorganizedHotkeys.Add(Identifier, value);
				return;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001A458 File Offset: 0x00018658
		public static bool IsHotkeyDown(string Identifier)
		{
			return HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Any(new Func<KeyCode, bool>(Input.GetKeyDown)) && HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.All(new Func<KeyCode, bool>(Input.GetKey));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000043AA File Offset: 0x000025AA
		public static bool IsHotkeyHeld(string Identifier)
		{
			return HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.All(new Func<KeyCode, bool>(Input.GetKey));
		}
	}
}
