using System;
using System.Collections.Generic;
using System.Linq;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000016 RID: 22
	public static class PlayersTab
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0000982C File Offset: 0x00007A2C
		public static SteamPlayer GetSteamPlayer(Player player)
		{
			using (List<SteamPlayer>.Enumerator enumerator = Provider.clients.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SteamPlayer steamPlayer = enumerator.Current;
					if (steamPlayer.player == player)
					{
						return steamPlayer;
					}
				}
				goto IL_49;
			}
			SteamPlayer result;
			return result;
			IL_49:
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00009894 File Offset: 0x00007A94
		public static void Tab()
		{
			GUILayout.BeginArea(new Rect(340f, 20f, 650f, 420f), "Online Players", "box");
			PlayersTab.SearchString = Prefab.TextField(PlayersTab.SearchString, "Search: ");
			PlayersTab.vector2_0 = GUILayout.BeginScrollView(PlayersTab.vector2_0, Array.Empty<GUILayoutOption>());
			for (int i = 0; i < Provider.clients.Count; i++)
			{
				Player player = Provider.clients[i].player;
				if (!(player == OptimizationVariables.MainPlayer) && !(player == null) && (!(PlayersTab.SearchString != "") || player.name.IndexOf(PlayersTab.SearchString, StringComparison.OrdinalIgnoreCase) != -1))
				{
					bool flag = FriendUtilities.IsFriendly(player);
					bool flag2 = MiscOptions.SpectatedPlayer == player;
					bool flag3 = false;
					bool flag4 = player == PlayersTab.SelectedPlayer;
					string text = flag ? "<color=#00ff00ff>" : "";
					if (GUILayout.Button(string.Concat(new string[]
					{
						flag4 ? "<b>" : "",
						(!flag2) ? "" : "<color=#0000ffff>[SPECTATING]</color> ",
						text,
						player.name,
						(!flag && !flag3) ? "" : "</color>",
						flag4 ? "</b>" : ""
					}), "NavBox", Array.Empty<GUILayoutOption>()))
					{
						PlayersTab.SelectedPlayer = player;
					}
					GUILayout.Space(2f);
				}
			}
			GUILayout.EndScrollView();
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(340f, 450f, 250f, 180f), "Other", "box");
			if (PlayersTab.SelectedPlayer != null)
			{
				CSteamID steamID = PlayersTab.SelectedPlayer.channel.owner.playerID.steamID;
				GUILayout.BeginHorizontal(new GUILayoutOption[0]);
				GUILayout.BeginVertical(new GUILayoutOption[0]);
				if (FriendUtilities.IsFriendly(PlayersTab.SelectedPlayer))
				{
					if (GUILayout.Button("Remove Friends", "verticalslider", Array.Empty<GUILayoutOption>()))
					{
						FriendUtilities.RemoveFriend(PlayersTab.SelectedPlayer);
					}
				}
				else if (GUILayout.Button("Add Friends", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					FriendUtilities.AddFriend(PlayersTab.SelectedPlayer);
				}
				if (GUILayout.Button("Open Steam Profile", "verticalslider", Array.Empty<GUILayoutOption>()))
				{
					Provider.provider.browserService.open("http://steamcommunity.com/profiles/" + PlayersTab.SelectedPlayer.channel.owner.playerID.steamID.ToString());
				}
				GUILayout.EndVertical();
				GUILayout.EndHorizontal();
			}
			GUILayout.EndArea();
			GUILayout.BeginArea(new Rect(600f, 450f, 390f, 180f), "Info", "box");
			if (PlayersTab.SelectedPlayer != null)
			{
				string str = Convert.ToString(Convert.ToInt32(Provider.clients.Count(new Func<SteamPlayer, bool>(PlayersTab.<>c.<>c_0.method_0))) + 1);
				GUILayout.BeginHorizontal(new GUILayoutOption[0]);
				GUILayout.BeginVertical(new GUILayoutOption[0]);
				GUILayout.TextField("Location: " + LocationUtilities.GetClosestLocation(PlayersTab.SelectedPlayer.transform.position).name, new GUILayoutOption[0]);
				GUILayout.TextField("Coordinates: " + PlayersTab.SelectedPlayer.transform.position.ToString(), new GUILayoutOption[0]);
				GUILayout.Label("Weapon: " + ((PlayersTab.SelectedPlayer.equipment.asset != null) ? PlayersTab.SelectedPlayer.equipment.asset.itemName : "Fists"), new GUILayoutOption[0]);
				GUILayout.Label("Vehicle: " + ((PlayersTab.SelectedPlayer.movement.getVehicle() != null) ? PlayersTab.SelectedPlayer.movement.getVehicle().asset.name : "No Vehicle"), new GUILayoutOption[0]);
				GUILayout.Label("Number In Group: " + str, new GUILayoutOption[0]);
				GUILayout.EndVertical();
				GUILayout.EndHorizontal();
			}
			GUILayout.EndArea();
		}

		// Token: 0x040000AC RID: 172
		private static Vector2 vector2_0 = new Vector2(0f, 0f);

		// Token: 0x040000AD RID: 173
		public static Vector2 PlayersScroll;

		// Token: 0x040000AE RID: 174
		public static Player SelectedPlayer;

		// Token: 0x040000AF RID: 175
		public static string SearchString = "";
	}
}
