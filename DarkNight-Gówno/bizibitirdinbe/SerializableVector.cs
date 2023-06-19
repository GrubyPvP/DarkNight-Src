using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000085 RID: 133
	public class SerializableVector
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00003EF9 File Offset: 0x000020F9
		public SerializableVector(float nx, float ny, float nz)
		{
			this.x = nx;
			this.y = ny;
			this.z = nz;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00003F17 File Offset: 0x00002117
		public Vector3 ToVector()
		{
			return new Vector3(this.x, this.y, this.z);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003F30 File Offset: 0x00002130
		public static implicit operator Vector3(SerializableVector vector)
		{
			return vector.ToVector();
		}

		// Token: 0x04000271 RID: 625
		public float x;

		// Token: 0x04000272 RID: 626
		public float y;

		// Token: 0x04000273 RID: 627
		public float z;
	}
}
