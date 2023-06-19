using System;

namespace bizibitirdinbe
{
	// Token: 0x02000042 RID: 66
	public struct EmbedColor
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public EmbedColor(byte r, byte g, byte b)
		{
			this.R = r;
			this.G = g;
			this.B = b;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00010684 File Offset: 0x0000E884
		public override bool Equals(object obj)
		{
			if (obj is EmbedColor)
			{
				EmbedColor embedColor = (EmbedColor)obj;
				return embedColor.R == this.R && embedColor.G == this.G && embedColor.B == this.B;
			}
			return false;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002BED File Offset: 0x00000DED
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002BFF File Offset: 0x00000DFF
		public static EmbedColor Transparent
		{
			get
			{
				return new EmbedColor(byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002C15 File Offset: 0x00000E15
		public static EmbedColor AliceBlue
		{
			get
			{
				return new EmbedColor(240, 248, byte.MaxValue);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002C2B File Offset: 0x00000E2B
		public static EmbedColor AntiqueWhite
		{
			get
			{
				return new EmbedColor(250, 235, 215);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002C41 File Offset: 0x00000E41
		public static EmbedColor Aqua
		{
			get
			{
				return new EmbedColor(0, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002C53 File Offset: 0x00000E53
		public static EmbedColor Aquamarine
		{
			get
			{
				return new EmbedColor(127, byte.MaxValue, 212);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002C66 File Offset: 0x00000E66
		public static EmbedColor Azure
		{
			get
			{
				return new EmbedColor(240, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002C7C File Offset: 0x00000E7C
		public static EmbedColor Beige
		{
			get
			{
				return new EmbedColor(245, 245, 220);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002C92 File Offset: 0x00000E92
		public static EmbedColor Bisque
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 228, 196);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public static EmbedColor Black
		{
			get
			{
				return new EmbedColor(0, 0, 0);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002CB2 File Offset: 0x00000EB2
		public static EmbedColor BlanchedAlmond
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 235, 205);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public static EmbedColor Blue
		{
			get
			{
				return new EmbedColor(0, 0, byte.MaxValue);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public static EmbedColor BlueViolet
		{
			get
			{
				return new EmbedColor(138, 43, 226);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public static EmbedColor Brown
		{
			get
			{
				return new EmbedColor(165, 42, 42);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public static EmbedColor BurlyWood
		{
			get
			{
				return new EmbedColor(222, 184, 135);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002D0F File Offset: 0x00000F0F
		public static EmbedColor CadetBlue
		{
			get
			{
				return new EmbedColor(95, 158, 160);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002D22 File Offset: 0x00000F22
		public static EmbedColor Chartreuse
		{
			get
			{
				return new EmbedColor(127, byte.MaxValue, 0);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002D31 File Offset: 0x00000F31
		public static EmbedColor Chocolate
		{
			get
			{
				return new EmbedColor(210, 105, 30);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002D41 File Offset: 0x00000F41
		public static EmbedColor Coral
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 127, 80);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002D51 File Offset: 0x00000F51
		public static EmbedColor CornflowerBlue
		{
			get
			{
				return new EmbedColor(100, 149, 237);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002D64 File Offset: 0x00000F64
		public static EmbedColor Cornsilk
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 248, 220);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002D7A File Offset: 0x00000F7A
		public static EmbedColor Crimson
		{
			get
			{
				return new EmbedColor(220, 20, 60);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002C41 File Offset: 0x00000E41
		public static EmbedColor Cyan
		{
			get
			{
				return new EmbedColor(0, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002D8A File Offset: 0x00000F8A
		public static EmbedColor DarkBlue
		{
			get
			{
				return new EmbedColor(0, 0, 139);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002D98 File Offset: 0x00000F98
		public static EmbedColor DarkCyan
		{
			get
			{
				return new EmbedColor(0, 139, 139);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002DAA File Offset: 0x00000FAA
		public static EmbedColor DarkGoldenrod
		{
			get
			{
				return new EmbedColor(184, 134, 11);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00002DBD File Offset: 0x00000FBD
		public static EmbedColor DarkGray
		{
			get
			{
				return new EmbedColor(169, 169, 169);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002DD3 File Offset: 0x00000FD3
		public static EmbedColor DarkGreen
		{
			get
			{
				return new EmbedColor(0, 100, 0);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00002DDE File Offset: 0x00000FDE
		public static EmbedColor DarkKhaki
		{
			get
			{
				return new EmbedColor(189, 183, 107);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002DF1 File Offset: 0x00000FF1
		public static EmbedColor DarkMagenta
		{
			get
			{
				return new EmbedColor(139, 0, 139);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002E03 File Offset: 0x00001003
		public static EmbedColor DarkOliveGreen
		{
			get
			{
				return new EmbedColor(85, 107, 47);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002E10 File Offset: 0x00001010
		public static EmbedColor DarkOrange
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 140, 0);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002E22 File Offset: 0x00001022
		public static EmbedColor DarkOrchid
		{
			get
			{
				return new EmbedColor(153, 50, 204);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002E35 File Offset: 0x00001035
		public static EmbedColor DarkRed
		{
			get
			{
				return new EmbedColor(139, 0, 0);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002E43 File Offset: 0x00001043
		public static EmbedColor DarkSalmon
		{
			get
			{
				return new EmbedColor(233, 150, 122);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002E56 File Offset: 0x00001056
		public static EmbedColor DarkSeaGreen
		{
			get
			{
				return new EmbedColor(143, 188, 143);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002E6C File Offset: 0x0000106C
		public static EmbedColor DarkSlateBlue
		{
			get
			{
				return new EmbedColor(72, 61, 139);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002E7C File Offset: 0x0000107C
		public static EmbedColor DarkSlateGray
		{
			get
			{
				return new EmbedColor(47, 79, 79);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00002E89 File Offset: 0x00001089
		public static EmbedColor DarkTurquoise
		{
			get
			{
				return new EmbedColor(0, 206, 209);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002E9B File Offset: 0x0000109B
		public static EmbedColor DarkViolet
		{
			get
			{
				return new EmbedColor(148, 0, 211);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002EAD File Offset: 0x000010AD
		public static EmbedColor DeepPink
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 20, 147);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002EC0 File Offset: 0x000010C0
		public static EmbedColor DeepSkyBlue
		{
			get
			{
				return new EmbedColor(0, 191, byte.MaxValue);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002ED2 File Offset: 0x000010D2
		public static EmbedColor DimGray
		{
			get
			{
				return new EmbedColor(105, 105, 105);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00002EDF File Offset: 0x000010DF
		public static EmbedColor DodgerBlue
		{
			get
			{
				return new EmbedColor(30, 144, byte.MaxValue);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002EF2 File Offset: 0x000010F2
		public static EmbedColor Firebrick
		{
			get
			{
				return new EmbedColor(178, 34, 34);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002F02 File Offset: 0x00001102
		public static EmbedColor FloralWhite
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 250, 240);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002F18 File Offset: 0x00001118
		public static EmbedColor ForestGreen
		{
			get
			{
				return new EmbedColor(34, 139, 34);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002F28 File Offset: 0x00001128
		public static EmbedColor Fuchsia
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 0, byte.MaxValue);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002F3A File Offset: 0x0000113A
		public static EmbedColor Gainsboro
		{
			get
			{
				return new EmbedColor(220, 220, 220);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002F50 File Offset: 0x00001150
		public static EmbedColor GhostWhite
		{
			get
			{
				return new EmbedColor(248, 248, byte.MaxValue);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002F66 File Offset: 0x00001166
		public static EmbedColor Gold
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 215, 0);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002F78 File Offset: 0x00001178
		public static EmbedColor Goldenrod
		{
			get
			{
				return new EmbedColor(218, 165, 32);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002F8B File Offset: 0x0000118B
		public static EmbedColor Gray
		{
			get
			{
				return new EmbedColor(128, 128, 128);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002FA1 File Offset: 0x000011A1
		public static EmbedColor Green
		{
			get
			{
				return new EmbedColor(0, 128, 0);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002FAF File Offset: 0x000011AF
		public static EmbedColor GreenYellow
		{
			get
			{
				return new EmbedColor(173, byte.MaxValue, 47);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002FC2 File Offset: 0x000011C2
		public static EmbedColor Honeydew
		{
			get
			{
				return new EmbedColor(240, byte.MaxValue, 240);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002FD8 File Offset: 0x000011D8
		public static EmbedColor HotPink
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 105, 180);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002FEB File Offset: 0x000011EB
		public static EmbedColor IndianRed
		{
			get
			{
				return new EmbedColor(205, 92, 92);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002FFB File Offset: 0x000011FB
		public static EmbedColor Indigo
		{
			get
			{
				return new EmbedColor(75, 0, 130);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000300A File Offset: 0x0000120A
		public static EmbedColor Ivory
		{
			get
			{
				return new EmbedColor(byte.MaxValue, byte.MaxValue, 240);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00003020 File Offset: 0x00001220
		public static EmbedColor Khaki
		{
			get
			{
				return new EmbedColor(240, 230, 140);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00003036 File Offset: 0x00001236
		public static EmbedColor Lavender
		{
			get
			{
				return new EmbedColor(230, 230, 250);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000304C File Offset: 0x0000124C
		public static EmbedColor LavenderBlush
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 240, 245);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00003062 File Offset: 0x00001262
		public static EmbedColor LawnGreen
		{
			get
			{
				return new EmbedColor(124, 252, 0);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00003071 File Offset: 0x00001271
		public static EmbedColor LemonChiffon
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 250, 205);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00003087 File Offset: 0x00001287
		public static EmbedColor LightBlue
		{
			get
			{
				return new EmbedColor(173, 216, 230);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000309D File Offset: 0x0000129D
		public static EmbedColor LightCoral
		{
			get
			{
				return new EmbedColor(240, 128, 128);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000030B3 File Offset: 0x000012B3
		public static EmbedColor LightCyan
		{
			get
			{
				return new EmbedColor(224, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000030C9 File Offset: 0x000012C9
		public static EmbedColor LightGoldenrodYellow
		{
			get
			{
				return new EmbedColor(250, 250, 210);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000030DF File Offset: 0x000012DF
		public static EmbedColor LightGreen
		{
			get
			{
				return new EmbedColor(144, 238, 144);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000030F5 File Offset: 0x000012F5
		public static EmbedColor LightGray
		{
			get
			{
				return new EmbedColor(211, 211, 211);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000310B File Offset: 0x0000130B
		public static EmbedColor LightPink
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 182, 193);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00003121 File Offset: 0x00001321
		public static EmbedColor LightSalmon
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 160, 122);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00003134 File Offset: 0x00001334
		public static EmbedColor LightSeaGreen
		{
			get
			{
				return new EmbedColor(32, 178, 170);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00003147 File Offset: 0x00001347
		public static EmbedColor LightSkyBlue
		{
			get
			{
				return new EmbedColor(135, 206, 250);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000315D File Offset: 0x0000135D
		public static EmbedColor LightSlateGray
		{
			get
			{
				return new EmbedColor(119, 136, 153);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00003170 File Offset: 0x00001370
		public static EmbedColor LightSteelBlue
		{
			get
			{
				return new EmbedColor(176, 196, 222);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00003186 File Offset: 0x00001386
		public static EmbedColor LightYellow
		{
			get
			{
				return new EmbedColor(byte.MaxValue, byte.MaxValue, 224);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000319C File Offset: 0x0000139C
		public static EmbedColor Lime
		{
			get
			{
				return new EmbedColor(0, byte.MaxValue, 0);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000031AA File Offset: 0x000013AA
		public static EmbedColor LimeGreen
		{
			get
			{
				return new EmbedColor(50, 205, 50);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000031BA File Offset: 0x000013BA
		public static EmbedColor Linen
		{
			get
			{
				return new EmbedColor(250, 240, 230);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002F28 File Offset: 0x00001128
		public static EmbedColor Magenta
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 0, byte.MaxValue);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000031D0 File Offset: 0x000013D0
		public static EmbedColor Maroon
		{
			get
			{
				return new EmbedColor(128, 0, 0);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000031DE File Offset: 0x000013DE
		public static EmbedColor MediumAquamarine
		{
			get
			{
				return new EmbedColor(102, 205, 170);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000031F1 File Offset: 0x000013F1
		public static EmbedColor MediumBlue
		{
			get
			{
				return new EmbedColor(0, 0, 205);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000031FF File Offset: 0x000013FF
		public static EmbedColor MediumOrchid
		{
			get
			{
				return new EmbedColor(186, 85, 211);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00003212 File Offset: 0x00001412
		public static EmbedColor MediumPurple
		{
			get
			{
				return new EmbedColor(147, 112, 219);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00003225 File Offset: 0x00001425
		public static EmbedColor MediumSeaGreen
		{
			get
			{
				return new EmbedColor(60, 179, 113);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00003235 File Offset: 0x00001435
		public static EmbedColor MediumSlateBlue
		{
			get
			{
				return new EmbedColor(123, 104, 238);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00003245 File Offset: 0x00001445
		public static EmbedColor MediumSpringGreen
		{
			get
			{
				return new EmbedColor(0, 250, 154);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00003257 File Offset: 0x00001457
		public static EmbedColor MediumTurquoise
		{
			get
			{
				return new EmbedColor(72, 209, 204);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000326A File Offset: 0x0000146A
		public static EmbedColor MediumVioletRed
		{
			get
			{
				return new EmbedColor(199, 21, 133);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000327D File Offset: 0x0000147D
		public static EmbedColor MidnightBlue
		{
			get
			{
				return new EmbedColor(25, 25, 112);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000328A File Offset: 0x0000148A
		public static EmbedColor MintCream
		{
			get
			{
				return new EmbedColor(245, byte.MaxValue, 250);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000032A0 File Offset: 0x000014A0
		public static EmbedColor MistyRose
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 228, 225);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000032B6 File Offset: 0x000014B6
		public static EmbedColor Moccasin
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 228, 181);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000032CC File Offset: 0x000014CC
		public static EmbedColor NavajoWhite
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 222, 173);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000032E2 File Offset: 0x000014E2
		public static EmbedColor Navy
		{
			get
			{
				return new EmbedColor(0, 0, 128);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000032F0 File Offset: 0x000014F0
		public static EmbedColor OldLace
		{
			get
			{
				return new EmbedColor(253, 245, 230);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00003306 File Offset: 0x00001506
		public static EmbedColor Olive
		{
			get
			{
				return new EmbedColor(128, 128, 0);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00003318 File Offset: 0x00001518
		public static EmbedColor OliveDrab
		{
			get
			{
				return new EmbedColor(107, 142, 35);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00003328 File Offset: 0x00001528
		public static EmbedColor Orange
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 165, 0);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000333A File Offset: 0x0000153A
		public static EmbedColor OrangeRed
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 69, 0);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003349 File Offset: 0x00001549
		public static EmbedColor Orchid
		{
			get
			{
				return new EmbedColor(218, 112, 214);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000335C File Offset: 0x0000155C
		public static EmbedColor PaleGoldenrod
		{
			get
			{
				return new EmbedColor(238, 232, 170);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003372 File Offset: 0x00001572
		public static EmbedColor PaleGreen
		{
			get
			{
				return new EmbedColor(152, 251, 152);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00003388 File Offset: 0x00001588
		public static EmbedColor PaleTurquoise
		{
			get
			{
				return new EmbedColor(175, 238, 238);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000339E File Offset: 0x0000159E
		public static EmbedColor PaleVioletRed
		{
			get
			{
				return new EmbedColor(219, 112, 147);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000033B1 File Offset: 0x000015B1
		public static EmbedColor PapayaWhip
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 239, 213);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000033C7 File Offset: 0x000015C7
		public static EmbedColor PeachPuff
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 218, 185);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000033DD File Offset: 0x000015DD
		public static EmbedColor Peru
		{
			get
			{
				return new EmbedColor(205, 133, 63);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000033F0 File Offset: 0x000015F0
		public static EmbedColor Pink
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 192, 203);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00003406 File Offset: 0x00001606
		public static EmbedColor Plum
		{
			get
			{
				return new EmbedColor(221, 160, 221);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000341C File Offset: 0x0000161C
		public static EmbedColor PowderBlue
		{
			get
			{
				return new EmbedColor(176, 224, 230);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00003432 File Offset: 0x00001632
		public static EmbedColor Purple
		{
			get
			{
				return new EmbedColor(128, 0, 128);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00003444 File Offset: 0x00001644
		public static EmbedColor RebeccaPurple
		{
			get
			{
				return new EmbedColor(102, 51, 153);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00003454 File Offset: 0x00001654
		public static EmbedColor Red
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 0, 0);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00003462 File Offset: 0x00001662
		public static EmbedColor RosyBrown
		{
			get
			{
				return new EmbedColor(188, 143, 143);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003478 File Offset: 0x00001678
		public static EmbedColor RoyalBlue
		{
			get
			{
				return new EmbedColor(65, 105, 225);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003488 File Offset: 0x00001688
		public static EmbedColor SaddleBrown
		{
			get
			{
				return new EmbedColor(139, 69, 19);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003498 File Offset: 0x00001698
		public static EmbedColor Salmon
		{
			get
			{
				return new EmbedColor(250, 128, 114);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000034AB File Offset: 0x000016AB
		public static EmbedColor SandyBrown
		{
			get
			{
				return new EmbedColor(244, 164, 96);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000034BE File Offset: 0x000016BE
		public static EmbedColor SeaGreen
		{
			get
			{
				return new EmbedColor(46, 139, 87);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000034CE File Offset: 0x000016CE
		public static EmbedColor SeaShell
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 245, 238);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000034E4 File Offset: 0x000016E4
		public static EmbedColor Sienna
		{
			get
			{
				return new EmbedColor(160, 82, 45);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000034F4 File Offset: 0x000016F4
		public static EmbedColor Silver
		{
			get
			{
				return new EmbedColor(192, 192, 192);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000350A File Offset: 0x0000170A
		public static EmbedColor SkyBlue
		{
			get
			{
				return new EmbedColor(135, 206, 235);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00003520 File Offset: 0x00001720
		public static EmbedColor SlateBlue
		{
			get
			{
				return new EmbedColor(106, 90, 205);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00003530 File Offset: 0x00001730
		public static EmbedColor SlateGray
		{
			get
			{
				return new EmbedColor(112, 128, 144);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00003543 File Offset: 0x00001743
		public static EmbedColor Snow
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 250, 250);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00003559 File Offset: 0x00001759
		public static EmbedColor SpringGreen
		{
			get
			{
				return new EmbedColor(0, byte.MaxValue, 127);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00003568 File Offset: 0x00001768
		public static EmbedColor SteelBlue
		{
			get
			{
				return new EmbedColor(70, 130, 180);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000357B File Offset: 0x0000177B
		public static EmbedColor Tan
		{
			get
			{
				return new EmbedColor(210, 180, 140);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00003591 File Offset: 0x00001791
		public static EmbedColor Teal
		{
			get
			{
				return new EmbedColor(0, 128, 128);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000035A3 File Offset: 0x000017A3
		public static EmbedColor Thistle
		{
			get
			{
				return new EmbedColor(216, 191, 216);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000035B9 File Offset: 0x000017B9
		public static EmbedColor Tomato
		{
			get
			{
				return new EmbedColor(byte.MaxValue, 99, 71);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000035C9 File Offset: 0x000017C9
		public static EmbedColor Turquoise
		{
			get
			{
				return new EmbedColor(64, 224, 208);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000035DC File Offset: 0x000017DC
		public static EmbedColor Violet
		{
			get
			{
				return new EmbedColor(238, 130, 238);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000035F2 File Offset: 0x000017F2
		public static EmbedColor Wheat
		{
			get
			{
				return new EmbedColor(245, 222, 179);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002BFF File Offset: 0x00000DFF
		public static EmbedColor White
		{
			get
			{
				return new EmbedColor(byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00003608 File Offset: 0x00001808
		public static EmbedColor WhiteSmoke
		{
			get
			{
				return new EmbedColor(245, 245, 245);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000361E File Offset: 0x0000181E
		public static EmbedColor Yellow
		{
			get
			{
				return new EmbedColor(byte.MaxValue, byte.MaxValue, 0);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00003630 File Offset: 0x00001830
		public static EmbedColor YellowGreen
		{
			get
			{
				return new EmbedColor(154, 205, 50);
			}
		}

		// Token: 0x0400014C RID: 332
		public byte R;

		// Token: 0x0400014D RID: 333
		public byte G;

		// Token: 0x0400014E RID: 334
		public byte B;
	}
}
