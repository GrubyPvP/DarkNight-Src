using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020000D3 RID: 211
internal class Class3
{
	// Token: 0x0600037C RID: 892 RVA: 0x0001D16C File Offset: 0x0001B36C
	static Class3()
	{
		Class3.bool_1 = false;
		Class3.bool_6 = false;
		Class3.rsacryptoServiceProvider_0 = null;
		Class3.dictionary_0 = null;
		Class3.object_0 = new object();
		Class3.int_4 = 0;
		Class3.object_1 = new object();
		Class3.list_1 = null;
		Class3.list_0 = null;
		Class3.byte_0 = new byte[0];
		Class3.byte_1 = new byte[0];
		Class3.intptr_0 = IntPtr.Zero;
		Class3.intptr_1 = IntPtr.Zero;
		Class3.string_0 = new string[0];
		Class3.int_3 = new int[0];
		Class3.int_2 = 1;
		Class3.bool_2 = false;
		Class3.sortedList_0 = new SortedList();
		Class3.int_1 = 0;
		Class3.long_0 = 0L;
		Class3.delegate2_1 = null;
		Class3.delegate2_0 = null;
		Class3.long_1 = 0L;
		Class3.int_5 = 0;
		Class3.bool_3 = false;
		Class3.bool_4 = false;
		Class3.int_0 = 0;
		Class3.intptr_3 = IntPtr.Zero;
		Class3.bool_5 = false;
		Class3.hashtable_0 = new Hashtable();
		Class3.delegate4_0 = null;
		Class3.delegate5_0 = null;
		Class3.delegate6_0 = null;
		Class3.delegate7_0 = null;
		Class3.delegate8_0 = null;
		Class3.delegate9_0 = null;
		Class3.intptr_2 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00002240 File Offset: 0x00000440
	private void method_0()
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0001D2E8 File Offset: 0x0001B4E8
	internal static byte[] smethod_0(byte[] byte_2)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_2.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_2.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_2.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array2[i] = byte_2[i];
		}
		byte[] array3 = array2;
		int num4 = byte_2.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class3.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class3.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class3.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class3.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class3.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class3.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class3.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class3.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class3.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class3.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class3.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class3.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class3.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class3.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class3.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class3.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class3.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class3.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class3.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class3.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class3.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class3.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class3.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class3.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class3.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class3.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class3.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class3.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class3.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class3.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class3.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class3.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class3.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class3.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class3.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class3.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class3.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class3.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class3.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class3.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class3.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class3.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class3.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class3.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class3.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class3.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class3.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class3.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class3.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class3.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class3.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class3.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class3.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class3.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class3.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class3.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class3.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class3.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class3.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class3.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class3.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class3.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class3.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class3.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0000488A File Offset: 0x00002A8A
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class3.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)uint_5] + Class3.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000048B3 File Offset: 0x00002AB3
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class3.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)uint_5] + Class3.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000381 RID: 897 RVA: 0x000048DC File Offset: 0x00002ADC
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class3.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)uint_5] + Class3.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00004902 File Offset: 0x00002B02
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class3.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)uint_5] + Class3.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00004929 File Offset: 0x00002B29
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0000493B File Offset: 0x00002B3B
	internal static bool smethod_6()
	{
		if (!Class3.bool_1)
		{
			Class3.smethod_8();
			Class3.bool_1 = true;
		}
		return Class3.bool_6;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x0000237F File Offset: 0x0000057F
	internal Class3()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0001D948 File Offset: 0x0001BB48
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 = 3771922U * (num13 & 255U) - (num13 >> 8);
			uint num14 = 3377656344U + num13;
			uint num15 = 3034820754U ^ num13;
			num14 = 2370U * (num14 & 1048575U) + (num14 >> 20);
			num13 = 64890U * num13 - num15;
			num13 ^= num13 << 8;
			num13 += num14;
			num13 ^= num13 >> 7;
			num13 += num15;
			num13 ^= num13 << 23;
			num13 += 304335374U;
			num13 = ((num13 << 12) - 840208304U ^ num14) - num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num16 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num16 & num9) >> num10);
				}
			}
			else
			{
				uint num17 = num4 ^ num11;
				array[num6] = (byte)(num17 & 255U);
				array[num6 + 1] = (byte)((num17 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num17 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num17 & 4278190080U) >> 24);
			}
		}
		Class3.byte_0 = array;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0001DC04 File Offset: 0x0001BE04
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class3.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0001DC84 File Offset: 0x0001BE84
	internal static void smethod_8()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class3.bool_6 = true;
			return;
		}
		try
		{
			Class3.bool_6 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00004954 File Offset: 0x00002B54
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class3.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class3.smethod_0(byte_2);
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0001DCD0 File Offset: 0x0001BED0
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class3.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x0600038B RID: 907 RVA: 0x0000496F File Offset: 0x00002B6F
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0001DD0C File Offset: 0x0001BF0C
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0000497D File Offset: 0x00002B7D
	private static uint smethod_13(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0001DD68 File Offset: 0x0001BF68
	private static void smethod_14(Stream stream_0, int int_6)
	{
		Class7.smethod_2(0, new object[]
		{
			stream_0,
			int_6
		}, null);
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
	internal static string smethod_15(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00004989 File Offset: 0x00002B89
	private static int smethod_16()
	{
		return 5;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
	private static void smethod_17()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0001DE00 File Offset: 0x0001C000
	private static Delegate smethod_18(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0001DE60 File Offset: 0x0001C060
	internal static object smethod_19(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000394 RID: 916
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x06000395 RID: 917
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x06000396 RID: 918 RVA: 0x0001DF70 File Offset: 0x0001C170
	private static IntPtr smethod_20(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class3.delegate4_0 == null)
		{
			Class3.delegate4_0 = (Class3.Delegate4)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Find ".Trim() + "ResourceA"), typeof(Class3.Delegate4));
		}
		return Class3.delegate4_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
	private static IntPtr smethod_21(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class3.delegate5_0 == null)
		{
			Class3.delegate5_0 = (Class3.Delegate5)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Virtual ".Trim() + "Alloc"), typeof(Class3.Delegate5));
		}
		return Class3.delegate5_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0001E024 File Offset: 0x0001C224
	private static int smethod_22(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class3.delegate6_0 == null)
		{
			Class3.delegate6_0 = (Class3.Delegate6)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class3.Delegate6));
		}
		return Class3.delegate6_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0001E08C File Offset: 0x0001C28C
	private static int smethod_23(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class3.delegate7_0 == null)
		{
			Class3.delegate7_0 = (Class3.Delegate7)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Virtual ".Trim() + "Protect"), typeof(Class3.Delegate7));
		}
		return Class3.delegate7_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
	private static IntPtr smethod_24(uint uint_1, int int_6, uint uint_2)
	{
		if (Class3.delegate8_0 == null)
		{
			Class3.delegate8_0 = (Class3.Delegate8)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Open ".Trim() + "Process"), typeof(Class3.Delegate8));
		}
		return Class3.delegate8_0(uint_1, int_6, uint_2);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0001E140 File Offset: 0x0001C340
	private static int smethod_25(IntPtr intptr_4)
	{
		if (Class3.delegate9_0 == null)
		{
			Class3.delegate9_0 = (Class3.Delegate9)Marshal.GetDelegateForFunctionPointer(Class3.GetProcAddress(Class3.smethod_26(), "Close ".Trim() + "Handle"), typeof(Class3.Delegate9));
		}
		return Class3.delegate9_0(intptr_4);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x0000498C File Offset: 0x00002B8C
	private static IntPtr smethod_26()
	{
		if (Class3.intptr_2 == IntPtr.Zero)
		{
			Class3.intptr_2 = Class3.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class3.intptr_2;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0001E198 File Offset: 0x0001C398
	private static byte[] smethod_27(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x0600039E RID: 926 RVA: 0x000049C2 File Offset: 0x00002BC2
	internal static byte[] smethod_28(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
	private static byte[] smethod_29(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class3.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			31,
			175,
			146,
			253,
			74,
			4,
			87,
			140,
			46,
			248,
			75,
			76,
			197,
			156,
			99,
			209,
			197,
			232,
			183,
			147,
			28,
			69,
			24,
			134,
			234,
			56,
			179,
			94,
			146,
			139,
			154,
			239
		};
		symmetricAlgorithm.IV = new byte[]
		{
			246,
			233,
			183,
			50,
			86,
			80,
			217,
			241,
			135,
			41,
			204,
			13,
			233,
			20,
			65,
			144
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class3.smethod_28(stream);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0001E264 File Offset: 0x0001C464
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0001E264 File Offset: 0x0001C464
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x000049CF File Offset: 0x00002BCF
	private byte[] method_4()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000049EA File Offset: 0x00002BEA
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00004A05 File Offset: 0x00002C05
	private byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00004A20 File Offset: 0x00002C20
	private byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00004A3B File Offset: 0x00002C3B
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00004A56 File Offset: 0x00002C56
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00004A71 File Offset: 0x00002C71
	internal byte[] method_10()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00004A8C File Offset: 0x00002C8C
	internal byte[] method_11()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00004AA7 File Offset: 0x00002CA7
	internal static bool smethod_30()
	{
		return null == null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00004AAD File Offset: 0x00002CAD
	internal static object smethod_31()
	{
		return null;
	}

	// Token: 0x04000424 RID: 1060
	private static bool bool_0 = false;

	// Token: 0x04000425 RID: 1061
	private static bool bool_1;

	// Token: 0x04000426 RID: 1062
	private static byte[] byte_0;

	// Token: 0x04000427 RID: 1063
	private static byte[] byte_1;

	// Token: 0x04000428 RID: 1064
	private static IntPtr intptr_0;

	// Token: 0x04000429 RID: 1065
	private static IntPtr intptr_1;

	// Token: 0x0400042A RID: 1066
	private static string[] string_0;

	// Token: 0x0400042B RID: 1067
	private static bool bool_2;

	// Token: 0x0400042C RID: 1068
	private static SortedList sortedList_0;

	// Token: 0x0400042D RID: 1069
	private static bool bool_3;

	// Token: 0x0400042E RID: 1070
	private static bool bool_4;

	// Token: 0x0400042F RID: 1071
	private static int int_0;

	// Token: 0x04000430 RID: 1072
	[Class3.Attribute0(typeof(Class3.Attribute0.Class4<object>[]))]
	private static bool bool_5;

	// Token: 0x04000431 RID: 1073
	internal static Hashtable hashtable_0;

	// Token: 0x04000432 RID: 1074
	private static Class3.Delegate4 delegate4_0;

	// Token: 0x04000433 RID: 1075
	private static List<int> list_0;

	// Token: 0x04000434 RID: 1076
	private static IntPtr intptr_2;

	// Token: 0x04000435 RID: 1077
	private static int int_1;

	// Token: 0x04000436 RID: 1078
	private static bool bool_6;

	// Token: 0x04000437 RID: 1079
	private static IntPtr intptr_3;

	// Token: 0x04000438 RID: 1080
	private static Class3.Delegate8 delegate8_0;

	// Token: 0x04000439 RID: 1081
	internal static Class3.Delegate2 delegate2_0;

	// Token: 0x0400043A RID: 1082
	private static long long_0;

	// Token: 0x0400043B RID: 1083
	private static Class3.Delegate9 delegate9_0;

	// Token: 0x0400043C RID: 1084
	private static int int_2;

	// Token: 0x0400043D RID: 1085
	private static List<string> list_1;

	// Token: 0x0400043E RID: 1086
	internal static Assembly assembly_0 = typeof(Class3).Assembly;

	// Token: 0x0400043F RID: 1087
	private static object object_0;

	// Token: 0x04000440 RID: 1088
	private static object object_1;

	// Token: 0x04000441 RID: 1089
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x04000442 RID: 1090
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0;

	// Token: 0x04000443 RID: 1091
	private static Class3.Delegate5 delegate5_0;

	// Token: 0x04000444 RID: 1092
	private static int[] int_3;

	// Token: 0x04000445 RID: 1093
	private static Class3.Delegate6 delegate6_0;

	// Token: 0x04000446 RID: 1094
	private static Class3.Delegate7 delegate7_0;

	// Token: 0x04000447 RID: 1095
	private static uint[] uint_0 = new uint[]
	{
		3614090360U,
		3905402710U,
		606105819U,
		3250441966U,
		4118548399U,
		1200080426U,
		2821735955U,
		4249261313U,
		1770035416U,
		2336552879U,
		4294925233U,
		2304563134U,
		1804603682U,
		4254626195U,
		2792965006U,
		1236535329U,
		4129170786U,
		3225465664U,
		643717713U,
		3921069994U,
		3593408605U,
		38016083U,
		3634488961U,
		3889429448U,
		568446438U,
		3275163606U,
		4107603335U,
		1163531501U,
		2850285829U,
		4243563512U,
		1735328473U,
		2368359562U,
		4294588738U,
		2272392833U,
		1839030562U,
		4259657740U,
		2763975236U,
		1272893353U,
		4139469664U,
		3200236656U,
		681279174U,
		3936430074U,
		3572445317U,
		76029189U,
		3654602809U,
		3873151461U,
		530742520U,
		3299628645U,
		4096336452U,
		1126891415U,
		2878612391U,
		4237533241U,
		1700485571U,
		2399980690U,
		4293915773U,
		2240044497U,
		1873313359U,
		4264355552U,
		2734768916U,
		1309151649U,
		4149444226U,
		3174756917U,
		718787259U,
		3951481745U
	};

	// Token: 0x04000448 RID: 1096
	private static int int_4;

	// Token: 0x04000449 RID: 1097
	private static int int_5;

	// Token: 0x0400044A RID: 1098
	internal static Class3.Delegate2 delegate2_1;

	// Token: 0x0400044B RID: 1099
	private static long long_1;

	// Token: 0x020000D4 RID: 212
	// (Invoke) Token: 0x060003AD RID: 941
	private delegate void Delegate1(object o);

	// Token: 0x020000D5 RID: 213
	internal class Attribute0 : Attribute
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public Attribute0(object object_0)
		{
		}

		// Token: 0x020000D6 RID: 214
		internal class Class4<T>
		{
			// Token: 0x060003B2 RID: 946 RVA: 0x00004AB8 File Offset: 0x00002CB8
			internal static bool smethod_0()
			{
				return Class3.Attribute0.Class4<T>.object_0 == null;
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00004AC2 File Offset: 0x00002CC2
			internal static object smethod_1()
			{
				return Class3.Attribute0.Class4<T>.object_0;
			}

			// Token: 0x0400044C RID: 1100
			internal static object object_0;
		}
	}

	// Token: 0x020000D7 RID: 215
	internal class Class5
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0001E274 File Offset: 0x0001C474
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class3.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class3.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x020000D8 RID: 216
	// (Invoke) Token: 0x060003B7 RID: 951
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x020000D9 RID: 217
	// (Invoke) Token: 0x060003BB RID: 955
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x020000DA RID: 218
	internal struct Struct0
	{
		// Token: 0x0400044D RID: 1101
		internal bool bool_0;

		// Token: 0x0400044E RID: 1102
		internal byte[] byte_0;
	}

	// Token: 0x020000DB RID: 219
	internal class Class6
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public Class6(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00004ADD File Offset: 0x00002CDD
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00004AEA File Offset: 0x00002CEA
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00004AF8 File Offset: 0x00002CF8
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004B08 File Offset: 0x00002D08
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00004B15 File Offset: 0x00002D15
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x0400044F RID: 1103
		private BinaryReader binaryReader_0;
	}

	// Token: 0x020000DC RID: 220
	// (Invoke) Token: 0x060003C5 RID: 965
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x020000DD RID: 221
	// (Invoke) Token: 0x060003C9 RID: 969
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x020000DE RID: 222
	// (Invoke) Token: 0x060003CD RID: 973
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x020000DF RID: 223
	// (Invoke) Token: 0x060003D1 RID: 977
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x020000E0 RID: 224
	// (Invoke) Token: 0x060003D5 RID: 981
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x020000E1 RID: 225
	// (Invoke) Token: 0x060003D9 RID: 985
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x020000E2 RID: 226
	[Flags]
	private enum Enum0
	{

	}
}
