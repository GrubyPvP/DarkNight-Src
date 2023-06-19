using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200004A RID: 74
	public static class Prefab
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x000037D1 File Offset: 0x000019D1
		public static bool AbsButton(Rect area, string text, params GUILayoutOption[] options)
		{
			Drawing.DrawRect(area, MenuComponent._OutlineBorderBlack, null);
			return GUI.Button(MenuUtilities.Inline(area, 1f), text, Prefab._ButtonStyle);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000037FA File Offset: 0x000019FA
		public static bool Button(string text, Rect rect)
		{
			Drawing.DrawRect(rect, MenuComponent._OutlineBorderBlack, null);
			return GUI.Button(MenuUtilities.Inline(rect, 1f), text, Prefab._ButtonStyle);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00012A70 File Offset: 0x00010C70
		public static bool Button(string text, float width, float height = 25f, params GUILayoutOption[] options)
		{
			List<GUILayoutOption> list = options.ToList<GUILayoutOption>();
			list.Add(GUILayout.Height(height));
			list.Add(GUILayout.Width(width));
			return Prefab.AbsButton(GUILayoutUtility.GetRect(width, height, list.ToArray()), text, options);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00012AB4 File Offset: 0x00010CB4
		public static int Arrows(float width, int listEntry, string content, int max)
		{
			Rect rect = GUILayoutUtility.GetRect(width, 25f, new GUILayoutOption[]
			{
				GUILayout.Height(25f),
				GUILayout.Width(width)
			});
			if (Prefab.Button("<", new Rect(rect.x, rect.y, 25f, 25f)))
			{
				listEntry--;
			}
			GUI.Label(MenuUtilities.Inline(new Rect(rect.x + 25f, rect.y, rect.width - 50f, 25f), 1f), content, Prefab._listStyle);
			if (Prefab.Button(">", new Rect(rect.x + rect.width - 25f, rect.y, 25f, 25f)))
			{
				listEntry++;
			}
			if (listEntry < 0)
			{
				listEntry = max;
			}
			else if (listEntry > max)
			{
				listEntry = 0;
			}
			return listEntry;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003823 File Offset: 0x00001A23
		public static Rect Inline(Rect rect, int border = 1)
		{
			return new Rect(rect.x + (float)border, rect.y + (float)border, rect.width - (float)(border * 2), rect.height - (float)(border * 2));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00012BAC File Offset: 0x00010DAC
		public static void ScrollView(Rect rect, ref Vector2 scrollpos, Action code)
		{
			GUILayout.BeginArea(rect);
			scrollpos = GUILayout.BeginScrollView(scrollpos, false, true, new GUILayoutOption[0]);
			try
			{
				code();
			}
			catch (Exception)
			{
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00012C00 File Offset: 0x00010E00
		public static void ScrollView(Rect rect, ref SerializableVector2 scrollpos, Action code)
		{
			GUILayout.BeginArea(rect);
			scrollpos = GUILayout.BeginScrollView(scrollpos.ToVector2(), false, true, new GUILayoutOption[0]);
			try
			{
				code();
			}
			catch (Exception)
			{
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00012C54 File Offset: 0x00010E54
		public static float Slider(float left, float right, float value, int size)
		{
			GUIStyle sliderThumbStyle = Prefab._sliderThumbStyle;
			GUIStyle sliderStyle = Prefab._sliderStyle;
			float num = (sliderThumbStyle.fixedWidth != 0f) ? sliderThumbStyle.fixedWidth : ((float)sliderThumbStyle.padding.horizontal);
			value = GUILayout.HorizontalSlider(value, left, right, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, new GUILayoutOption[]
			{
				GUILayout.Width((float)size)
			});
			Rect lastRect = GUILayoutUtility.GetLastRect();
			float num2 = (lastRect.width - (float)sliderStyle.padding.horizontal - num) / (right - left);
			Rect rect = new Rect((value - left) * num2 + lastRect.x + (float)sliderStyle.padding.left, lastRect.y + (float)sliderStyle.padding.top, num, lastRect.height - (float)sliderStyle.padding.vertical);
			Drawing.DrawRect(lastRect, MenuComponent._FillLightBlack, null);
			Drawing.DrawRect(new Rect(lastRect.x, lastRect.y + lastRect.height / 2f - 2f, lastRect.width, 4f), Prefab._ToggleBoxBG, null);
			Drawing.DrawRect(rect, MenuComponent._OutlineBorderBlack, null);
			Drawing.DrawRect(MenuUtilities.Inline(rect, 1f), Prefab._MenuTabStyle.onNormal.textColor, null);
			GUILayout.Space(5f);
			return value;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public static bool MenuTab2(string text, ref bool state, int fontsize = 29)
		{
			bool result = false;
			int fontSize = Prefab._MenuTabStyle2.fontSize;
			Prefab._MenuTabStyle2.fontSize = fontsize;
			bool flag = GUILayout.Toggle(state, text.ToUpper(), Prefab._MenuTabStyle2, Array.Empty<GUILayoutOption>());
			if (state != flag)
			{
				state = !state;
				result = true;
			}
			Prefab._MenuTabStyle2.fontSize = fontSize;
			return result;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00003856 File Offset: 0x00001A56
		public static void ToggleButton(ref bool toggle, string head, GUIStyle gUIStyle)
		{
			if (GUILayout.Button(head, gUIStyle, new GUILayoutOption[0]))
			{
				toggle = !toggle;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000386E File Offset: 0x00001A6E
		public static bool Toggle(ref bool value, string head, int fakeint = 0)
		{
			value = GUILayout.Toggle(value, head, new GUILayoutOption[0]);
			return value;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00012E2C File Offset: 0x0001102C
		public static void ToggleLast(ref bool state)
		{
			Rect lastRect = GUILayoutUtility.GetLastRect();
			lastRect..ctor(lastRect.x + 161f, lastRect.y - 14f, 13f, 13f);
			Rect position = MenuUtilities.Inline(lastRect, 1f);
			Drawing.DrawRect(lastRect, MenuComponent._OutlineBorderBlack, null);
			Drawing.DrawRect(position, Prefab._ToggleBoxBG, null);
			if (GUI.Button(lastRect, GUIContent.none, Prefab._TextStyle))
			{
				state = !state;
			}
			if (state)
			{
				Drawing.DrawRect(position, MenuComponent._Accent2, null);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00003882 File Offset: 0x00001A82
		public static bool Toggle(string head, ref bool value, int fakeint = 0)
		{
			value = GUILayout.Toggle(value, head, new GUILayoutOption[0]);
			return value;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00012ED0 File Offset: 0x000110D0
		public static string TextField(string text, string label, int width)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.Label(label, new GUILayoutOption[0]);
			float y = new GUIStyle().CalcSize(new GUIContent("asdf")).y;
			Rect rect = GUILayoutUtility.GetRect((float)width, y + 10f);
			text = GUI.TextField(new Rect(rect.x + 4f, rect.y + 2f, rect.width, rect.height), text);
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			return text;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003896 File Offset: 0x00001A96
		public static string TextField(string text, string label)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.Label(label, new GUILayoutOption[0]);
			text = GUILayout.TextField(text.ToString(), new GUILayoutOption[]
			{
				GUILayout.Width(565f)
			});
			GUILayout.EndHorizontal();
			return text;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00012F64 File Offset: 0x00011164
		public static int TextField(int text, string label, int maxL, int min = 0, int max = 255)
		{
			GUILayout.BeginHorizontal(new GUILayoutOption[0]);
			GUILayout.Label(label, new GUILayoutOption[0]);
			int num = int.Parse(GUILayout.TextField(text.ToString(), maxL, new GUILayoutOption[]
			{
				GUILayout.Width((float)(maxL * 10 + 1))
			}));
			if (num >= min && num <= max)
			{
				text = num;
			}
			GUILayout.EndHorizontal();
			return text;
		}

		// Token: 0x04000179 RID: 377
		public static GUIStyle _None;

		// Token: 0x0400017A RID: 378
		public static GUIStyle _MenuTabStyle;

		// Token: 0x0400017B RID: 379
		public static GUIStyle _MenuTabStyle2;

		// Token: 0x0400017C RID: 380
		public static GUIStyle _HeaderStyle;

		// Token: 0x0400017D RID: 381
		public static GUIStyle _HeaderStyle2;

		// Token: 0x0400017E RID: 382
		public static GUIStyle _TextStyle;

		// Token: 0x0400017F RID: 383
		public static GUIStyle _sliderStyle;

		// Token: 0x04000180 RID: 384
		public static GUIStyle _sliderThumbStyle;

		// Token: 0x04000181 RID: 385
		public static GUIStyle _sliderVThumbStyle;

		// Token: 0x04000182 RID: 386
		public static GUIStyle _listStyle;

		// Token: 0x04000183 RID: 387
		public static GUIStyle _ButtonStyle;

		// Token: 0x04000184 RID: 388
		public static Color32 _ToggleBoxBG;

		// Token: 0x04000185 RID: 389
		private static int int_0 = "PopupList".GetHashCode();

		// Token: 0x04000186 RID: 390
		public static Regex digitsOnly = new Regex("[^\\d]");
	}
}
