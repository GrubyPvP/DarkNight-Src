using System;
using System.Reflection;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000A5 RID: 165
	public static class OV_SearchForMapsInInventory
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0000429F File Offset: 0x0000249F
		[Override(typeof(PlayerDashboardInformationUI), "searchForMapsInInventory", BindingFlags.Static | BindingFlags.NonPublic, 0)]
		public static void OV_searchForMapsInInventory(ref bool enableChart, ref bool enableMap)
		{
			if (!MiscOptions.GPS)
			{
				OverrideUtilities.CallOriginal(null, new object[]
				{
					true,
					true
				});
				return;
			}
			enableMap = true;
			enableChart = true;
		}
	}
}
