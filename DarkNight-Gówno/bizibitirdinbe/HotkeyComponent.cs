using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Serialization;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000027 RID: 39
	[Component]
	public class HotkeyComponent : MonoBehaviour
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000C920 File Offset: 0x0000AB20
		public void Update()
		{
			if (HotkeyComponent.NeedsKeys)
			{
				List<KeyCode> currentKeys = HotkeyComponent.CurrentKeys.ToList<KeyCode>();
				HotkeyComponent.CurrentKeys.Clear();
				foreach (KeyCode keyCode in HotkeyComponent.Keys)
				{
					if (Input.GetKey(keyCode))
					{
						HotkeyComponent.CurrentKeys.Add(keyCode);
					}
				}
				if (HotkeyComponent.CurrentKeys.Count < HotkeyComponent.CurrentKeyCount && HotkeyComponent.CurrentKeyCount > 0)
				{
					HotkeyComponent.CurrentKeys = currentKeys;
					HotkeyComponent.StopKeys = true;
				}
				HotkeyComponent.CurrentKeyCount = HotkeyComponent.CurrentKeys.Count;
			}
			if (!MenuComponent.IsInMenu)
			{
				foreach (KeyValuePair<string, Action> keyValuePair in HotkeyComponent.ActionDict)
				{
					if ((!MiscOptions.PanicMode || keyValuePair.Key == "_PanicButton") && HotkeyUtilities.IsHotkeyDown(keyValuePair.Key))
					{
						keyValuePair.Value.Invoke();
					}
				}
				return;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000254D File Offset: 0x0000074D
		public static void Clear()
		{
			HotkeyComponent.NeedsKeys = false;
			HotkeyComponent.StopKeys = false;
			HotkeyComponent.CurrentKeyCount = 0;
			HotkeyComponent.CurrentKeys = new List<KeyCode>();
		}

		// Token: 0x040000D2 RID: 210
		public static bool NeedsKeys;

		// Token: 0x040000D3 RID: 211
		public static bool StopKeys;

		// Token: 0x040000D4 RID: 212
		public static int CurrentKeyCount;

		// Token: 0x040000D5 RID: 213
		public static List<KeyCode> CurrentKeys;

		// Token: 0x040000D6 RID: 214
		public static Dictionary<string, Action> ActionDict = new Dictionary<string, Action>();

		// Token: 0x040000D7 RID: 215
		public static KeyCode[] Keys = (KeyCode[])Enum.GetValues(typeof(KeyCode));
	}
}
