using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000076 RID: 118
	public class LocalBounds
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00003D93 File Offset: 0x00001F93
		public LocalBounds(Vector3 po, Vector3 e)
		{
			this.PosOffset = po;
			this.Extents = e;
		}

		// Token: 0x0400021B RID: 539
		public Vector3 PosOffset;

		// Token: 0x0400021C RID: 540
		public Vector3 Extents;
	}
}
