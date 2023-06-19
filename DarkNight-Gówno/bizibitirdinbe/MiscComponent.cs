using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using SDG.Provider;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200002A RID: 42
	[Component]
	public class MiscComponent : MonoBehaviour
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Initializer]
		public static void Initialize()
		{
			HotkeyComponent.ActionDict.Add("_Cam", new Action(MiscComponent.<>c.<>c_0.method_0));
			HotkeyComponent.ActionDict.Add("_Çık", new Action(MiscComponent.<>c.<>c_0.method_1));
			HotkeyComponent.ActionDict.Add("_VFToggle", new Action(MiscComponent.<>c.<>c_0.method_2));
			HotkeyComponent.ActionDict.Add("_ToggleAimbot", new Action(MiscComponent.<>c.<>c_0.method_3));
			HotkeyComponent.ActionDict.Add("_AimbotOnKey", new Action(MiscComponent.<>c.<>c_0.method_4));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000CF08 File Offset: 0x0000B108
		[OnSpy]
		public static void Disable()
		{
			if (MiscOptions.WasNightVision)
			{
				MiscComponent.NightvisionBeforeSpy = true;
				MiscOptions.NightVision = false;
			}
			if (ESPOptions.ShowMap)
			{
				ESPOptions.ShowMap2 = true;
				ESPOptions.ShowMap = false;
			}
			if (MiscOptions.Freecam)
			{
				MiscComponent.FreecamBeforeSpy = true;
				MiscOptions.Freecam = false;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000CF50 File Offset: 0x0000B150
		[OffSpy]
		public static void Enable()
		{
			if (ESPOptions.ShowMap2)
			{
				ESPOptions.ShowMap2 = false;
				ESPOptions.ShowMap = true;
			}
			if (MiscComponent.NightvisionBeforeSpy)
			{
				MiscComponent.NightvisionBeforeSpy = false;
				MiscOptions.NightVision = true;
			}
			if (MiscComponent.FreecamBeforeSpy)
			{
				MiscComponent.FreecamBeforeSpy = false;
				MiscOptions.Freecam = true;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000CF98 File Offset: 0x0000B198
		public void Start()
		{
			MiscComponent.Instance = this;
			Provider.onClientConnected = (Provider.ClientConnected)Delegate.Combine(Provider.onClientConnected, new Provider.ClientConnected(MiscComponent.<>c.<>c_0.method_5));
			SkinsUtilities.RefreshEconInfo();
			HotkeyComponent.ActionDict.Add("_Com1", new Action(MiscComponent.<>c.<>c_0.method_6));
			HotkeyComponent.ActionDict.Add("_Com2", new Action(MiscComponent.<>c.<>c_0.method_7));
			HotkeyComponent.ActionDict.Add("_Com3", new Action(MiscComponent.<>c.<>c_0.method_8));
			HotkeyComponent.ActionDict.Add("_Com4", new Action(MiscComponent.<>c.<>c_0.method_9));
			HotkeyComponent.ActionDict.Add("_Com5", new Action(MiscComponent.<>c.<>c_0.method_10));
			HotkeyComponent.ActionDict.Add("_AutoPickUp", new Action(MiscComponent.<>c.<>c_0.method_11));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000D100 File Offset: 0x0000B300
		public void Update()
		{
			if (Camera.main != null && OptimizationVariables.MainCam == null)
			{
				OptimizationVariables.MainCam = Camera.main;
			}
			if (OptimizationVariables.MainPlayer && DrawUtilities.ShouldRun())
			{
				if (MiscOptions.hang)
				{
					Player.player.movement.pluginGravityMultiplier = -1f;
				}
				else
				{
					Player.player.movement.pluginGravityMultiplier = 1f;
				}
				int num;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num);
				int num2;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num2);
				int num3;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num3);
				int num4;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num4);
				int num5;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num5);
				int num6;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num6);
				if (WeaponOptions.OofOnDeath)
				{
					if (num != this.currentKills)
					{
						if (this.currentKills != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["oof"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills = num;
					}
				}
				else
				{
					this.currentKills = num;
				}
				if (WeaponOptions.Cod)
				{
					if (num2 != this.currentKills2)
					{
						if (this.currentKills2 != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["cod"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills2 = num2;
					}
				}
				else
				{
					this.currentKills2 = num2;
				}
				if (WeaponOptions.hypixe)
				{
					if (num3 != this.currentKills3)
					{
						if (this.currentKills3 != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["hypiexl"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills3 = num3;
					}
				}
				else
				{
					this.currentKills3 = num3;
				}
				if (WeaponOptions.Ez4ence)
				{
					if (num6 != this.currentKills6)
					{
						if (this.currentKills6 != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["EZ4ANCE"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills6 = num6;
					}
				}
				else
				{
					this.currentKills6 = num6;
				}
				if (WeaponOptions.coin)
				{
					if (num4 != this.currentKills4)
					{
						if (this.currentKills4 != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["Coin"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills4 = num4;
					}
				}
				else
				{
					this.currentKills4 = num4;
				}
				if (WeaponOptions.sigma)
				{
					if (num5 != this.currentKills5)
					{
						if (this.currentKills5 != -1)
						{
							OptimizationVariables.MainPlayer.GetComponentInChildren<AudioSource>().PlayOneShot(AssetUtilities.AudioClip["sigma"], WeaponOptions.KillSoundVolume);
						}
						this.currentKills5 = num5;
					}
				}
				else
				{
					this.currentKills5 = num5;
				}
				int num7;
				Provider.provider.statisticsService.userStatisticsService.getStatistic("Kills_Players", ref num7);
				if (MiscOptions.KillSpam)
				{
					if (num7 != this.Killer2)
					{
						if (this.Killer2 != -1)
						{
							ChatManager.sendChat(0, MiscOptions.KillSpamText);
						}
						this.Killer2 = num7;
					}
				}
				else
				{
					this.Killer2 = num7;
				}
				if (MiscOptions.NightVision2)
				{
					LevelLighting.vision = 1;
					LevelLighting.nightvisionColor = new Color(0.078f, 0.471f, 0.314f, 1f);
					LevelLighting.nightvisionFogIntensity = 0.25f;
					LevelLighting.updateLighting();
					LevelLighting.updateLocal();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision2 = true;
				}
				else if (MiscOptions.WasNightVision2)
				{
					LevelLighting.vision = 0;
					LevelLighting.nightvisionColor = new Color(0f, 0f, 0f, 0f);
					LevelLighting.nightvisionFogIntensity = 0f;
					LevelLighting.updateLighting();
					LevelLighting.updateLocal();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision2 = false;
				}
				if (MiscOptions.NightVision3)
				{
					LevelLighting.vision = 3;
					LevelLighting.nightvisionColor = new Color(0.078f, 0f, 0f, 0f);
					LevelLighting.nightvisionFogIntensity = 0.25f;
					LevelLighting.updateLighting();
					LevelLighting.updateLocal();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision3 = true;
				}
				else if (MiscOptions.WasNightVision3)
				{
					LevelLighting.vision = 0;
					LevelLighting.nightvisionColor = new Color(0f, 0f, 0f, 0f);
					LevelLighting.nightvisionFogIntensity = 0f;
					LevelLighting.updateLighting();
					LevelLighting.updateLocal();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision3 = false;
				}
				if (MiscOptions.NightVision)
				{
					LevelLighting.vision = 1;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision = true;
				}
				else if (MiscOptions.WasNightVision)
				{
					LevelLighting.vision = 0;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision = false;
				}
				if (MiscOptions.NightVision2)
				{
					LevelLighting.vision = 1;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision2 = true;
				}
				else if (MiscOptions.WasNightVision2)
				{
					LevelLighting.vision = 0;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision2 = false;
				}
				if (MiscOptions.NightVision3)
				{
					LevelLighting.vision = 3;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision3 = true;
				}
				else if (MiscOptions.WasNightVision3)
				{
					LevelLighting.vision = 0;
					LevelLighting.updateLighting();
					PlayerLifeUI.updateGrayscale();
					MiscOptions.WasNightVision3 = false;
				}
				if (OptimizationVariables.MainPlayer.life.isDead)
				{
					MiscComponent.LastDeath = OptimizationVariables.MainPlayer.transform.position;
				}
				if (MiscOptions.NoFlash && MiscOptions.NoFlash && ((Color)typeof(PlayerUI).GetField("stunColor", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).a > 0f)
				{
					Color color = (Color)typeof(PlayerUI).GetField("stunColor", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
					color.a = 0f;
					typeof(PlayerUI).GetField("stunColor", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, color);
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000D700 File Offset: 0x0000B900
		public void FixedUpdate()
		{
			if (OptimizationVariables.MainPlayer)
			{
				MiscComponent.VehicleFlight();
				MiscComponent.PlayerFlight();
			}
			MiscComponent.PlayerFlight();
			if (!MiscOptions.RunspeedMult2 && !MiscOptions.JumpMult2)
			{
				this.fieldInfo_0.SetValue(this.fieldInfo_1, MiscComponent.float_0);
				this.fieldInfo_2.SetValue(this.fieldInfo_1, MiscComponent.float_1);
				this.fieldInfo_1.SetValue(this.fieldInfo_1, MiscComponent.float_2);
				this.fieldInfo_3.SetValue(this.fieldInfo_3, MiscComponent.float_3);
				return;
			}
			this.fieldInfo_0.SetValue(this.fieldInfo_1, MiscOptions.RunspeedMult);
			this.fieldInfo_2.SetValue(this.fieldInfo_1, MiscOptions.RunspeedMult);
			this.fieldInfo_1.SetValue(this.fieldInfo_1, MiscOptions.RunspeedMult);
			this.fieldInfo_3.SetValue(this.fieldInfo_3, MiscOptions.JumpMult);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000D814 File Offset: 0x0000BA14
		public static void PlayerFlight()
		{
			Player mainPlayer = OptimizationVariables.MainPlayer;
			if (!MiscOptions.PlayerFlight)
			{
				ItemCloudAsset itemCloudAsset = mainPlayer.equipment.asset as ItemCloudAsset;
				mainPlayer.movement.itemGravityMultiplier = ((itemCloudAsset != null) ? itemCloudAsset.gravity : 1f);
				return;
			}
			mainPlayer.movement.itemGravityMultiplier = 0f;
			float flightSpeedMultiplier = MiscOptions.FlightSpeedMultiplier;
			if (HotkeyUtilities.IsHotkeyHeld("_FlyUp"))
			{
				mainPlayer.transform.position += mainPlayer.transform.up / 5f * flightSpeedMultiplier;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_FlyDown"))
			{
				mainPlayer.transform.position -= mainPlayer.transform.up / 5f * flightSpeedMultiplier;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_FlyLeft"))
			{
				mainPlayer.transform.position -= mainPlayer.transform.right / 5f * flightSpeedMultiplier;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_FlyRight"))
			{
				mainPlayer.transform.position += mainPlayer.transform.right / 5f * flightSpeedMultiplier;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_FlyForward"))
			{
				mainPlayer.transform.position += mainPlayer.transform.forward / 5f * flightSpeedMultiplier;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_FlyBackward"))
			{
				mainPlayer.transform.position -= mainPlayer.transform.forward / 5f * flightSpeedMultiplier;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public static void VehicleFlight()
		{
			InteractableVehicle vehicle = Player.player.movement.getVehicle();
			if (vehicle == null)
			{
				return;
			}
			Rigidbody component = vehicle.GetComponent<Rigidbody>();
			if (component == null)
			{
				return;
			}
			if (!vehicle.isDriver)
			{
				return;
			}
			if (!MiscOptions.VehicleFly)
			{
				if (MiscComponent.bool_0)
				{
					MiscComponent.bool_0 = false;
					component.isKinematic = false;
				}
				return;
			}
			MiscComponent.bool_0 = true;
			component.isKinematic = true;
			float num = MiscOptions.VehicleUseMaxSpeed ? (vehicle.asset.speedMax * Time.fixedDeltaTime) : (MiscOptions.SpeedMultiplier / 3f);
			num *= 0.98f;
			Transform transform = component.transform;
			Vector3 zero = Vector3.zero;
			Vector3 vector = Vector3.zero;
			if (HotkeyUtilities.IsHotkeyHeld("_VFRotateRight"))
			{
				zero.y += 2f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFRotateLeft"))
			{
				zero.y += -2f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFRollLeft"))
			{
				zero.z += 2f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFRollRight"))
			{
				zero.z += -2f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFRotateUp"))
			{
				zero.x += -1.5f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFRotateDown"))
			{
				zero.x += 1.5f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFStrafeUp"))
			{
				vector.y += 0.6f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFStrafeDown"))
			{
				vector.y -= 0.6f;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFStrafeLeft"))
			{
				vector -= transform.right;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFStrafeRight"))
			{
				vector += transform.right;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFMoveForward"))
			{
				vector += transform.forward;
			}
			if (HotkeyUtilities.IsHotkeyHeld("_VFMoveBackward"))
			{
				vector -= transform.forward;
			}
			vector = vector * num + transform.position;
			if (MiscOptions.VehicleRigibody)
			{
				transform.position = vector;
				transform.Rotate(zero);
				return;
			}
			component.MovePosition(vector);
			component.MoveRotation(transform.localRotation * Quaternion.Euler(zero));
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002648 File Offset: 0x00000848
		public static void CheckMovementVerification()
		{
			MiscComponent.Instance.StartCoroutine(MiscComponent.CheckVerification(OptimizationVariables.MainPlayer.transform.position));
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000DC70 File Offset: 0x0000BE70
		public static void incrementStatTrackerValue(ushort itemID, int newValue)
		{
			if (Player.player == null)
			{
				return;
			}
			SteamPlayer owner = Player.player.channel.owner;
			if (owner == null)
			{
				return;
			}
			int num;
			if (!owner.getItemSkinItemDefID(itemID, ref num))
			{
				return;
			}
			string text;
			string text2;
			if (!owner.getTagsAndDynamicPropsForItem(num, ref text, ref text2))
			{
				return;
			}
			DynamicEconDetails dynamicEconDetails;
			dynamicEconDetails..ctor(text, text2);
			EStatTrackerType estatTrackerType;
			int num2;
			if (dynamicEconDetails.getStatTrackerValue(ref estatTrackerType, ref num2))
			{
				if (!owner.modifiedItems.Contains(itemID))
				{
					owner.modifiedItems.Add(itemID);
				}
				int i = 0;
				while (i < owner.skinItems.Length)
				{
					if (owner.skinItems[i] != num)
					{
						i++;
					}
					else
					{
						if (i < owner.skinDynamicProps.Length)
						{
							owner.skinDynamicProps[i] = dynamicEconDetails.getPredictedDynamicPropsJsonForStatTracker(estatTrackerType, newValue);
							return;
						}
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002669 File Offset: 0x00000869
		public static IEnumerator CheckVerification(Vector3 LastPos)
		{
			if (Time.realtimeSinceStartup - MiscComponent.LastMovementCheck < 0.8f)
			{
				yield break;
			}
			MiscComponent.LastMovementCheck = Time.realtimeSinceStartup;
			OptimizationVariables.MainPlayer.transform.position = new Vector3(0f, -1337f, 0f);
			yield return new WaitForSeconds(3f);
			int num;
			if (num != 1)
			{
				yield break;
			}
			if (VectorUtilities.GetDistance(OptimizationVariables.MainPlayer.transform.position, LastPos) < 10.0)
			{
				MiscOptions.NoMovementVerification = false;
			}
			else
			{
				MiscOptions.NoMovementVerification = true;
				OptimizationVariables.MainPlayer.transform.position = LastPos + new Vector3(0f, 5f, 0f);
			}
			yield break;
		}

		// Token: 0x040000DD RID: 221
		private FieldInfo fieldInfo_0 = typeof(PlayerMovement).GetField("SPEED_STAND", BindingFlags.Static | BindingFlags.NonPublic);

		// Token: 0x040000DE RID: 222
		private FieldInfo fieldInfo_1 = typeof(PlayerMovement).GetField("SPEED_SPRINT", BindingFlags.Static | BindingFlags.NonPublic);

		// Token: 0x040000DF RID: 223
		private FieldInfo fieldInfo_2 = typeof(PlayerMovement).GetField("SPEED_PRONE", BindingFlags.Static | BindingFlags.NonPublic);

		// Token: 0x040000E0 RID: 224
		private FieldInfo fieldInfo_3 = typeof(PlayerMovement).GetField("JUMP", BindingFlags.Static | BindingFlags.NonPublic);

		// Token: 0x040000E1 RID: 225
		private static readonly float float_0 = 4.5f;

		// Token: 0x040000E2 RID: 226
		private static readonly float float_1 = 1.5f;

		// Token: 0x040000E3 RID: 227
		private static readonly float float_2 = 7f;

		// Token: 0x040000E4 RID: 228
		private static readonly float float_3 = 7f;

		// Token: 0x040000E5 RID: 229
		private static bool bool_0;

		// Token: 0x040000E6 RID: 230
		public static Vector3 LastDeath;

		// Token: 0x040000E7 RID: 231
		public static MiscComponent Instance;

		// Token: 0x040000E8 RID: 232
		public static float LastMovementCheck;

		// Token: 0x040000E9 RID: 233
		public static bool FreecamBeforeSpy;

		// Token: 0x040000EA RID: 234
		public static bool NightvisionBeforeSpy;

		// Token: 0x040000EB RID: 235
		public static List<PlayerInputPacket> ClientsidePackets;

		// Token: 0x040000EC RID: 236
		public static FieldInfo Primary = typeof(PlayerEquipment).GetField("_primary", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x040000ED RID: 237
		public static FieldInfo Sequence = typeof(PlayerInput).GetField("sequence", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x040000EE RID: 238
		public static FieldInfo CPField = typeof(PlayerInput).GetField("clientsidePackets", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x040000EF RID: 239
		public int currentKills = -1;

		// Token: 0x040000F0 RID: 240
		public int currentKills2 = -1;

		// Token: 0x040000F1 RID: 241
		public int currentKills3 = -1;

		// Token: 0x040000F2 RID: 242
		public int currentKills4 = -1;

		// Token: 0x040000F3 RID: 243
		public int currentKills5 = -1;

		// Token: 0x040000F4 RID: 244
		public int currentKills6 = -1;

		// Token: 0x040000F5 RID: 245
		public int Killer2 = -1;

		// Token: 0x040000F6 RID: 246
		public bool _isBroken;
	}
}
