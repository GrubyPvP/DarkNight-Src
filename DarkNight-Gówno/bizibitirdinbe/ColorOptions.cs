using System;
using System.Collections.Generic;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000091 RID: 145
	public static class ColorOptions
	{
		// Token: 0x0400034D RID: 845
		[Save]
		public static Dictionary<string, ColorVariable> ColorDict = new Dictionary<string, ColorVariable>();

		// Token: 0x0400034E RID: 846
		public static Dictionary<string, ColorVariable> DefaultColorDict = new Dictionary<string, ColorVariable>();

		// Token: 0x0400034F RID: 847
		public static ColorVariable errorColor = new ColorVariable("errorColor", "#ERROR.NOTFOUND", Color.magenta, true);

		// Token: 0x04000350 RID: 848
		public static ColorVariable preview = new ColorVariable("preview", "Renk Seçilmedi", Color.white, true);

		// Token: 0x04000351 RID: 849
		public static ColorVariable previewselected;

		// Token: 0x04000352 RID: 850
		public static string selectedOption;
	}
}
