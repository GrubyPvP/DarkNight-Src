using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000032 RID: 50
	[Component]
	public class ShowAdmin : MonoBehaviour
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000F058 File Offset: 0x0000D258
		private void OnGUI()
		{
			if (MiscOptions.ShowAdmin && !G.BeingSpied && Provider.isConnected && Provider.clients.Count > 0)
			{
				GUI.color = new Color(1f, 1f, 1f, 0f);
				using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (Vector3.Distance(enumerator.Current.player.transform.position, Vector3.zero) < 10f)
						{
							GUILayout.Window(67326, ShowAdmin.vew, new GUI.WindowFunction(this.method_0), "", Array.Empty<GUILayoutOption>());
						}
					}
				}
				GUI.color = Color.white;
				return;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000F144 File Offset: 0x0000D344
		private void method_0(int int_0)
		{
			T.DrawColor(new Rect(0f, 0f, ShowAdmin.vew.width, 25f), new Color32(34, 34, 34, 200));
			T.DrawColor(new Rect(0f, 25f, ShowAdmin.vew.width, ShowAdmin.vew.height + 25f), new Color32(34, 34, 34, 200));
			foreach (SteamPlayer steamPlayer in Provider.clients)
			{
				if (steamPlayer.player.channel.owner.isAdmin)
				{
					GUILayout.Label(steamPlayer.playerID.characterName, Array.Empty<GUILayoutOption>());
				}
			}
			GUI.DragWindow();
		}

		// Token: 0x04000115 RID: 277
		public static Rect vew = new Rect((float)(Screen.width - 395), 50f, 200f, 100f);
	}
}
