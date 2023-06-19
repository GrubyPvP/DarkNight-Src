using System;

namespace bizibitirdinbe
{
	// Token: 0x02000097 RID: 151
	public static class SkinOptions
	{
		// Token: 0x040003A1 RID: 929
		[Save]
		public static SkinConfig SkinConfig = new SkinConfig();

		// Token: 0x040003A2 RID: 930
		public static SkinOptionList SkinWeapons = new SkinOptionList(SkinType.Weapons);

		// Token: 0x040003A3 RID: 931
		public static SkinOptionList SkinClothesShirts = new SkinOptionList(SkinType.Shirts);

		// Token: 0x040003A4 RID: 932
		public static SkinOptionList SkinClothesPants = new SkinOptionList(SkinType.Pants);

		// Token: 0x040003A5 RID: 933
		public static SkinOptionList SkinClothesBackpack = new SkinOptionList(SkinType.Bags);

		// Token: 0x040003A6 RID: 934
		public static SkinOptionList SkinClothesVest = new SkinOptionList(SkinType.Vests);

		// Token: 0x040003A7 RID: 935
		public static SkinOptionList SkinClothesHats = new SkinOptionList(SkinType.Hats);

		// Token: 0x040003A8 RID: 936
		public static SkinOptionList SkinClothesMask = new SkinOptionList(SkinType.Masks);

		// Token: 0x040003A9 RID: 937
		public static SkinOptionList SkinClothesGlasses = new SkinOptionList(SkinType.Glasses);
	}
}
