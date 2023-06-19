using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using HighlightingSystem;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000034 RID: 52
	[Component]
	public class TrajectoryComponent : MonoBehaviour
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000028EA File Offset: 0x00000AEA
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000028F1 File Offset: 0x00000AF1
		public static Highlighter Highlighted
		{
			get
			{
				return TrajectoryComponent.highlighter_0;
			}
			private set
			{
				if (TrajectoryComponent.highlighter_0 != null)
				{
					TrajectoryComponent.smethod_3(TrajectoryComponent.highlighter_0);
				}
				TrajectoryComponent.highlighter_0 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002910 File Offset: 0x00000B10
		public static HashSet<GameObject> BodiesInMotion { get; } = new HashSet<GameObject>();

		// Token: 0x060000BF RID: 191 RVA: 0x00002917 File Offset: 0x00000B17
		private static Color smethod_0()
		{
			return Color.green;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000291E File Offset: 0x00000B1E
		private static Color smethod_1()
		{
			return Color.red;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		[Initializer]
		public static void Initialize()
		{
			Class1.smethod_0(new ColorVariable("_TrajectoryPredictionInRange", "B.D. Predict (In Range)", Color.cyan, true));
			Class1.smethod_0(new ColorVariable("_TrajectoryPredictionOutOfRange", "B.D. Predict (Out of Range)", Color.red, true));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002925 File Offset: 0x00000B25
		public void Start()
		{
			CoroutineComponent.TrajectoryCoroutine = base.StartCoroutine(TrajectoryCoroutines.UpdateBodiesInMotionSet());
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000F34C File Offset: 0x0000D54C
		private void method_0(RaycastHit raycastHit_0, Color color_0)
		{
			if (!WeaponOptions.HighlightBulletDropPredictionTarget)
			{
				TrajectoryComponent.Highlighted = null;
				return;
			}
			if (WeaponOptions.HighlightBulletDropPredictionTarget && raycastHit_0.collider != null)
			{
				Transform transform = raycastHit_0.transform;
				GameObject gameObject = null;
				if (DamageTool.getPlayer(transform) != null)
				{
					gameObject = DamageTool.getPlayer(transform).gameObject;
				}
				else if (DamageTool.getZombie(transform) != null)
				{
					gameObject = DamageTool.getZombie(transform).gameObject;
				}
				else if (DamageTool.getAnimal(transform) != null)
				{
					gameObject = DamageTool.getAnimal(transform).gameObject;
				}
				else if (DamageTool.getVehicle(transform) != null)
				{
					gameObject = DamageTool.getVehicle(transform).gameObject;
				}
				if (gameObject != null)
				{
					Highlighter highlighter = gameObject.GetComponent<Highlighter>() ?? gameObject.AddComponent<Highlighter>();
					if (!highlighter.enabled)
					{
						highlighter.occluder = true;
						highlighter.overlay = true;
						highlighter.ConstantOnImmediate(color_0);
					}
					TrajectoryComponent.Highlighted = highlighter;
					return;
				}
				TrajectoryComponent.Highlighted = null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000F458 File Offset: 0x0000D658
		public void OnGUI()
		{
			if (DrawUtilities.ShouldRun() && !TrajectoryComponent.bool_0 && WeaponOptions.EnableBulletDropPrediction)
			{
				TrajectoryComponent.hashSet_0.RemoveWhere(new Predicate<GameObject>(TrajectoryComponent.<>c.<>c_0.method_0));
				foreach (GameObject gameObject in TrajectoryComponent.hashSet_0)
				{
					Rigidbody component = gameObject.GetComponent<Rigidbody>();
					Vector3? vector = (component != null) ? new Vector3?(component.velocity) : null;
					Vector3 zero = Vector3.zero;
					if (vector == null || (vector != null && vector.GetValueOrDefault() != zero))
					{
						TrajectoryComponent.smethod_2(TrajectoryComponent.PlotTrajectoryRigidBodyInMotion(gameObject, 1500), TrajectoryComponent.smethod_1());
					}
				}
				Player mainPlayer = OptimizationVariables.MainPlayer;
				Useable useable;
				if (mainPlayer == null)
				{
					useable = null;
				}
				else
				{
					PlayerEquipment equipment = mainPlayer.equipment;
					useable = ((equipment != null) ? equipment.useable : null);
				}
				Useable useable2 = useable;
				if (!(useable2 == null))
				{
					UseableGun useableGun = useable2 as UseableGun;
					bool flag;
					if (useableGun == null)
					{
						flag = true;
					}
					else
					{
						ItemGunAsset equippedGunAsset = useableGun.equippedGunAsset;
						EAction? eaction = (equippedGunAsset != null) ? new EAction?(equippedGunAsset.action) : null;
						flag = !(eaction.GetValueOrDefault() == 6 & eaction != null);
					}
					if (!flag || Provider.modeConfigData.Gameplay.Ballistics)
					{
						UseableGun useableGun2 = useable2 as UseableGun;
						List<Vector3> list;
						bool flag2;
						if (useableGun2 != null)
						{
							EAction action = useableGun2.equippedGunAsset.action;
							RaycastHit raycastHit_;
							list = ((action == 6) ? TrajectoryComponent.PlotTrajectoryRocket(useableGun2, out raycastHit_, 1500) : TrajectoryComponent.PlotTrajectoryGun(useableGun2, out raycastHit_, 255));
							flag2 = (action != 6 && Vector3.Distance(list.Last<Vector3>(), OptimizationVariables.MainPlayer.look.aim.position) > useableGun2.equippedGunAsset.range);
							if (action != 6)
							{
								this.method_0(raycastHit_, flag2 ? TrajectoryComponent.smethod_1() : TrajectoryComponent.smethod_0());
							}
						}
						else
						{
							UseableThrowable useableThrowable = useable2 as UseableThrowable;
							if (useableThrowable == null)
							{
								return;
							}
							flag2 = false;
							list = TrajectoryComponent.PlotTrajectoryGrenade(useableThrowable, 50 * (int)useableThrowable.equippedThrowableAsset.fuseLength);
						}
						TrajectoryComponent.smethod_2(list, flag2 ? TrajectoryComponent.smethod_1() : TrajectoryComponent.smethod_0());
						return;
					}
				}
				TrajectoryComponent.Highlighted = null;
				return;
			}
			TrajectoryComponent.Highlighted = null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		private static void smethod_2(List<Vector3> list_0, Color color_0)
		{
			T.DrawMaterial.SetPass(0);
			GL.PushMatrix();
			GL.LoadProjectionMatrix(OptimizationVariables.MainCam.projectionMatrix);
			GL.modelview = OptimizationVariables.MainCam.worldToCameraMatrix;
			GL.Begin(2);
			GL.Color(color_0);
			foreach (Vector3 vector in list_0)
			{
				GL.Vertex(vector);
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002937 File Offset: 0x00000B37
		private static void smethod_3(Highlighter highlighter_1)
		{
			if (highlighter_1 == null)
			{
				return;
			}
			highlighter_1.occluder = false;
			highlighter_1.overlay = false;
			highlighter_1.ConstantOffImmediate();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000F754 File Offset: 0x0000D954
		public static List<Vector3> PlotTrajectoryGrenade(UseableThrowable grenade, int maxSteps)
		{
			Vector3 vector = OptimizationVariables.MainPlayer.look.aim.position;
			float num = grenade.equippedThrowableAsset.strongThrowForce;
			if (OptimizationVariables.MainPlayer.skills.boost == 4)
			{
				num *= grenade.equippedThrowableAsset.boostForceMultiplier;
			}
			Vector3 vector2 = OptimizationVariables.MainPlayer.look.aim.forward * num;
			float mass = grenade.equippedThrowableAsset.throwable.GetComponent<Rigidbody>().mass;
			Vector3 vector3 = vector2 / mass * Time.fixedDeltaTime;
			List<Vector3> list = new List<Vector3>
			{
				vector
			};
			RaycastHit raycastHit;
			if (!Physics.Raycast(new Ray(vector, OptimizationVariables.MainPlayer.look.aim.forward), ref raycastHit, 1f, RayMasks.DAMAGE_SERVER, 0))
			{
				vector += OptimizationVariables.MainPlayer.look.aim.forward;
				list.Add(vector);
			}
			float fixedDeltaTime = Time.fixedDeltaTime;
			for (int i = 1; i < maxSteps; i++)
			{
				vector += vector3 * fixedDeltaTime + 0.5f * Physics.gravity * fixedDeltaTime * fixedDeltaTime;
				vector3 += Physics.gravity * fixedDeltaTime;
				RaycastHit raycastHit2;
				if (Physics.Linecast(list[i - 1], vector, ref raycastHit2, RayMasks.DAMAGE_CLIENT))
				{
					list.Add(raycastHit2.point);
					return list;
				}
				list.Add(vector);
			}
			return list;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
		public static List<Vector3> PlotTrajectoryRigidBodyInMotion(GameObject obj, int maxSteps)
		{
			Vector3 vector = obj.transform.position;
			Vector3 vector2 = obj.GetComponent<Rigidbody>().velocity;
			List<Vector3> list = new List<Vector3>
			{
				obj.transform.position
			};
			float fixedDeltaTime = Time.fixedDeltaTime;
			for (int i = 1; i < maxSteps; i++)
			{
				vector += vector2 * fixedDeltaTime + 0.5f * Physics.gravity * fixedDeltaTime * fixedDeltaTime;
				vector2 += Physics.gravity * fixedDeltaTime;
				RaycastHit raycastHit;
				if (Physics.Linecast(list[i - 1], vector, ref raycastHit, RayMasks.DAMAGE_CLIENT))
				{
					list.Add(raycastHit.point);
					return list;
				}
				list.Add(vector);
			}
			return list;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000F998 File Offset: 0x0000DB98
		public static List<Vector3> PlotTrajectoryRocket(UseableGun gun, out RaycastHit hit, int maxSteps)
		{
			hit = default(RaycastHit);
			Vector3 vector = OptimizationVariables.MainPlayer.look.aim.position;
			Vector3 vector2 = OptimizationVariables.MainPlayer.look.aim.forward * gun.equippedGunAsset.ballisticForce;
			float mass = gun.equippedGunAsset.projectile.GetComponent<Rigidbody>().mass;
			Vector3 vector3 = vector2 / mass * Time.fixedDeltaTime;
			List<Vector3> list = new List<Vector3>
			{
				vector
			};
			RaycastHit raycastHit;
			if (!Physics.Raycast(new Ray(vector, OptimizationVariables.MainPlayer.look.aim.forward), ref raycastHit, 1f, RayMasks.DAMAGE_SERVER, 0))
			{
				vector += OptimizationVariables.MainPlayer.look.aim.forward;
				list.Add(vector);
			}
			float fixedDeltaTime = Time.fixedDeltaTime;
			for (int i = 1; i < maxSteps; i++)
			{
				vector += vector3 * fixedDeltaTime + 0.5f * Physics.gravity * fixedDeltaTime * fixedDeltaTime;
				vector3 += Physics.gravity * fixedDeltaTime;
				if (Physics.Linecast(list[i - 1], vector, ref hit, RayMasks.DAMAGE_CLIENT))
				{
					list.Add(hit.point);
					return list;
				}
				list.Add(vector);
			}
			return list;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		public static List<Vector3> PlotTrajectoryGun(UseableGun gun, out RaycastHit hit, int maxSteps = 255)
		{
			hit = default(RaycastHit);
			Transform transform = (OptimizationVariables.MainPlayer.look.perspective == null) ? OptimizationVariables.MainPlayer.look.aim : OptimizationVariables.MainCam.transform;
			Vector3 vector = transform.position;
			Vector3 forward = transform.forward;
			ItemGunAsset equippedGunAsset = gun.equippedGunAsset;
			float num = equippedGunAsset.ballisticTravel;
			Attachments attachments = (Attachments)TrajectoryComponent.fieldInfo_0.GetValue(gun);
			List<Vector3> list = new List<Vector3>
			{
				vector
			};
			if (((attachments != null) ? attachments.barrelAsset : null) != null)
			{
				num *= attachments.barrelAsset.ballisticDrop;
			}
			for (int i = 1; i < maxSteps; i++)
			{
				vector += forward * equippedGunAsset.ballisticTravel;
				forward.y -= num;
				forward.Normalize();
				if (Physics.Linecast(list[i - 1], vector, ref hit, RayMasks.DAMAGE_CLIENT))
				{
					list.Add(hit.point);
					return list;
				}
				list.Add(vector);
			}
			return list;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002957 File Offset: 0x00000B57
		[OnSpy]
		public static void OnSpy()
		{
			if (TrajectoryComponent.highlighter_0 != null)
			{
				TrajectoryComponent.smethod_3(TrajectoryComponent.highlighter_0);
			}
			TrajectoryComponent.bool_0 = true;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002976 File Offset: 0x00000B76
		[OffSpy]
		public static void OffSpy()
		{
			TrajectoryComponent.bool_0 = false;
		}

		// Token: 0x04000116 RID: 278
		private static readonly FieldInfo fieldInfo_0 = typeof(UseableGun).GetField("thirdAttachments", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000117 RID: 279
		private static readonly FieldInfo fieldInfo_1 = typeof(UseableThrowable).GetField("swingMode", BindingFlags.Instance | BindingFlags.NonPublic);

		// Token: 0x04000118 RID: 280
		private static Highlighter highlighter_0;

		// Token: 0x04000119 RID: 281
		[CompilerGenerated]
		private static readonly HashSet<GameObject> hashSet_0;

		// Token: 0x0400011A RID: 282
		private static bool bool_0;
	}
}
