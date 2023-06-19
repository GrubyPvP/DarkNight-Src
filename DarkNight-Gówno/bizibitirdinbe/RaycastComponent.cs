using System;
using System.Collections;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x0200002F RID: 47
	[DisallowMultipleComponent]
	public class RaycastComponent : MonoBehaviour
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00002858 File Offset: 0x00000A58
		public void Awake()
		{
			base.StartCoroutine(this.RedoSphere());
			base.StartCoroutine(this.CalcSphere());
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002874 File Offset: 0x00000A74
		public IEnumerator CalcSphere()
		{
			RaycastComponent.<CalcSphere>d__1 <CalcSphere>d__ = new RaycastComponent.<CalcSphere>d__1(0);
			<CalcSphere>d__.<>4__this = this;
			return <CalcSphere>d__;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002883 File Offset: 0x00000A83
		public IEnumerator RedoSphere()
		{
			RaycastComponent.<RedoSphere>d__2 <RedoSphere>d__ = new RaycastComponent.<RedoSphere>d__2(0);
			<RedoSphere>d__.<>4__this = this;
			return <RedoSphere>d__;
		}

		// Token: 0x0400010E RID: 270
		public GameObject Sphere;
	}
}
