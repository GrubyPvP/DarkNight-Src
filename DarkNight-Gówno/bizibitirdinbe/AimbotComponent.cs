using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000025 RID: 37
	[Component]
	public class AimbotComponent : MonoBehaviour
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000251F File Offset: 0x0000071F
		public void Start()
		{
			CoroutineComponent.LockCoroutine = base.StartCoroutine(AimbotCoroutines.SetLockedObject());
			CoroutineComponent.AimbotCoroutine = base.StartCoroutine(AimbotCoroutines.AimToObject());
			base.StartCoroutine(RaycastCoroutines.UpdateObjects());
		}
	}
}
