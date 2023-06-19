using System;

namespace bizibitirdinbe
{
	// Token: 0x0200008E RID: 142
	public static class ItemOptions
	{
		// Token: 0x040002DE RID: 734
		[Save]
		public static bool AutoItemPickup = false;

		// Token: 0x040002DF RID: 735
		[Save]
		public static bool AutoItemPickupFiltresiz = false;

		// Token: 0x040002E0 RID: 736
		[Save]
		public static float ItemPickupDelayFiltresizDelay = 1f;

		// Token: 0x040002E1 RID: 737
		[Save]
		public static int ItemPickupDelayFiltresizRange = 20;

		// Token: 0x040002E2 RID: 738
		[Save]
		public static float ItemPickupDelay = 1f;

		// Token: 0x040002E3 RID: 739
		[Save]
		public static int ItemPickupRange = 20;

		// Token: 0x040002E4 RID: 740
		[Save]
		public static ItemOptionList ItemFilterOptions = new ItemOptionList();

		// Token: 0x040002E5 RID: 741
		[Save]
		public static ItemOptionList ItemESPOptions = new ItemOptionList();
	}
}
