using System;
using System.Collections.Generic;
using System.Linq;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000C2 RID: 194
	public static class SphereUtilities
	{
		// Token: 0x06000341 RID: 833 RVA: 0x0001CC74 File Offset: 0x0001AE74
		public static bool GetRaycast(GameObject Target, Vector3 StartPos, out Vector3 Point)
		{
			Point = Vector3.zero;
			bool result;
			if (Target == null)
			{
				result = false;
			}
			else
			{
				SphereUtilities.<>c__DisplayClass0_0 CS$<>8__locals1 = new SphereUtilities.<>c__DisplayClass0_0();
				int layer = Target.layer;
				Target.layer = 24;
				CS$<>8__locals1.YuFmkrWpyj = Target.GetComponent<RaycastComponent>();
				if (VectorUtilities.GetDistance(Target.transform.position, StartPos) <= 15.5)
				{
					Point = OptimizationVariables.MainPlayer.transform.position;
					result = true;
				}
				else
				{
					IEnumerable<Vector3> vertices = CS$<>8__locals1.YuFmkrWpyj.Sphere.GetComponent<MeshCollider>().sharedMesh.vertices;
					Func<Vector3, Vector3> selector;
					if ((selector = CS$<>8__locals1.func_0) == null)
					{
						selector = (CS$<>8__locals1.func_0 = new Func<Vector3, Vector3>(CS$<>8__locals1.method_0));
					}
					foreach (Vector3 vector in vertices.Select(selector).ToArray<Vector3>())
					{
						Vector3 vector2 = VectorUtilities.Normalize(vector - StartPos);
						double distance = VectorUtilities.GetDistance(StartPos, vector);
						if (!Physics.Raycast(StartPos, vector2, (float)distance + 0.5f, RayMasks.DAMAGE_CLIENT))
						{
							Target.layer = layer;
							Point = vector;
							return true;
						}
					}
					Target.layer = layer;
					result = false;
				}
			}
			return result;
		}
	}
}
