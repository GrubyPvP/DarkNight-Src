using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A1 RID: 161
	public static class OV_PlayerLifeUI
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x000041FB File Offset: 0x000023FB
		[Override(typeof(PlayerLifeUI), "hasCompassInInventory", BindingFlags.Static | BindingFlags.NonPublic, 0)]
		public static bool OV_hasCompassInInventory()
		{
			return MiscOptions.Compass || (bool)OverrideUtilities.CallOriginal(null, new object[0]);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00004217 File Offset: 0x00002417
		[Override(typeof(PlayerLifeUI), "updateGrayscale", BindingFlags.Static | BindingFlags.Public, 0)]
		public static void OV_updateGrayscale()
		{
			if (!MiscOptions.NoGrayscale)
			{
				OverrideUtilities.CallOriginal(null, new object[0]);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000422D File Offset: 0x0000242D
		[OnSpy]
		public static void Disable()
		{
			if (DrawUtilities.ShouldRun())
			{
				OV_PlayerLifeUI.WasCompassEnabled = MiscOptions.Compass;
				MiscOptions.Compass = false;
				PlayerLifeUI.updateCompass();
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000424E File Offset: 0x0000244E
		[OffSpy]
		public static void Enable()
		{
			if (DrawUtilities.ShouldRun())
			{
				MiscOptions.Compass = OV_PlayerLifeUI.WasCompassEnabled;
				PlayerLifeUI.updateCompass();
			}
		}

		// Token: 0x040003CA RID: 970
		public static bool WasCompassEnabled;
	}
}
