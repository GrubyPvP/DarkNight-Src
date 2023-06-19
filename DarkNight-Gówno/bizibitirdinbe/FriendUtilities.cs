using System;
using SDG.Unturned;

namespace bizibitirdinbe
{
	// Token: 0x020000AD RID: 173
	public static class FriendUtilities
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x0001A30C File Offset: 0x0001850C
		public static bool IsFriendly(Player player)
		{
			return player.quests.isMemberOfGroup(OptimizationVariables.MainPlayer.quests.groupID) || MiscOptions.Friends.Contains(player.channel.owner.playerID.steamID.m_SteamID);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001A35C File Offset: 0x0001855C
		public static void AddFriend(Player Friend)
		{
			ulong steamID = Friend.channel.owner.playerID.steamID.m_SteamID;
			if (!MiscOptions.Friends.Contains(steamID))
			{
				MiscOptions.Friends.Add(steamID);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001A3A4 File Offset: 0x000185A4
		public static void RemoveFriend(Player Friend)
		{
			ulong steamID = Friend.channel.owner.playerID.steamID.m_SteamID;
			if (MiscOptions.Friends.Contains(steamID))
			{
				MiscOptions.Friends.Remove(steamID);
			}
		}
	}
}
