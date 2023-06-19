using System;
using System.Collections.Generic;

namespace bizibitirdinbe
{
	// Token: 0x02000075 RID: 117
	public class ItemOptionList
	{
		// Token: 0x0400020D RID: 525
		public HashSet<ushort> AddedItems = new HashSet<ushort>();

		// Token: 0x0400020E RID: 526
		public bool ItemfilterGun = true;

		// Token: 0x0400020F RID: 527
		public bool ItemfilterGunMeel = true;

		// Token: 0x04000210 RID: 528
		public bool ItemfilterAmmo = true;

		// Token: 0x04000211 RID: 529
		public bool ItemfilterMedical = true;

		// Token: 0x04000212 RID: 530
		public bool ItemfilterBackpack = true;

		// Token: 0x04000213 RID: 531
		public bool ItemfilterCharges = true;

		// Token: 0x04000214 RID: 532
		public bool ItemfilterFuel = true;

		// Token: 0x04000215 RID: 533
		public bool ItemfilterClothing = true;

		// Token: 0x04000216 RID: 534
		public bool ItemfilterFoodAndWater = true;

		// Token: 0x04000217 RID: 535
		public bool ItemfilterCustom = true;

		// Token: 0x04000218 RID: 536
		public string searchstring = "";

		// Token: 0x04000219 RID: 537
		public SerializableVector2 additemscroll = new SerializableVector2(0f, 0f);

		// Token: 0x0400021A RID: 538
		public SerializableVector2 removeitemscroll = new SerializableVector2(0f, 0f);
	}
}
