using System;
using System.Linq;
using SDG.Unturned;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000B1 RID: 177
	public static class LocationUtilities
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0001A828 File Offset: 0x00018A28
		public static LocationNode GetClosestLocation(Vector3 pos)
		{
			double num = 1337420.0;
			LocationNode result = null;
			foreach (LocationNode locationNode in LevelNodes.nodes.Where(new Func<Node, bool>(LocationUtilities.<>c.<>c_0.method_0)).Select(new Func<Node, LocationNode>(LocationUtilities.<>c.<>c_0.method_1)).ToArray<LocationNode>())
			{
				double distance = VectorUtilities.GetDistance(pos, locationNode.point);
				if (distance < num)
				{
					num = distance;
					result = locationNode;
				}
			}
			return result;
		}
	}
}
