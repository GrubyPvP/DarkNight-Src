using System;
using System.Collections.Generic;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x02000088 RID: 136
	public static class RaycastOptions
	{
		// Token: 0x04000285 RID: 645
		[Save]
		public static bool Enabled = false;

		// Token: 0x04000286 RID: 646
		[Save]
		public static int FovMethod = 0;

		// Token: 0x04000287 RID: 647
		[Save]
		public static bool SlientInfo = false;

		// Token: 0x04000288 RID: 648
		[Save]
		public static bool SlientCizgi = false;

		// Token: 0x04000289 RID: 649
		[Save]
		public static bool TargetPlayers = true;

		// Token: 0x0400028A RID: 650
		[Save]
		public static bool TargetZombies = false;

		// Token: 0x0400028B RID: 651
		[Save]
		public static bool TargetSentries = false;

		// Token: 0x0400028C RID: 652
		[Save]
		public static bool TargetBeds = false;

		// Token: 0x0400028D RID: 653
		[Save]
		public static bool TargetAnimal = false;

		// Token: 0x0400028E RID: 654
		[Save]
		public static bool TargetGenerators = false;

		// Token: 0x0400028F RID: 655
		[Save]
		public static bool TargetClaimFlags = false;

		// Token: 0x04000290 RID: 656
		[Save]
		public static bool TargetVehicles = false;

		// Token: 0x04000291 RID: 657
		[Save]
		public static bool TargetStorage = false;

		// Token: 0x04000292 RID: 658
		[Save]
		public static bool TargetYourSelf = false;

		// Token: 0x04000293 RID: 659
		[Save]
		public static bool ExpandHitboxes = false;

		// Token: 0x04000294 RID: 660
		[Save]
		public static bool Players = false;

		// Token: 0x04000295 RID: 661
		[Save]
		public static bool NoShootthroughthewalls = false;

		// Token: 0x04000296 RID: 662
		[Save]
		public static bool AlwaysHitHead = false;

		// Token: 0x04000297 RID: 663
		[Save]
		public static bool UseRandomLimb = false;

		// Token: 0x04000298 RID: 664
		[Save]
		public static bool UseCustomLimb = false;

		// Token: 0x04000299 RID: 665
		[Save]
		public static bool UseTargetMaterial = false;

		// Token: 0x0400029A RID: 666
		[Save]
		public static bool UseModifiedVector = false;

		// Token: 0x0400029B RID: 667
		[Save]
		public static bool bool_0 = false;

		// Token: 0x0400029C RID: 668
		[Save]
		public static bool EnablePlayerSelection = false;

		// Token: 0x0400029D RID: 669
		[Save]
		public static bool OnlyShootAtSelectedPlayer = false;

		// Token: 0x0400029E RID: 670
		[Save]
		public static bool SilentAimUseFOV = false;

		// Token: 0x0400029F RID: 671
		[Save]
		public static bool bool_1 = true;

		// Token: 0x040002A0 RID: 672
		[Save]
		public static float float_0 = 0.01f;

		// Token: 0x040002A1 RID: 673
		[Save]
		public static float SilentAimFOV = 20f;

		// Token: 0x040002A2 RID: 674
		[Save]
		public static HashSet<TargetPriority> Targets = new HashSet<TargetPriority>();

		// Token: 0x040002A3 RID: 675
		[Save]
		public static TargetPriority Target = TargetPriority.Players;

		// Token: 0x040002A4 RID: 676
		[Save]
		public static EPhysicsMaterial TargetMaterial = 20;

		// Token: 0x040002A5 RID: 677
		[Save]
		public static ELimb TargetLimb = 13;

		// Token: 0x040002A6 RID: 678
		[Save]
		public static SerializableVector TargetRagdoll = new SerializableVector(0f, 10f, 0f);
	}
}
