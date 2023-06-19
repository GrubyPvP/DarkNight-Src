using System;
using System.Globalization;
using System.Linq;
using bizibitirdinbe;
using UnityEngine;

// Token: 0x020000AB RID: 171
internal class Class1
{
	// Token: 0x060002DE RID: 734 RVA: 0x00004333 File Offset: 0x00002533
	public static void smethod_0(ColorVariable colorVariable_0)
	{
		if (!ColorOptions.DefaultColorDict.ContainsKey(colorVariable_0.identity))
		{
			ColorOptions.DefaultColorDict.Add(colorVariable_0.identity, colorVariable_0);
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00018E10 File Offset: 0x00017010
	public static ColorVariable smethod_1(string string_0)
	{
		ColorVariable colorVariable;
		ColorVariable result;
		if (!ColorOptions.ColorDict.TryGetValue(string_0, out colorVariable))
		{
			result = ColorOptions.errorColor;
		}
		else
		{
			result = colorVariable;
		}
		return result;
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00018E3C File Offset: 0x0001703C
	public static string smethod_2(string string_0)
	{
		ColorVariable color;
		string result;
		if (!ColorOptions.ColorDict.TryGetValue(string_0, out color))
		{
			result = Class1.smethod_4(ColorOptions.errorColor);
		}
		else
		{
			result = Class1.smethod_4(color);
		}
		return result;
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00018E7C File Offset: 0x0001707C
	public static void smethod_3(string string_0, Color32 color32_0)
	{
		ColorVariable colorVariable;
		if (ColorOptions.ColorDict.TryGetValue(string_0, out colorVariable))
		{
			colorVariable.color = color32_0.ToSerializableColor();
		}
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00018EA8 File Offset: 0x000170A8
	public static string smethod_4(Color32 color32_0)
	{
		return color32_0.r.ToString("X2") + color32_0.g.ToString("X2") + color32_0.b.ToString("X2") + "FF";
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0000435B File Offset: 0x0000255B
	public static ColorVariable[] smethod_5()
	{
		return ColorOptions.ColorDict.Values.ToArray<ColorVariable>();
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00018EF8 File Offset: 0x000170F8
	public static Color32 smethod_6(string string_0)
	{
		byte b = byte.Parse(string_0.Substring(0, 2), NumberStyles.HexNumber);
		byte b2 = byte.Parse(string_0.Substring(2, 2), NumberStyles.HexNumber);
		byte b3 = byte.Parse(string_0.Substring(4, 2), NumberStyles.HexNumber);
		return new Color32(b, b2, b3, byte.MaxValue);
	}
}
