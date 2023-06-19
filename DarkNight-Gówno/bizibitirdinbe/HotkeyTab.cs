using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000011 RID: 17
	public static class HotkeyTab
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000070C0 File Offset: 0x000052C0
		public static void Tab()
		{
			GUILayout.BeginArea(new Rect(340f, 20f, 650f, 610f), "Hotkeys", "box");
			HotkeyTab.vector2_0 = GUILayout.BeginScrollView(HotkeyTab.vector2_0, Array.Empty<GUILayoutOption>());
			foreach (KeyValuePair<string, Dictionary<string, Hotkey>> keyValuePair in HotkeyOptions.HotkeyDict)
			{
				if (HotkeyTab.IsFirst)
				{
					HotkeyTab.IsFirst = false;
					HotkeyTab.DrawSpacer(keyValuePair.Key, true);
				}
				else
				{
					HotkeyTab.DrawSpacer(keyValuePair.Key, false);
				}
				foreach (KeyValuePair<string, Hotkey> keyValuePair2 in keyValuePair.Value)
				{
					HotkeyTab.DrawButton(keyValuePair2.Value.Name, keyValuePair2.Key);
				}
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022AD File Offset: 0x000004AD
		public static void DrawSpacer(string Text, bool First)
		{
			if (!First)
			{
				GUILayout.Space(10f);
			}
			GUILayout.Label(Text, new GUILayoutOption[0]);
			GUILayout.Space(8f);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000071E0 File Offset: 0x000053E0
		public static void DrawButton(string Option, string Identifier)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.Label(Option, new GUILayoutOption[0]);
			if (HotkeyTab.ClickedOption == Identifier)
			{
				if (GUILayout.Button("Put away", "SelectedButton", Array.Empty<GUILayoutOption>()))
				{
					HotkeyComponent.Clear();
					HotkeyOptions.UnorganizedHotkeys[Identifier].Keys = new KeyCode[0];
					HotkeyTab.ClickedOption = "";
				}
				if (!HotkeyComponent.StopKeys)
				{
					string text;
					if (HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Length != 0)
					{
						text = string.Join(" + ", HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Select(new Func<KeyCode, string>(HotkeyTab.<>c.<>c_0.method_0)).ToArray<string>());
					}
					else
					{
						text = "Not assigned";
					}
					GUILayout.Button(text, "SelectedButton", Array.Empty<GUILayoutOption>());
				}
				else
				{
					HotkeyOptions.UnorganizedHotkeys[Identifier].Keys = HotkeyComponent.CurrentKeys.ToArray();
					HotkeyComponent.Clear();
					GUILayout.Button(string.Join(" + ", HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Select(new Func<KeyCode, string>(HotkeyTab.<>c.<>c_0.method_1)).ToArray<string>()), new GUILayoutOption[0]);
					HotkeyTab.ClickedOption = "";
				}
			}
			else
			{
				string text2;
				if (HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Length != 0)
				{
					text2 = string.Join(" + ", HotkeyOptions.UnorganizedHotkeys[Identifier].Keys.Select(new Func<KeyCode, string>(HotkeyTab.<>c.<>c_0.method_2)).ToArray<string>());
				}
				else
				{
					text2 = "Not assigned";
				}
				if (GUILayout.Button(text2, "SelectedButton", Array.Empty<GUILayoutOption>()))
				{
					HotkeyComponent.Clear();
					HotkeyTab.ClickedOption = Identifier;
					HotkeyComponent.NeedsKeys = true;
				}
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(2f);
		}

		// Token: 0x0400006C RID: 108
		private static Vector2 vector2_0 = new Vector2(0f, 0f);

		// Token: 0x0400006D RID: 109
		public static Vector2 HotkeyScroll;

		// Token: 0x0400006E RID: 110
		public static string ClickedOption;

		// Token: 0x0400006F RID: 111
		public static bool IsFirst = true;
	}
}
