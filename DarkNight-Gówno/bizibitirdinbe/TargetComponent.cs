using System;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200004B RID: 75
	[Component]
	[SpyComponent]
	public class TargetComponent : MonoBehaviour
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00012FC8 File Offset: 0x000111C8
		public void OnGUI()
		{
			GUI.skin = AssetUtilities.Skin;
			if (DrawUtilities.ShouldRun() && !G.BeingSpied)
			{
				ItemGunAsset itemGunAsset = OptimizationVariables.MainPlayer.equipment.asset as ItemGunAsset;
				float range = (itemGunAsset != null) ? itemGunAsset.range : 15.5f;
				GameObject gameObject;
				Vector3 vector;
				RaycastUtilities.GetTargetObject(RaycastUtilities.Objects, out gameObject, out vector, range);
				if (RaycastOptions.Enabled && gameObject != null)
				{
					this.TargetInfoWin = GUILayout.Window(313316, this.TargetInfoWin, new GUI.WindowFunction(this.method_0), "", "SelectedButtonDropdown", Array.Empty<GUILayoutOption>());
					T.DrawSnapline(Color.cyan);
				}
				if (WeaponOptions.ShowWeaponInfo)
				{
					this.WeapontInfoWin = GUILayout.Window(326274, this.WeapontInfoWin, new GUI.WindowFunction(this.method_1), "", "SelectedButtonDropdown", Array.Empty<GUILayoutOption>());
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000130C0 File Offset: 0x000112C0
		private void method_0(int int_0)
		{
			ItemGunAsset itemGunAsset = OptimizationVariables.MainPlayer.equipment.asset as ItemGunAsset;
			float range = (itemGunAsset != null) ? itemGunAsset.range : 15.5f;
			GameObject gameObject;
			Vector3 vector;
			RaycastUtilities.GetTargetObject(RaycastUtilities.Objects, out gameObject, out vector, range);
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
			GUILayout.Label(string.Format("       Target: [{0}] {1}", VectorUtilities.GetDistance2(gameObject.transform.position), gameObject.name), Array.Empty<GUILayoutOption>());
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001314C File Offset: 0x0001134C
		private void method_1(int int_0)
		{
			GUILayout.Label("", Array.Empty<GUILayoutOption>());
			GUILayout.Label("<size=17>       Weapon Range: </size><size=17>" + T.GetGunDistance().ToString() + "</size>", Array.Empty<GUILayoutOption>());
		}

		// Token: 0x04000187 RID: 391
		public Rect WeapontInfoWin = new Rect(0f, (float)(Screen.height / 2 - 90), 220f, 0f);

		// Token: 0x04000188 RID: 392
		public Rect TargetInfoWin = new Rect(0f, (float)(Screen.height / 2 - 20), 220f, 0f);

		// Token: 0x04000189 RID: 393
		public static Camera MainCamera;
	}
}
