using System;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200009C RID: 156
	public static class OV_ItemManager
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x000176F0 File Offset: 0x000158F0
		[Override(typeof(ItemManager), "getItemsInRadius", BindingFlags.Static | BindingFlags.Public, 0)]
		public static void OV_getItemsInRadius(Vector3 center, float sqrRadius, List<RegionCoordinate> search, List<InteractableItem> result)
		{
			if (MiscOptions.IncreaseNearbyItemDistance)
			{
				OverrideUtilities.CallOriginal(null, new object[]
				{
					center,
					Mathf.Pow(MiscOptions.NearbyItemDistance, 2f),
					search,
					result
				});
				return;
			}
			OverrideUtilities.CallOriginal(null, new object[]
			{
				center,
				sqrRadius,
				search,
				result
			});
		}
	}
}
