using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200008F RID: 143
	public static class MiscOptions
	{
		// Token: 0x040002E6 RID: 742
		[Save]
		public static bool VehicleRigibody;

		// Token: 0x040002E7 RID: 743
		[Save]
		public static bool ShowVanish;

		// Token: 0x040002E8 RID: 744
		public static bool ShowAdmin;

		// Token: 0x040002E9 RID: 745
		[Save]
		public static bool Adam;

		// Token: 0x040002EA RID: 746
		public static Dictionary<string, Color32> GlobalColors = new Dictionary<string, Color32>();

		// Token: 0x040002EB RID: 747
		[Save]
		public static bool Adam2;

		// Token: 0x040002EC RID: 748
		[Save]
		public static bool Fovv;

		// Token: 0x040002ED RID: 749
		[Save]
		public static bool HwidChanger = true;

		// Token: 0x040002EE RID: 750
		public static bool spynofity;

		// Token: 0x040002EF RID: 751
		public static bool bool_0;

		// Token: 0x040002F0 RID: 752
		[Save]
		public static bool bool_1 = false;

		// Token: 0x040002F1 RID: 753
		[Save]
		public static float float_0 = 90f;

		// Token: 0x040002F2 RID: 754
		[Save]
		public static bool AllOnMap = false;

		// Token: 0x040002F3 RID: 755
		[Save]
		public static bool ChatGlobal = true;

		// Token: 0x040002F4 RID: 756
		[Save]
		public static bool ChatArea = false;

		// Token: 0x040002F5 RID: 757
		[Save]
		public static bool ChatGroup = false;

		// Token: 0x040002F6 RID: 758
		[Save]
		public static bool ChatSay = false;

		// Token: 0x040002F7 RID: 759
		public static Vector3 pos;

		// Token: 0x040002F8 RID: 760
		public static bool PanicMode = false;

		// Token: 0x040002F9 RID: 761
		[Save]
		public static bool hang = false;

		// Token: 0x040002FA RID: 762
		[Save]
		public static bool PunchSilentAim = false;

		// Token: 0x040002FB RID: 763
		public static float RunspeedMult = 5f;

		// Token: 0x040002FC RID: 764
		public static float JumpMult = 10f;

		// Token: 0x040002FD RID: 765
		public static string UISkin = "";

		// Token: 0x040002FE RID: 766
		public static string FontName = "";

		// Token: 0x040002FF RID: 767
		[Save]
		public static bool FastSell;

		// Token: 0x04000300 RID: 768
		[Save]
		public static bool FastBuy;

		// Token: 0x04000301 RID: 769
		[Save]
		public static int FastSellCount = 5;

		// Token: 0x04000302 RID: 770
		[Save]
		public static bool EnVehicle = false;

		// Token: 0x04000303 RID: 771
		[Save]
		public static bool BuildinObstacles = false;

		// Token: 0x04000304 RID: 772
		[Save]
		public static bool FToplama = false;

		// Token: 0x04000305 RID: 773
		[Save]
		public static bool NoFlash = false;

		// Token: 0x04000306 RID: 774
		[Save]
		public static bool PunchAura = false;

		// Token: 0x04000307 RID: 775
		[Save]
		public static bool NoCloud = false;

		// Token: 0x04000308 RID: 776
		[Save]
		public static bool NoGrass = true;

		// Token: 0x04000309 RID: 777
		[Save]
		public static bool GPS = false;

		// Token: 0x0400030A RID: 778
		[Save]
		public static bool NoSnow = false;

		// Token: 0x0400030B RID: 779
		[Save]
		public static bool NoRain = false;

		// Token: 0x0400030C RID: 780
		[Save]
		public static bool NoTree = false;

		// Token: 0x0400030D RID: 781
		[Save]
		public static bool NoFog = false;

		// Token: 0x0400030E RID: 782
		[Save]
		public static bool NoFlinch = false;

		// Token: 0x0400030F RID: 783
		[Save]
		public static bool NoGrayscale = false;

		// Token: 0x04000310 RID: 784
		[Save]
		public static bool CustomSalvageTime = false;

		// Token: 0x04000311 RID: 785
		[Save]
		public static float SalvageTime = 0.2f;

		// Token: 0x04000312 RID: 786
		[Save]
		public static bool SetTimeEnabled = false;

		// Token: 0x04000313 RID: 787
		[Save]
		public static float Time = 0.4f;

		// Token: 0x04000314 RID: 788
		[Save]
		public static bool SlowFall = false;

		// Token: 0x04000315 RID: 789
		[Save]
		public static bool AirStick = false;

		// Token: 0x04000316 RID: 790
		[Save]
		public static bool Compass = false;

		// Token: 0x04000317 RID: 791
		[Save]
		public static bool Bones = false;

		// Token: 0x04000318 RID: 792
		[Save]
		public static bool ShowPlayersOnMap = false;

		// Token: 0x04000319 RID: 793
		[Save]
		public static bool NightVision = false;

		// Token: 0x0400031A RID: 794
		[Save]
		public static bool NightVision2 = false;

		// Token: 0x0400031B RID: 795
		[Save]
		public static bool NightVision3 = false;

		// Token: 0x0400031C RID: 796
		[Save]
		public static bool CIVILIAN = false;

		// Token: 0x0400031D RID: 797
		[Save]
		public static bool HEADLAMP = false;

		// Token: 0x0400031E RID: 798
		public static bool WasNightVision = false;

		// Token: 0x0400031F RID: 799
		public static bool WasNightVision2 = false;

		// Token: 0x04000320 RID: 800
		public static bool WasNightVision3 = false;

		// Token: 0x04000321 RID: 801
		[Save]
		public static string KillSpamText = "youtube.com/UnturnedHack - DarkNight";

		// Token: 0x04000322 RID: 802
		[Save]
		public static bool KillSpam = false;

		// Token: 0x04000323 RID: 803
		[Save]
		public static string SpamText = "youtube.com/UnturnedHack - DarkNight";

		// Token: 0x04000324 RID: 804
		[Save]
		public static bool Spam = false;

		// Token: 0x04000325 RID: 805
		[Save]
		public static string NickName = "";

		// Token: 0x04000326 RID: 806
		[Save]
		public static string Password = "";

		// Token: 0x04000327 RID: 807
		[Save]
		public static bool SpammerEnabled = false;

		// Token: 0x04000328 RID: 808
		[Save]
		public static int SpammerDelay = 3000;

		// Token: 0x04000329 RID: 809
		[Save]
		public static bool VehicleFly = false;

		// Token: 0x0400032A RID: 810
		[Save]
		public static bool VehicleUseMaxSpeed = false;

		// Token: 0x0400032B RID: 811
		[Save]
		public static bool VehicleInfo = false;

		// Token: 0x0400032C RID: 812
		[Save]
		public static float SpeedMultiplier = 0.85f;

		// Token: 0x0400032D RID: 813
		[Save]
		public static bool ExtendMeleeRange;

		// Token: 0x0400032E RID: 814
		[Save]
		public static float MeleeRangeExtension = 15.5f;

		// Token: 0x0400032F RID: 815
		public static bool NoMovementVerification = false;

		// Token: 0x04000330 RID: 816
		[Save]
		public static bool AlwaysCheckMovementVerification = false;

		// Token: 0x04000331 RID: 817
		public static Player SpectatedPlayer;

		// Token: 0x04000332 RID: 818
		[Save]
		public static bool PlayerFlight = false;

		// Token: 0x04000333 RID: 819
		[Save]
		public static bool RunspeedMult2 = false;

		// Token: 0x04000334 RID: 820
		[Save]
		public static bool JumpMult2 = false;

		// Token: 0x04000335 RID: 821
		[Save]
		public static float FlightSpeedMultiplier = 1f;

		// Token: 0x04000336 RID: 822
		public static bool Freecam = false;

		// Token: 0x04000337 RID: 823
		public static bool DeleteCharacterAnimation = false;

		// Token: 0x04000338 RID: 824
		public static bool shake = false;

		// Token: 0x04000339 RID: 825
		[Save]
		public static HashSet<ulong> Friends = new HashSet<ulong>();

		// Token: 0x0400033A RID: 826
		[Save]
		public static int SCrashMethod = 1;

		// Token: 0x0400033B RID: 827
		[Save]
		public static int AntiSpyMethod = 0;

		// Token: 0x0400033C RID: 828
		[Save]
		public static int ShaderMethod = 0;

		// Token: 0x0400033D RID: 829
		[Save]
		public static string AntiSpyPath = "";

		// Token: 0x0400033E RID: 830
		public static string AntiSpyPath2 = "";

		// Token: 0x0400033F RID: 831
		[Save]
		public static bool AlertOnSpy = true;

		// Token: 0x04000340 RID: 832
		[Save]
		public static bool EnableDistanceCrash = false;

		// Token: 0x04000341 RID: 833
		[Save]
		public static float CrashDistance = 100f;

		// Token: 0x04000342 RID: 834
		[Save]
		public static bool CrashByName = false;

		// Token: 0x04000343 RID: 835
		[Save]
		public static List<string> CrashWords = new List<string>();

		// Token: 0x04000344 RID: 836
		[Save]
		public static List<string> CrashIDs = new List<string>();

		// Token: 0x04000345 RID: 837
		[Save]
		public static bool NearbyItemRaycast = true;

		// Token: 0x04000346 RID: 838
		[Save]
		public static bool IncreaseNearbyItemDistance = true;

		// Token: 0x04000347 RID: 839
		[Save]
		public static float NearbyItemDistance = 15f;

		// Token: 0x04000348 RID: 840
		[Save]
		public static bool ConnectKick = false;

		// Token: 0x04000349 RID: 841
		[Save]
		public static bool epos;

		// Token: 0x0400034A RID: 842
		public static float Altitude;
	}
}
