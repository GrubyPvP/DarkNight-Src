using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000B0 RID: 176
	public static class ItemUtilities
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0001A668 File Offset: 0x00018868
		public static bool Whitelisted(ItemAsset asset, ItemOptionList OptionList)
		{
			return (OptionList.ItemfilterCustom && OptionList.AddedItems.Contains(asset.id)) || (OptionList.ItemfilterGun && asset is ItemGunAsset) || (OptionList.ItemfilterGunMeel && asset is ItemMeleeAsset) || (OptionList.ItemfilterAmmo && asset is ItemMagazineAsset) || (OptionList.ItemfilterMedical && asset is ItemMedicalAsset) || (OptionList.ItemfilterFoodAndWater && (asset is ItemFoodAsset || asset is ItemWaterAsset)) || (OptionList.ItemfilterBackpack && asset is ItemBackpackAsset) || (OptionList.ItemfilterCharges && asset is ItemChargeAsset) || (OptionList.ItemfilterFuel && asset is ItemFuelAsset) || (OptionList.ItemfilterClothing && asset is ItemClothingAsset);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0001A79C File Offset: 0x0001899C
		public static void DrawItemButton(ItemAsset asset, HashSet<ushort> AddedItems)
		{
			string text = asset.itemName;
			if (asset.itemName.Length > 60)
			{
				text = asset.itemName.Substring(0, 60) + "..";
			}
			if (Prefab.Button(text, 390f, 25f, new GUILayoutOption[0]))
			{
				if (AddedItems.Contains(asset.id))
				{
					AddedItems.Remove(asset.id);
				}
				else
				{
					AddedItems.Add(asset.id);
				}
			}
			GUILayout.Space(3f);
		}
	}
}
