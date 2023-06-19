using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000047 RID: 71
	public class Drawing
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00003751 File Offset: 0x00001951
		public static void DrawRect(Rect position, Color color, GUIContent content = null)
		{
			Color backgroundColor = GUI.backgroundColor;
			GUI.backgroundColor = color;
			GUI.Box(position, content ?? GUIContent.none, Drawing.textureStyle);
			GUI.backgroundColor = backgroundColor;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003778 File Offset: 0x00001978
		public static void LayoutBox(Color color, GUIContent content = null)
		{
			Color backgroundColor = GUI.backgroundColor;
			GUI.backgroundColor = color;
			GUILayout.Box(content ?? GUIContent.none, Drawing.textureStyle, new GUILayoutOption[0]);
			GUI.backgroundColor = backgroundColor;
		}

		// Token: 0x0400015B RID: 347
		public static Texture2D backgroundTexture = Texture2D.whiteTexture;

		// Token: 0x0400015C RID: 348
		public static GUIStyle textureStyle = new GUIStyle
		{
			normal = new GUIStyleState
			{
				background = Drawing.backgroundTexture
			}
		};
	}
}
