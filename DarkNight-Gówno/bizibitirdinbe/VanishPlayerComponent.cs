using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000036 RID: 54
	[Component]
	public class VanishPlayerComponent : MonoBehaviour
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000FC90 File Offset: 0x0000DE90
		private void OnGUI()
		{
			if (MiscOptions.ShowVanish && !G.BeingSpied && Provider.isConnected && Provider.clients.Count > 0)
			{
				GUI.color = new Color(1f, 1f, 1f, 0f);
				using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Vector3.Distance(enumerator.Current.player.transform.position, Vector3.zero) < 10f)
						{
							GUILayout.Window(7, VanishPlayerComponent.vew, new GUI.WindowFunction(this.method_0), "", Array.Empty<GUILayoutOption>());
						}
					}
				}
				GUI.color = Color.white;
				return;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000FD78 File Offset: 0x0000DF78
		private void method_0(int int_0)
		{
			T.DrawColor(new Rect(0f, 0f, VanishPlayerComponent.vew.width, 25f), new Color32(34, 34, 34, 200));
			T.DrawColor(new Rect(0f, 25f, VanishPlayerComponent.vew.width, VanishPlayerComponent.vew.height + 25f), new Color32(34, 34, 34, 200));
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				if (Vector3.Distance(steamPlayer.player.transform.position, Vector3.zero) < 10f)
				{
					GUILayout.Label(steamPlayer.playerID.characterName, Array.Empty<GUILayoutOption>());
				}
			}
			GUI.DragWindow();
		}

		// Token: 0x0400011D RID: 285
		public static Rect vew = new Rect((float)(Screen.width - 395), 50f, 200f, 100f);
	}
}
