using System;

namespace bizibitirdinbe
{
	// Token: 0x0200008B RID: 139
	public static class WeaponOptions
	{
		// Token: 0x040002AC RID: 684
		[Save]
		public static bool ShowWeaponInfo = false;

		// Token: 0x040002AD RID: 685
		[Save]
		public static bool HeatShot = false;

		// Token: 0x040002AE RID: 686
		[Save]
		public static float HeatShotVolume = 1f;

		// Token: 0x040002AF RID: 687
		[Save]
		public static float HitmarkerSoundVolume = 1f;

		// Token: 0x040002B0 RID: 688
		public static bool HitmarkerBonk = true;

		// Token: 0x040002B1 RID: 689
		public static bool HitmarkerSoundStatus = true;

		// Token: 0x040002B2 RID: 690
		public static bool csgo = false;

		// Token: 0x040002B3 RID: 691
		public static bool rust = false;

		// Token: 0x040002B4 RID: 692
		public static bool skeet = false;

		// Token: 0x040002B5 RID: 693
		public static string HitmarkerName = "defualt";

		// Token: 0x040002B6 RID: 694
		[Save]
		public static int TracerTime = 2;

		// Token: 0x040002B7 RID: 695
		[Save]
		public static bool Tracers = false;

		// Token: 0x040002B8 RID: 696
		public static bool RemoveHammerDelay = false;

		// Token: 0x040002B9 RID: 697
		public static bool RemoveBurstDelay = false;

		// Token: 0x040002BA RID: 698
		public static bool InstantReload = false;

		// Token: 0x040002BB RID: 699
		[Save]
		public static bool SafeZone = false;

		// Token: 0x040002BC RID: 700
		[Save]
		public static bool Admin = false;

		// Token: 0x040002BD RID: 701
		[Save]
		public static bool DamageIndicators = false;

		// Token: 0x040002BE RID: 702
		[Save]
		public static bool CustomCrosshair = false;

		// Token: 0x040002BF RID: 703
		[Save]
		public static SerializableColor CrosshairColor = new SerializableColor(255, 0, 0);

		// Token: 0x040002C0 RID: 704
		[Save]
		public static bool NoRecoil = false;

		// Token: 0x040002C1 RID: 705
		[Save]
		public static float NoRecoil1 = 0f;

		// Token: 0x040002C2 RID: 706
		[Save]
		public static float NoSpread1 = 0f;

		// Token: 0x040002C3 RID: 707
		[Save]
		public static float NoSway1 = 0f;

		// Token: 0x040002C4 RID: 708
		[Save]
		public static bool NoSpread = false;

		// Token: 0x040002C5 RID: 709
		[Save]
		public static bool Crosshair = true;

		// Token: 0x040002C6 RID: 710
		[Save]
		public static bool NoSway = false;

		// Token: 0x040002C7 RID: 711
		[Save]
		public static bool NoDrop = false;

		// Token: 0x040002C8 RID: 712
		[Save]
		public static bool RemoveReloadDelay = false;

		// Token: 0x040002C9 RID: 713
		[Save]
		public static bool OofOnDeath = false;

		// Token: 0x040002CA RID: 714
		[Save]
		public static bool Cod = false;

		// Token: 0x040002CB RID: 715
		[Save]
		public static bool coin = false;

		// Token: 0x040002CC RID: 716
		[Save]
		public static bool hypixe = false;

		// Token: 0x040002CD RID: 717
		[Save]
		public static bool Ez4ence = false;

		// Token: 0x040002CE RID: 718
		[Save]
		public static bool sigma = true;

		// Token: 0x040002CF RID: 719
		[Save]
		public static float KillSoundVolume = 2f;

		// Token: 0x040002D0 RID: 720
		[Save]
		public static bool AutoReload = false;

		// Token: 0x040002D1 RID: 721
		[Save]
		public static bool EnableBulletDropPrediction = true;

		// Token: 0x040002D2 RID: 722
		[Save]
		public static bool HighlightBulletDropPredictionTarget = true;

		// Token: 0x040002D3 RID: 723
		[Save]
		public static bool Zoom;

		// Token: 0x040002D4 RID: 724
		[Save]
		public static float ZoomValue = 16f;
	}
}
