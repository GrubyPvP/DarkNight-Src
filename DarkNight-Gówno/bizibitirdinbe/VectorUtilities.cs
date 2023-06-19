using System;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000C4 RID: 196
	public static class VectorUtilities
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000045E2 File Offset: 0x000027E2
		public static double GetDistance(Vector3 point)
		{
			return VectorUtilities.GetDistance(OptimizationVariables.MainCam.transform.position, point);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000023C8 File Offset: 0x000005C8
		public static float GetDistance2(Vector3 endpos)
		{
			return (float)Math.Round((double)Vector3.Distance(Player.player.look.aim.position, endpos));
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		public static double GetDistance(Vector3 start, Vector3 point)
		{
			Vector3 vector;
			vector.x = start.x - point.x;
			vector.y = start.y - point.y;
			vector.z = start.z - point.z;
			return Math.Sqrt((double)(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z));
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001CE38 File Offset: 0x0001B038
		public static float smethod_0(float fov)
		{
			float fieldOfView = OptimizationVariables.MainCam.fieldOfView;
			if (GraphicsSettings.scopeQuality != null)
			{
				UseableGun useableGun = Player.player.equipment.useable as UseableGun;
				if (useableGun && useableGun.isAiming && Player.player.look.scopeCamera.enabled)
				{
					fieldOfView = Player.player.look.scopeCamera.fieldOfView;
				}
			}
			return (float)(Math.Tan((double)fov * 0.017453292519943295 / 2.0) / Math.Tan((double)fieldOfView * 0.017453292519943295 / 2.0) * (double)Screen.height);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000045F9 File Offset: 0x000027F9
		public static double GetMagnitude(Vector3 vector)
		{
			return Math.Sqrt((double)(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000462A File Offset: 0x0000282A
		public static Vector3 Normalize(Vector3 vector)
		{
			return vector / (float)VectorUtilities.GetMagnitude(vector);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		public static double GetAngleDelta(Vector3 mainPos, Vector3 forward, Vector3 target)
		{
			Vector3 vector = VectorUtilities.Normalize(target - mainPos);
			return Math.Atan2(VectorUtilities.GetMagnitude(Vector3.Cross(vector, forward)), (double)Vector3.Dot(vector, forward)) * 57.29577951308232;
		}
	}
}
