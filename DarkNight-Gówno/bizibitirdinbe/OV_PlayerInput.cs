using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200009F RID: 159
	public class OV_PlayerInput
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000040DE File Offset: 0x000022DE
		public static List<PlayerInputPacket> ClientsidePackets
		{
			get
			{
				if (DrawUtilities.ShouldRun() && OV_PlayerInput.Run)
				{
					return (List<PlayerInputPacket>)OV_PlayerInput.ClientsidePacketsField.GetValue(OptimizationVariables.MainPlayer.input);
				}
				return null;
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000177D4 File Offset: 0x000159D4
		public static void OV_askAck(PlayerInput instance, CSteamID steamId, int ack)
		{
			if (!(steamId != Provider.server))
			{
				for (int i = OV_PlayerInput.Packets.Count - 1; i >= 0; i--)
				{
				}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0001780C File Offset: 0x00015A0C
		public static void OV_FixedUpdate()
		{
			Player mainPlayer = OptimizationVariables.MainPlayer;
			if (MiscOptions.PunchSilentAim)
			{
				OV_DamageTool.OVType = OverrideType.PlayerHit;
			}
			DamageTool.raycast(new Ray(mainPlayer.look.aim.position, mainPlayer.look.aim.forward), 15.5f, RayMasks.DAMAGE_SERVER);
			OverrideUtilities.CallOriginal(null, new object[0]);
			List<PlayerInputPacket> clientsidePackets = OV_PlayerInput.ClientsidePackets;
			OV_PlayerInput.LastPacket = ((clientsidePackets != null) ? clientsidePackets.Last<PlayerInputPacket>() : null);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001788C File Offset: 0x00015A8C
		[Override(typeof(PlayerInput), "InitializePlayer", BindingFlags.Instance | BindingFlags.NonPublic, 0)]
		public static void OV_InitializePlayer(PlayerInput instance)
		{
			if (instance.player != Player.player)
			{
				OverrideUtilities.CallOriginal(instance, new object[0]);
				return;
			}
			OptimizationVariables.MainPlayer = Player.player;
			OV_PlayerInput.Rate = 4;
			OV_PlayerInput.Count = 0;
			OV_PlayerInput.Buffer = 0;
			OV_PlayerInput.Packets.Clear();
			OV_PlayerInput.LastPacket = null;
			OV_PlayerInput.SequenceDiff = 0;
			OV_PlayerInput.ClientSequence = 0;
			OverrideUtilities.CallOriginal(instance, new object[0]);
		}

		// Token: 0x040003B0 RID: 944
		public static FieldInfo ClientsidePacketsField = typeof(PlayerInput).GetField("clientsidePackets", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x040003B1 RID: 945
		public static PlayerInputPacket LastPacket;

		// Token: 0x040003B2 RID: 946
		public static float Yaw;

		// Token: 0x040003B3 RID: 947
		public static float Pitch;

		// Token: 0x040003B4 RID: 948
		public static int Count;

		// Token: 0x040003B5 RID: 949
		public static int Buffer;

		// Token: 0x040003B6 RID: 950
		public static int Choked;

		// Token: 0x040003B7 RID: 951
		public static uint Clock = 1U;

		// Token: 0x040003B8 RID: 952
		public static int Rate;

		// Token: 0x040003B9 RID: 953
		public static int ClientSequence = 1;

		// Token: 0x040003BA RID: 954
		public static int SequenceDiff;

		// Token: 0x040003BB RID: 955
		public static List<PlayerInputPacket> Packets = new List<PlayerInputPacket>();

		// Token: 0x040003BC RID: 956
		public static Queue<PlayerInputPacket> WaitingPackets = new Queue<PlayerInputPacket>();

		// Token: 0x040003BD RID: 957
		public static float LastReal;

		// Token: 0x040003BE RID: 958
		public static bool Run;

		// Token: 0x040003BF RID: 959
		public static FieldInfo SimField = typeof(PlayerInput).GetField("_simulation", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x040003C0 RID: 960
		public static Vector3 lastSentPositon = Vector3.zero;
	}
}
