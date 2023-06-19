using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x02000083 RID: 131
	public static class Extensions
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00003E07 File Offset: 0x00002007
		public static Color Invert(this Color32 color)
		{
			return new Color((float)(byte.MaxValue - color.r), (float)(byte.MaxValue - color.g), (float)(byte.MaxValue - color.b));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00016BA0 File Offset: 0x00014DA0
		public static T Next<T>(this T src) where T : struct
		{
			if (!typeof(T).IsEnum)
			{
				throw new ArgumentException(string.Format("Argument {0} is not an Enum", typeof(T).FullName));
			}
			T[] array = (T[])Enum.GetValues(src.GetType());
			int num = Array.IndexOf<T>(array, src) + 1;
			if (array.Length != num)
			{
				return array[num];
			}
			return array[0];
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00003E35 File Offset: 0x00002035
		public static SerializableColor ToSerializableColor(this Color32 c)
		{
			return new SerializableColor((int)c.r, (int)c.g, (int)c.b, (int)c.a);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003E54 File Offset: 0x00002054
		public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int N)
		{
			return source.Skip(Math.Max(0, source.Count<T>() - N));
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00016C18 File Offset: 0x00014E18
		public static void AddRange<T>(this HashSet<T> source, IEnumerable<T> target)
		{
			foreach (T item in target)
			{
				source.Add(item);
			}
		}
	}
}
