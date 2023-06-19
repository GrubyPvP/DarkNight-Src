using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000019 RID: 25
	public class SkinsTab
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000A888 File Offset: 0x00008A88
		public static void Tab()
		{
			GUILayout.BeginArea(new Rect(300f, 0f, 940f, 40f));
			SkinsTab.Select = (SkinType)GUI.Toolbar(new Rect(27f, 10f, 685f, 40f), (int)SkinsTab.Select, Main.buttons7.ToArray(), "TabBtn");
			GUILayout.EndArea();
			Rect rect = new Rect(340f, 70f, 650f, 550f);
			GUIStyle guistyle = "box";
			GUILayout.BeginArea(rect, string.Format("<size=15>{0}</size>", SkinsTab.Select), guistyle);
			switch (SkinsTab.Select)
			{
			case SkinType.Weapons:
				if (OptimizationVariables.MainPlayer != null && OptimizationVariables.MainPlayer.equipment.asset != null)
				{
					SkinsUtilities.DrawSkins2(SkinOptions.SkinWeapons);
				}
				else
				{
					GUILayout.Label("Use For Join Any Server And Equip GUN", Array.Empty<GUILayoutOption>());
				}
				break;
			case SkinType.Shirts:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesShirts);
				break;
			case SkinType.Pants:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesPants);
				break;
			case SkinType.Bags:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesBackpack);
				break;
			case SkinType.Vests:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesVest);
				break;
			case SkinType.Hats:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesHats);
				break;
			case SkinType.Masks:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesMask);
				break;
			case SkinType.Glasses:
				SkinsUtilities.DrawSkins(SkinOptions.SkinClothesGlasses);
				break;
			}
			GUILayout.EndArea();
		}

		// Token: 0x040000BB RID: 187
		public static string SelectedColorIdentifier = "";

		// Token: 0x040000BC RID: 188
		public static SkinType Select = SkinType.Weapons;
	}
}
