﻿using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000C0 RID: 192
	public static class RaycastUtilities
	{
		// Token: 0x06000331 RID: 817 RVA: 0x0001BC6C File Offset: 0x00019E6C
		public static bool NoShootthroughthewalls(Transform transform)
		{
			Vector3 vector = AimbotCoroutines.GetAimPosition(transform, "Skull") - Player.player.look.aim.position;
			RaycastHit raycastHit;
			return Physics.Raycast(new Ray(Player.player.look.aim.position, vector), ref raycastHit, vector.magnitude, RayMasks.DAMAGE_CLIENT, 0) && raycastHit.transform.IsChildOf(transform);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		public static RaycastInfo GenerateOriginalRaycast(Ray ray, float range, int mask, Player ignorePlayer = null)
		{
			RaycastHit raycastHit;
			Physics.Raycast(ray, ref raycastHit, range, mask);
			RaycastInfo raycastInfo = new RaycastInfo(raycastHit);
			raycastInfo.direction = ray.direction;
			raycastInfo.limb = 12;
			if (raycastInfo.transform != null)
			{
				if (raycastInfo.transform.CompareTag("Barricade"))
				{
					raycastInfo.transform = DamageTool.getBarricadeRootTransform(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Structure"))
				{
					raycastInfo.transform = DamageTool.getStructureRootTransform(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Resource"))
				{
					raycastInfo.transform = DamageTool.getResourceRootTransform(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Enemy"))
				{
					raycastInfo.player = DamageTool.getPlayer(raycastInfo.transform);
					if (raycastInfo.player == ignorePlayer)
					{
						raycastInfo.player = null;
					}
					raycastInfo.limb = DamageTool.getLimb(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Zombie"))
				{
					raycastInfo.zombie = DamageTool.getZombie(raycastInfo.transform);
					raycastInfo.limb = DamageTool.getLimb(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Animal"))
				{
					raycastInfo.animal = DamageTool.getAnimal(raycastInfo.transform);
					raycastInfo.limb = DamageTool.getLimb(raycastInfo.transform);
				}
				else if (raycastInfo.transform.CompareTag("Vehicle"))
				{
					raycastInfo.vehicle = DamageTool.getVehicle(raycastInfo.transform);
				}
				if (raycastInfo.zombie != null && raycastInfo.zombie.isRadioactive)
				{
					raycastInfo.materialName = "ALIEN_DYNAMIC";
				}
				else
				{
					raycastInfo.materialName = PhysicsTool.GetMaterialName(raycastHit.point, raycastInfo.transform, raycastInfo.collider);
				}
			}
			return raycastInfo;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
		public static bool GenerateRaycast(out RaycastInfo info)
		{
			ItemGunAsset itemGunAsset = OptimizationVariables.MainPlayer.equipment.asset as ItemGunAsset;
			float num = (itemGunAsset != null) ? itemGunAsset.range : 15.5f;
			info = RaycastUtilities.GenerateOriginalRaycast(new Ray(OptimizationVariables.MainPlayer.look.aim.position, OptimizationVariables.MainPlayer.look.aim.forward), num, RayMasks.DAMAGE_CLIENT, null);
			if (RaycastOptions.EnablePlayerSelection && RaycastUtilities.TargetedPlayer != null)
			{
				GameObject gameObject = RaycastUtilities.TargetedPlayer.gameObject;
				bool flag = true;
				Vector3 position = OptimizationVariables.MainPlayer.look.aim.position;
				if (Vector3.Distance(position, gameObject.transform.position) > num)
				{
					flag = false;
				}
				Vector3 point;
				if (!SphereUtilities.GetRaycast(gameObject, position, out point))
				{
					flag = false;
				}
				if (flag)
				{
					info = RaycastUtilities.GenerateRaycast(gameObject, point, info.collider);
					return true;
				}
				if (RaycastOptions.OnlyShootAtSelectedPlayer)
				{
					return false;
				}
			}
			GameObject @object;
			Vector3 point2;
			if (RaycastUtilities.GetTargetObject(RaycastUtilities.Objects, out @object, out point2, num))
			{
				info = RaycastUtilities.GenerateRaycast(@object, point2, info.collider);
				return true;
			}
			return false;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001C014 File Offset: 0x0001A214
		public static RaycastInfo GenerateRaycast(GameObject Object, Vector3 Point, Collider col)
		{
			ELimb limb = RaycastOptions.TargetLimb;
			if (RaycastOptions.UseRandomLimb)
			{
				ELimb[] array = (ELimb[])Enum.GetValues(typeof(ELimb));
				limb = array[MathUtilities.Random.Next(0, array.Length)];
			}
			return new RaycastInfo(Object.transform)
			{
				point = Point,
				direction = OptimizationVariables.MainPlayer.look.aim.forward,
				limb = limb,
				player = Object.GetComponent<Player>(),
				zombie = Object.GetComponent<Zombie>(),
				vehicle = Object.GetComponent<InteractableVehicle>()
			};
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
		public static bool GetTargetObject(HashSet<GameObject> Objects, out GameObject Object, out Vector3 Point, float Range)
		{
			double num = (double)(Range + 1f);
			double num2 = 180.0;
			Object = null;
			Point = Vector3.zero;
			Vector3 position = OptimizationVariables.MainPlayer.look.aim.position;
			Vector3 forward = OptimizationVariables.MainPlayer.look.aim.forward;
			using (HashSet<GameObject>.Enumerator enumerator = Objects.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GameObject gameObject = enumerator.Current;
					if (!(gameObject == null))
					{
						if (gameObject.GetComponent<RaycastComponent>() == null)
						{
							gameObject.AddComponent<RaycastComponent>();
						}
						else
						{
							Vector3 position2 = gameObject.transform.position;
							Player component = gameObject.GetComponent<Player>();
							if ((!component || (!component.life.isDead && !FriendUtilities.IsFriendly(component))) && (!WeaponOptions.SafeZone || !LevelNodes.isPointInsideSafezone(component.transform.position, ref RaycastUtilities.isSafeInfo)) && (!WeaponOptions.Admin || !component.channel.owner.isAdmin))
							{
								if (AimbotOptions.HitChance != 100 && new Random().Next(0, 100) >= AimbotOptions.HitChance)
								{
									return false;
								}
								Zombie component2 = gameObject.GetComponent<Zombie>();
								if (!component2 || !component2.isDead)
								{
									double distance = VectorUtilities.GetDistance(position, position2);
									if (distance <= (double)Range)
									{
										if (RaycastOptions.SilentAimUseFOV)
										{
											double angleDelta = VectorUtilities.GetAngleDelta(position, forward, position2);
											if (angleDelta > (double)RaycastOptions.SilentAimFOV || angleDelta > num2)
											{
												continue;
											}
											num2 = angleDelta;
										}
										else if (distance > num)
										{
											continue;
										}
										Vector3 vector;
										if (SphereUtilities.GetRaycast(gameObject, position, out vector))
										{
											Object = gameObject;
											num = distance;
											Point = vector;
										}
									}
								}
							}
						}
					}
				}
				goto IL_1B9;
			}
			bool result;
			return result;
			IL_1B9:
			return Object != null;
		}

		// Token: 0x040003EB RID: 1003
		public static SafezoneNode isSafeInfo;

		// Token: 0x040003EC RID: 1004
		public static HashSet<GameObject> Objects = new HashSet<GameObject>();

		// Token: 0x040003ED RID: 1005
		public static List<GameObject> AttachedObjects = new List<GameObject>();

		// Token: 0x040003EE RID: 1006
		public static Player TargetedPlayer;
	}
}
