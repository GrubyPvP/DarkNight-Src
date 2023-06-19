using System;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x02000087 RID: 135
	public static class AimbotOptions
	{
		// Token: 0x04000276 RID: 630
		[Save]
		public static bool Enabled = false;

		// Token: 0x04000277 RID: 631
		[Save]
		public static float float_0 = 15f;

		// Token: 0x04000278 RID: 632
		[Save]
		public static bool ShowAimUseFOV = true;

		// Token: 0x04000279 RID: 633
		[Save]
		public static bool bool_0 = false;

		// Token: 0x0400027A RID: 634
		[Save]
		public static bool UseGunDistance = false;

		// Token: 0x0400027B RID: 635
		[Save]
		public static int HitChance = 100;

		// Token: 0x0400027C RID: 636
		[Save]
		public static bool Smooth = false;

		// Token: 0x0400027D RID: 637
		[Save]
		public static bool OnKey = true;

		// Token: 0x0400027E RID: 638
		[Save]
		public static int HitboxSize = 15;

		// Token: 0x0400027F RID: 639
		public static float MaxSpeed = 20f;

		// Token: 0x04000280 RID: 640
		[Save]
		public static float AimSpeed = 5f;

		// Token: 0x04000281 RID: 641
		[Save]
		public static float Distance = 300f;

		// Token: 0x04000282 RID: 642
		[Save]
		public static ELimb TargetLimb = 13;

		// Token: 0x04000283 RID: 643
		[Save]
		public static TargetMode TargetMode = TargetMode.FOV;

		// Token: 0x04000284 RID: 644
		[Save]
		public static bool NoAimbotDrop = false;
	}
}
