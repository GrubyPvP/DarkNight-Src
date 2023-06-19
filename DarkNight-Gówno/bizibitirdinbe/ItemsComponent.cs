using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000028 RID: 40
	[Component]
	public class ItemsComponent : MonoBehaviour
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000CA38 File Offset: 0x0000AC38
		public static void RefreshItems()
		{
			ItemsComponent.items.Clear();
			for (ushort num = 0; num < 65535; num += 1)
			{
				ItemAsset itemAsset = (ItemAsset)Assets.find(1, num);
				if (!string.IsNullOrEmpty((itemAsset != null) ? itemAsset.itemName : null) && !ItemsComponent.items.Contains(itemAsset))
				{
					ItemsComponent.items.Add(itemAsset);
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002591 File Offset: 0x00000791
		public void Start()
		{
			CoroutineComponent.ItemPickupCoroutine = base.StartCoroutine(ItemCoroutines.PickupItems());
			CoroutineComponent.ItemPickupCoroutine2 = base.StartCoroutine(ItemCoroutines2.PickupItems());
		}

		// Token: 0x040000D8 RID: 216
		public static List<ItemAsset> items = new List<ItemAsset>();
	}
}
