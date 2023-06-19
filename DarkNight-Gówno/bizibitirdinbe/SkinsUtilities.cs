using System;
using System.Collections.Generic;
using SDG.Provider;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000C1 RID: 193
	public static class SkinsUtilities
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00004576 File Offset: 0x00002776
		public static HumanClothes CharacterClothes
		{
			get
			{
				return OptimizationVariables.MainPlayer.clothing.characterClothes;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00004587 File Offset: 0x00002787
		public static HumanClothes FirstClothes
		{
			get
			{
				return OptimizationVariables.MainPlayer.clothing.firstClothes;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00004598 File Offset: 0x00002798
		public static HumanClothes ThirdClothes
		{
			get
			{
				return OptimizationVariables.MainPlayer.clothing.thirdClothes;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
		public static void Apply(Skin skin, SkinType skinType)
		{
			if (skinType == SkinType.Weapons)
			{
				Dictionary<ushort, int> itemSkins = OptimizationVariables.MainPlayer.channel.owner.itemSkins;
				if (itemSkins == null)
				{
					return;
				}
				ushort inventorySkinID = Provider.provider.economyService.getInventorySkinID(skin.ID);
				SkinOptions.SkinConfig.WeaponSkins.Clear();
				int num;
				if (itemSkins.TryGetValue(inventorySkinID, out num))
				{
					itemSkins[inventorySkinID] = skin.ID;
				}
				else
				{
					itemSkins.Add(inventorySkinID, skin.ID);
				}
				OptimizationVariables.MainPlayer.equipment.applySkinVisual();
				OptimizationVariables.MainPlayer.equipment.applyMythicVisual();
				using (Dictionary<ushort, int>.Enumerator enumerator = itemSkins.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<ushort, int> keyValuePair = enumerator.Current;
						SkinOptions.SkinConfig.WeaponSkins.Add(new WeaponSave(keyValuePair.Key, keyValuePair.Value));
					}
					return;
				}
			}
			SkinsUtilities.ApplyClothing(skin, skinType);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		public static void ApplyClothing(Skin skin, SkinType type)
		{
			if (!G.BeingSpied)
			{
				switch (type)
				{
				case SkinType.Shirts:
					SkinsUtilities.CharacterClothes.visualShirt = skin.ID;
					SkinsUtilities.FirstClothes.visualShirt = skin.ID;
					SkinsUtilities.ThirdClothes.visualShirt = skin.ID;
					SkinOptions.SkinConfig.ShirtID = skin.ID;
					break;
				case SkinType.Pants:
					SkinsUtilities.CharacterClothes.visualPants = skin.ID;
					SkinsUtilities.FirstClothes.visualPants = skin.ID;
					SkinsUtilities.ThirdClothes.visualPants = skin.ID;
					SkinOptions.SkinConfig.PantsID = skin.ID;
					break;
				case SkinType.Bags:
					SkinsUtilities.CharacterClothes.visualBackpack = skin.ID;
					SkinsUtilities.FirstClothes.visualBackpack = skin.ID;
					SkinsUtilities.ThirdClothes.visualBackpack = skin.ID;
					SkinOptions.SkinConfig.BackpackID = skin.ID;
					break;
				case SkinType.Vests:
					SkinsUtilities.CharacterClothes.visualVest = skin.ID;
					SkinsUtilities.FirstClothes.visualVest = skin.ID;
					SkinsUtilities.ThirdClothes.visualVest = skin.ID;
					SkinOptions.SkinConfig.VestID = skin.ID;
					break;
				case SkinType.Hats:
					SkinsUtilities.CharacterClothes.visualHat = skin.ID;
					SkinsUtilities.FirstClothes.visualHat = skin.ID;
					SkinsUtilities.ThirdClothes.visualHat = skin.ID;
					SkinOptions.SkinConfig.HatID = skin.ID;
					break;
				case SkinType.Masks:
					SkinsUtilities.CharacterClothes.visualMask = skin.ID;
					SkinsUtilities.FirstClothes.visualMask = skin.ID;
					SkinsUtilities.ThirdClothes.visualMask = skin.ID;
					SkinOptions.SkinConfig.MaskID = skin.ID;
					break;
				case SkinType.Glasses:
					SkinsUtilities.CharacterClothes.visualGlasses = skin.ID;
					SkinsUtilities.FirstClothes.visualGlasses = skin.ID;
					SkinsUtilities.ThirdClothes.visualGlasses = skin.ID;
					SkinOptions.SkinConfig.GlassesID = skin.ID;
					break;
				}
				SkinsUtilities.CharacterClothes.apply();
				SkinsUtilities.FirstClothes.apply();
				SkinsUtilities.ThirdClothes.apply();
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		public static void ApplyFromConfig()
		{
			Dictionary<ushort, int> dictionary = new Dictionary<ushort, int>();
			foreach (WeaponSave weaponSave in SkinOptions.SkinConfig.WeaponSkins)
			{
				dictionary[weaponSave.WeaponID] = weaponSave.SkinID;
			}
			if (!(OptimizationVariables.MainPlayer == null))
			{
				OptimizationVariables.MainPlayer.channel.owner.itemSkins = dictionary;
				if (SkinOptions.SkinConfig.ShirtID != 0)
				{
					SkinsUtilities.CharacterClothes.visualShirt = SkinOptions.SkinConfig.ShirtID;
					SkinsUtilities.FirstClothes.visualShirt = SkinOptions.SkinConfig.ShirtID;
					SkinsUtilities.ThirdClothes.visualShirt = SkinOptions.SkinConfig.ShirtID;
				}
				if (SkinOptions.SkinConfig.PantsID != 0)
				{
					SkinsUtilities.CharacterClothes.visualPants = SkinOptions.SkinConfig.PantsID;
					SkinsUtilities.FirstClothes.visualPants = SkinOptions.SkinConfig.PantsID;
					SkinsUtilities.ThirdClothes.visualPants = SkinOptions.SkinConfig.PantsID;
				}
				if (SkinOptions.SkinConfig.BackpackID != 0)
				{
					SkinsUtilities.CharacterClothes.visualBackpack = SkinOptions.SkinConfig.BackpackID;
					SkinsUtilities.FirstClothes.visualBackpack = SkinOptions.SkinConfig.BackpackID;
					SkinsUtilities.ThirdClothes.visualBackpack = SkinOptions.SkinConfig.BackpackID;
				}
				if (SkinOptions.SkinConfig.VestID != 0)
				{
					SkinsUtilities.CharacterClothes.visualVest = SkinOptions.SkinConfig.VestID;
					SkinsUtilities.FirstClothes.visualVest = SkinOptions.SkinConfig.VestID;
					SkinsUtilities.ThirdClothes.visualVest = SkinOptions.SkinConfig.VestID;
				}
				if (SkinOptions.SkinConfig.HatID != 0)
				{
					SkinsUtilities.CharacterClothes.visualHat = SkinOptions.SkinConfig.HatID;
					SkinsUtilities.FirstClothes.visualHat = SkinOptions.SkinConfig.HatID;
					SkinsUtilities.ThirdClothes.visualHat = SkinOptions.SkinConfig.HatID;
				}
				if (SkinOptions.SkinConfig.MaskID != 0)
				{
					SkinsUtilities.CharacterClothes.visualMask = SkinOptions.SkinConfig.MaskID;
					SkinsUtilities.FirstClothes.visualMask = SkinOptions.SkinConfig.MaskID;
					SkinsUtilities.ThirdClothes.visualMask = SkinOptions.SkinConfig.MaskID;
				}
				if (SkinOptions.SkinConfig.GlassesID != 0)
				{
					SkinsUtilities.CharacterClothes.visualGlasses = SkinOptions.SkinConfig.GlassesID;
					SkinsUtilities.FirstClothes.visualGlasses = SkinOptions.SkinConfig.GlassesID;
					SkinsUtilities.ThirdClothes.visualGlasses = SkinOptions.SkinConfig.GlassesID;
				}
				SkinsUtilities.CharacterClothes.apply();
				SkinsUtilities.FirstClothes.apply();
				SkinsUtilities.ThirdClothes.apply();
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001C894 File Offset: 0x0001AA94
		public static void DrawSkins(SkinOptionList OptionList)
		{
			SkinsUtilities.SearchString = Prefab.TextField(SkinsUtilities.SearchString, "Search: ");
			SkinsUtilities.vector2_0 = GUILayout.BeginScrollView(SkinsUtilities.vector2_0, Array.Empty<GUILayoutOption>());
			foreach (Skin skin in OptionList.Skins)
			{
				if (skin.Name.ToLower().Contains(SkinsUtilities.SearchString.ToLower()))
				{
					if (GUILayout.Button(skin.Name, "NavBox", Array.Empty<GUILayoutOption>()))
					{
						SkinsUtilities.Apply(skin, OptionList.Type);
					}
					GUILayout.Space(5f);
				}
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001C964 File Offset: 0x0001AB64
		public static void DrawSkins2(SkinOptionList OptionList)
		{
			SkinsUtilities.SearchString = Prefab.TextField(SkinsUtilities.SearchString, "Search: ");
			SkinsUtilities.vector2_0 = GUILayout.BeginScrollView(SkinsUtilities.vector2_0, Array.Empty<GUILayoutOption>());
			foreach (Skin skin in OptionList.Skins)
			{
				if (skin.Name.ToLower().Contains(OptimizationVariables.MainPlayer.equipment.asset.itemName.ToLower()))
				{
					if (GUILayout.Button(skin.Name, "NavBox", Array.Empty<GUILayoutOption>()))
					{
						SkinsUtilities.Apply(skin, OptionList.Type);
					}
					GUILayout.Space(5f);
				}
			}
			GUILayout.EndScrollView();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001CA44 File Offset: 0x0001AC44
		public static void RefreshEconInfo()
		{
			if (SkinOptions.SkinWeapons.Skins.Count <= 5)
			{
				foreach (UnturnedEconInfo unturnedEconInfo in TempSteamworksEconomy.econInfo)
				{
					if (unturnedEconInfo.type.Contains("Skin"))
					{
						SkinOptions.SkinWeapons.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Shirt"))
					{
						SkinOptions.SkinClothesShirts.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Pants"))
					{
						SkinOptions.SkinClothesPants.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Backpack"))
					{
						SkinOptions.SkinClothesBackpack.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Vest"))
					{
						SkinOptions.SkinClothesVest.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Hat"))
					{
						SkinOptions.SkinClothesHats.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Mask"))
					{
						SkinOptions.SkinClothesMask.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
					if (unturnedEconInfo.type.Contains("Glass"))
					{
						SkinOptions.SkinClothesGlasses.Skins.Add(new Skin(unturnedEconInfo.name, unturnedEconInfo.itemdefid));
					}
				}
			}
		}

		// Token: 0x040003EF RID: 1007
		public static Vector2 ScrollPos;

		// Token: 0x040003F0 RID: 1008
		public static string SearchString = "";

		// Token: 0x040003F1 RID: 1009
		private static Vector2 vector2_0 = new Vector2(0f, 0f);
	}
}
