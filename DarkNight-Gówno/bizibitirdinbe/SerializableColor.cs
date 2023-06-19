using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000084 RID: 132
	public class SerializableColor
	{
		// Token: 0x0600027F RID: 639 RVA: 0x00003E6A File Offset: 0x0000206A
		public SerializableColor(int nr, int ng, int nb, int na)
		{
			this.r = nr;
			this.g = ng;
			this.b = nb;
			this.a = na;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003E90 File Offset: 0x00002090
		public SerializableColor(int nr, int ng, int nb)
		{
			this.r = nr;
			this.g = ng;
			this.b = nb;
			this.a = 255;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003EB9 File Offset: 0x000020B9
		public static implicit operator Color32(SerializableColor color)
		{
			return color.ToColor();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00003EC1 File Offset: 0x000020C1
		public static implicit operator Color(SerializableColor color)
		{
			return color.ToColor();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00003ECE File Offset: 0x000020CE
		public static implicit operator SerializableColor(Color32 color)
		{
			return color.ToSerializableColor();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003ED6 File Offset: 0x000020D6
		public Color32 ToColor()
		{
			return new Color32((byte)this.r, (byte)this.g, (byte)this.b, (byte)this.a);
		}

		// Token: 0x0400026D RID: 621
		public int r;

		// Token: 0x0400026E RID: 622
		public int g;

		// Token: 0x0400026F RID: 623
		public int b;

		// Token: 0x04000270 RID: 624
		public int a;
	}
}
