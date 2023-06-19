using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000095 RID: 149
	public static class RadarOptions
	{
		// Token: 0x04000391 RID: 913
		[Save]
		public static bool Enabled = false;

		// Token: 0x04000392 RID: 914
		[Save]
		public static int type = 3;

		// Token: 0x04000393 RID: 915
		[Save]
		public static bool DetialedPlayers = false;

		// Token: 0x04000394 RID: 916
		[Save]
		public static bool ShowPlayers = false;

		// Token: 0x04000395 RID: 917
		[Save]
		public static bool ShowVehicles = false;

		// Token: 0x04000396 RID: 918
		[Save]
		public static bool ShowVehiclesUnlocked = false;

		// Token: 0x04000397 RID: 919
		[Save]
		public static bool ShowDeathPosition = false;

		// Token: 0x04000398 RID: 920
		[Save]
		public static float RadarZoom = 1f;

		// Token: 0x04000399 RID: 921
		[Save]
		public static float RadarSize = 300f;

		// Token: 0x0400039A RID: 922
		[Save]
		public static SerializableRect vew = new Rect((float)Screen.width - RadarOptions.RadarSize - 20f, 10f, RadarOptions.RadarSize + 10f, RadarOptions.RadarSize + 10f);

		// Token: 0x0400039B RID: 923
		public static float cumbo = 90f;

		// Token: 0x0400039C RID: 924
		public static float cumbo2 = 90f;
	}
}
