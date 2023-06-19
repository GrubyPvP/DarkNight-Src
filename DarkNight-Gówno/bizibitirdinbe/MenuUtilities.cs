using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000B4 RID: 180
	public class MenuUtilities
	{
		// Token: 0x0600030C RID: 780 RVA: 0x00004406 File Offset: 0x00002606
		static MenuUtilities()
		{
			MenuUtilities.TexClear.SetPixel(0, 0, new Color(0f, 0f, 0f, 0f));
			MenuUtilities.TexClear.Apply();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0001AB98 File Offset: 0x00018D98
		public static void FixGUIStyleColor(GUIStyle style)
		{
			style.normal.background = MenuUtilities.TexClear;
			style.onNormal.background = MenuUtilities.TexClear;
			style.active.background = MenuUtilities.TexClear;
			style.onActive.background = MenuUtilities.TexClear;
			style.focused.background = MenuUtilities.TexClear;
			style.onFocused.background = MenuUtilities.TexClear;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00004444 File Offset: 0x00002644
		public static Rect Inline(Rect rect, float border = 1f)
		{
			return new Rect(rect.x + border, rect.y + border, rect.width - border * 2f, rect.height - border * 2f);
		}

		// Token: 0x040003D5 RID: 981
		public static Texture2D TexClear = new Texture2D(1, 1);
	}
}
