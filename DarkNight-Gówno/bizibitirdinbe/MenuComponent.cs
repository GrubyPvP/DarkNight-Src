using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000048 RID: 72
	public class MenuComponent : MonoBehaviour
	{
		// Token: 0x0400015D RID: 349
		public static Texture2D[] Icons;

		// Token: 0x0400015E RID: 350
		public static Font _TabFont;

		// Token: 0x0400015F RID: 351
		public static Font _TextFont;

		// Token: 0x04000160 RID: 352
		public static Texture2D _Logo;

		// Token: 0x04000161 RID: 353
		public static bool IsInMenu;

		// Token: 0x04000162 RID: 354
		public static KeyCode MenuKey = 282;

		// Token: 0x04000163 RID: 355
		public static Rect MenuRect = new Rect(400f, 200f, 640f, 500f);

		// Token: 0x04000164 RID: 356
		public static Color32 _OutlineBorderBlack;

		// Token: 0x04000165 RID: 357
		public static Color32 _OutlineBorderLightGray;

		// Token: 0x04000166 RID: 358
		public static Color32 _OutlineBorderDarkGray;

		// Token: 0x04000167 RID: 359
		public static Color32 _FillLightBlack;

		// Token: 0x04000168 RID: 360
		public static Color32 _Accent1;

		// Token: 0x04000169 RID: 361
		public static Color32 _Accent2;

		// Token: 0x0400016A RID: 362
		public static Rect _cursor = new Rect(0f, 0f, 23f, 31f);

		// Token: 0x0400016B RID: 363
		private Texture texture_0;

		// Token: 0x0400016C RID: 364
		public static int _pIndex = 0;
	}
}
