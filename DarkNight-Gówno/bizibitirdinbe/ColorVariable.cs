using System;
using Newtonsoft.Json;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000CB RID: 203
	public class ColorVariable
	{
		// Token: 0x06000351 RID: 849 RVA: 0x000046C9 File Offset: 0x000028C9
		[JsonConstructor]
		public ColorVariable(string identity, string name, Color32 color, Color32 origColor, bool disableAlpha)
		{
			this.identity = identity;
			this.name = name;
			this.color = color;
			this.origColor = origColor;
			this.disableAlpha = disableAlpha;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00004701 File Offset: 0x00002901
		public ColorVariable(string identity, string name, Color32 color, bool disableAlpha = true)
		{
			this.identity = identity;
			this.name = name;
			this.color = color;
			this.origColor = color;
			this.disableAlpha = disableAlpha;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001CF2C File Offset: 0x0001B12C
		public ColorVariable(ColorVariable option)
		{
			this.identity = option.identity;
			this.name = option.name;
			this.color = option.color;
			this.origColor = option.origColor;
			this.disableAlpha = option.disableAlpha;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00004738 File Offset: 0x00002938
		public static implicit operator Color(ColorVariable color)
		{
			return color.color.ToColor();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000474A File Offset: 0x0000294A
		public static implicit operator Color32(ColorVariable color)
		{
			return color.color;
		}

		// Token: 0x0400040C RID: 1036
		public SerializableColor color;

		// Token: 0x0400040D RID: 1037
		public SerializableColor origColor;

		// Token: 0x0400040E RID: 1038
		public string name;

		// Token: 0x0400040F RID: 1039
		public string identity;

		// Token: 0x04000410 RID: 1040
		public bool disableAlpha;
	}
}
