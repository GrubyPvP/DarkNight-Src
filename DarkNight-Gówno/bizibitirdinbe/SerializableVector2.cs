using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000086 RID: 134
	public class SerializableVector2
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00003F38 File Offset: 0x00002138
		public SerializableVector2(float nx, float ny)
		{
			this.x = nx;
			this.y = ny;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003F4F File Offset: 0x0000214F
		public Vector2 ToVector2()
		{
			return new Vector2(this.x, this.y);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003F62 File Offset: 0x00002162
		public static implicit operator Vector2(SerializableVector2 vector)
		{
			return vector.ToVector2();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003F6A File Offset: 0x0000216A
		public static implicit operator SerializableVector2(Vector2 vector)
		{
			return new SerializableVector2(vector.x, vector.y);
		}

		// Token: 0x04000274 RID: 628
		public float x;

		// Token: 0x04000275 RID: 629
		public float y;
	}
}
