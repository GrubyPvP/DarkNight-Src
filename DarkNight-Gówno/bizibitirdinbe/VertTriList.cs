using System;
using UnityEngine;

namespace bizibitirdinbe
{
	// Token: 0x020000B8 RID: 184
	public class VertTriList
	{
		// Token: 0x170000BE RID: 190
		public int[] this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000449D File Offset: 0x0000269D
		public VertTriList(int[] tri, int numVerts)
		{
			this.Init(tri, numVerts);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000044AE File Offset: 0x000026AE
		public VertTriList(Mesh mesh)
		{
			this.Init(mesh.triangles, mesh.vertexCount);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001B5C0 File Offset: 0x000197C0
		public void Init(int[] tri, int numVerts)
		{
			int[] array = new int[numVerts];
			for (int i = 0; i < tri.Length; i++)
			{
				array[tri[i]]++;
			}
			this.list = new int[numVerts][];
			for (int j = 0; j < array.Length; j++)
			{
				this.list[j] = new int[array[j]];
			}
			for (int k = 0; k < tri.Length; k++)
			{
				int num = tri[k];
				int[] array2 = this.list[num];
				int[] array3 = array;
				int num2 = num;
				int num3 = array3[num2] - 1;
				array3[num2] = num3;
				array2[num3] = k / 3;
			}
		}

		// Token: 0x040003DD RID: 989
		public int[][] list;
	}
}
