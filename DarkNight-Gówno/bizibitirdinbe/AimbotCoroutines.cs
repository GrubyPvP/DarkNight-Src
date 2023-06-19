using System;
using System.Collections;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200004F RID: 79
	public static class AimbotCoroutines
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000390C File Offset: 0x00001B0C
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000391D File Offset: 0x00001B1D
		public static float Pitch
		{
			get
			{
				return OptimizationVariables.MainPlayer.look.pitch;
			}
			set
			{
				AimbotCoroutines.PitchInfo.SetValue(OptimizationVariables.MainPlayer.look, value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00003939 File Offset: 0x00001B39
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000394A File Offset: 0x00001B4A
		public static float Yaw
		{
			get
			{
				return OptimizationVariables.MainPlayer.look.yaw;
			}
			set
			{
				AimbotCoroutines.YawInfo.SetValue(OptimizationVariables.MainPlayer.look, value);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00003966 File Offset: 0x00001B66
		[Initializer]
		public static void Init()
		{
			AimbotCoroutines.PitchInfo = typeof(PlayerLook).GetField("_pitch", BindingFlags.Instance | BindingFlags.NonPublic);
			AimbotCoroutines.YawInfo = typeof(PlayerLook).GetField("_yaw", BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000039A0 File Offset: 0x00001BA0
		public static IEnumerator SetLockedObject()
		{
			return new AimbotCoroutines.<SetLockedObject>d__7(0);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000039A8 File Offset: 0x00001BA8
		public static IEnumerator AimToObject()
		{
			return new AimbotCoroutines.<AimToObject>d__8(0);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00013D24 File Offset: 0x00011F24
		public static void Aim(GameObject obj)
		{
			Camera mainCam = OptimizationVariables.MainCam;
			Vector3 aimPosition = AimbotCoroutines.GetAimPosition(obj.transform, "Skull");
			if (!(aimPosition == AimbotCoroutines.PiVector))
			{
				OptimizationVariables.MainPlayer.transform.LookAt(aimPosition);
				OptimizationVariables.MainPlayer.transform.eulerAngles = new Vector3(0f, OptimizationVariables.MainPlayer.transform.rotation.eulerAngles.y, 0f);
				mainCam.transform.LookAt(aimPosition);
				float num = mainCam.transform.localRotation.eulerAngles.x;
				if (num <= 90f && num <= 270f)
				{
					num = mainCam.transform.localRotation.eulerAngles.x + 90f;
				}
				else if (num >= 270f && num <= 360f)
				{
					num = mainCam.transform.localRotation.eulerAngles.x - 270f;
				}
				AimbotCoroutines.Pitch = num;
				AimbotCoroutines.Yaw = OptimizationVariables.MainPlayer.transform.rotation.eulerAngles.y;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00013E78 File Offset: 0x00012078
		public static void SmoothAim(GameObject obj)
		{
			Camera mainCam = OptimizationVariables.MainCam;
			Vector3 aimPosition = AimbotCoroutines.GetAimPosition(obj.transform, "Skull");
			if (!(aimPosition == AimbotCoroutines.PiVector))
			{
				OptimizationVariables.MainPlayer.transform.rotation = Quaternion.Slerp(OptimizationVariables.MainPlayer.transform.rotation, Quaternion.LookRotation(aimPosition - OptimizationVariables.MainPlayer.transform.position), Time.deltaTime * AimbotOptions.AimSpeed);
				OptimizationVariables.MainPlayer.transform.eulerAngles = new Vector3(0f, OptimizationVariables.MainPlayer.transform.rotation.eulerAngles.y, 0f);
				mainCam.transform.localRotation = Quaternion.Slerp(mainCam.transform.localRotation, Quaternion.LookRotation(aimPosition - mainCam.transform.position), Time.deltaTime * AimbotOptions.AimSpeed);
				float num = mainCam.transform.localRotation.eulerAngles.x;
				if (num <= 90f && num <= 270f)
				{
					num = mainCam.transform.localRotation.eulerAngles.x + 90f;
				}
				else if (num >= 270f && num <= 360f)
				{
					num = mainCam.transform.localRotation.eulerAngles.x - 270f;
				}
				AimbotCoroutines.Pitch = num;
				AimbotCoroutines.Yaw = OptimizationVariables.MainPlayer.transform.rotation.eulerAngles.y;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000039B0 File Offset: 0x00001BB0
		public static Vector2 CalcAngle(GameObject obj)
		{
			ESPComponent.MainCamera.WorldToScreenPoint(AimbotCoroutines.GetAimPosition(obj.transform, "Skull"));
			return Vector2.zero;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000039D3 File Offset: 0x00001BD3
		public static void AimMouseTo(float x, float y)
		{
			AimbotCoroutines.Yaw = x;
			AimbotCoroutines.Pitch = y;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00014034 File Offset: 0x00012234
		public static Vector3 GetAimPosition(Transform parent, string name)
		{
			Transform[] componentsInChildren = parent.GetComponentsInChildren<Transform>();
			Vector3 piVector;
			if (componentsInChildren == null)
			{
				piVector = AimbotCoroutines.PiVector;
			}
			else
			{
				foreach (Transform transform in componentsInChildren)
				{
					if (transform.name.Trim() == name)
					{
						return transform.position + new Vector3(0f, 0.4f, 0f);
					}
				}
				piVector = AimbotCoroutines.PiVector;
			}
			return piVector;
		}

		// Token: 0x040001A6 RID: 422
		public static Vector3 PiVector = new Vector3(0f, 3.1415927f, 0f);

		// Token: 0x040001A7 RID: 423
		public static GameObject LockedObject;

		// Token: 0x040001A8 RID: 424
		public static bool IsAiming = false;

		// Token: 0x040001A9 RID: 425
		public static FieldInfo PitchInfo;

		// Token: 0x040001AA RID: 426
		public static FieldInfo YawInfo;
	}
}
