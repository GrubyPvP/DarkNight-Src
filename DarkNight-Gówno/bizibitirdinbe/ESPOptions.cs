using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000092 RID: 146
	public static class ESPOptions
	{
		// Token: 0x04000353 RID: 851
		public static ShaderType ChamType = ShaderType.None;

		// Token: 0x04000354 RID: 852
		[Save]
		public static bool Enabled = true;

		// Token: 0x04000355 RID: 853
		[Save]
		public static bool ChamsEnabled = false;

		// Token: 0x04000356 RID: 854
		[Save]
		public static bool Ignore = false;

		// Token: 0x04000357 RID: 855
		[Save]
		public static bool Skeleton = false;

		// Token: 0x04000358 RID: 856
		[Save]
		public static bool Tran = false;

		// Token: 0x04000359 RID: 857
		public static bool EspStyle = true;

		// Token: 0x0400035A RID: 858
		public static bool EspStyle1 = false;

		// Token: 0x0400035B RID: 859
		public static bool EspStyle2 = false;

		// Token: 0x0400035C RID: 860
		public static bool EspStyle3 = false;

		// Token: 0x0400035D RID: 861
		public static bool EspStyle4 = false;

		// Token: 0x0400035E RID: 862
		public static bool EspStyle5 = false;

		// Token: 0x0400035F RID: 863
		[Save]
		public static float xxx = 50f;

		// Token: 0x04000360 RID: 864
		[Save]
		public static float yyy = 50f;

		// Token: 0x04000361 RID: 865
		[Save]
		public static float zzz = 50f;

		// Token: 0x04000362 RID: 866
		[Save]
		public static float bnmk = 50f;

		// Token: 0x04000363 RID: 867
		[Save]
		public static bool SelfChams = false;

		// Token: 0x04000364 RID: 868
		[Save]
		public static float ChamsTime = 2f;

		// Token: 0x04000365 RID: 869
		[Save]
		public static bool ChamsFlat = false;

		// Token: 0x04000366 RID: 870
		[Save]
		public static bool RGBChams = false;

		// Token: 0x04000367 RID: 871
		[Save]
		public static bool SpinBotOyuncu = false;

		// Token: 0x04000368 RID: 872
		[Save]
		public static bool bool_0 = false;

		// Token: 0x04000369 RID: 873
		[Save]
		public static bool ShowVanishPlayers = false;

		// Token: 0x0400036A RID: 874
		[Save]
		public static bool ShowVehiclePlayers = false;

		// Token: 0x0400036B RID: 875
		[Save]
		public static bool ShowToolTipWindow = false;

		// Token: 0x0400036C RID: 876
		[Save]
		public static bool ShowCoordinates = false;

		// Token: 0x0400036D RID: 877
		[Save]
		public static bool ShowMap = false;

		// Token: 0x0400036E RID: 878
		public static bool ShowMap2 = false;

		// Token: 0x0400036F RID: 879
		[Save]
		public static ESPVisual[] VisualOptions = Enumerable.Repeat<ESPVisual>(new ESPVisual
		{
			Enabled = false,
			Boxes = false,
			ShowName = true,
			ShowDistance = true,
			ShowAngle = false,
			TwoDimensional = false,
			Glow = false,
			InfiniteDistance = false,
			LineToObject = false,
			TextScaling = false,
			UseObjectCap = false,
			CustomTextColor = false,
			Distance = 500f,
			Location = LabelLocation.BottomMiddle,
			FixedTextSize = 11,
			MinTextSize = 8,
			MaxTextSize = 11,
			MinTextSizeDistance = 800f,
			BorderStrength = 0,
			ObjectCap = 24
		}, Enum.GetValues(typeof(ESPTarget)).Length).ToArray<ESPVisual>();

		// Token: 0x04000370 RID: 880
		[Save]
		public static Dictionary<ESPTarget, int> PriorityTable = Enum.GetValues(typeof(ESPTarget)).Cast<ESPTarget>().ToDictionary(new Func<ESPTarget, ESPTarget>(ESPOptions.<>c.<>c_0.method_0), new Func<ESPTarget, int>(ESPOptions.<>c.<>c_0.method_1));

		// Token: 0x04000371 RID: 881
		[Save]
		public static bool ShowPlayerWeapon = false;

		// Token: 0x04000372 RID: 882
		[Save]
		public static bool ShowNpcItems = false;

		// Token: 0x04000373 RID: 883
		[Save]
		public static bool showhotbar = false;

		// Token: 0x04000374 RID: 884
		[Save]
		public static bool HitboxSize = false;

		// Token: 0x04000375 RID: 885
		public static int x = 50;

		// Token: 0x04000376 RID: 886
		public static int y = 50;

		// Token: 0x04000377 RID: 887
		public static int cumbox = 50;

		// Token: 0x04000378 RID: 888
		public static int cumboy = 50;

		// Token: 0x04000379 RID: 889
		public static bool ShowAmmo = false;

		// Token: 0x0400037A RID: 890
		[Save]
		public static bool ShowPlayerVehicle = false;

		// Token: 0x0400037B RID: 891
		[Save]
		public static bool bool_1 = true;

		// Token: 0x0400037C RID: 892
		[Save]
		public static bool AdminRengi = true;

		// Token: 0x0400037D RID: 893
		[Save]
		public static bool UsePlayerGroup = true;

		// Token: 0x0400037E RID: 894
		[Save]
		public static SerializableColor SameGroupColor = Color.green.ToSerializableColor();

		// Token: 0x0400037F RID: 895
		[Save]
		public static bool FilterItems = false;

		// Token: 0x04000380 RID: 896
		[Save]
		public static bool ShowVehicleFuel;

		// Token: 0x04000381 RID: 897
		[Save]
		public static bool ShowVehicleHealth;

		// Token: 0x04000382 RID: 898
		[Save]
		public static bool ShowVehicleLocked;

		// Token: 0x04000383 RID: 899
		[Save]
		public static bool FilterVehicleLocked;

		// Token: 0x04000384 RID: 900
		[Save]
		public static bool ShowStorageItem;

		// Token: 0x04000385 RID: 901
		[Save]
		public static bool ShowSentryItem;

		// Token: 0x04000386 RID: 902
		[Save]
		public static bool ShowClaimed;

		// Token: 0x04000387 RID: 903
		[Save]
		public static bool bool_2;

		// Token: 0x04000388 RID: 904
		[Save]
		public static bool ClaimNameStorage;

		// Token: 0x04000389 RID: 905
		[Save]
		public static bool bool_3;

		// Token: 0x0400038A RID: 906
		[Save]
		public static bool ClaimNameCar;

		// Token: 0x0400038B RID: 907
		[Save]
		public static bool bool_4;

		// Token: 0x0400038C RID: 908
		[Save]
		public static bool ClaimNameBed;

		// Token: 0x0400038D RID: 909
		[Save]
		public static bool ShowGeneratorFuel;

		// Token: 0x0400038E RID: 910
		[Save]
		public static bool ShowGeneratorPowered;
	}
}
