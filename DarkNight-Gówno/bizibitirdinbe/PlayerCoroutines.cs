using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200005D RID: 93
	public class PlayerCoroutines : MonoBehaviour
	{
		// Token: 0x06000217 RID: 535 RVA: 0x00003B51 File Offset: 0x00001D51
		[Override(typeof(Player), "ReceiveTakeScreenshot", BindingFlags.Instance | BindingFlags.Public, 0)]
		public void OV_ReceiveTakeScreenshot()
		{
			base.StartCoroutine(new PlayerCoroutines.<TakeScreenshot>d__1(0));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00015314 File Offset: 0x00013514
		public static void _HandleScreenshotData(byte[] data, SteamChannel channel)
		{
			if (Dedicator.isDedicated)
			{
				ReadWrite.writeBytes(string.Concat(new string[]
				{
					ReadWrite.PATH,
					ServerSavedata.directory,
					"/",
					Provider.serverID,
					"/Spy.jpg"
				}), false, false, data);
				ReadWrite.writeBytes(string.Concat(new object[]
				{
					ReadWrite.PATH,
					ServerSavedata.directory,
					"/",
					Provider.serverID,
					"/Spy/",
					channel.owner.playerID.steamID.m_SteamID,
					".jpg"
				}), false, false, data);
				if (Player.player.onPlayerSpyReady != null)
				{
					Player.player.onPlayerSpyReady.Invoke(channel.owner.playerID.steamID, data);
				}
				PlayerSpyReady playerSpyReady = new Queue<PlayerSpyReady>().Dequeue();
				if (playerSpyReady != null)
				{
					playerSpyReady.Invoke(channel.owner.playerID.steamID, data);
					return;
				}
			}
			else
			{
				ReadWrite.writeBytes("/Spy.jpg", false, true, data);
				if (Player.onSpyReady != null)
				{
					Player.onSpyReady.Invoke(channel.owner.playerID.steamID, data);
				}
				Debug.Log("0x4");
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003B60 File Offset: 0x00001D60
		public static IEnumerator ScreenShotMessageCoroutine()
		{
			return new PlayerCoroutines.<ScreenShotMessageCoroutine>d__3(0);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003B68 File Offset: 0x00001D68
		public static IEnumerator smethod_0()
		{
			return new PlayerCoroutines.Class0(0);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001545C File Offset: 0x0001365C
		public static void DisableAllVisuals()
		{
			SpyManager.InvokePre();
			if (DrawUtilities.ShouldRun() && OptimizationVariables.MainPlayer.equipment.asset is ItemGunAsset)
			{
				Useable useable = OptimizationVariables.MainPlayer.equipment.useable;
			}
			if (LevelLighting.seaLevel == 0f)
			{
				LevelLighting.seaLevel = MiscOptions.Altitude;
			}
			SpyManager.DestroyComponents();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00003B70 File Offset: 0x00001D70
		public static void EnableAllVisuals()
		{
			SpyManager.AddComponents();
			SpyManager.InvokePost();
		}

		// Token: 0x040001C0 RID: 448
		public static float LastSpy;

		// Token: 0x040001C1 RID: 449
		public static Player SpecPlayer;
	}
}
