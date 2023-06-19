using System;
using System.Collections.Generic;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000C5 RID: 197
	public static class AssetVariables
	{
		// Token: 0x040003F4 RID: 1012
		public static AssetBundle ABundle;

		// Token: 0x040003F5 RID: 1013
		public static Dictionary<string, Material> Materials = new Dictionary<string, Material>();

		// Token: 0x040003F6 RID: 1014
		public static Dictionary<string, Font> Fonts = new Dictionary<string, Font>();

		// Token: 0x040003F7 RID: 1015
		public static Dictionary<string, Cursor> Cursor = new Dictionary<string, Cursor>();

		// Token: 0x040003F8 RID: 1016
		public static Dictionary<string, AudioClip> Audio = new Dictionary<string, AudioClip>();

		// Token: 0x040003F9 RID: 1017
		public static Dictionary<string, Texture2D> Textures = new Dictionary<string, Texture2D>();

		// Token: 0x040003FA RID: 1018
		public static Dictionary<string, Shader> Shaders = new Dictionary<string, Shader>();
	}
}
