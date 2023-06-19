using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000096 RID: 150
	public class SerializableRect
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00003FC7 File Offset: 0x000021C7
		public static implicit operator Rect(SerializableRect rect)
		{
			return new Rect(rect.x, rect.y, rect.width, rect.height);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003FE6 File Offset: 0x000021E6
		public static implicit operator SerializableRect(Rect rect)
		{
			return new SerializableRect
			{
				x = rect.x,
				y = rect.y,
				width = rect.width,
				height = rect.height
			};
		}

		// Token: 0x0400039D RID: 925
		public float x;

		// Token: 0x0400039E RID: 926
		public float y;

		// Token: 0x0400039F RID: 927
		public float width;

		// Token: 0x040003A0 RID: 928
		public float height;
	}
}
