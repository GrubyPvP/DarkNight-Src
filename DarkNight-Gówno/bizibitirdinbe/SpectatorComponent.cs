using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000033 RID: 51
	[Component]
	public class SpectatorComponent : MonoBehaviour
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000F240 File Offset: 0x0000D440
		public void FixedUpdate()
		{
			if (DrawUtilities.ShouldRun())
			{
				if (MiscOptions.SpectatedPlayer != null && !G.BeingSpied)
				{
					OptimizationVariables.MainPlayer.look.isOrbiting = true;
					OptimizationVariables.MainPlayer.look.orbitPosition = MiscOptions.SpectatedPlayer.transform.position - OptimizationVariables.MainPlayer.transform.position;
					OptimizationVariables.MainPlayer.look.orbitPosition += new Vector3(0f, 3f, 0f);
					return;
				}
				OptimizationVariables.MainPlayer.look.isOrbiting = MiscOptions.Freecam;
			}
		}
	}
}
