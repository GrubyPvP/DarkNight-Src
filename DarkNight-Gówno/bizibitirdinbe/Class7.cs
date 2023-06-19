using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x020000E3 RID: 227
internal class Class7
{
	// Token: 0x060003DC RID: 988 RVA: 0x00004B22 File Offset: 0x00002D22
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
	internal static object[] smethod_1<T>(int int_1, object[] object_1, object object_2, ref T gparam_0)
	{
		Class7.Class13 @class = null;
		object obj = Class7.object_0;
		lock (obj)
		{
			if (!Class7.bool_0)
			{
				Class7.bool_0 = true;
				Class7.smethod_4();
			}
			if (Class7.class13_0[int_1] != null)
			{
				@class = Class7.class13_0[int_1];
			}
			else
			{
				Class7.binaryReader_0.BaseStream.Position = (long)Class7.int_0[int_1];
				@class = new Class7.Class13();
				Module module = typeof(Class7).Module;
				int metadataToken = Class7.smethod_6(Class7.binaryReader_0);
				int num = Class7.smethod_6(Class7.binaryReader_0);
				int num2 = Class7.smethod_6(Class7.binaryReader_0);
				int num3 = Class7.smethod_6(Class7.binaryReader_0);
				@class.methodBase_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.methodBase_0.GetParameters();
				@class.PoCeHkwYbP = new Class7.Class9[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class7.Class9 class2 = new Class7.Class9();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.PoCeHkwYbP[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class7.Enum1 enum1_;
					if (type == typeof(string))
					{
						enum1_ = (Class7.Enum1)14;
					}
					else if (type == typeof(byte))
					{
						enum1_ = (Class7.Enum1)2;
					}
					else if (type == typeof(sbyte))
					{
						enum1_ = (Class7.Enum1)1;
					}
					else if (type == typeof(short))
					{
						enum1_ = (Class7.Enum1)3;
					}
					else if (type == typeof(ushort))
					{
						enum1_ = (Class7.Enum1)4;
					}
					else if (type == typeof(int))
					{
						enum1_ = (Class7.Enum1)5;
					}
					else if (type == typeof(uint))
					{
						enum1_ = (Class7.Enum1)6;
					}
					else if (type == typeof(long))
					{
						enum1_ = (Class7.Enum1)7;
					}
					else if (type == typeof(ulong))
					{
						enum1_ = (Class7.Enum1)8;
					}
					else if (type == typeof(float))
					{
						enum1_ = (Class7.Enum1)9;
					}
					else if (type == typeof(double))
					{
						enum1_ = (Class7.Enum1)10;
					}
					else if (type == typeof(bool))
					{
						enum1_ = (Class7.Enum1)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum1_ = (Class7.Enum1)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum1_ = (Class7.Enum1)13;
					}
					else if (type == typeof(char))
					{
						enum1_ = (Class7.Enum1)15;
					}
					else
					{
						enum1_ = (Class7.Enum1)0;
					}
					class2.enum1_0 = enum1_;
				}
				@class.list_1 = new List<Class7.Class10>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class7.smethod_6(Class7.binaryReader_0);
					Class7.Class10 class3 = new Class7.Class10();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum1_0 = (Class7.Enum1)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.list_1.Add(class3);
				}
				@class.list_2 = new List<Class7.Class11>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class7.smethod_6(Class7.binaryReader_0);
					int int_2 = Class7.smethod_6(Class7.binaryReader_0);
					Class7.Class11 class4 = new Class7.Class11();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class7.Class12 class5 = new Class7.Class12();
					class4.class12_0 = class5;
					num5 = Class7.smethod_6(Class7.binaryReader_0);
					int_2 = Class7.smethod_6(Class7.binaryReader_0);
					int num6 = Class7.smethod_6(Class7.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class7.smethod_6(Class7.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class7.smethod_6(Class7.binaryReader_0);
					}
					else
					{
						Class7.smethod_6(Class7.binaryReader_0);
					}
					@class.list_2.Add(class4);
				}
				@class.list_2.Sort(new Comparison<Class7.Class11>(Class7.Class33<T>.<>9.method_0));
				@class.list_0 = new List<Class7.Class8>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class7.Class8 class6 = new Class7.Class8();
					byte b = Class7.binaryReader_0.ReadByte();
					class6.YhMrVgOnii = (Class7.Enum3)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class7.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class7.smethod_6(Class7.binaryReader_0);
							break;
						case 2:
							obj2 = Class7.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class7.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class7.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class7.smethod_6(Class7.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class7.smethod_6(Class7.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class7.class13_0[int_1] = @class;
			}
		}
		Class7.Class16 class7 = new Class7.Class16();
		class7.class13_0 = @class;
		ParameterInfo[] parameters2 = @class.methodBase_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.methodBase_0 is MethodInfo && ((MethodInfo)@class.methodBase_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.methodBase_0.IsStatic)
		{
			class7.class18_0 = new Class7.Class18[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class18_0[n] = Class7.Class18.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class18_0 = new Class7.Class18[parameters2.Length + 1];
			if (@class.methodBase_0.DeclaringType.IsValueType)
			{
				class7.class18_0[0] = new Class7.Class29(new Class7.Class30(object_2), @class.methodBase_0.DeclaringType);
			}
			else
			{
				class7.class18_0[0] = new Class7.Class30(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class18_0[num10 + 1] = Class7.Class18.smethod_1(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class18_0[num10 + 1] = Class7.Class18.smethod_1(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class18_1 = new Class7.Class18[@class.list_1.Count];
		for (int num11 = 0; num11 < @class.list_1.Count; num11++)
		{
			Class7.Class10 class8 = @class.list_1[num11];
			switch (class8.enum1_0)
			{
			case (Class7.Enum1)0:
				class7.class18_1[num11] = null;
				break;
			case (Class7.Enum1)1:
			case (Class7.Enum1)2:
			case (Class7.Enum1)3:
			case (Class7.Enum1)4:
			case (Class7.Enum1)5:
			case (Class7.Enum1)6:
			case (Class7.Enum1)11:
			case (Class7.Enum1)15:
				class7.class18_1[num11] = new Class7.Class20(0, class8.enum1_0);
				break;
			case (Class7.Enum1)7:
			case (Class7.Enum1)8:
				class7.class18_1[num11] = new Class7.Class21(0L, class8.enum1_0);
				break;
			case (Class7.Enum1)9:
			case (Class7.Enum1)10:
				class7.class18_1[num11] = new Class7.Class23(0.0, class8.enum1_0);
				break;
			case (Class7.Enum1)12:
				class7.class18_1[num11] = new Class7.Class22(IntPtr.Zero);
				break;
			case (Class7.Enum1)13:
				class7.class18_1[num11] = new Class7.Class22(UIntPtr.Zero);
				break;
			case (Class7.Enum1)14:
				class7.class18_1[num11] = null;
				break;
			case (Class7.Enum1)16:
				class7.class18_1[num11] = new Class7.Class30(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.methodBase_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class18_2 != null)
			{
				array2[0] = class7.class18_2.vmethod_4(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class18_0[num14] != null)
					{
						if (@class.methodBase_0.IsStatic)
						{
							array2[num13] = class7.class18_0[num14].vmethod_4(type2);
						}
						else
						{
							array2[num13] = class7.class18_0[num14 + 1].vmethod_4(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.methodBase_0.IsStatic && @class.methodBase_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class18_0[0].vmethod_4(@class.methodBase_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0001ECD4 File Offset: 0x0001CED4
	internal static object[] smethod_2(int int_1, object[] object_1, object object_2)
	{
		int num = 0;
		return Class7.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00004B2A File Offset: 0x00002D2A
	internal static object[] smethod_3<T>(int int_1, object[] object_1, ref T gparam_0)
	{
		return Class7.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
	internal static void smethod_4()
	{
		if (Class7.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class7).Assembly.GetManifestResourceStream("4\u0093\u0090\u008bm\u0097\u008fa\u0088\u008e\u00889k0l\u009c\u009ec.\u009a\u0094\u00868i\u0089\u0090bgp\u008ef\u009d\u0093f\u0096o8"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class7.smethod_5(byte_);
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x0001ED58 File Offset: 0x0001CF58
	internal static void smethod_5(byte[] byte_1)
	{
		Class7.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class7.byte_0 = new byte[255];
		int num = Class7.smethod_6(Class7.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class7.binaryReader_0.ReadByte();
			Class7.byte_0[num2] = Class7.binaryReader_0.ReadByte();
		}
		num = Class7.smethod_6(Class7.binaryReader_0);
		Class7.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class7.list_0.Add(Encoding.Unicode.GetString(Class7.binaryReader_0.ReadBytes(Class7.smethod_6(Class7.binaryReader_0))));
		}
		num = Class7.smethod_6(Class7.binaryReader_0);
		Class7.class13_0 = new Class7.Class13[num];
		Class7.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class7.class13_0[k] = null;
			Class7.int_0[k] = Class7.smethod_6(Class7.binaryReader_0);
		}
		int num3 = (int)Class7.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class7.int_0[l];
			Class7.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num < 128U)
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x04000451 RID: 1105
	internal static Class7.Class13[] class13_0 = null;

	// Token: 0x04000452 RID: 1106
	internal static int[] int_0 = null;

	// Token: 0x04000453 RID: 1107
	internal static List<string> list_0;

	// Token: 0x04000454 RID: 1108
	private static BinaryReader binaryReader_0;

	// Token: 0x04000455 RID: 1109
	private static byte[] byte_0;

	// Token: 0x04000456 RID: 1110
	private static bool bool_0 = false;

	// Token: 0x04000457 RID: 1111
	private static object object_0 = new object();

	// Token: 0x020000E4 RID: 228
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct1
	{
		// Token: 0x04000458 RID: 1112
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000459 RID: 1113
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x0400045A RID: 1114
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x0400045B RID: 1115
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x0400045C RID: 1116
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x0400045D RID: 1117
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x020000E5 RID: 229
	private class Class20 : Class7.Class19
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00004B5E File Offset: 0x00002D5E
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			this.struct1_0 = ((Class7.Class20)class18_0).struct1_0;
			this.enum1_0 = ((Class7.Class20)class18_0).enum1_0;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_9(class18_0);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00004B8B File Offset: 0x00002D8B
		public Class20(bool bool_0)
		{
			this.enum4_0 = (Class7.Enum4)1;
			if (!bool_0)
			{
				this.struct1_0.int_0 = 0;
			}
			else
			{
				this.struct1_0.int_0 = 1;
			}
			this.enum1_0 = (Class7.Enum1)11;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public Class20(Class7.Class20 class20_0)
		{
			this.enum4_0 = class20_0.enum4_0;
			this.struct1_0.int_0 = class20_0.struct1_0.int_0;
			this.enum1_0 = class20_0.enum1_0;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00004BF7 File Offset: 0x00002DF7
		public override Class7.Class19 vmethod_73()
		{
			return new Class7.Class20(this);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00004BFF File Offset: 0x00002DFF
		public Class20(int int_0)
		{
			this.enum4_0 = (Class7.Enum4)1;
			this.struct1_0.int_0 = int_0;
			this.enum1_0 = (Class7.Enum1)5;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00004C22 File Offset: 0x00002E22
		public Class20(uint uint_0)
		{
			this.enum4_0 = (Class7.Enum4)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum1_0 = (Class7.Enum1)6;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004C45 File Offset: 0x00002E45
		public Class20(int int_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)1;
			this.struct1_0.int_0 = int_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00004C68 File Offset: 0x00002E68
		public Class20(uint uint_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)1;
			this.struct1_0.uint_0 = uint_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001EF1C File Offset: 0x0001D11C
		public override bool vmethod_10()
		{
			Class7.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class7.Enum1)1:
			case (Class7.Enum1)3:
			case (Class7.Enum1)5:
			case (Class7.Enum1)7:
				goto IL_4A;
			case (Class7.Enum1)2:
			case (Class7.Enum1)4:
			case (Class7.Enum1)6:
				break;
			default:
				if (@enum == (Class7.Enum1)11)
				{
					goto IL_4A;
				}
				if (@enum == (Class7.Enum1)15)
				{
					goto IL_4A;
				}
				break;
			}
			return this.struct1_0.uint_0 == 0U;
			IL_4A:
			return this.struct1_0.int_0 == 0;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00004C8B File Offset: 0x00002E8B
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001EF84 File Offset: 0x0001D184
		public override Class7.Class18 vmethod_12(Class7.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class7.Enum1)1:
				return this.vmethod_14();
			case (Class7.Enum1)2:
				return this.vmethod_15();
			case (Class7.Enum1)3:
				return this.vmethod_16();
			case (Class7.Enum1)4:
				return this.vmethod_17();
			case (Class7.Enum1)5:
				return this.vmethod_18();
			case (Class7.Enum1)6:
				return this.vmethod_19();
			case (Class7.Enum1)11:
				return this.vmethod_13();
			case (Class7.Enum1)15:
				return this.method_7();
			case (Class7.Enum1)16:
				return this.vmethod_73();
			}
			throw new Exception(((Class7.Enum5)4).ToString());
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001F030 File Offset: 0x0001D230
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class7.Enum1)1:
					return this.struct1_0.sbyte_0;
				case (Class7.Enum1)2:
					return this.struct1_0.byte_0;
				case (Class7.Enum1)3:
					return this.struct1_0.short_0;
				case (Class7.Enum1)4:
					return this.struct1_0.ushort_0;
				case (Class7.Enum1)5:
					return this.struct1_0.int_0;
				case (Class7.Enum1)6:
					return this.struct1_0.uint_0;
				case (Class7.Enum1)7:
					return (long)this.struct1_0.int_0;
				case (Class7.Enum1)8:
					return (ulong)this.struct1_0.uint_0;
				case (Class7.Enum1)11:
					return this.vmethod_11();
				case (Class7.Enum1)15:
					return (char)this.struct1_0.int_0;
				}
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct1_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct1_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct1_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct1_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct1_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct1_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct1_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct1_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct1_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct1_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct1_0.uint_0);
			}
			if (!type_0.IsEnum)
			{
				throw new Class7.Exception1();
			}
			return this.method_6(type_0);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001F368 File Offset: 0x0001D568
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct1_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct1_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct1_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct1_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct1_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct1_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct1_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct1_0.uint_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct1_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct1_0.int_0);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00004C96 File Offset: 0x00002E96
		public override Class7.Class20 vmethod_13()
		{
			return new Class7.Class20(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00004CA9 File Offset: 0x00002EA9
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public override Class7.Class20 vmethod_14()
		{
			return new Class7.Class20((int)this.struct1_0.sbyte_0, (Class7.Enum1)1);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public Class7.Class20 method_7()
		{
			return new Class7.Class20(this.struct1_0.int_0, (Class7.Enum1)15);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public override Class7.Class20 vmethod_15()
		{
			return new Class7.Class20((uint)this.struct1_0.byte_0, (Class7.Enum1)2);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00004CEB File Offset: 0x00002EEB
		public override Class7.Class20 vmethod_16()
		{
			return new Class7.Class20((int)this.struct1_0.short_0, (Class7.Enum1)3);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00004CFE File Offset: 0x00002EFE
		public override Class7.Class20 vmethod_17()
		{
			return new Class7.Class20((uint)this.struct1_0.ushort_0, (Class7.Enum1)4);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004D11 File Offset: 0x00002F11
		public override Class7.Class20 vmethod_18()
		{
			return new Class7.Class20(this.struct1_0.int_0, (Class7.Enum1)5);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00004D24 File Offset: 0x00002F24
		public override Class7.Class20 vmethod_19()
		{
			return new Class7.Class20(this.struct1_0.uint_0, (Class7.Enum1)6);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00004D37 File Offset: 0x00002F37
		public override Class7.Class21 vmethod_20()
		{
			return new Class7.Class21((long)this.struct1_0.int_0, (Class7.Enum1)7);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004D4B File Offset: 0x00002F4B
		public override Class7.Class21 vmethod_21()
		{
			return new Class7.Class21((ulong)this.struct1_0.uint_0, (Class7.Enum1)8);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004D5F File Offset: 0x00002F5F
		public override Class7.Class20 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004D67 File Offset: 0x00002F67
		public override Class7.Class20 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004D6F File Offset: 0x00002F6F
		public override Class7.Class20 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class7.Class21 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004D7F File Offset: 0x00002F7F
		public override Class7.Class20 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004D87 File Offset: 0x00002F87
		public override Class7.Class20 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00004D8F File Offset: 0x00002F8F
		public override Class7.Class20 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00004D97 File Offset: 0x00002F97
		public override Class7.Class21 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00004D9F File Offset: 0x00002F9F
		public override Class7.Class20 vmethod_30()
		{
			return new Class7.Class20((int)(checked((sbyte)this.struct1_0.int_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public override Class7.Class20 vmethod_31()
		{
			return new Class7.Class20((int)(checked((sbyte)this.struct1_0.uint_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00004DC7 File Offset: 0x00002FC7
		public override Class7.Class20 vmethod_32()
		{
			return new Class7.Class20((int)(checked((short)this.struct1_0.int_0)), (Class7.Enum1)3);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004DDB File Offset: 0x00002FDB
		public override Class7.Class20 vmethod_33()
		{
			return new Class7.Class20((int)(checked((short)this.struct1_0.uint_0)), (Class7.Enum1)3);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00004D11 File Offset: 0x00002F11
		public override Class7.Class20 vmethod_34()
		{
			return new Class7.Class20(this.struct1_0.int_0, (Class7.Enum1)5);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004DEF File Offset: 0x00002FEF
		public override Class7.Class20 vmethod_35()
		{
			return new Class7.Class20(checked((int)this.struct1_0.uint_0), (Class7.Enum1)5);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00004D37 File Offset: 0x00002F37
		public override Class7.Class21 vmethod_36()
		{
			return new Class7.Class21((long)this.struct1_0.int_0, (Class7.Enum1)7);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00004E03 File Offset: 0x00003003
		public override Class7.Class21 vmethod_37()
		{
			return new Class7.Class21((long)((ulong)this.struct1_0.uint_0), (Class7.Enum1)7);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00004E17 File Offset: 0x00003017
		public override Class7.Class20 vmethod_38()
		{
			return new Class7.Class20((int)(checked((byte)this.struct1_0.int_0)), (Class7.Enum1)2);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004E2B File Offset: 0x0000302B
		public override Class7.Class20 vmethod_39()
		{
			return new Class7.Class20((int)(checked((byte)this.struct1_0.uint_0)), (Class7.Enum1)2);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00004E3F File Offset: 0x0000303F
		public override Class7.Class20 vmethod_40()
		{
			return new Class7.Class20((int)(checked((ushort)this.struct1_0.int_0)), (Class7.Enum1)4);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00004E53 File Offset: 0x00003053
		public override Class7.Class20 vmethod_41()
		{
			return new Class7.Class20((int)(checked((ushort)this.struct1_0.uint_0)), (Class7.Enum1)4);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00004E67 File Offset: 0x00003067
		public override Class7.Class20 vmethod_42()
		{
			return new Class7.Class20(checked((uint)this.struct1_0.int_0), (Class7.Enum1)6);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00004D24 File Offset: 0x00002F24
		public override Class7.Class20 vmethod_43()
		{
			return new Class7.Class20(this.struct1_0.uint_0, (Class7.Enum1)6);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00004E7B File Offset: 0x0000307B
		public override Class7.Class21 vmethod_44()
		{
			return new Class7.Class21(checked((ulong)this.struct1_0.int_0), (Class7.Enum1)8);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00004D4B File Offset: 0x00002F4B
		public override Class7.Class21 vmethod_45()
		{
			return new Class7.Class21((ulong)this.struct1_0.uint_0, (Class7.Enum1)8);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00004E8F File Offset: 0x0000308F
		public override Class7.Class23 vmethod_46()
		{
			return new Class7.Class23((float)this.struct1_0.int_0);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00004EA2 File Offset: 0x000030A2
		public override Class7.Class23 vmethod_47()
		{
			return new Class7.Class23((double)this.struct1_0.int_0);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00004EB5 File Offset: 0x000030B5
		public override Class7.Class23 vmethod_48()
		{
			return new Class7.Class23(this.struct1_0.uint_0);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00004EC9 File Offset: 0x000030C9
		public override Class7.Class22 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_25().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_24().struct1_0.int_0);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00004EFF File Offset: 0x000030FF
		public override Class7.Class22 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_29().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_28().struct1_0.uint_0);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00004F35 File Offset: 0x00003135
		public override Class7.Class22 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_36().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00004F6B File Offset: 0x0000316B
		public override Class7.Class22 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004FA1 File Offset: 0x000031A1
		public override Class7.Class22 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_37().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_35().struct1_0.int_0);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004FD7 File Offset: 0x000031D7
		public override Class7.Class22 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_45().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_43().struct1_0.uint_0);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		public override Class7.Class18 vmethod_55()
		{
			Class7.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class7.Enum1)1:
			case (Class7.Enum1)3:
			case (Class7.Enum1)5:
				goto IL_47;
			case (Class7.Enum1)2:
			case (Class7.Enum1)4:
				break;
			default:
				if (@enum == (Class7.Enum1)11)
				{
					goto IL_47;
				}
				if (@enum == (Class7.Enum1)15)
				{
					goto IL_47;
				}
				break;
			}
			return new Class7.Class20((int)(-(int)((ulong)this.struct1_0.uint_0)));
			IL_47:
			return new Class7.Class20(-this.struct1_0.int_0);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001F548 File Offset: 0x0001D748
		public override Class7.Class18 vmethod_56(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 + ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_56(this);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		public override Class7.Class18 vmethod_57(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.int_0 + ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_57(this);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001F610 File Offset: 0x0001D810
		public override Class7.Class18 vmethod_58(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.uint_0 + ((Class7.Class20)class18_0).struct1_0.uint_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_58(this);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001F674 File Offset: 0x0001D874
		public override Class7.Class18 vmethod_59(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 - ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_8(this);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public override Class7.Class18 vmethod_60(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.int_0 - ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_9(this);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001F73C File Offset: 0x0001D93C
		public override Class7.Class18 vmethod_61(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.uint_0 - ((Class7.Class20)class18_0).struct1_0.uint_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_10(this);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		public override Class7.Class18 vmethod_62(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 * ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (class18_0.method_2())
			{
				return ((Class7.Class22)class18_0).vmethod_62(this);
			}
			throw new Class7.Exception1();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001F804 File Offset: 0x0001DA04
		public override Class7.Class18 vmethod_63(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.int_0 * ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_63(this);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001F868 File Offset: 0x0001DA68
		public override Class7.Class18 vmethod_64(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(checked(this.struct1_0.uint_0 * ((Class7.Class20)class18_0).struct1_0.uint_0));
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_64(this);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001F8CC File Offset: 0x0001DACC
		public override Class7.Class18 vmethod_65(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 / ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_11(this);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001F930 File Offset: 0x0001DB30
		public override Class7.Class18 vmethod_66(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.uint_0 / ((Class7.Class20)class18_0).struct1_0.uint_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_12(this);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001F994 File Offset: 0x0001DB94
		public override Class7.Class18 vmethod_67(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 % ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_13(this);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		public override Class7.Class18 vmethod_68(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.uint_0 % ((Class7.Class20)class18_0).struct1_0.uint_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_14(this);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public override Class7.Class18 vmethod_69(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 & ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_69(this);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
		public override Class7.Class18 vmethod_70(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 | ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_70(this);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000500D File Offset: 0x0000320D
		public override Class7.Class18 vmethod_71()
		{
			return new Class7.Class20(~this.struct1_0.int_0);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public override Class7.Class18 vmethod_72(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 ^ ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_72(this);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001FB88 File Offset: 0x0001DD88
		public override Class7.Class18 vmethod_74(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 << ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_17(this);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		public override Class7.Class18 vmethod_75(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.int_0 >> ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_16(this);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001FC50 File Offset: 0x0001DE50
		public override Class7.Class18 vmethod_76(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return new Class7.Class20(this.struct1_0.uint_0 >> ((Class7.Class20)class18_0).struct1_0.int_0);
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).method_15(this);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		public override string ToString()
		{
			Class7.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class7.Enum1)1:
			case (Class7.Enum1)3:
			case (Class7.Enum1)5:
				goto IL_3E;
			case (Class7.Enum1)2:
			case (Class7.Enum1)4:
				break;
			default:
				if (@enum == (Class7.Enum1)11)
				{
					goto IL_3E;
				}
				break;
			}
			return this.struct1_0.uint_0.ToString();
			IL_3E:
			return this.struct1_0.int_0.ToString();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00005020 File Offset: 0x00003220
		internal override Class7.Class18 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001FD10 File Offset: 0x0001DF10
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return ((Class7.Class30)class18_0).vmethod_5(this);
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).vmethod_5(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct1_0.int_0 == ((Class7.Class20)@class).struct1_0.int_0;
			}
			return ((Class7.Class22)@class).vmethod_5(this);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private static Class7.Class19 smethod_4(Class7.Class18 class18_0)
		{
			Class7.Class19 @class = class18_0 as Class7.Class19;
			if (@class == null && class18_0.vmethod_0())
			{
				@class = (class18_0.vmethod_7() as Class7.Class19);
			}
			return @class;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).hvnLfEhAw6(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct1_0.uint_0 != ((Class7.Class20)@class).struct1_0.uint_0;
			}
			return ((Class7.Class22)@class).hvnLfEhAw6(this);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001FE50 File Offset: 0x0001E050
		public override bool vmethod_77(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.int_0 >= ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_81(this);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
		public override bool vmethod_78(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.uint_0 >= ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_82(this);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0001FF10 File Offset: 0x0001E110
		public override bool vmethod_79(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.int_0 > ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_83(this);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001FF70 File Offset: 0x0001E170
		public override bool vmethod_80(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.uint_0 > ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_84(this);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001FFD0 File Offset: 0x0001E1D0
		public override bool vmethod_81(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.int_0 <= ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_77(this);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00020030 File Offset: 0x0001E230
		public override bool vmethod_82(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.uint_0 <= ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_78(this);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00020090 File Offset: 0x0001E290
		public override bool vmethod_83(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.int_0 < ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_79(this);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000200F0 File Offset: 0x0001E2F0
		public override bool vmethod_84(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				return this.struct1_0.uint_0 < ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			if (!class18_0.method_2())
			{
				throw new Class7.Exception1();
			}
			return ((Class7.Class22)class18_0).vmethod_80(this);
		}

		// Token: 0x0400045E RID: 1118
		public Class7.Struct1 struct1_0;

		// Token: 0x0400045F RID: 1119
		public Class7.Enum1 enum1_0;
	}

	// Token: 0x020000E6 RID: 230
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct2
	{
		// Token: 0x04000460 RID: 1120
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000461 RID: 1121
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000462 RID: 1122
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000463 RID: 1123
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000464 RID: 1124
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000465 RID: 1125
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x04000466 RID: 1126
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x04000467 RID: 1127
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x020000E7 RID: 231
	private class Class21 : Class7.Class19
	{
		// Token: 0x06000442 RID: 1090 RVA: 0x00005026 File Offset: 0x00003226
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			this.struct2_0 = ((Class7.Class21)class18_0).struct2_0;
			this.enum1_0 = ((Class7.Class21)class18_0).enum1_0;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_9(class18_0);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000504A File Offset: 0x0000324A
		public Class21(long long_0)
		{
			this.enum4_0 = (Class7.Enum4)2;
			this.struct2_0.long_0 = long_0;
			this.enum1_0 = (Class7.Enum1)7;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000506D File Offset: 0x0000326D
		public Class21(Class7.Class21 class21_0)
		{
			this.enum4_0 = class21_0.enum4_0;
			this.struct2_0.long_0 = class21_0.struct2_0.long_0;
			this.enum1_0 = class21_0.enum1_0;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000050A4 File Offset: 0x000032A4
		public override Class7.Class19 vmethod_73()
		{
			return new Class7.Class21(this);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000050AC File Offset: 0x000032AC
		public Class21(long long_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)2;
			this.struct2_0.long_0 = long_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000050CF File Offset: 0x000032CF
		public Class21(ulong ulong_0)
		{
			this.enum4_0 = (Class7.Enum4)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum1_0 = (Class7.Enum1)8;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000050F2 File Offset: 0x000032F2
		public Class21(ulong ulong_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)2;
			this.struct2_0.ulong_0 = ulong_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00005115 File Offset: 0x00003315
		public override bool vmethod_10()
		{
			if (this.enum1_0 == (Class7.Enum1)7)
			{
				return this.struct2_0.long_0 == 0L;
			}
			return this.struct2_0.ulong_0 == 0UL;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00004C8B File Offset: 0x00002E8B
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00020150 File Offset: 0x0001E350
		public override Class7.Class18 vmethod_12(Class7.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class7.Enum1)1:
				return this.vmethod_14();
			case (Class7.Enum1)2:
				return this.vmethod_15();
			case (Class7.Enum1)3:
				return this.vmethod_16();
			case (Class7.Enum1)4:
				return this.vmethod_17();
			case (Class7.Enum1)5:
				return this.vmethod_18();
			case (Class7.Enum1)6:
				return this.vmethod_19();
			case (Class7.Enum1)7:
				return this.vmethod_20();
			case (Class7.Enum1)8:
				return this.vmethod_21();
			case (Class7.Enum1)11:
				return this.vmethod_13();
			case (Class7.Enum1)15:
				return this.method_7();
			case (Class7.Enum1)16:
				return this.vmethod_73();
			}
			throw new Exception(((Class7.Enum5)4).ToString());
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0002020C File Offset: 0x0001E40C
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class7.Enum1)1:
					return this.struct2_0.sbyte_0;
				case (Class7.Enum1)2:
					return this.struct2_0.byte_0;
				case (Class7.Enum1)3:
					return this.struct2_0.short_0;
				case (Class7.Enum1)4:
					return this.struct2_0.ushort_0;
				case (Class7.Enum1)5:
					return this.struct2_0.int_0;
				case (Class7.Enum1)6:
					return this.struct2_0.uint_0;
				case (Class7.Enum1)7:
					return this.struct2_0.long_0;
				case (Class7.Enum1)8:
					return this.struct2_0.ulong_0;
				case (Class7.Enum1)11:
					return this.vmethod_11();
				case (Class7.Enum1)15:
					return (char)this.struct2_0.int_0;
				}
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct2_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct2_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct2_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct2_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct2_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct2_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct2_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct2_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct2_0.long_0;
			}
			if (!type_0.IsEnum)
			{
				throw new Class7.Exception1();
			}
			return this.method_6(type_0);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000204D0 File Offset: 0x0001E6D0
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct2_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct2_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct2_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct2_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct2_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct2_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct2_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct2_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct2_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct2_0.long_0);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00004C96 File Offset: 0x00002E96
		public override Class7.Class20 vmethod_13()
		{
			return new Class7.Class20(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00004CA9 File Offset: 0x00002EA9
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000514D File Offset: 0x0000334D
		public Class7.Class20 method_7()
		{
			return new Class7.Class20((int)this.struct2_0.sbyte_0, (Class7.Enum1)15);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00005161 File Offset: 0x00003361
		public override Class7.Class20 vmethod_14()
		{
			return new Class7.Class20((int)this.struct2_0.sbyte_0, (Class7.Enum1)1);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00005174 File Offset: 0x00003374
		public override Class7.Class20 vmethod_15()
		{
			return new Class7.Class20((uint)this.struct2_0.byte_0, (Class7.Enum1)2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00005187 File Offset: 0x00003387
		public override Class7.Class20 vmethod_16()
		{
			return new Class7.Class20((int)this.struct2_0.short_0, (Class7.Enum1)3);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000519A File Offset: 0x0000339A
		public override Class7.Class20 vmethod_17()
		{
			return new Class7.Class20((uint)this.struct2_0.ushort_0, (Class7.Enum1)4);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000051AD File Offset: 0x000033AD
		public override Class7.Class20 vmethod_18()
		{
			return new Class7.Class20(this.struct2_0.int_0, (Class7.Enum1)5);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000051C0 File Offset: 0x000033C0
		public override Class7.Class20 vmethod_19()
		{
			return new Class7.Class20(this.struct2_0.uint_0, (Class7.Enum1)6);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000051D3 File Offset: 0x000033D3
		public override Class7.Class21 vmethod_20()
		{
			return new Class7.Class21(this.struct2_0.long_0, (Class7.Enum1)7);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000051E6 File Offset: 0x000033E6
		public override Class7.Class21 vmethod_21()
		{
			return new Class7.Class21(this.struct2_0.ulong_0, (Class7.Enum1)8);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00004D5F File Offset: 0x00002F5F
		public override Class7.Class20 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00004D67 File Offset: 0x00002F67
		public override Class7.Class20 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00004D6F File Offset: 0x00002F6F
		public override Class7.Class20 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class7.Class21 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00004D7F File Offset: 0x00002F7F
		public override Class7.Class20 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00004D87 File Offset: 0x00002F87
		public override Class7.Class20 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00004D8F File Offset: 0x00002F8F
		public override Class7.Class20 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00004D97 File Offset: 0x00002F97
		public override Class7.Class21 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000051F9 File Offset: 0x000033F9
		public override Class7.Class20 vmethod_30()
		{
			return new Class7.Class20((int)(checked((sbyte)this.struct2_0.long_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000520D File Offset: 0x0000340D
		public override Class7.Class20 vmethod_31()
		{
			return new Class7.Class20((int)(checked((sbyte)this.struct2_0.ulong_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00005221 File Offset: 0x00003421
		public override Class7.Class20 vmethod_32()
		{
			return new Class7.Class20((int)(checked((short)this.struct2_0.long_0)), (Class7.Enum1)3);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00005235 File Offset: 0x00003435
		public override Class7.Class20 vmethod_33()
		{
			return new Class7.Class20((int)(checked((short)this.struct2_0.ulong_0)), (Class7.Enum1)3);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00005249 File Offset: 0x00003449
		public override Class7.Class20 vmethod_34()
		{
			return new Class7.Class20(checked((int)this.struct2_0.long_0), (Class7.Enum1)5);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000525D File Offset: 0x0000345D
		public override Class7.Class20 vmethod_35()
		{
			return new Class7.Class20(checked((int)this.struct2_0.ulong_0), (Class7.Enum1)5);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000051D3 File Offset: 0x000033D3
		public override Class7.Class21 vmethod_36()
		{
			return new Class7.Class21(this.struct2_0.long_0, (Class7.Enum1)7);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00005271 File Offset: 0x00003471
		public override Class7.Class21 vmethod_37()
		{
			return new Class7.Class21(checked((long)this.struct2_0.ulong_0), (Class7.Enum1)7);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00005285 File Offset: 0x00003485
		public override Class7.Class20 vmethod_38()
		{
			return new Class7.Class20((int)(checked((byte)this.struct2_0.long_0)), (Class7.Enum1)2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00005299 File Offset: 0x00003499
		public override Class7.Class20 vmethod_39()
		{
			return new Class7.Class20((int)(checked((byte)this.struct2_0.ulong_0)), (Class7.Enum1)2);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000052AD File Offset: 0x000034AD
		public override Class7.Class20 vmethod_40()
		{
			return new Class7.Class20((int)(checked((ushort)this.struct2_0.long_0)), (Class7.Enum1)4);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000052C1 File Offset: 0x000034C1
		public override Class7.Class20 vmethod_41()
		{
			return new Class7.Class20((int)(checked((ushort)this.struct2_0.ulong_0)), (Class7.Enum1)4);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000052D5 File Offset: 0x000034D5
		public override Class7.Class20 vmethod_42()
		{
			return new Class7.Class20(checked((uint)this.struct2_0.long_0), (Class7.Enum1)6);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000052E9 File Offset: 0x000034E9
		public override Class7.Class20 vmethod_43()
		{
			return new Class7.Class20(checked((uint)this.struct2_0.ulong_0), (Class7.Enum1)6);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000052FD File Offset: 0x000034FD
		public override Class7.Class21 vmethod_44()
		{
			return new Class7.Class21(checked((ulong)this.struct2_0.long_0), (Class7.Enum1)8);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000051E6 File Offset: 0x000033E6
		public override Class7.Class21 vmethod_45()
		{
			return new Class7.Class21(this.struct2_0.ulong_0, (Class7.Enum1)8);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00005311 File Offset: 0x00003511
		public override Class7.Class23 vmethod_46()
		{
			return new Class7.Class23((float)this.struct2_0.long_0);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00005324 File Offset: 0x00003524
		public override Class7.Class23 vmethod_47()
		{
			return new Class7.Class23((double)this.struct2_0.long_0);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00005337 File Offset: 0x00003537
		public override Class7.Class23 vmethod_48()
		{
			return new Class7.Class23(this.struct2_0.ulong_0);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00004EC9 File Offset: 0x000030C9
		public override Class7.Class22 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_25().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_24().struct1_0.int_0);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00004EFF File Offset: 0x000030FF
		public override Class7.Class22 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_29().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_28().struct1_0.uint_0);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00004F35 File Offset: 0x00003135
		public override Class7.Class22 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_36().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00004F6B File Offset: 0x0000316B
		public override Class7.Class22 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00004FA1 File Offset: 0x000031A1
		public override Class7.Class22 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_37().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_35().struct1_0.int_0);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000534B File Offset: 0x0000354B
		public override Class7.Class22 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)(checked((uint)this.struct2_0.ulong_0)));
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00005378 File Offset: 0x00003578
		public override Class7.Class18 vmethod_55()
		{
			return new Class7.Class21(-this.struct2_0.long_0);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00020644 File Offset: 0x0001E844
		public override Class7.Class18 vmethod_56(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 + ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00020690 File Offset: 0x0001E890
		public override Class7.Class18 vmethod_57(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.long_0 + ((Class7.Class21)class18_0).struct2_0.long_0));
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000206DC File Offset: 0x0001E8DC
		public override Class7.Class18 vmethod_58(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.ulong_0 + ((Class7.Class21)class18_0).struct2_0.ulong_0));
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00020728 File Offset: 0x0001E928
		public override Class7.Class18 vmethod_59(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 - ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00020774 File Offset: 0x0001E974
		public override Class7.Class18 vmethod_60(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.long_0 - ((Class7.Class21)class18_0).struct2_0.long_0));
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000207C0 File Offset: 0x0001E9C0
		public override Class7.Class18 vmethod_61(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.ulong_0 - ((Class7.Class21)class18_0).struct2_0.ulong_0));
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0002080C File Offset: 0x0001EA0C
		public override Class7.Class18 vmethod_62(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 * ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00020858 File Offset: 0x0001EA58
		public override Class7.Class18 vmethod_63(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.long_0 * ((Class7.Class21)class18_0).struct2_0.long_0));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public override Class7.Class18 vmethod_64(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(checked(this.struct2_0.ulong_0 * ((Class7.Class21)class18_0).struct2_0.ulong_0));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000208F0 File Offset: 0x0001EAF0
		public override Class7.Class18 vmethod_65(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 / ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002093C File Offset: 0x0001EB3C
		public override Class7.Class18 vmethod_66(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.ulong_0 / ((Class7.Class21)class18_0).struct2_0.ulong_0);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00020988 File Offset: 0x0001EB88
		public override Class7.Class18 vmethod_67(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 % ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000209D4 File Offset: 0x0001EBD4
		public override Class7.Class18 vmethod_68(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.ulong_0 % ((Class7.Class21)class18_0).struct2_0.ulong_0);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00020A20 File Offset: 0x0001EC20
		public override Class7.Class18 vmethod_69(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 & ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00020A6C File Offset: 0x0001EC6C
		public override Class7.Class18 vmethod_70(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 | ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000538B File Offset: 0x0000358B
		public override Class7.Class18 vmethod_71()
		{
			return new Class7.Class21(~this.struct2_0.long_0);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public override Class7.Class18 vmethod_72(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 ^ ((Class7.Class21)class18_0).struct2_0.long_0);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00020B04 File Offset: 0x0001ED04
		public override Class7.Class18 vmethod_74(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_3())
			{
				return new Class7.Class21(this.struct2_0.long_0 << ((Class7.Class21)class18_0).struct2_0.int_0);
			}
			if (!class18_0.vmethod_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 << ((Class7.Class19)class18_0).vmethod_18().struct1_0.int_0);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00020B88 File Offset: 0x0001ED88
		public override Class7.Class18 vmethod_75(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_3())
			{
				return new Class7.Class21(this.struct2_0.long_0 >> ((Class7.Class21)class18_0).struct2_0.int_0);
			}
			if (!class18_0.vmethod_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.long_0 >> ((Class7.Class19)class18_0).vmethod_18().struct1_0.int_0);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00020C0C File Offset: 0x0001EE0C
		public override Class7.Class18 vmethod_76(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_3())
			{
				return new Class7.Class21(this.struct2_0.ulong_0 >> ((Class7.Class21)class18_0).struct2_0.int_0);
			}
			if (!class18_0.vmethod_3())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class21(this.struct2_0.ulong_0 >> ((Class7.Class19)class18_0).vmethod_18().struct1_0.int_0);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000539E File Offset: 0x0000359E
		public override string ToString()
		{
			if (this.enum1_0 == (Class7.Enum1)7)
			{
				return this.struct2_0.long_0.ToString();
			}
			return this.struct2_0.ulong_0.ToString();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00005020 File Offset: 0x00003220
		internal override Class7.Class18 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00020C90 File Offset: 0x0001EE90
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return ((Class7.Class30)class18_0).vmethod_5(this);
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).vmethod_5(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			return @class.method_3() && this.struct2_0.long_0 == ((Class7.Class21)@class).struct2_0.long_0;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private static Class7.Class19 smethod_4(Class7.Class18 class18_0)
		{
			Class7.Class19 @class = class18_0 as Class7.Class19;
			if (@class == null && class18_0.vmethod_0())
			{
				@class = (class18_0.vmethod_7() as Class7.Class19);
			}
			return @class;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).hvnLfEhAw6(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			return @class.method_3() && this.struct2_0.ulong_0 != ((Class7.Class21)@class).struct2_0.ulong_0;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000053CA File Offset: 0x000035CA
		public override bool vmethod_77(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.long_0 >= ((Class7.Class21)class18_0).struct2_0.long_0;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000540A File Offset: 0x0000360A
		public override bool vmethod_78(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.ulong_0 >= ((Class7.Class21)class18_0).struct2_0.ulong_0;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000544A File Offset: 0x0000364A
		public override bool vmethod_79(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.long_0 > ((Class7.Class21)class18_0).struct2_0.long_0;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00005487 File Offset: 0x00003687
		public override bool vmethod_80(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.ulong_0 > ((Class7.Class21)class18_0).struct2_0.ulong_0;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000054C4 File Offset: 0x000036C4
		public override bool vmethod_81(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.long_0 <= ((Class7.Class21)class18_0).struct2_0.long_0;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00005504 File Offset: 0x00003704
		public override bool vmethod_82(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.ulong_0 <= ((Class7.Class21)class18_0).struct2_0.ulong_0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00005544 File Offset: 0x00003744
		public override bool vmethod_83(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.long_0 < ((Class7.Class21)class18_0).struct2_0.long_0;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00005581 File Offset: 0x00003781
		public override bool vmethod_84(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_3())
			{
				throw new Class7.Exception1();
			}
			return this.struct2_0.ulong_0 < ((Class7.Class21)class18_0).struct2_0.ulong_0;
		}

		// Token: 0x04000468 RID: 1128
		public Class7.Struct2 struct2_0;

		// Token: 0x04000469 RID: 1129
		public Class7.Enum1 enum1_0;
	}

	// Token: 0x020000E8 RID: 232
	private class Class22 : Class7.Class19
	{
		// Token: 0x0600049E RID: 1182 RVA: 0x000055BE File Offset: 0x000037BE
		internal void method_6(Class7.Class18 class18_0)
		{
			if (!class18_0.method_2())
			{
				this.vmethod_9(class18_0);
				return;
			}
			this.class19_0 = ((Class7.Class22)class18_0).class19_0;
			this.enum1_0 = ((Class7.Class22)class18_0).enum1_0;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00020D58 File Offset: 0x0001EF58
		internal unsafe override void vmethod_9(Class7.Class18 class18_0)
		{
			if (class18_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class7.Class21)this.class19_0).struct2_0.long_0);
					IntPtr intPtr = new IntPtr(((Class7.Class21)((Class7.Class22)class18_0).class19_0).struct2_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class7.Class20)this.class19_0).struct1_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class7.Class20)((Class7.Class22)class18_0).class19_0).struct1_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class18_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class7.Class21)this.class19_0).struct2_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class7.Class20)this.class19_0).struct1_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (!(type == typeof(char)))
				{
					throw new Class7.Exception1();
				}
				*(short*)((void*)value3) = (short)((char)obj);
				return;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_9(class18_0);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002106C File Offset: 0x0001F26C
		public Class22(IntPtr intptr_0)
		{
			this.enum4_0 = (Class7.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(intptr_0.ToInt64());
				this.enum1_0 = (Class7.Enum1)12;
				return;
			}
			this.class19_0 = new Class7.Class20(intptr_0.ToInt32());
			this.enum1_0 = (Class7.Enum1)12;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000210C4 File Offset: 0x0001F2C4
		public Class22(UIntPtr uintptr_0)
		{
			this.enum4_0 = (Class7.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(uintptr_0.ToUInt64());
				this.enum1_0 = (Class7.Enum1)12;
				return;
			}
			this.class19_0 = new Class7.Class20(uintptr_0.ToUInt32());
			this.enum1_0 = (Class7.Enum1)12;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002111C File Offset: 0x0001F31C
		public Class22()
		{
			this.enum4_0 = (Class7.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(0L);
				this.enum1_0 = (Class7.Enum1)12;
				return;
			}
			this.class19_0 = new Class7.Class20(0);
			this.enum1_0 = (Class7.Enum1)12;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000055F2 File Offset: 0x000037F2
		public override Class7.Class19 vmethod_73()
		{
			return new Class7.Class22
			{
				class19_0 = this.class19_0.vmethod_73(),
				enum1_0 = this.enum1_0
			};
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00021170 File Offset: 0x0001F370
		public Class22(long long_0)
		{
			this.enum4_0 = (Class7.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(long_0);
				this.enum1_0 = (Class7.Enum1)12;
				return;
			}
			this.class19_0 = new Class7.Class20((int)long_0);
			this.enum1_0 = (Class7.Enum1)12;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00005616 File Offset: 0x00003816
		public Class22(long long_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(long_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.class19_0 = new Class7.Class20((int)long_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000211C0 File Offset: 0x0001F3C0
		public Class22(ulong ulong_0)
		{
			this.enum4_0 = (Class7.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(ulong_0);
				this.enum1_0 = (Class7.Enum1)13;
				return;
			}
			this.class19_0 = new Class7.Class20((uint)ulong_0);
			this.enum1_0 = (Class7.Enum1)13;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00005656 File Offset: 0x00003856
		public Class22(ulong ulong_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.class19_0 = new Class7.Class21(ulong_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.class19_0 = new Class7.Class20((uint)ulong_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00005696 File Offset: 0x00003896
		public override bool vmethod_10()
		{
			return this.class19_0.vmethod_10();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004C8B File Offset: 0x00002E8B
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00004CA9 File Offset: 0x00002EA9
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00021210 File Offset: 0x0001F410
		public override Class7.Class18 vmethod_12(Class7.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class7.Enum1)1:
				return this.vmethod_14();
			case (Class7.Enum1)2:
				return this.vmethod_15();
			case (Class7.Enum1)3:
				return this.vmethod_16();
			case (Class7.Enum1)4:
				return this.vmethod_17();
			case (Class7.Enum1)5:
				return this.vmethod_18();
			case (Class7.Enum1)6:
				return this.vmethod_19();
			case (Class7.Enum1)7:
				return this.vmethod_20();
			case (Class7.Enum1)8:
				return this.vmethod_21();
			case (Class7.Enum1)11:
				return this.vmethod_13();
			case (Class7.Enum1)12:
				return this;
			case (Class7.Enum1)13:
				return this;
			case (Class7.Enum1)16:
				return this.vmethod_73();
			}
			throw new Exception(((Class7.Enum5)4).ToString());
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000056A3 File Offset: 0x000038A3
		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class7.Class21)this.class19_0).struct2_0.long_0);
			}
			return new IntPtr(((Class7.Class20)this.class19_0).struct1_0.int_0);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000212C8 File Offset: 0x0001F4C8
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class7.Class21)this.class19_0).struct2_0.long_0);
				}
				return new IntPtr(((Class7.Class20)this.class19_0).struct1_0.int_0);
			}
			else if (type_0 == typeof(UIntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class7.Class21)this.class19_0).struct2_0.ulong_0);
				}
				return new UIntPtr(((Class7.Class20)this.class19_0).struct1_0.uint_0);
			}
			else
			{
				if (!(type_0 == null) && !(type_0 == typeof(object)))
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					if (this.enum1_0 == (Class7.Enum1)12)
					{
						return new IntPtr(((Class7.Class21)this.class19_0).struct2_0.long_0);
					}
					return new UIntPtr(((Class7.Class21)this.class19_0).struct2_0.ulong_0);
				}
				else
				{
					if (this.enum1_0 == (Class7.Enum1)12)
					{
						return new IntPtr(((Class7.Class21)this.class19_0).struct2_0.int_0);
					}
					return new UIntPtr(((Class7.Class20)this.class19_0).struct1_0.uint_0);
				}
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000056E2 File Offset: 0x000038E2
		public override Class7.Class20 vmethod_13()
		{
			return this.class19_0.vmethod_13();
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000056EF File Offset: 0x000038EF
		public override Class7.Class20 vmethod_14()
		{
			return this.class19_0.vmethod_14();
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000056FC File Offset: 0x000038FC
		public override Class7.Class20 vmethod_15()
		{
			return this.class19_0.vmethod_15();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00005709 File Offset: 0x00003909
		public override Class7.Class20 vmethod_16()
		{
			return this.class19_0.vmethod_16();
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00005716 File Offset: 0x00003916
		public override Class7.Class20 vmethod_17()
		{
			return this.class19_0.vmethod_17();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00005723 File Offset: 0x00003923
		public override Class7.Class20 vmethod_18()
		{
			return this.class19_0.vmethod_18();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00005730 File Offset: 0x00003930
		public override Class7.Class20 vmethod_19()
		{
			return this.class19_0.vmethod_19();
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000573D File Offset: 0x0000393D
		public override Class7.Class21 vmethod_20()
		{
			return this.class19_0.vmethod_20();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000574A File Offset: 0x0000394A
		public override Class7.Class21 vmethod_21()
		{
			return this.class19_0.vmethod_21();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00004D5F File Offset: 0x00002F5F
		public override Class7.Class20 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004D67 File Offset: 0x00002F67
		public override Class7.Class20 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004D6F File Offset: 0x00002F6F
		public override Class7.Class20 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class7.Class21 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004D7F File Offset: 0x00002F7F
		public override Class7.Class20 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004D87 File Offset: 0x00002F87
		public override Class7.Class20 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004D8F File Offset: 0x00002F8F
		public override Class7.Class20 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004D97 File Offset: 0x00002F97
		public override Class7.Class21 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00005757 File Offset: 0x00003957
		public override Class7.Class20 vmethod_30()
		{
			return this.class19_0.vmethod_30();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00005764 File Offset: 0x00003964
		public override Class7.Class20 vmethod_31()
		{
			return this.class19_0.vmethod_31();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00005771 File Offset: 0x00003971
		public override Class7.Class20 vmethod_32()
		{
			return this.class19_0.vmethod_32();
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000577E File Offset: 0x0000397E
		public override Class7.Class20 vmethod_33()
		{
			return this.class19_0.vmethod_33();
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000578B File Offset: 0x0000398B
		public override Class7.Class20 vmethod_34()
		{
			return this.class19_0.vmethod_34();
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00005798 File Offset: 0x00003998
		public override Class7.Class20 vmethod_35()
		{
			return this.class19_0.vmethod_35();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000057A5 File Offset: 0x000039A5
		public override Class7.Class21 vmethod_36()
		{
			return this.class19_0.vmethod_36();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000057B2 File Offset: 0x000039B2
		public override Class7.Class21 vmethod_37()
		{
			return this.class19_0.vmethod_37();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000057BF File Offset: 0x000039BF
		public override Class7.Class20 vmethod_38()
		{
			return this.class19_0.vmethod_38();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000057CC File Offset: 0x000039CC
		public override Class7.Class20 vmethod_39()
		{
			return this.class19_0.vmethod_39();
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000057D9 File Offset: 0x000039D9
		public override Class7.Class20 vmethod_40()
		{
			return this.class19_0.vmethod_40();
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000057E6 File Offset: 0x000039E6
		public override Class7.Class20 vmethod_41()
		{
			return this.class19_0.vmethod_41();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000057F3 File Offset: 0x000039F3
		public override Class7.Class20 vmethod_42()
		{
			return this.class19_0.vmethod_42();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00005800 File Offset: 0x00003A00
		public override Class7.Class20 vmethod_43()
		{
			return this.class19_0.vmethod_43();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000580D File Offset: 0x00003A0D
		public override Class7.Class21 vmethod_44()
		{
			return this.class19_0.vmethod_44();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000581A File Offset: 0x00003A1A
		public override Class7.Class21 vmethod_45()
		{
			return this.class19_0.vmethod_45();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00005827 File Offset: 0x00003A27
		public override Class7.Class23 vmethod_46()
		{
			return this.class19_0.vmethod_46();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00005834 File Offset: 0x00003A34
		public override Class7.Class23 vmethod_47()
		{
			return this.class19_0.vmethod_47();
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00005841 File Offset: 0x00003A41
		public override Class7.Class23 vmethod_48()
		{
			return this.class19_0.vmethod_48();
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004EC9 File Offset: 0x000030C9
		public override Class7.Class22 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_25().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_24().struct1_0.int_0);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004EFF File Offset: 0x000030FF
		public override Class7.Class22 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_29().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_28().struct1_0.uint_0);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00004F35 File Offset: 0x00003135
		public override Class7.Class22 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_36().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004F6B File Offset: 0x0000316B
		public override Class7.Class22 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004FA1 File Offset: 0x000031A1
		public override Class7.Class22 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_37().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_35().struct1_0.int_0);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00004FD7 File Offset: 0x000031D7
		public override Class7.Class22 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_45().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_43().struct1_0.uint_0);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00021460 File Offset: 0x0001F660
		public override Class7.Class18 vmethod_55()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(-((Class7.Class21)this.class19_0).struct2_0.long_0);
			}
			return new Class7.Class22((long)(-(long)((Class7.Class20)this.class19_0).struct1_0.int_0));
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000214B0 File Offset: 0x0001F6B0
		public override Class7.Class18 vmethod_56(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 + ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 + ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 + ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 + ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000215A0 File Offset: 0x0001F7A0
		public override Class7.Class18 vmethod_57(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 + ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 + ((Class7.Class20)class18_0).struct1_0.int_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 + ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 + ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0)));
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00021690 File Offset: 0x0001F890
		public override Class7.Class18 vmethod_58(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 + unchecked((ulong)((Class7.Class20)class18_0).struct1_0.uint_0)));
				}
				return new Class7.Class22((long)((ulong)(checked(this.vmethod_18().struct1_0.uint_0 + ((Class7.Class20)class18_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 + ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0));
				}
				return new Class7.Class22((ulong)(checked(this.vmethod_18().struct1_0.uint_0 + ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0)));
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0002177C File Offset: 0x0001F97C
		public override Class7.Class18 vmethod_59(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 - ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 - ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 - ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 - ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0002186C File Offset: 0x0001FA6C
		public Class7.Class18 method_8(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0 - this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class20)class18_0).struct1_0.int_0 - this.vmethod_18().struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0 - this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0 - this.vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002195C File Offset: 0x0001FB5C
		public override Class7.Class18 vmethod_60(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 - ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 - ((Class7.Class20)class18_0).struct1_0.int_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 - ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 - ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0)));
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00021A4C File Offset: 0x0001FC4C
		public Class7.Class18 method_9(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0 - this.vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(((Class7.Class20)class18_0).struct1_0.int_0 - this.vmethod_18().struct1_0.int_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0 - this.vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0 - this.vmethod_18().struct1_0.int_0)));
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00021B3C File Offset: 0x0001FD3C
		public override Class7.Class18 vmethod_61(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 - unchecked((ulong)((Class7.Class20)class18_0).struct1_0.uint_0)));
				}
				return new Class7.Class22((long)((ulong)(checked(this.vmethod_18().struct1_0.uint_0 - ((Class7.Class20)class18_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 - ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0));
				}
				return new Class7.Class22((ulong)(checked(this.vmethod_18().struct1_0.uint_0 - ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0)));
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00021C28 File Offset: 0x0001FE28
		public Class7.Class18 method_10(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(unchecked((ulong)((Class7.Class20)class18_0).struct1_0.uint_0) - this.vmethod_20().struct2_0.ulong_0));
				}
				return new Class7.Class22((long)((ulong)(checked(((Class7.Class20)class18_0).struct1_0.uint_0 - this.vmethod_18().struct1_0.uint_0))));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0 - this.vmethod_20().struct2_0.ulong_0));
				}
				return new Class7.Class22((ulong)(checked(((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0 - this.vmethod_18().struct1_0.uint_0)));
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00021D14 File Offset: 0x0001FF14
		public override Class7.Class18 vmethod_62(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 * ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 * ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 * ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 * ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00021E04 File Offset: 0x00020004
		public override Class7.Class18 vmethod_63(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 * ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 * ((Class7.Class20)class18_0).struct1_0.int_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.long_0 * ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0));
				}
				return new Class7.Class22((long)(checked(this.vmethod_18().struct1_0.int_0 * ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0)));
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00021EF4 File Offset: 0x000200F4
		public override Class7.Class18 vmethod_64(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 * unchecked((ulong)((Class7.Class20)class18_0).struct1_0.uint_0)));
				}
				return new Class7.Class22((long)((ulong)(checked(this.vmethod_18().struct1_0.uint_0 * ((Class7.Class20)class18_0).struct1_0.uint_0))));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(checked(this.vmethod_20().struct2_0.ulong_0 * ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0));
				}
				return new Class7.Class22((ulong)(checked(this.vmethod_18().struct1_0.uint_0 * ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0)));
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00021FE0 File Offset: 0x000201E0
		public override Class7.Class18 vmethod_65(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 / ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 / ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 / ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 / ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000220D0 File Offset: 0x000202D0
		public Class7.Class18 method_11(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0 / this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class20)class18_0).struct1_0.int_0 / this.vmethod_18().struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0 / this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0 / this.vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000221C0 File Offset: 0x000203C0
		public override Class7.Class18 vmethod_66(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 / ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((long)((ulong)(this.vmethod_18().struct1_0.uint_0 / ((Class7.Class20)class18_0).struct1_0.uint_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 / ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((ulong)(this.vmethod_18().struct1_0.uint_0 / ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0));
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000222B0 File Offset: 0x000204B0
		public Class7.Class18 method_12(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0 / this.vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((long)((ulong)(((Class7.Class20)class18_0).struct1_0.uint_0 / this.vmethod_18().struct1_0.uint_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0 / this.vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((ulong)(((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0 / this.vmethod_18().struct1_0.uint_0));
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000223A0 File Offset: 0x000205A0
		public override Class7.Class18 vmethod_67(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 % ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 % ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 % ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 % ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00022490 File Offset: 0x00020690
		public Class7.Class18 method_13(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0 % this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class20)class18_0).struct1_0.int_0 % this.vmethod_18().struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0 % this.vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0 % this.vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00022580 File Offset: 0x00020780
		public override Class7.Class18 vmethod_68(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 % ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((long)((ulong)(this.vmethod_18().struct1_0.uint_0 % ((Class7.Class20)class18_0).struct1_0.uint_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 % ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((ulong)(this.vmethod_18().struct1_0.uint_0 % ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0));
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00022670 File Offset: 0x00020870
		public Class7.Class18 method_14(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0 % this.vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((long)((ulong)(((Class7.Class20)class18_0).struct1_0.uint_0 % this.vmethod_18().struct1_0.uint_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0 % this.vmethod_20().struct2_0.ulong_0);
				}
				return new Class7.Class22((ulong)(((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0 % this.vmethod_18().struct1_0.uint_0));
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00022760 File Offset: 0x00020960
		public override Class7.Class18 vmethod_69(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 & ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 & ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 & ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 & ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00022850 File Offset: 0x00020A50
		public override Class7.Class18 vmethod_70(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 | ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 | ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 | ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 | ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000584E File Offset: 0x00003A4E
		public override Class7.Class18 vmethod_71()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(~this.vmethod_20().struct2_0.long_0);
			}
			return new Class7.Class22((long)(~(long)this.vmethod_18().struct1_0.int_0));
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00022940 File Offset: 0x00020B40
		public override Class7.Class18 vmethod_72(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 ^ ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 ^ ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 ^ ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 ^ ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00022A30 File Offset: 0x00020C30
		public override Class7.Class18 vmethod_74(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 << ((Class7.Class20)class18_0).struct1_0.int_0);
				}
				return new Class7.Class22((long)((long)this.vmethod_18().struct1_0.int_0 << ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 << ((Class7.Class22)class18_0).vmethod_20().struct2_0.int_0);
				}
				return new Class7.Class22((long)((long)this.vmethod_18().struct1_0.int_0 << ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00022B28 File Offset: 0x00020D28
		public override Class7.Class18 vmethod_75(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 >> ((Class7.Class20)class18_0).struct1_0.int_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 >> ((Class7.Class20)class18_0).struct1_0.int_0));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.long_0 >> ((Class7.Class22)class18_0).vmethod_20().struct2_0.int_0);
				}
				return new Class7.Class22((long)(this.vmethod_18().struct1_0.int_0 >> ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0));
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00022C20 File Offset: 0x00020E20
		public override Class7.Class18 vmethod_76(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 >> ((Class7.Class20)class18_0).struct1_0.int_0);
				}
				return new Class7.Class22((long)((ulong)(this.vmethod_18().struct1_0.uint_0 >> ((Class7.Class20)class18_0).struct1_0.int_0)));
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class7.Class22(this.vmethod_20().struct2_0.ulong_0 >> ((Class7.Class22)class18_0).vmethod_20().struct2_0.int_0);
				}
				return new Class7.Class22((long)((ulong)(this.vmethod_18().struct1_0.uint_0 >> ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0)));
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00005886 File Offset: 0x00003A86
		public Class7.Class18 method_15(Class7.Class20 class20_0)
		{
			return new Class7.Class22((long)((ulong)(class20_0.struct1_0.uint_0 >> this.vmethod_18().struct1_0.int_0)));
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000058AD File Offset: 0x00003AAD
		public Class7.Class18 method_16(Class7.Class20 class20_0)
		{
			return new Class7.Class22((long)(class20_0.struct1_0.int_0 >> this.vmethod_20().struct2_0.int_0));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000058D4 File Offset: 0x00003AD4
		public Class7.Class18 method_17(Class7.Class20 class20_0)
		{
			return new Class7.Class22((long)((long)class20_0.struct1_0.int_0 << this.vmethod_20().struct2_0.int_0));
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000058FB File Offset: 0x00003AFB
		public override string ToString()
		{
			return this.class19_0.ToString();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00005020 File Offset: 0x00003220
		internal override Class7.Class18 vmethod_7()
		{
			return this;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00022D18 File Offset: 0x00020F18
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).vmethod_5(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (!@class.method_1())
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct2_0.long_0 == ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0;
				}
				return false;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 == ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 == ((Class7.Class20)class18_0).struct1_0.int_0;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00022DF0 File Offset: 0x00020FF0
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).hvnLfEhAw6(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 != ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 != ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			else
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct2_0.ulong_0 != ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return false;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00022ED0 File Offset: 0x000210D0
		public override bool vmethod_77(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 >= ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 >= ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 >= ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 >= ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0;
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00022FBC File Offset: 0x000211BC
		public override bool vmethod_78(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_1())
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 >= ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 >= ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 >= ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 >= ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000230A8 File Offset: 0x000212A8
		public override bool vmethod_79(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 > ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 > ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 > ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 > ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00023188 File Offset: 0x00021388
		public override bool vmethod_80(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 > ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 > ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 > ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 > ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00023268 File Offset: 0x00021468
		public override bool vmethod_81(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 <= ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 <= ((Class7.Class20)class18_0).struct1_0.int_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 <= ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 <= ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00023354 File Offset: 0x00021554
		public override bool vmethod_82(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 <= ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 <= ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 <= ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 <= ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00023440 File Offset: 0x00021640
		public override bool vmethod_83(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_1())
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 < ((Class7.Class22)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 < ((Class7.Class22)class18_0).vmethod_18().struct1_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.long_0 < ((Class7.Class20)class18_0).vmethod_20().struct2_0.long_0;
				}
				return this.vmethod_18().struct1_0.int_0 < ((Class7.Class20)class18_0).struct1_0.int_0;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00023520 File Offset: 0x00021720
		public override bool vmethod_84(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (class18_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 < ((Class7.Class20)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 < ((Class7.Class20)class18_0).struct1_0.uint_0;
			}
			else
			{
				if (!class18_0.method_2())
				{
					throw new Class7.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct2_0.ulong_0 < ((Class7.Class22)class18_0).vmethod_20().struct2_0.ulong_0;
				}
				return this.vmethod_18().struct1_0.uint_0 < ((Class7.Class22)class18_0).vmethod_18().struct1_0.uint_0;
			}
		}

		// Token: 0x0400046A RID: 1130
		public Class7.Class19 class19_0;

		// Token: 0x0400046B RID: 1131
		public Class7.Enum1 enum1_0;
	}

	// Token: 0x020000E9 RID: 233
	private abstract class Class19 : Class7.Class18
	{
		// Token: 0x06000506 RID: 1286
		public abstract bool vmethod_10();

		// Token: 0x06000507 RID: 1287
		public abstract bool vmethod_11();

		// Token: 0x06000508 RID: 1288
		public abstract Class7.Class18 vmethod_12(Class7.Enum1 enum1_0);

		// Token: 0x06000509 RID: 1289
		public abstract Class7.Class20 vmethod_13();

		// Token: 0x0600050A RID: 1290
		public abstract Class7.Class20 vmethod_14();

		// Token: 0x0600050B RID: 1291
		public abstract Class7.Class20 vmethod_15();

		// Token: 0x0600050C RID: 1292
		public abstract Class7.Class20 vmethod_16();

		// Token: 0x0600050D RID: 1293
		public abstract Class7.Class20 vmethod_17();

		// Token: 0x0600050E RID: 1294
		public abstract Class7.Class20 vmethod_18();

		// Token: 0x0600050F RID: 1295
		public abstract Class7.Class20 vmethod_19();

		// Token: 0x06000510 RID: 1296
		public abstract Class7.Class21 vmethod_20();

		// Token: 0x06000511 RID: 1297
		public abstract Class7.Class21 vmethod_21();

		// Token: 0x06000512 RID: 1298
		public abstract Class7.Class20 vmethod_22();

		// Token: 0x06000513 RID: 1299
		public abstract Class7.Class20 vmethod_23();

		// Token: 0x06000514 RID: 1300
		public abstract Class7.Class20 vmethod_24();

		// Token: 0x06000515 RID: 1301
		public abstract Class7.Class21 vmethod_25();

		// Token: 0x06000516 RID: 1302
		public abstract Class7.Class20 vmethod_26();

		// Token: 0x06000517 RID: 1303
		public abstract Class7.Class20 vmethod_27();

		// Token: 0x06000518 RID: 1304
		public abstract Class7.Class20 vmethod_28();

		// Token: 0x06000519 RID: 1305
		public abstract Class7.Class21 vmethod_29();

		// Token: 0x0600051A RID: 1306
		public abstract Class7.Class20 vmethod_30();

		// Token: 0x0600051B RID: 1307
		public abstract Class7.Class20 vmethod_31();

		// Token: 0x0600051C RID: 1308
		public abstract Class7.Class20 vmethod_32();

		// Token: 0x0600051D RID: 1309
		public abstract Class7.Class20 vmethod_33();

		// Token: 0x0600051E RID: 1310
		public abstract Class7.Class20 vmethod_34();

		// Token: 0x0600051F RID: 1311
		public abstract Class7.Class20 vmethod_35();

		// Token: 0x06000520 RID: 1312
		public abstract Class7.Class21 vmethod_36();

		// Token: 0x06000521 RID: 1313
		public abstract Class7.Class21 vmethod_37();

		// Token: 0x06000522 RID: 1314
		public abstract Class7.Class20 vmethod_38();

		// Token: 0x06000523 RID: 1315
		public abstract Class7.Class20 vmethod_39();

		// Token: 0x06000524 RID: 1316
		public abstract Class7.Class20 vmethod_40();

		// Token: 0x06000525 RID: 1317
		public abstract Class7.Class20 vmethod_41();

		// Token: 0x06000526 RID: 1318
		public abstract Class7.Class20 vmethod_42();

		// Token: 0x06000527 RID: 1319
		public abstract Class7.Class20 vmethod_43();

		// Token: 0x06000528 RID: 1320
		public abstract Class7.Class21 vmethod_44();

		// Token: 0x06000529 RID: 1321
		public abstract Class7.Class21 vmethod_45();

		// Token: 0x0600052A RID: 1322
		public abstract Class7.Class23 vmethod_46();

		// Token: 0x0600052B RID: 1323
		public abstract Class7.Class23 vmethod_47();

		// Token: 0x0600052C RID: 1324
		public abstract Class7.Class23 vmethod_48();

		// Token: 0x0600052D RID: 1325
		public abstract Class7.Class22 vmethod_49();

		// Token: 0x0600052E RID: 1326
		public abstract Class7.Class22 vmethod_50();

		// Token: 0x0600052F RID: 1327
		public abstract Class7.Class22 vmethod_51();

		// Token: 0x06000530 RID: 1328
		public abstract Class7.Class22 vmethod_52();

		// Token: 0x06000531 RID: 1329
		public abstract Class7.Class22 vmethod_53();

		// Token: 0x06000532 RID: 1330
		public abstract Class7.Class22 vmethod_54();

		// Token: 0x06000533 RID: 1331
		public abstract Class7.Class18 vmethod_55();

		// Token: 0x06000534 RID: 1332
		public abstract Class7.Class18 vmethod_56(Class7.Class18 class18_0);

		// Token: 0x06000535 RID: 1333
		public abstract Class7.Class18 vmethod_57(Class7.Class18 class18_0);

		// Token: 0x06000536 RID: 1334
		public abstract Class7.Class18 vmethod_58(Class7.Class18 class18_0);

		// Token: 0x06000537 RID: 1335
		public abstract Class7.Class18 vmethod_59(Class7.Class18 class18_0);

		// Token: 0x06000538 RID: 1336
		public abstract Class7.Class18 vmethod_60(Class7.Class18 class18_0);

		// Token: 0x06000539 RID: 1337
		public abstract Class7.Class18 vmethod_61(Class7.Class18 class18_0);

		// Token: 0x0600053A RID: 1338
		public abstract Class7.Class18 vmethod_62(Class7.Class18 class18_0);

		// Token: 0x0600053B RID: 1339
		public abstract Class7.Class18 vmethod_63(Class7.Class18 class18_0);

		// Token: 0x0600053C RID: 1340
		public abstract Class7.Class18 vmethod_64(Class7.Class18 class18_0);

		// Token: 0x0600053D RID: 1341
		public abstract Class7.Class18 vmethod_65(Class7.Class18 class18_0);

		// Token: 0x0600053E RID: 1342
		public abstract Class7.Class18 vmethod_66(Class7.Class18 class18_0);

		// Token: 0x0600053F RID: 1343
		public abstract Class7.Class18 vmethod_67(Class7.Class18 class18_0);

		// Token: 0x06000540 RID: 1344
		public abstract Class7.Class18 vmethod_68(Class7.Class18 class18_0);

		// Token: 0x06000541 RID: 1345
		public abstract Class7.Class18 vmethod_69(Class7.Class18 class18_0);

		// Token: 0x06000542 RID: 1346
		public abstract Class7.Class18 vmethod_70(Class7.Class18 class18_0);

		// Token: 0x06000543 RID: 1347
		public abstract Class7.Class18 vmethod_71();

		// Token: 0x06000544 RID: 1348
		public abstract Class7.Class18 vmethod_72(Class7.Class18 class18_0);

		// Token: 0x06000545 RID: 1349
		public abstract Class7.Class19 vmethod_73();

		// Token: 0x06000546 RID: 1350
		public abstract Class7.Class18 vmethod_74(Class7.Class18 class18_0);

		// Token: 0x06000547 RID: 1351
		public abstract Class7.Class18 vmethod_75(Class7.Class18 class18_0);

		// Token: 0x06000548 RID: 1352
		public abstract Class7.Class18 vmethod_76(Class7.Class18 class18_0);

		// Token: 0x06000549 RID: 1353
		public abstract bool vmethod_77(Class7.Class18 class18_0);

		// Token: 0x0600054A RID: 1354
		public abstract bool vmethod_78(Class7.Class18 class18_0);

		// Token: 0x0600054B RID: 1355
		public abstract bool vmethod_79(Class7.Class18 class18_0);

		// Token: 0x0600054C RID: 1356
		public abstract bool vmethod_80(Class7.Class18 class18_0);

		// Token: 0x0600054D RID: 1357
		public abstract bool vmethod_81(Class7.Class18 class18_0);

		// Token: 0x0600054E RID: 1358
		public abstract bool vmethod_82(Class7.Class18 class18_0);

		// Token: 0x0600054F RID: 1359
		public abstract bool vmethod_83(Class7.Class18 class18_0);

		// Token: 0x06000550 RID: 1360
		public abstract bool vmethod_84(Class7.Class18 class18_0);

		// Token: 0x06000551 RID: 1361 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x020000EA RID: 234
	private class Class23 : Class7.Class19
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x00005911 File Offset: 0x00003B11
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			this.double_0 = ((Class7.Class23)class18_0).double_0;
			this.enum1_0 = ((Class7.Class23)class18_0).enum1_0;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_9(class18_0);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00005935 File Offset: 0x00003B35
		public Class23(double double_1)
		{
			this.enum4_0 = (Class7.Enum4)5;
			this.enum1_0 = (Class7.Enum1)10;
			this.double_0 = double_1;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00005954 File Offset: 0x00003B54
		public Class23(Class7.Class23 class23_0)
		{
			this.enum4_0 = class23_0.enum4_0;
			this.enum1_0 = class23_0.enum1_0;
			this.double_0 = class23_0.double_0;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00005981 File Offset: 0x00003B81
		public override Class7.Class19 vmethod_73()
		{
			return new Class7.Class23(this);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00005989 File Offset: 0x00003B89
		public Class23(double double_1, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)5;
			this.double_0 = double_1;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000059A7 File Offset: 0x00003BA7
		public Class23(float float_0)
		{
			this.enum4_0 = (Class7.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = (Class7.Enum1)9;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000059C7 File Offset: 0x00003BC7
		public Class23(float float_0, Class7.Enum1 enum1_1)
		{
			this.enum4_0 = (Class7.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000059E6 File Offset: 0x00003BE6
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004C8B File Offset: 0x00002E8B
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000059F9 File Offset: 0x00003BF9
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00023600 File Offset: 0x00021800
		public override Class7.Class18 vmethod_12(Class7.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class7.Enum1)1:
				return this.vmethod_14();
			case (Class7.Enum1)2:
				return this.vmethod_15();
			case (Class7.Enum1)3:
				return this.vmethod_16();
			case (Class7.Enum1)4:
				return this.vmethod_17();
			case (Class7.Enum1)5:
				return this.vmethod_18();
			case (Class7.Enum1)6:
				return this.vmethod_19();
			case (Class7.Enum1)7:
				return this.vmethod_20();
			case (Class7.Enum1)8:
				return this.vmethod_21();
			case (Class7.Enum1)9:
				return this.vmethod_46();
			case (Class7.Enum1)10:
				return this.vmethod_47();
			case (Class7.Enum1)11:
				return this.vmethod_13();
			default:
				throw new Exception(((Class7.Enum5)4).ToString());
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000236A4 File Offset: 0x000218A4
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum1_0 == (Class7.Enum1)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00005A06 File Offset: 0x00003C06
		public override Class7.Class20 vmethod_13()
		{
			return new Class7.Class20(this.vmethod_10() ? 1 : 0);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004CA9 File Offset: 0x00002EA9
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00005A19 File Offset: 0x00003C19
		public override Class7.Class20 vmethod_14()
		{
			return new Class7.Class20((int)((sbyte)this.double_0), (Class7.Enum1)1);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00005A28 File Offset: 0x00003C28
		public override Class7.Class20 vmethod_15()
		{
			return new Class7.Class20((uint)((byte)this.double_0), (Class7.Enum1)2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00005A37 File Offset: 0x00003C37
		public override Class7.Class20 vmethod_16()
		{
			return new Class7.Class20((int)((short)this.double_0), (Class7.Enum1)3);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00005A46 File Offset: 0x00003C46
		public override Class7.Class20 vmethod_17()
		{
			return new Class7.Class20((uint)((ushort)this.double_0), (Class7.Enum1)4);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00005A55 File Offset: 0x00003C55
		public override Class7.Class20 vmethod_18()
		{
			return new Class7.Class20((int)this.double_0, (Class7.Enum1)5);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00005A64 File Offset: 0x00003C64
		public override Class7.Class20 vmethod_19()
		{
			return new Class7.Class20((uint)this.double_0, (Class7.Enum1)6);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00005A73 File Offset: 0x00003C73
		public override Class7.Class21 vmethod_20()
		{
			return new Class7.Class21((long)this.double_0, (Class7.Enum1)7);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00005A82 File Offset: 0x00003C82
		public override Class7.Class21 vmethod_21()
		{
			return new Class7.Class21((ulong)this.double_0, (Class7.Enum1)8);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004D5F File Offset: 0x00002F5F
		public override Class7.Class20 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004D67 File Offset: 0x00002F67
		public override Class7.Class20 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004D6F File Offset: 0x00002F6F
		public override Class7.Class20 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class7.Class21 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00004D7F File Offset: 0x00002F7F
		public override Class7.Class20 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00004D87 File Offset: 0x00002F87
		public override Class7.Class20 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004D8F File Offset: 0x00002F8F
		public override Class7.Class20 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00004D97 File Offset: 0x00002F97
		public override Class7.Class21 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00005A91 File Offset: 0x00003C91
		public override Class7.Class20 vmethod_30()
		{
			return new Class7.Class20((int)(checked((sbyte)this.double_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00005A91 File Offset: 0x00003C91
		public override Class7.Class20 vmethod_31()
		{
			return new Class7.Class20((int)(checked((sbyte)this.double_0)), (Class7.Enum1)1);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00005AA0 File Offset: 0x00003CA0
		public override Class7.Class20 vmethod_32()
		{
			return new Class7.Class20((int)(checked((short)this.double_0)), (Class7.Enum1)3);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00005AA0 File Offset: 0x00003CA0
		public override Class7.Class20 vmethod_33()
		{
			return new Class7.Class20((int)(checked((short)this.double_0)), (Class7.Enum1)3);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00005AAF File Offset: 0x00003CAF
		public override Class7.Class20 vmethod_34()
		{
			return new Class7.Class20(checked((int)this.double_0), (Class7.Enum1)5);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00005AAF File Offset: 0x00003CAF
		public override Class7.Class20 vmethod_35()
		{
			return new Class7.Class20(checked((int)this.double_0), (Class7.Enum1)5);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00005ABE File Offset: 0x00003CBE
		public override Class7.Class21 vmethod_36()
		{
			return new Class7.Class21(checked((long)this.double_0), (Class7.Enum1)7);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00005ABE File Offset: 0x00003CBE
		public override Class7.Class21 vmethod_37()
		{
			return new Class7.Class21(checked((long)this.double_0), (Class7.Enum1)7);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00005ACD File Offset: 0x00003CCD
		public override Class7.Class20 vmethod_38()
		{
			return new Class7.Class20((int)(checked((byte)this.double_0)), (Class7.Enum1)2);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00005ACD File Offset: 0x00003CCD
		public override Class7.Class20 vmethod_39()
		{
			return new Class7.Class20((int)(checked((byte)this.double_0)), (Class7.Enum1)2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00005ADC File Offset: 0x00003CDC
		public override Class7.Class20 vmethod_40()
		{
			return new Class7.Class20((int)(checked((ushort)this.double_0)), (Class7.Enum1)4);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00005ADC File Offset: 0x00003CDC
		public override Class7.Class20 vmethod_41()
		{
			return new Class7.Class20((int)(checked((ushort)this.double_0)), (Class7.Enum1)4);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00005AEB File Offset: 0x00003CEB
		public override Class7.Class20 vmethod_42()
		{
			return new Class7.Class20(checked((uint)this.double_0), (Class7.Enum1)6);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00005AEB File Offset: 0x00003CEB
		public override Class7.Class20 vmethod_43()
		{
			return new Class7.Class20(checked((uint)this.double_0), (Class7.Enum1)6);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00005AFA File Offset: 0x00003CFA
		public override Class7.Class21 vmethod_44()
		{
			return new Class7.Class21(checked((ulong)this.double_0), (Class7.Enum1)8);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00005AFA File Offset: 0x00003CFA
		public override Class7.Class21 vmethod_45()
		{
			return new Class7.Class21(checked((ulong)this.double_0), (Class7.Enum1)8);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00005B09 File Offset: 0x00003D09
		public override Class7.Class23 vmethod_46()
		{
			return new Class7.Class23((float)this.double_0, (Class7.Enum1)9);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00005B19 File Offset: 0x00003D19
		public override Class7.Class23 vmethod_47()
		{
			return new Class7.Class23(this.double_0, (Class7.Enum1)10);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00005B29 File Offset: 0x00003D29
		public override Class7.Class23 vmethod_48()
		{
			return new Class7.Class23(this.double_0);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00004EC9 File Offset: 0x000030C9
		public override Class7.Class22 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_25().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_24().struct1_0.int_0);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00004EFF File Offset: 0x000030FF
		public override Class7.Class22 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_29().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_28().struct1_0.uint_0);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00004F35 File Offset: 0x00003135
		public override Class7.Class22 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_36().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_34().struct1_0.int_0);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004F6B File Offset: 0x0000316B
		public override Class7.Class22 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_44().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_42().struct1_0.uint_0);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00004FA1 File Offset: 0x000031A1
		public override Class7.Class22 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_37().struct2_0.long_0);
			}
			return new Class7.Class22((long)this.vmethod_35().struct1_0.int_0);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00004FD7 File Offset: 0x000031D7
		public override Class7.Class22 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class7.Class22(this.vmethod_45().struct2_0.ulong_0);
			}
			return new Class7.Class22((ulong)this.vmethod_43().struct1_0.uint_0);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00005B37 File Offset: 0x00003D37
		public override Class7.Class18 vmethod_55()
		{
			if (this.enum1_0 == (Class7.Enum1)9)
			{
				return new Class7.Class23((float)(-(float)this.double_0));
			}
			return new Class7.Class23(-this.double_0);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00005B5E File Offset: 0x00003D5E
		public override Class7.Class18 vmethod_56(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 + ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00005B5E File Offset: 0x00003D5E
		public override Class7.Class18 vmethod_57(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 + ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00005B5E File Offset: 0x00003D5E
		public override Class7.Class18 vmethod_58(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 + ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00005B95 File Offset: 0x00003D95
		public override Class7.Class18 vmethod_59(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 - ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00005B95 File Offset: 0x00003D95
		public override Class7.Class18 vmethod_60(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 - ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00005B95 File Offset: 0x00003D95
		public override Class7.Class18 vmethod_61(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 - ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00005BCC File Offset: 0x00003DCC
		public override Class7.Class18 vmethod_62(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4() || !class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 * ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00005C0B File Offset: 0x00003E0B
		public override Class7.Class18 vmethod_63(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 * ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00005C0B File Offset: 0x00003E0B
		public override Class7.Class18 vmethod_64(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 * ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00005C42 File Offset: 0x00003E42
		public override Class7.Class18 vmethod_65(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 / ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00005C42 File Offset: 0x00003E42
		public override Class7.Class18 vmethod_66(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 / ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00005C79 File Offset: 0x00003E79
		public override Class7.Class18 vmethod_67(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 % ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00005C79 File Offset: 0x00003E79
		public override Class7.Class18 vmethod_68(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return new Class7.Class23(this.double_0 % ((Class7.Class23)class18_0).double_0);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_69(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_70(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_71()
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_72(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_74(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_75(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00005CB0 File Offset: 0x00003EB0
		public override Class7.Class18 vmethod_76(Class7.Class18 class18_0)
		{
			throw new Class7.Exception1();
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00005020 File Offset: 0x00003220
		internal override Class7.Class18 vmethod_7()
		{
			return this;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00023744 File Offset: 0x00021944
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).vmethod_5(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			return @class.method_4() && this.double_0 == ((Class7.Class23)@class).double_0;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00023798 File Offset: 0x00021998
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (class18_0.method_0())
			{
				return false;
			}
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).hvnLfEhAw6(this);
			}
			Class7.Class18 @class = class18_0.vmethod_7();
			return @class.method_4() && this.double_0 != ((Class7.Class23)@class).double_0;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public override bool vmethod_77(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 >= ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public override bool vmethod_78(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 >= ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00005CED File Offset: 0x00003EED
		public override bool vmethod_79(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 > ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00005CED File Offset: 0x00003EED
		public override bool vmethod_80(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 > ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00005D20 File Offset: 0x00003F20
		public override bool vmethod_81(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 <= ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00005D20 File Offset: 0x00003F20
		public override bool vmethod_82(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 <= ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005D56 File Offset: 0x00003F56
		public override bool vmethod_83(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 < ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00005D56 File Offset: 0x00003F56
		public override bool vmethod_84(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				class18_0 = class18_0.vmethod_7();
			}
			if (!class18_0.method_4())
			{
				throw new Class7.Exception1();
			}
			return this.double_0 < ((Class7.Class23)class18_0).double_0;
		}

		// Token: 0x0400046C RID: 1132
		public double double_0;

		// Token: 0x0400046D RID: 1133
		public Class7.Enum1 enum1_0;
	}

	// Token: 0x020000EB RID: 235
	internal enum Enum1 : byte
	{

	}

	// Token: 0x020000EC RID: 236
	internal enum Enum2 : byte
	{

	}

	// Token: 0x020000ED RID: 237
	private class Exception0 : Exception
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x00005D89 File Offset: 0x00003F89
		public Exception0(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x020000EE RID: 238
	private class Exception1 : Exception
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x00005D93 File Offset: 0x00003F93
		public Exception1()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00005D89 File Offset: 0x00003F89
		public Exception1(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x020000EF RID: 239
	internal class Class8
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x000237F0 File Offset: 0x000219F0
		public override string ToString()
		{
			object obj = this.YhMrVgOnii;
			if (this.object_0 == null)
			{
				return obj.ToString();
			}
			return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
		}

		// Token: 0x04000470 RID: 1136
		internal Class7.Enum3 YhMrVgOnii = (Class7.Enum3)126;

		// Token: 0x04000471 RID: 1137
		internal object object_0;
	}

	// Token: 0x020000F0 RID: 240
	internal abstract class Class24 : Class7.Class18
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x00005908 File Offset: 0x00003B08
		public Class24()
		{
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060005B2 RID: 1458
		internal abstract IntPtr vmethod_10();

		// Token: 0x060005B3 RID: 1459
		internal abstract void vmethod_11(Class7.Class18 class18_0);

		// Token: 0x060005B4 RID: 1460 RVA: 0x00005023 File Offset: 0x00003223
		internal override bool vmethod_1()
		{
			return true;
		}
	}

	// Token: 0x020000F1 RID: 241
	internal class Class25 : Class7.Class24
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x00005DAD File Offset: 0x00003FAD
		public Class25(int int_0, Class7.Class16 class16_1)
		{
			this.class16_0 = class16_1;
			this.AhCrajaHic = int_0;
			this.enum4_0 = (Class7.Enum4)7;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002383C File Offset: 0x00021A3C
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			if (class18_0 is Class7.Class25)
			{
				this.class16_0 = ((Class7.Class25)class18_0).class16_0;
				this.AhCrajaHic = ((Class7.Class25)class18_0).AhCrajaHic;
				return;
			}
			Class7.Class10 @class = this.class16_0.class13_0.list_1[this.AhCrajaHic];
			if (class18_0 is Class7.Class24 && (@class.enum1_0 & (Class7.Enum1)226) > (Class7.Enum1)0)
			{
				Class7.Class18 class18_ = (class18_0 as Class7.Class24).vmethod_7();
				this.vmethod_11(class18_);
				return;
			}
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00005DCB File Offset: 0x00003FCB
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00005DD4 File Offset: 0x00003FD4
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00005DDB File Offset: 0x00003FDB
		internal override void vmethod_11(Class7.Class18 class18_0)
		{
			this.class16_0.class18_1[this.AhCrajaHic] = class18_0;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00005DF0 File Offset: 0x00003FF0
		internal override object vmethod_4(Type type_0)
		{
			if (this.class16_0.class18_1[this.AhCrajaHic] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00005E14 File Offset: 0x00004014
		internal override Class7.Class18 vmethod_7()
		{
			if (this.class16_0.class18_1[this.AhCrajaHic] != null)
			{
				return this.class16_0.class18_1[this.AhCrajaHic].vmethod_7();
			}
			return new Class7.Class30(null);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00005E48 File Offset: 0x00004048
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00005E55 File Offset: 0x00004055
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			return class18_0.vmethod_0() && class18_0 is Class7.Class25 && ((Class7.Class25)class18_0).AhCrajaHic == this.AhCrajaHic;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00005E81 File Offset: 0x00004081
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			return !class18_0.vmethod_0() || !(class18_0 is Class7.Class25) || ((Class7.Class25)class18_0).AhCrajaHic != this.AhCrajaHic;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00005EAD File Offset: 0x000040AD
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000472 RID: 1138
		private Class7.Class16 class16_0;

		// Token: 0x04000473 RID: 1139
		internal int AhCrajaHic;
	}

	// Token: 0x020000F2 RID: 242
	internal class Class26 : Class7.Class24
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x00005EBA File Offset: 0x000040BA
		public Class26(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class7.Enum4)7;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00005DD4 File Offset: 0x00003FD4
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00005ED8 File Offset: 0x000040D8
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			if (!(class18_0 is Class7.Class26))
			{
				this.vmethod_11(class18_0);
				return;
			}
			this.array_0 = ((Class7.Class26)class18_0).array_0;
			this.int_0 = ((Class7.Class26)class18_0).int_0;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00005DCB File Offset: 0x00003FCB
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00005F0C File Offset: 0x0000410C
		internal override void vmethod_11(Class7.Class18 class18_0)
		{
			this.array_0.SetValue(class18_0.vmethod_4(null), this.int_0);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00005F26 File Offset: 0x00004126
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00005F34 File Offset: 0x00004134
		internal override Class7.Class18 vmethod_7()
		{
			return Class7.Class18.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00005E48 File Offset: 0x00004048
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000238C8 File Offset: 0x00021AC8
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (!class18_0.vmethod_0())
			{
				return false;
			}
			if (class18_0 is Class7.Class26)
			{
				Class7.Class26 @class = (Class7.Class26)class18_0;
				return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
			}
			return false;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00023914 File Offset: 0x00021B14
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (!class18_0.vmethod_0())
			{
				return true;
			}
			if (class18_0 is Class7.Class26)
			{
				Class7.Class26 @class = (Class7.Class26)class18_0;
				return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
			}
			return true;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00005EAD File Offset: 0x000040AD
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000474 RID: 1140
		private Array array_0;

		// Token: 0x04000475 RID: 1141
		internal int int_0;
	}

	// Token: 0x020000F3 RID: 243
	internal class Class27 : Class7.Class24
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x00005F5C File Offset: 0x0000415C
		public Class27(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum4_0 = (Class7.Enum4)7;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00005DD4 File Offset: 0x00003FD4
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00023960 File Offset: 0x00021B60
		internal override void vmethod_11(Class7.Class18 class18_0)
		{
			if (this.object_0 != null && this.object_0 is Class7.Class18)
			{
				this.fieldInfo_0.SetValue(((Class7.Class18)this.object_0).vmethod_4(null), class18_0.vmethod_4(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class18_0.vmethod_4(null));
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00005F7A File Offset: 0x0000417A
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			if (!(class18_0 is Class7.Class27))
			{
				this.vmethod_11(class18_0);
				return;
			}
			this.fieldInfo_0 = ((Class7.Class27)class18_0).fieldInfo_0;
			this.object_0 = ((Class7.Class27)class18_0).object_0;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00005DCB File Offset: 0x00003FCB
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00005F26 File Offset: 0x00004126
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000239C0 File Offset: 0x00021BC0
		internal override Class7.Class18 vmethod_7()
		{
			if (this.object_0 != null && this.object_0 is Class7.Class18)
			{
				return Class7.Class18.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class7.Class18)this.object_0).vmethod_4(null)));
			}
			return Class7.Class18.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00005E48 File Offset: 0x00004048
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00023A30 File Offset: 0x00021C30
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (!class18_0.vmethod_0())
			{
				return false;
			}
			if (class18_0 is Class7.Class27)
			{
				Class7.Class27 @class = (Class7.Class27)class18_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00023A84 File Offset: 0x00021C84
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (!class18_0.vmethod_0())
			{
				return true;
			}
			if (class18_0 is Class7.Class27)
			{
				Class7.Class27 @class = (Class7.Class27)class18_0;
				return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
			}
			return true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00005EAD File Offset: 0x000040AD
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000476 RID: 1142
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000477 RID: 1143
		internal object object_0;
	}

	// Token: 0x020000F4 RID: 244
	internal class Class28 : Class7.Class24
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00005FAE File Offset: 0x000041AE
		public Class28(int int_1, Class7.Class16 class16_1)
		{
			this.class16_0 = class16_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class7.Enum4)7;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00005DD4 File Offset: 0x00003FD4
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00005FCC File Offset: 0x000041CC
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			if (class18_0 is Class7.Class28)
			{
				this.class16_0 = ((Class7.Class28)class18_0).class16_0;
				this.int_0 = ((Class7.Class28)class18_0).int_0;
				return;
			}
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00005DCB File Offset: 0x00003FCB
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_11(class18_0);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00006000 File Offset: 0x00004200
		internal override void vmethod_11(Class7.Class18 class18_0)
		{
			this.class16_0.class18_0[this.int_0] = class18_0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00006015 File Offset: 0x00004215
		internal override object vmethod_4(Type type_0)
		{
			if (this.class16_0.class18_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00006039 File Offset: 0x00004239
		internal override Class7.Class18 vmethod_7()
		{
			if (this.class16_0.class18_0[this.int_0] == null)
			{
				return new Class7.Class30(null);
			}
			return this.class16_0.class18_0[this.int_0].vmethod_7();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00005E48 File Offset: 0x00004048
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000606D File Offset: 0x0000426D
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			return class18_0.vmethod_0() && class18_0 is Class7.Class28 && ((Class7.Class28)class18_0).int_0 == this.int_0;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00006096 File Offset: 0x00004296
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			return !class18_0.vmethod_0() || !(class18_0 is Class7.Class28) || ((Class7.Class28)class18_0).int_0 != this.int_0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00005EAD File Offset: 0x000040AD
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000478 RID: 1144
		private Class7.Class16 class16_0;

		// Token: 0x04000479 RID: 1145
		internal int int_0;
	}

	// Token: 0x020000F5 RID: 245
	internal class Class29 : Class7.Class24
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x000060C2 File Offset: 0x000042C2
		public Class29(Class7.Class18 class18_1, Type type_1)
		{
			this.class18_0 = class18_1;
			this.type_0 = type_1;
			this.enum4_0 = (Class7.Enum4)7;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00005DD4 File Offset: 0x00003FD4
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000060E0 File Offset: 0x000042E0
		internal override void vmethod_9(Class7.Class18 class18_1)
		{
			if (!(class18_1 is Class7.Class29))
			{
				this.class18_0.vmethod_9(class18_1);
				return;
			}
			this.type_0 = ((Class7.Class29)class18_1).type_0;
			this.class18_0 = ((Class7.Class29)class18_1).class18_0;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00005DCB File Offset: 0x00003FCB
		internal override void vmethod_2(Class7.Class18 class18_1)
		{
			this.vmethod_11(class18_1);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00006119 File Offset: 0x00004319
		internal override void vmethod_11(Class7.Class18 class18_1)
		{
			this.class18_0 = class18_1;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00023AD8 File Offset: 0x00021CD8
		internal override object vmethod_4(Type type_1)
		{
			if (this.class18_0 == null)
			{
				return new Class7.Class30(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return this.class18_0.vmethod_4(type_1);
			}
			return this.class18_0.vmethod_4(this.type_0);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00006122 File Offset: 0x00004322
		internal override Class7.Class18 vmethod_7()
		{
			if (this.class18_0 == null)
			{
				return new Class7.Class30(null);
			}
			return this.class18_0.vmethod_7();
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00005E48 File Offset: 0x00004048
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00023B30 File Offset: 0x00021D30
		internal override bool vmethod_5(Class7.Class18 class18_1)
		{
			if (!class18_1.vmethod_0())
			{
				return false;
			}
			if (!(class18_1 is Class7.Class29))
			{
				return false;
			}
			Class7.Class29 @class = (Class7.Class29)class18_1;
			if (@class.type_0 != this.type_0)
			{
				return false;
			}
			if (this.class18_0 == null)
			{
				return @class.class18_0 == null;
			}
			return this.class18_0.vmethod_5(@class.class18_0);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00023B98 File Offset: 0x00021D98
		internal override bool hvnLfEhAw6(Class7.Class18 class18_1)
		{
			if (!class18_1.vmethod_0())
			{
				return true;
			}
			if (!(class18_1 is Class7.Class29))
			{
				return true;
			}
			Class7.Class29 @class = (Class7.Class29)class18_1;
			if (@class.type_0 != this.type_0)
			{
				return true;
			}
			if (this.class18_0 != null)
			{
				return this.class18_0.hvnLfEhAw6(@class.class18_0);
			}
			return @class.class18_0 != null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00005EAD File Offset: 0x000040AD
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x0400047A RID: 1146
		private Class7.Class18 class18_0;

		// Token: 0x0400047B RID: 1147
		private Type type_0;
	}

	// Token: 0x020000F6 RID: 246
	internal class Class9
	{
		// Token: 0x0400047C RID: 1148
		public int int_0;

		// Token: 0x0400047D RID: 1149
		public bool bool_0;

		// Token: 0x0400047E RID: 1150
		public Class7.Enum1 enum1_0;
	}

	// Token: 0x020000F7 RID: 247
	internal class Class10
	{
		// Token: 0x0400047F RID: 1151
		public int int_0;

		// Token: 0x04000480 RID: 1152
		public Class7.Enum1 enum1_0;

		// Token: 0x04000481 RID: 1153
		public bool bool_0;

		// Token: 0x04000482 RID: 1154
		public Type type_0 = typeof(object);
	}

	// Token: 0x020000F8 RID: 248
	internal class Class11
	{
		// Token: 0x04000483 RID: 1155
		public int int_0;

		// Token: 0x04000484 RID: 1156
		public int int_1;

		// Token: 0x04000485 RID: 1157
		public Class7.Class12 class12_0;
	}

	// Token: 0x020000F9 RID: 249
	internal class Class12
	{
		// Token: 0x04000486 RID: 1158
		public int int_0;

		// Token: 0x04000487 RID: 1159
		public int int_1;

		// Token: 0x04000488 RID: 1160
		public byte byte_0;

		// Token: 0x04000489 RID: 1161
		public Type type_0;

		// Token: 0x0400048A RID: 1162
		public int int_2;

		// Token: 0x0400048B RID: 1163
		public int int_3;
	}

	// Token: 0x020000FA RID: 250
	internal class Class13
	{
		// Token: 0x0400048C RID: 1164
		internal MethodBase methodBase_0;

		// Token: 0x0400048D RID: 1165
		internal List<Class7.Class8> list_0;

		// Token: 0x0400048E RID: 1166
		internal Class7.Class9[] PoCeHkwYbP;

		// Token: 0x0400048F RID: 1167
		internal List<Class7.Class10> list_1;

		// Token: 0x04000490 RID: 1168
		internal List<Class7.Class11> list_2;
	}

	// Token: 0x020000FB RID: 251
	private class Class14
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00006157 File Offset: 0x00004357
		public Class14(FieldInfo fieldInfo_1, int int_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.int_0 = int_1;
		}

		// Token: 0x04000491 RID: 1169
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000492 RID: 1170
		internal int int_0;
	}

	// Token: 0x020000FC RID: 252
	private class Class15
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x0000616E File Offset: 0x0000436E
		public Class15(MethodBase methodBase_1, List<Class7.Class14> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00006190 File Offset: 0x00004390
		public Class15(MethodBase methodBase_1, Class7.Class14[] class14_0)
		{
			this.list_0.AddRange(class14_0);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00023C00 File Offset: 0x00021E00
		public override bool Equals(object obj)
		{
			Class7.Class15 @class = obj as Class7.Class15;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].fieldInfo_0 != @class.list_0[i].fieldInfo_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00023CC0 File Offset: 0x00021EC0
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class7.Class14 @class in this.list_0)
			{
				int num2 = @class.fieldInfo_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00023D40 File Offset: 0x00021F40
		public Class7.Class14 method_0(int int_0)
		{
			foreach (Class7.Class14 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00023DA8 File Offset: 0x00021FA8
		public bool method_1(int int_0)
		{
			using (List<Class7.Class14>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000493 RID: 1171
		private List<Class7.Class14> list_0 = new List<Class7.Class14>();

		// Token: 0x04000494 RID: 1172
		private MethodBase methodBase_0;
	}

	// Token: 0x020000FD RID: 253
	// (Invoke) Token: 0x060005F9 RID: 1529
	private delegate object Delegate10(object target, object[] paramters);

	// Token: 0x020000FE RID: 254
	// (Invoke) Token: 0x060005FD RID: 1533
	private delegate object Delegate11(object target);

	// Token: 0x020000FF RID: 255
	// (Invoke) Token: 0x06000601 RID: 1537
	private delegate void Delegate12(IntPtr a, byte b, int c);

	// Token: 0x02000100 RID: 256
	// (Invoke) Token: 0x06000605 RID: 1541
	private delegate void Delegate13(IntPtr s, IntPtr t, uint c);

	// Token: 0x02000101 RID: 257
	internal class Class16
	{
		// Token: 0x06000608 RID: 1544 RVA: 0x00023E08 File Offset: 0x00022008
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00023E20 File Offset: 0x00022020
		internal void method_1()
		{
			this.class32_0.method_1();
			this.class18_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00023EB4 File Offset: 0x000220B4
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class7.Class8 @class = this.class13_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class32_0.method_1();
						int int_ = this.int_1;
						Class7.Class11 class2 = this.method_5(int_, innerException);
						List<Class7.Class11> list = this.method_6(int_, false);
						List<Class7.Class11> list2 = new List<Class7.Class11>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class7.Class11>(Class7.Class16.Class17.<>9.method_0));
						Class7.Class11 class3 = null;
						foreach (Class7.Class11 class4 in list2)
						{
							if (class4.class12_0.int_3 != 0)
							{
								this.class32_0.method_2(new Class7.Class30(innerException));
								this.int_1 = class4.class12_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 == null)
						{
							throw innerException;
						}
						this.int_2 = class3.class12_0.int_0;
						this.method_3(int_, class3.class12_0.int_0);
						if (this.int_2 >= 0)
						{
							this.class32_0.method_2(new Class7.Class30(innerException));
							this.int_1 = this.int_2;
							this.int_0 = this.int_1;
							this.int_2 = -1;
							this.method_0();
						}
						return;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class32_0.method_1();
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00024170 File Offset: 0x00022370
		internal void method_3(int int_3, int int_4)
		{
			if (this.class13_0.list_2 != null)
			{
				foreach (Class7.Class11 @class in this.class13_0.list_2)
				{
					if ((@class.class12_0.int_3 == 4 || @class.class12_0.int_3 == 2) && @class.class12_0.int_0 >= int_3 && @class.class12_0.int_1 <= int_4)
					{
						this.int_1 = @class.class12_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00024240 File Offset: 0x00022440
		internal void method_4(int int_3, int int_4)
		{
			if (this.class13_0.list_2 != null)
			{
				foreach (Class7.Class11 @class in this.class13_0.list_2)
				{
					if (@class.class12_0.int_3 == 2 && @class.class12_0.int_0 >= int_3 && @class.class12_0.int_1 <= int_4)
					{
						this.int_1 = @class.class12_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00024300 File Offset: 0x00022500
		internal Class7.Class11 method_5(int int_3, Exception exception_1)
		{
			Class7.Class11 @class = null;
			if (this.class13_0.list_2 != null)
			{
				foreach (Class7.Class11 class2 in this.class13_0.list_2)
				{
					if (class2.class12_0 != null && class2.class12_0.int_3 == 0 && (class2.class12_0.type_0 == exception_1.GetType() || (class2.class12_0.type_0 != null && (class2.class12_0.type_0.FullName == exception_1.GetType().FullName || class2.class12_0.type_0.FullName == typeof(object).FullName || class2.class12_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class12_0.int_0 < @class.class12_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00024478 File Offset: 0x00022678
		internal List<Class7.Class11> method_6(int int_3, bool bool_4)
		{
			if (this.class13_0.list_2 == null)
			{
				return null;
			}
			List<Class7.Class11> list = new List<Class7.Class11>();
			foreach (Class7.Class11 @class in this.class13_0.list_2)
			{
				if ((@class.class12_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00024514 File Offset: 0x00022714
		private unsafe void method_7(Class7.Class8 class8_0)
		{
			switch (class8_0.YhMrVgOnii)
			{
			case (Class7.Enum3)0:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_34());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)1:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_57(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)2:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_79(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)3:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (!Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_79(class3))
				{
					this.class32_0.method_2(new Class7.Class20(0));
					return;
				}
				this.class32_0.method_2(new Class7.Class20(1));
				return;
			}
			case (Class7.Enum3)4:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_25());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)5:
			{
				object obj = Class7.Class16.object_2;
				lock (obj)
				{
					object obj2 = this.class32_0.method_4().vmethod_4(null);
					Class7.Class18 class3 = null;
					if (Class7.Class16.dictionary_1.TryGetValue(obj2, out class3))
					{
						this.class32_0.method_2(class3);
					}
					else
					{
						this.class32_0.method_2(new Class7.Class30(null));
					}
				}
				return;
			}
			case (Class7.Enum3)6:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class7.Enum3)7:
				this.class32_0.method_2(new Class7.Class21((long)this.object_0));
				return;
			case (Class7.Enum3)8:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class7).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class32_0.method_2(new Class7.Class30(obj));
				return;
			}
			case (Class7.Enum3)9:
			case (Class7.Enum3)68:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class18 class3 = this.class32_0.method_4();
				object obj = class3.vmethod_4(type);
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class7.Class16.smethod_9(obj);
					}
					class3 = Class7.Class18.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					class3 = Class7.Class18.smethod_1(type, obj);
				}
				else
				{
					class3 = new Class7.Class30(null);
				}
				Class7.Class24 class4 = this.class32_0.method_4() as Class7.Class24;
				if (class4 != null)
				{
					class4.vmethod_9(class3);
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)10:
			{
				Class7.Class18 class3 = this.class18_1[(int)this.object_0];
				this.class32_0.method_2(class3);
				return;
			}
			case (Class7.Enum3)11:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_76(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)12:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_75(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)13:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(float), obj));
				return;
			}
			case (Class7.Enum3)14:
			{
				bool flag = false;
				Class7.Class18 class3 = this.class32_0.method_4();
				flag = (class3 == null || !class3.vmethod_6());
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)15:
			{
				Class7.Class19 class5 = Class7.Class16.smethod_1(this.class32_0.method_3());
				if (class5 == null)
				{
					throw new ArithmeticException(((Class7.Enum5)0).ToString());
				}
				Class7.Class23 class6 = class5 as Class7.Class23;
				if (class6 != null)
				{
					if (double.IsNaN(class6.double_0))
					{
						throw new OverflowException(((Class7.Enum5)2).ToString());
					}
					if (double.IsInfinity(class6.double_0))
					{
						throw new OverflowException(((Class7.Enum5)1).ToString());
					}
				}
				return;
			}
			case (Class7.Enum3)16:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_49();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)17:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_54());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)18:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class7).Module.ResolveType(num);
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Array array = Array.CreateInstance(elementType, @class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(new Class7.Class30(array));
				return;
			}
			case (Class7.Enum3)19:
				this.class32_0.method_2(this.class18_0[(int)this.object_0]);
				return;
			case (Class7.Enum3)20:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_47();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)21:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class7).Module;
				this.class32_0.method_2(new Class7.Class22(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class7.Enum3)22:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class7.Enum3)23:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_53());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)24:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3 != null && class3.vmethod_6())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)25:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_82(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)26:
			case (Class7.Enum3)73:
			case (Class7.Enum3)79:
			case (Class7.Enum3)109:
			case (Class7.Enum3)133:
			case (Class7.Enum3)139:
				return;
			case (Class7.Enum3)27:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_71());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)28:
				throw (Exception)this.class32_0.method_4().vmethod_4(null);
			case (Class7.Enum3)29:
				return;
			case (Class7.Enum3)30:
				this.class32_0.method_2(new Class7.Class25((int)this.object_0, this));
				return;
			case (Class7.Enum3)31:
			case (Class7.Enum3)83:
			case (Class7.Enum3)94:
			case (Class7.Enum3)123:
			case (Class7.Enum3)144:
			case (Class7.Enum3)145:
				throw new Class7.Exception1();
			case (Class7.Enum3)32:
				this.bool_2 = true;
				return;
			case (Class7.Enum3)33:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_23());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20((int)(*(short*)((void*)intPtr)), (Class7.Enum1)3));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)34:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_23();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)35:
			case (Class7.Enum3)58:
			case (Class7.Enum3)86:
			case (Class7.Enum3)93:
			case (Class7.Enum3)106:
			case (Class7.Enum3)120:
			case (Class7.Enum3)127:
			case (Class7.Enum3)146:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Array array2 = (Array)this.class32_0.method_4().vmethod_4(null);
				Type type = array2.GetType().GetElementType();
				array2.SetValue(class3.vmethod_4(type), @class.vmethod_18().struct1_0.int_0);
				return;
			}
			case (Class7.Enum3)36:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_22());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)37:
				this.int_0 = -3;
				if (this.class32_0.method_0() > 0)
				{
					this.class18_2 = this.class32_0.method_4();
				}
				return;
			case (Class7.Enum3)38:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				object obj = this.class32_0.method_4().vmethod_7().vmethod_4(type);
				Class7.Class18 class3 = Class7.Class18.smethod_1(type, obj);
				this.class32_0.method_2(class3);
				return;
			}
			case (Class7.Enum3)39:
			{
				int[] array3 = (int[])this.object_0;
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				long num2 = @class.vmethod_20().struct2_0.long_0;
				if ((num2 < 0L || @class.method_4()) && IntPtr.Size == 4)
				{
					num2 = (long)((int)num2);
				}
				if (@class.method_1())
				{
					Class7.Class20 class7 = (Class7.Class20)@class;
					if (class7.enum1_0 == (Class7.Enum1)6)
					{
						num2 = (long)((ulong)class7.struct1_0.uint_0);
					}
				}
				if (num2 < (long)array3.Length && num2 >= 0L)
				{
					this.int_0 = array3[(int)(checked((IntPtr)num2))] - 1;
				}
				return;
			}
			case (Class7.Enum3)40:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_25();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)41:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_22();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)42:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(int), obj));
				return;
			}
			case (Class7.Enum3)43:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				((Array)this.class32_0.method_4().vmethod_4(null)).SetValue(class3.vmethod_4(type), @class.vmethod_18().struct1_0.int_0);
				return;
			}
			case (Class7.Enum3)44:
				this.class32_0.method_2(new Class7.Class28((int)this.object_0, this));
				return;
			case (Class7.Enum3)45:
				this.class32_0.method_4();
				return;
			case (Class7.Enum3)46:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_22());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20((int)(*(sbyte*)((void*)intPtr)), (Class7.Enum1)1));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)47:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_81(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)48:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_28());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20(*(uint*)((void*)intPtr), (Class7.Enum1)6));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)49:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_83(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)50:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_46();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)51:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				object obj = this.class32_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class7.Enum3)52:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_47());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class23(*(double*)((void*)intPtr), (Class7.Enum1)10));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)53:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(double), obj));
				return;
			}
			case (Class7.Enum3)54:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class24 class8 = this.class32_0.method_4() as Class7.Class24;
				if (class8 == null)
				{
					throw new Class7.Exception1();
				}
				if (type.IsValueType)
				{
					object obj = Activator.CreateInstance(type);
					class8.vmethod_11(Class7.Class18.smethod_1(type, obj));
					return;
				}
				class8.vmethod_11(new Class7.Class30(null));
				return;
			}
			case (Class7.Enum3)55:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class18 class3 = this.class32_0.method_4();
				object obj = class3.vmethod_4(null);
				if (obj == null)
				{
					this.class32_0.method_2(new Class7.Class30(null));
					return;
				}
				if (!type.IsAssignableFrom(obj.GetType()))
				{
					this.class32_0.method_2(new Class7.Class30(null));
					return;
				}
				this.class32_0.method_2(class3);
				return;
			}
			case (Class7.Enum3)56:
				if (this.class32_0.method_4().hvnLfEhAw6(this.class32_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class7.Enum3)57:
				this.class32_0.method_2(this.class32_0.method_3());
				return;
			case (Class7.Enum3)59:
			{
				Class7.Class18 class9 = Class7.Class16.smethod_6(this.class32_0.method_4());
				Class7.Class18 class3 = Class7.Class16.smethod_6(this.class32_0.method_4());
				if (class9.vmethod_5(class3))
				{
					this.class32_0.method_2(new Class7.Class20(1));
					return;
				}
				this.class32_0.method_2(new Class7.Class20(0));
				return;
			}
			case (Class7.Enum3)60:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class7.Enum3)61:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_74(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)62:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_84(class3))
				{
					this.class32_0.method_2(new Class7.Class20(1));
					return;
				}
				this.class32_0.method_2(new Class7.Class20(0));
				return;
			}
			case (Class7.Enum3)63:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_56(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)64:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_78(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)65:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_51());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)66:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_59(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)67:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_49());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)69:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				object obj = this.class32_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class7.Class18 class3 = this.class32_0.method_4();
				object obj2 = class3.vmethod_4(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (class3 is Class7.Class25)
					{
						((Class7.Class24)class3).vmethod_11(Class7.Class18.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class7.Enum3)70:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (!class3.vmethod_0())
				{
					throw new Class7.Exception1();
				}
				object obj = class3.vmethod_4(null);
				if (obj != null)
				{
					class3 = Class7.Class18.smethod_1(obj.GetType(), obj);
				}
				else
				{
					class3 = new Class7.Class30(null);
				}
				this.class32_0.method_2(class3);
				return;
			}
			case (Class7.Enum3)71:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				Class7.Class18 class18_ = this.class32_0.method_4();
				Class7.Class19 class2 = Class7.Class16.smethod_1(class18_);
				if (class2 != null && @class != null)
				{
					if (class2.vmethod_80(class3))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (class3.hvnLfEhAw6(class18_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)72:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				object obj = this.class32_0.method_4().vmethod_4(null);
				this.class32_0.method_2(Class7.Class18.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class7.Enum3)74:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_24());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)75:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_33());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)76:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class7).Module.ResolveMethod(num);
				Type type = this.class32_0.method_4().vmethod_4(null).GetType();
				List<Type> list = new List<Type>();
				do
				{
					list.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class32_0.method_2(new Class7.Class22(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class7.Enum3)77:
				this.class32_0.method_2(((Class7.Class19)this.class32_0.method_4()).vmethod_55());
				return;
			case (Class7.Enum3)78:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_37());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)80:
				this.class32_0.method_2(new Class7.Class20((int)this.object_0));
				return;
			case (Class7.Enum3)81:
			{
				Class7.Class19 @class = this.class32_0.method_4() as Class7.Class19;
				Class7.Class19 class2 = this.class32_0.method_4() as Class7.Class19;
				IntPtr intPtr = Class7.Class16.smethod_8(this.class32_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class2.vmethod_15().struct1_0.byte_0;
					uint num3 = @class.vmethod_19().struct1_0.uint_0;
					Class7.Class16.smethod_10(intPtr, byte_, (int)num3);
				}
				return;
			}
			case (Class7.Enum3)82:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class == null)
				{
					throw new Class7.Exception1();
				}
				this.class32_0.method_2(@class.vmethod_42());
				return;
			}
			case (Class7.Enum3)84:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_23());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)85:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = (Class7.Class19)this.class32_0.method_4();
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_60(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)87:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)88:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_38());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)89:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_29());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)90:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class7.Enum3)91:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_45());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)92:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class32_0.method_2(@class.vmethod_70(class2));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)95:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_25());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class21(*(long*)((void*)intPtr), (Class7.Enum1)7));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)96:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_32());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)97:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class7.Enum3)98:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_62(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)99:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Array array4 = (Array)this.class32_0.method_4().vmethod_4(null);
				object obj = array4.GetValue(@class.vmethod_18().struct1_0.int_0);
				Type type = array4.GetType().GetElementType();
				this.class32_0.method_2(Class7.Class18.smethod_1(type, obj));
				return;
			}
			case (Class7.Enum3)100:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_64(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)101:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_50());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)102:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_36());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)103:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_43());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)104:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_47());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)105:
			{
				Type type = typeof(Class7).Module.ResolveType((int)this.object_0);
				object obj = this.class32_0.method_4().vmethod_4(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class7.Class30 class10 = new Class7.Class30(Class7.Class18.smethod_1(type, Class7.Class16.smethod_9(obj)));
				this.class32_0.method_2(class10);
				return;
			}
			case (Class7.Enum3)107:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_24());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20(*(int*)((void*)intPtr), (Class7.Enum1)5));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)108:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(short), obj));
				return;
			}
			case (Class7.Enum3)110:
				throw this.exception_0;
			case (Class7.Enum3)111:
				this.method_12(true);
				return;
			case (Class7.Enum3)112:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_67(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)113:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class7.Enum3)114:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_66(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)115:
			{
				int num = (int)this.object_0;
				typeof(Class7).Module.ResolveType(num);
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Array array = (Array)this.class32_0.method_4().vmethod_4(null);
				this.class32_0.method_2(new Class7.Class26(@class.vmethod_18().struct1_0.int_0, array));
				return;
			}
			case (Class7.Enum3)116:
				if (Class7.list_0.Count == 0)
				{
					Module module = typeof(Class7).Module;
					this.class32_0.method_2(new Class7.Class31(module.ResolveString((int)this.object_0 | 1879048192)));
					return;
				}
				this.class32_0.method_2(new Class7.Class31(Class7.list_0[(int)this.object_0]));
				return;
			case (Class7.Enum3)117:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				Class7.Class18 class18_ = this.class32_0.method_4();
				Class7.Class19 class2 = Class7.Class16.smethod_1(class18_);
				if (class2 != null && @class != null)
				{
					if (class2.vmethod_80(class3))
					{
						this.class32_0.method_2(new Class7.Class20(1));
						return;
					}
					this.class32_0.method_2(new Class7.Class20(0));
					return;
				}
				else
				{
					if (class3.hvnLfEhAw6(class18_))
					{
						this.class32_0.method_2(new Class7.Class20(1));
						return;
					}
					this.class32_0.method_2(new Class7.Class20(0));
					return;
				}
				break;
			}
			case (Class7.Enum3)118:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_77(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)119:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class32_0.method_2(@class.vmethod_72(class2));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)121:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_31());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)122:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_46());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class23(*(float*)((void*)intPtr), (Class7.Enum1)9));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)124:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_41());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)125:
				this.class32_0.method_2(new Class7.Class23((float)this.object_0));
				return;
			case (Class7.Enum3)126:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_48());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)128:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_27());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20((int)(*(ushort*)((void*)intPtr)), (Class7.Enum1)4));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)129:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_68(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)130:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class32_0.method_2(@class.vmethod_69(class2));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)131:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_27());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)132:
			{
				object obj = Class7.Class16.object_2;
				lock (obj)
				{
					Class7.Class18 class3 = this.class32_0.method_4();
					object obj2 = this.class32_0.method_4().vmethod_4(null);
					Class7.Class16.dictionary_1[obj2] = class3;
				}
				return;
			}
			case (Class7.Enum3)134:
				this.method_12(false);
				return;
			case (Class7.Enum3)135:
			{
				Array array = (Array)this.class32_0.method_4().vmethod_4(null);
				this.class32_0.method_2(new Class7.Class20(array.Length, (Class7.Enum1)5));
				return;
			}
			case (Class7.Enum3)136:
			{
				int num = (int)this.object_0;
				uint num3 = (uint)Class7.Class16.smethod_0(typeof(Class7).Module.ResolveType(num));
				this.class32_0.method_2(new Class7.Class20(num3, (Class7.Enum1)6));
				return;
			}
			case (Class7.Enum3)137:
			{
				int num = (int)this.object_0;
				if (this.class13_0.methodBase_0.IsStatic)
				{
					this.class18_0[num] = this.method_8(this.class32_0.method_4(), this.class13_0.PoCeHkwYbP[num].enum1_0, false);
					return;
				}
				this.class18_0[num] = this.method_8(this.class32_0.method_4(), this.class13_0.PoCeHkwYbP[num - 1].enum1_0, false);
				return;
			}
			case (Class7.Enum3)138:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_30());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)140:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_83(class3))
				{
					this.class32_0.method_2(new Class7.Class20(1));
					return;
				}
				this.class32_0.method_2(new Class7.Class20(0));
				return;
			}
			case (Class7.Enum3)141:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class7.Class19)class3).vmethod_24();
				}
				this.class32_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class7.Enum3)142:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_39());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)143:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_61(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)147:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_26());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class7.Class22)@class).method_7();
					this.class32_0.method_2(new Class7.Class20((int)(*(byte*)((void*)intPtr)), (Class7.Enum1)2));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)148:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_46());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)149:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class24 class11 = this.class32_0.method_4() as Class7.Class24;
				if (class11 == null)
				{
					throw new Class7.Exception1();
				}
				object obj = class11.vmethod_4(type);
				Class7.Class18 class3;
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class7.Class16.smethod_9(obj);
					}
					class3 = Class7.Class18.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					class3 = Class7.Class18.smethod_1(type, obj);
				}
				else
				{
					class3 = new Class7.Class30(null);
				}
				this.class32_0.method_2(class3);
				return;
			}
			case (Class7.Enum3)150:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				Class7.Class18 class12 = this.class32_0.method_4();
				class12.vmethod_7();
				object obj = class12.vmethod_4(null);
				this.class32_0.method_2(new Class7.Class27(fieldInfo, obj));
				return;
			}
			case (Class7.Enum3)151:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class32_0.method_4() as Class7.Class19).vmethod_18().struct1_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class32_0.method_2(new Class7.Class22(intPtr));
				return;
			}
			case (Class7.Enum3)152:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_40());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)153:
			{
				int num = (int)this.object_0;
				this.class18_1[num] = this.method_8(this.class32_0.method_4(), this.class13_0.list_1[num].enum1_0, this.class13_0.list_1[num].bool_0);
				return;
			}
			case (Class7.Enum3)154:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				bool flag2 = Class7.Class16.smethod_1(this.class32_0.method_4()).vmethod_84(class3);
				if (flag2)
				{
					this.class32_0.method_2(new Class7.Class20(1));
				}
				else
				{
					this.class32_0.method_2(new Class7.Class20(0));
				}
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)155:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_44());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)156:
				this.class32_0.method_2(new Class7.Class23((double)this.object_0));
				return;
			case (Class7.Enum3)157:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class7).Module.ResolveType(num);
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(type, obj));
				return;
			}
			case (Class7.Enum3)158:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_52());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)159:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_26());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)160:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(long), obj));
				return;
			}
			case (Class7.Enum3)161:
			{
				Class7.Class19 @class = this.class32_0.method_4() as Class7.Class19;
				IntPtr intPtr = Class7.Class16.smethod_8(this.class32_0.method_4());
				IntPtr intPtr2 = Class7.Class16.smethod_8(this.class32_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num3 = @class.vmethod_19().struct1_0.uint_0;
					Class7.Class16.smethod_11(intPtr2, intPtr, num3);
				}
				return;
			}
			case (Class7.Enum3)162:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				this.class32_0.method_2(new Class7.Class27(fieldInfo, null));
				return;
			}
			case (Class7.Enum3)163:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				object obj = ((Array)this.class32_0.method_4().vmethod_4(null)).GetValue(@class.vmethod_18().struct1_0.int_0);
				this.class32_0.method_2(Class7.Class18.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class7.Enum3)164:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_63(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)165:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_35());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)166:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class7).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array5 = new object[parameters.Length];
				Class7.Class18[] array6 = new Class7.Class18[parameters.Length];
				List<Class7.Class14> list2 = null;
				Class7.Class15 class13 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class7.Class18 class3 = this.class32_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag = false;
					if (type.IsByRef)
					{
						Class7.Class27 class14 = class3 as Class7.Class27;
						if (class14 != null)
						{
							if (list2 == null)
							{
								list2 = new List<Class7.Class14>();
							}
							list2.Add(new Class7.Class14(class14.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class14.object_0;
							if (obj2 is Class7.Class18)
							{
								class3 = (obj2 as Class7.Class18);
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						if (class3 != null)
						{
							obj2 = class3.vmethod_4(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (class3 is Class7.Class25)
								{
									((Class7.Class24)class3).vmethod_11(Class7.Class18.smethod_1(type, obj2));
								}
							}
						}
					}
					array6[array5.Length - 1 - i] = class3;
					array5[array5.Length - 1 - i] = obj2;
				}
				Class7.Delegate10 @delegate = null;
				if (list2 != null)
				{
					class13 = new Class7.Class15(constructorInfo, list2);
					@delegate = Class7.Class16.smethod_4(constructorInfo, true, class13);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array5);
				}
				else
				{
					obj = constructorInfo.Invoke(array5);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class13 == null || !class13.method_1(j)))
					{
						if (array6[j].method_2())
						{
							((Class7.Class22)array6[j]).method_6(Class7.Class18.smethod_1(parameters[j].ParameterType, array5[j]));
						}
						else if (array6[j] is Class7.Class25)
						{
							array6[j].vmethod_9(Class7.Class18.smethod_1(parameters[j].ParameterType.GetElementType(), array5[j]));
						}
						else
						{
							array6[j].vmethod_9(Class7.Class18.smethod_1(parameters[j].ParameterType, array5[j]));
						}
					}
				}
				this.class32_0.method_2(Class7.Class18.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class7.Enum3)167:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (@class != null)
				{
					this.class32_0.method_2(@class.vmethod_28());
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)168:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class32_0.method_2(class2.vmethod_65(@class));
					return;
				}
				throw new Class7.Exception1();
			}
			case (Class7.Enum3)169:
				this.class32_0.method_2(new Class7.Class30(null));
				return;
			case (Class7.Enum3)170:
			{
				Class7.Class18 class3 = this.class32_0.method_4();
				Class7.Class19 @class = Class7.Class16.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class32_0.method_2(@class.vmethod_49());
					return;
				}
				if (@class == null || !@class.method_2())
				{
					throw new Class7.Exception1();
				}
				IntPtr intPtr = ((Class7.Class22)@class).method_7();
				if (IntPtr.Size == 8)
				{
					long num2 = *(long*)((void*)intPtr);
					this.class32_0.method_2(new Class7.Class22(num2, (Class7.Enum1)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class32_0.method_2(new Class7.Class22((long)num, (Class7.Enum1)12));
				return;
			}
			case (Class7.Enum3)171:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class7).Module.ResolveField(num);
				this.class32_0.method_2(Class7.Class18.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class7.Enum3)172:
			{
				Class7.Class18 class15 = this.class32_0.method_4();
				Class7.Class18 class3 = this.class32_0.method_4();
				if (class15.vmethod_5(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class7.Enum3)173:
				this.class32_0.method_2(this.class32_0.method_4().vmethod_7());
				return;
			case (Class7.Enum3)174:
				this.bool_3 = (bool)this.class32_0.method_4().vmethod_4(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class7.Enum3)175:
			{
				Class7.Class19 @class = Class7.Class16.smethod_1(this.class32_0.method_4());
				Class7.Class19 class2 = Class7.Class16.smethod_1(this.class32_0.method_4());
				if (class2 == null || @class == null)
				{
					throw new Class7.Exception1();
				}
				this.class32_0.method_2(class2.vmethod_58(@class));
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002759C File Offset: 0x0002579C
		private Class7.Class18 method_8(Class7.Class18 class18_3, Class7.Enum1 enum1_0, bool bool_4 = false)
		{
			if (!bool_4 && class18_3.vmethod_0())
			{
				class18_3 = class18_3.vmethod_7();
			}
			if (class18_3.method_1())
			{
				return ((Class7.Class20)class18_3).vmethod_12(enum1_0);
			}
			if (class18_3.method_3())
			{
				return ((Class7.Class21)class18_3).vmethod_12(enum1_0);
			}
			if (class18_3.method_4())
			{
				return ((Class7.Class23)class18_3).vmethod_12(enum1_0);
			}
			if (class18_3.method_2())
			{
				return ((Class7.Class22)class18_3).vmethod_12(enum1_0);
			}
			return class18_3;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000061B0 File Offset: 0x000043B0
		private Class7.Class18 method_9(int int_3)
		{
			return this.class18_1[int_3];
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000061BA File Offset: 0x000043BA
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class32_0.method_4());
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00027614 File Offset: 0x00025814
		private static int smethod_0(Type type_0)
		{
			object obj = Class7.Class16.object_1;
			int result;
			lock (obj)
			{
				if (Class7.Class16.dictionary_0 == null)
				{
					Class7.Class16.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (!Class7.Class16.dictionary_0.TryGetValue(type_0, out num))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class7.Class16.dictionary_0[type_0] = num;
						result = num;
					}
					else
					{
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000061CE File Offset: 0x000043CE
		private void method_11(int int_3, Class7.Class18 class18_3)
		{
			this.class18_1[int_3] = this.method_8(class18_3, this.class13_0.list_1[int_3].enum1_0, this.class13_0.list_1[int_3].bool_0);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private static Class7.Class19 smethod_1(Class7.Class18 class18_3)
		{
			Class7.Class19 @class = class18_3 as Class7.Class19;
			if (@class == null && class18_3.vmethod_0())
			{
				@class = (class18_3.vmethod_7() as Class7.Class19);
			}
			return @class;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000276E8 File Offset: 0x000258E8
		private void method_12(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class7).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class7.Class18[] array2 = new Class7.Class18[parameters.Length];
			List<Class7.Class14> list = null;
			Class7.Class15 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class7.Class18 class2 = this.class32_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class7.Class27 class3 = class2 as Class7.Class27;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class7.Class14>();
						}
						list.Add(new Class7.Class14(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class7.Class18)
						{
							class2 = (obj as Class7.Class18);
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class7.Class25)
									{
										((Class7.Class24)class2).vmethod_11(Class7.Class18.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class7.Class25)
							{
								((Class7.Class24)class2).vmethod_11(Class7.Class18.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class7.Delegate10 @delegate = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class7.Class16.smethod_2(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class7.Class15(methodBase, list);
				@delegate = Class7.Class16.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class7.Class18 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class32_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class7.Class25)
					{
						((Class7.Class24)class4).vmethod_11(Class7.Class18.smethod_1(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class7.Class25)
				{
					((Class7.Class24)class4).vmethod_11(Class7.Class18.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate != null)
			{
				obj3 = @delegate(obj2, array);
			}
			else
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_2())
					{
						((Class7.Class22)array2[j]).method_6(Class7.Class18.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class7.Class25)
					{
						array2[j].vmethod_9(Class7.Class18.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].vmethod_9(Class7.Class18.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class32_0.method_2(Class7.Class18.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00027B1C File Offset: 0x00025D1C
		private static Class7.Delegate10 smethod_2(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class7.Class16.object_3;
			Class7.Delegate10 result2;
			lock (obj)
			{
				Class7.Delegate10 result = null;
				if (bool_4)
				{
					if (Class7.Class16.dictionary_2.TryGetValue(methodBase_0, out result))
					{
						return result;
					}
				}
				else if (Class7.Class16.dictionary_3.TryGetValue(methodBase_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class7.Class16.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class7.Class16.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class7.Delegate10 @delegate = (Class7.Delegate10)dynamicMethod.CreateDelegate(typeof(Class7.Delegate10));
				if (bool_4)
				{
					Class7.Class16.dictionary_2.Add(methodBase_0, @delegate);
				}
				else
				{
					Class7.Class16.dictionary_3.Add(methodBase_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00027FCC File Offset: 0x000261CC
		private static Class7.Delegate10 smethod_3(MethodBase methodBase_0, bool bool_4, Class7.Class15 class15_0)
		{
			object obj = Class7.Class16.object_4;
			Class7.Delegate10 result2;
			lock (obj)
			{
				Class7.Delegate10 result = null;
				if (bool_4)
				{
					if (Class7.Class16.dictionary_4.TryGetValue(class15_0, out result))
					{
						return result;
					}
				}
				else if (Class7.Class16.dictionary_5.TryGetValue(class15_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class7), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (class15_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class7.Class16.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class15_0.method_1(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!class15_0.method_1(l))
					{
						if (parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
					}
					else
					{
						Class7.Class14 @class = class15_0.method_0(l);
						if (@class.fieldInfo_0.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
						}
						else if (@class.fieldInfo_0.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!class15_0.method_1(m))
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class7.Class16.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							Class7.Class14 class2 = class15_0.method_0(m);
							if (class2.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class7.Class16.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
								if (class2.fieldInfo_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class7.Class16.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class7.Delegate10 @delegate = (Class7.Delegate10)dynamicMethod.CreateDelegate(typeof(Class7.Delegate10));
				if (bool_4)
				{
					Class7.Class16.dictionary_4.Add(class15_0, @delegate);
				}
				else
				{
					Class7.Class16.dictionary_5.Add(class15_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00028674 File Offset: 0x00026874
		private static Class7.Delegate10 smethod_4(MethodBase methodBase_0, bool bool_4, Class7.Class15 class15_0)
		{
			object obj = Class7.Class16.object_5;
			Class7.Delegate10 result;
			lock (obj)
			{
				Class7.Delegate10 @delegate = null;
				if (Class7.Class16.dictionary_6.TryGetValue(class15_0, out @delegate))
				{
					result = @delegate;
				}
				else
				{
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class7), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
						else
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					int num = array.Length;
					if (methodBase_0.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (class15_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
					}
					if (methodBase_0.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class7.Class16.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class15_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (!class15_0.method_1(l))
						{
							if (parameters[l].ParameterType.IsByRef)
							{
								ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							}
						}
						else
						{
							Class7.Class14 @class = class15_0.method_0(l);
							if (!@class.fieldInfo_0.IsStatic)
							{
								if (@class.fieldInfo_0.DeclaringType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
									ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
									ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
								}
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, methodBase_0 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class15_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class7.Class16.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class7.Class14 class2 = class15_0.method_0(m);
								if (class2.fieldInfo_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class7.Class16.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
									if (class2.fieldInfo_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class7.Class16.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class7.Delegate10 delegate2 = (Class7.Delegate10)dynamicMethod.CreateDelegate(typeof(Class7.Delegate10));
					Class7.Class16.dictionary_6.Add(class15_0, delegate2);
					result = delegate2;
				}
			}
			return result;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00028BA0 File Offset: 0x00026DA0
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00028C80 File Offset: 0x00026E80
		private static Class7.Class18 smethod_6(Class7.Class18 class18_3)
		{
			if (class18_3.vmethod_7().method_0())
			{
				object obj = class18_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class7.Class18 @class = Class7.Class16.smethod_7(Class7.Class18.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class7.Class19;
					}
				}
			}
			return class18_3;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private static Class7.Class19 smethod_7(Class7.Class18 class18_3)
		{
			Class7.Class19 @class = class18_3 as Class7.Class19;
			if (@class == null && class18_3.vmethod_0())
			{
				@class = (class18_3.vmethod_7() as Class7.Class19);
			}
			return @class;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00028CEC File Offset: 0x00026EEC
		private static IntPtr smethod_8(Class7.Class18 class18_3)
		{
			if (class18_3 == null)
			{
				return IntPtr.Zero;
			}
			if (class18_3.method_2())
			{
				return ((Class7.Class22)class18_3).method_7();
			}
			if (class18_3.vmethod_0())
			{
				Class7.Class24 @class = (Class7.Class24)class18_3;
				IntPtr result;
				try
				{
					result = @class.vmethod_10();
				}
				catch
				{
					goto IL_3E;
				}
				return result;
			}
			IL_3E:
			object obj = class18_3.vmethod_4(typeof(IntPtr));
			if (obj == null || !(obj.GetType() == typeof(IntPtr)))
			{
				throw new Class7.Exception1();
			}
			return (IntPtr)obj;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00028D84 File Offset: 0x00026F84
		private static object smethod_9(object object_7)
		{
			object obj = Class7.Class16.object_6;
			object result;
			lock (obj)
			{
				if (Class7.Class16.dictionary_7 == null)
				{
					Class7.Class16.dictionary_7 = new Dictionary<Type, Class7.Delegate11>();
				}
				if (object_7 != null)
				{
					try
					{
						Type type = object_7.GetType();
						Class7.Delegate11 @delegate;
						if (!Class7.Class16.dictionary_7.TryGetValue(type, out @delegate))
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
							{
								typeof(object)
							}, true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Unbox_Any, type);
							ilgenerator.Emit(OpCodes.Box, type);
							ilgenerator.Emit(OpCodes.Ret);
							Class7.Delegate11 delegate2 = (Class7.Delegate11)dynamicMethod.CreateDelegate(typeof(Class7.Delegate11));
							Class7.Class16.dictionary_7.Add(type, delegate2);
							return delegate2(object_7);
						}
						return @delegate(object_7);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00028EA8 File Offset: 0x000270A8
		private static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class7.Class16.object_6;
			lock (obj)
			{
				if (Class7.Class16.delegate12_0 == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class7), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class7.Class16.delegate12_0 = (Class7.Delegate12)dynamicMethod.CreateDelegate(typeof(Class7.Delegate12));
				}
				Class7.Class16.delegate12_0(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00028FA0 File Offset: 0x000271A0
		private static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class7.Class16.delegate13_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class7), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class7.Class16.delegate13_0 = (Class7.Delegate13)dynamicMethod.CreateDelegate(typeof(Class7.Delegate13));
			}
			Class7.Class16.delegate13_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x04000495 RID: 1173
		internal Class7.Class13 class13_0;

		// Token: 0x04000496 RID: 1174
		internal Class7.Class18[] class18_0 = new Class7.Class18[0];

		// Token: 0x04000497 RID: 1175
		internal Class7.Class18[] class18_1 = new Class7.Class18[0];

		// Token: 0x04000498 RID: 1176
		internal Class7.Class32 class32_0 = new Class7.Class32();

		// Token: 0x04000499 RID: 1177
		internal Class7.Class18 class18_2;

		// Token: 0x0400049A RID: 1178
		internal Exception exception_0;

		// Token: 0x0400049B RID: 1179
		internal List<IntPtr> list_0;

		// Token: 0x0400049C RID: 1180
		private int int_0;

		// Token: 0x0400049D RID: 1181
		private int int_1;

		// Token: 0x0400049E RID: 1182
		private int int_2 = -1;

		// Token: 0x0400049F RID: 1183
		private object object_0;

		// Token: 0x040004A0 RID: 1184
		private bool bool_0;

		// Token: 0x040004A1 RID: 1185
		private bool bool_1;

		// Token: 0x040004A2 RID: 1186
		private bool bool_2;

		// Token: 0x040004A3 RID: 1187
		private bool bool_3;

		// Token: 0x040004A4 RID: 1188
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x040004A5 RID: 1189
		private static object object_1 = new object();

		// Token: 0x040004A6 RID: 1190
		private static Dictionary<object, Class7.Class18> dictionary_1 = new Dictionary<object, Class7.Class18>();

		// Token: 0x040004A7 RID: 1191
		private static object object_2 = new object();

		// Token: 0x040004A8 RID: 1192
		private static Dictionary<MethodBase, Class7.Delegate10> dictionary_2 = new Dictionary<MethodBase, Class7.Delegate10>();

		// Token: 0x040004A9 RID: 1193
		private static Dictionary<MethodBase, Class7.Delegate10> dictionary_3 = new Dictionary<MethodBase, Class7.Delegate10>();

		// Token: 0x040004AA RID: 1194
		private static object object_3 = new object();

		// Token: 0x040004AB RID: 1195
		private static Dictionary<Class7.Class15, Class7.Delegate10> dictionary_4 = new Dictionary<Class7.Class15, Class7.Delegate10>();

		// Token: 0x040004AC RID: 1196
		private static Dictionary<Class7.Class15, Class7.Delegate10> dictionary_5 = new Dictionary<Class7.Class15, Class7.Delegate10>();

		// Token: 0x040004AD RID: 1197
		private static object object_4 = new object();

		// Token: 0x040004AE RID: 1198
		private static Dictionary<Class7.Class15, Class7.Delegate10> dictionary_6 = new Dictionary<Class7.Class15, Class7.Delegate10>();

		// Token: 0x040004AF RID: 1199
		private static object object_5 = new object();

		// Token: 0x040004B0 RID: 1200
		private static Dictionary<Type, Class7.Delegate11> dictionary_7;

		// Token: 0x040004B1 RID: 1201
		private static object object_6 = new object();

		// Token: 0x040004B2 RID: 1202
		private static Class7.Delegate12 delegate12_0;

		// Token: 0x040004B3 RID: 1203
		private static Class7.Delegate13 delegate13_0;

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		[Serializable]
		private sealed class Class17
		{
			// Token: 0x06000625 RID: 1573 RVA: 0x0000624B File Offset: 0x0000444B
			internal int method_0(Class7.Class11 x, Class7.Class11 y)
			{
				return x.class12_0.int_0.CompareTo(y.class12_0.int_0);
			}

			// Token: 0x040004B4 RID: 1204
			public static readonly Class7.Class16.Class17 <>9 = new Class7.Class16.Class17();

			// Token: 0x040004B5 RID: 1205
			public static Comparison<Class7.Class11> <>9__12_0;
		}
	}

	// Token: 0x02000103 RID: 259
	internal enum Enum3 : byte
	{

	}

	// Token: 0x02000104 RID: 260
	internal enum Enum4 : byte
	{

	}

	// Token: 0x02000105 RID: 261
	internal abstract class Class18
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x0000226F File Offset: 0x0000046F
		public Class18()
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00006268 File Offset: 0x00004468
		internal bool method_0()
		{
			return this.enum4_0 == (Class7.Enum4)0;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00006273 File Offset: 0x00004473
		internal bool method_1()
		{
			return this.enum4_0 == (Class7.Enum4)1;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000627E File Offset: 0x0000447E
		internal bool method_2()
		{
			return this.enum4_0 == (Class7.Enum4)3 || this.enum4_0 == (Class7.Enum4)4;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00006294 File Offset: 0x00004494
		internal bool method_3()
		{
			return this.enum4_0 == (Class7.Enum4)2;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000629F File Offset: 0x0000449F
		internal bool method_4()
		{
			return this.enum4_0 == (Class7.Enum4)5;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000062AA File Offset: 0x000044AA
		internal bool method_5()
		{
			return this.enum4_0 == (Class7.Enum4)6;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000062B5 File Offset: 0x000044B5
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000062B5 File Offset: 0x000044B5
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x0600062F RID: 1583
		internal abstract void vmethod_2(Class7.Class18 class18_0);

		// Token: 0x06000630 RID: 1584 RVA: 0x000062B5 File Offset: 0x000044B5
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000062B8 File Offset: 0x000044B8
		internal Class18(Class7.Enum4 enum4_1)
		{
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06000632 RID: 1586
		internal abstract object vmethod_4(Type type_0);

		// Token: 0x06000633 RID: 1587
		internal abstract bool vmethod_5(Class7.Class18 class18_0);

		// Token: 0x06000634 RID: 1588
		internal abstract bool hvnLfEhAw6(Class7.Class18 class18_0);

		// Token: 0x06000635 RID: 1589
		internal abstract bool vmethod_6();

		// Token: 0x06000636 RID: 1590
		internal abstract Class7.Class18 vmethod_7();

		// Token: 0x06000637 RID: 1591 RVA: 0x000062B5 File Offset: 0x000044B5
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06000638 RID: 1592
		internal abstract void vmethod_9(Class7.Class18 class18_0);

		// Token: 0x06000639 RID: 1593 RVA: 0x000290F0 File Offset: 0x000272F0
		internal static Class7.Enum2 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class7.Enum2)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class7.Enum2)14;
			}
			if (type == typeof(byte))
			{
				return (Class7.Enum2)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class7.Enum2)1;
			}
			if (type == typeof(short))
			{
				return (Class7.Enum2)3;
			}
			if (type == typeof(ushort))
			{
				return (Class7.Enum2)4;
			}
			if (type == typeof(int))
			{
				return (Class7.Enum2)5;
			}
			if (type == typeof(uint))
			{
				return (Class7.Enum2)6;
			}
			if (type == typeof(long))
			{
				return (Class7.Enum2)7;
			}
			if (type == typeof(ulong))
			{
				return (Class7.Enum2)8;
			}
			if (type == typeof(float))
			{
				return (Class7.Enum2)9;
			}
			if (type == typeof(double))
			{
				return (Class7.Enum2)10;
			}
			if (type == typeof(bool))
			{
				return (Class7.Enum2)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class7.Enum2)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class7.Enum2)13;
			}
			if (type == typeof(char))
			{
				return (Class7.Enum2)15;
			}
			if (type == typeof(object))
			{
				return (Class7.Enum2)0;
			}
			if (type.IsEnum)
			{
				return (Class7.Enum2)16;
			}
			return (Class7.Enum2)17;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000292AC File Offset: 0x000274AC
		internal static Class7.Class18 smethod_1(Type type_0, object object_0)
		{
			Class7.Enum2 @enum = Class7.Class18.smethod_0(type_0);
			Class7.Enum2 enum2 = (Class7.Enum2)18;
			if (object_0 != null)
			{
				enum2 = Class7.Class18.smethod_0(object_0.GetType());
			}
			Class7.Class18 @class = null;
			switch (@enum)
			{
			case (Class7.Enum2)0:
				if (enum2 == (Class7.Enum2)15)
				{
					@class = new Class7.Class30(object_0);
				}
				else
				{
					@class = Class7.Class18.smethod_2(object_0);
				}
				break;
			case (Class7.Enum2)1:
				if (enum2 <= (Class7.Enum2)2)
				{
					if (enum2 == (Class7.Enum2)1)
					{
						@class = new Class7.Class20((int)((sbyte)object_0), (Class7.Enum1)1);
						break;
					}
					if (enum2 == (Class7.Enum2)2)
					{
						@class = new Class7.Class20((int)((sbyte)((byte)object_0)), (Class7.Enum1)1);
						break;
					}
				}
				else if (enum2 != (Class7.Enum2)11)
				{
					if (enum2 == (Class7.Enum2)15)
					{
						@class = new Class7.Class20((int)((sbyte)((char)object_0)), (Class7.Enum1)1);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class7.Class20(1, (Class7.Enum1)1);
						break;
					}
					@class = new Class7.Class20(0, (Class7.Enum1)1);
					break;
				}
				throw new InvalidCastException();
			case (Class7.Enum2)2:
				if (enum2 <= (Class7.Enum2)2)
				{
					if (enum2 == (Class7.Enum2)1)
					{
						@class = new Class7.Class20((int)((byte)((sbyte)object_0)), (Class7.Enum1)2);
						break;
					}
					if (enum2 == (Class7.Enum2)2)
					{
						@class = new Class7.Class20((int)((byte)object_0), (Class7.Enum1)2);
						break;
					}
				}
				else if (enum2 != (Class7.Enum2)11)
				{
					if (enum2 == (Class7.Enum2)15)
					{
						@class = new Class7.Class20((int)((byte)((char)object_0)), (Class7.Enum1)2);
						break;
					}
				}
				else
				{
					if (!(bool)object_0)
					{
						@class = new Class7.Class20(0, (Class7.Enum1)2);
						break;
					}
					@class = new Class7.Class20(1, (Class7.Enum1)2);
					break;
				}
				throw new InvalidCastException();
			case (Class7.Enum2)3:
				if (enum2 != (Class7.Enum2)3)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class20((int)((short)((char)object_0)), (Class7.Enum1)3);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class20(1, (Class7.Enum1)3);
					}
					else
					{
						@class = new Class7.Class20(0, (Class7.Enum1)3);
					}
				}
				else
				{
					@class = new Class7.Class20((int)((short)object_0), (Class7.Enum1)3);
				}
				break;
			case (Class7.Enum2)4:
				if (enum2 != (Class7.Enum2)4)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class20((int)((char)object_0), (Class7.Enum1)4);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class20(1, (Class7.Enum1)4);
					}
					else
					{
						@class = new Class7.Class20(0, (Class7.Enum1)4);
					}
				}
				else
				{
					@class = new Class7.Class20((int)((ushort)object_0), (Class7.Enum1)4);
				}
				break;
			case (Class7.Enum2)5:
				if (enum2 != (Class7.Enum2)5)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class20((int)((char)object_0), (Class7.Enum1)5);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class20(1, (Class7.Enum1)5);
					}
					else
					{
						@class = new Class7.Class20(0, (Class7.Enum1)5);
					}
				}
				else
				{
					@class = new Class7.Class20((int)object_0, (Class7.Enum1)5);
				}
				break;
			case (Class7.Enum2)6:
				if (enum2 != (Class7.Enum2)6)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class20((uint)((char)object_0), (Class7.Enum1)6);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class20(1U, (Class7.Enum1)6);
					}
					else
					{
						@class = new Class7.Class20(0U, (Class7.Enum1)6);
					}
				}
				else
				{
					@class = new Class7.Class20((uint)object_0, (Class7.Enum1)6);
				}
				break;
			case (Class7.Enum2)7:
				if (enum2 != (Class7.Enum2)7)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class21((long)((ulong)((char)object_0)), (Class7.Enum1)7);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class21(1L, (Class7.Enum1)7);
					}
					else
					{
						@class = new Class7.Class21(0L, (Class7.Enum1)7);
					}
				}
				else
				{
					@class = new Class7.Class21((long)object_0, (Class7.Enum1)7);
				}
				break;
			case (Class7.Enum2)8:
				if (enum2 != (Class7.Enum2)8)
				{
					if (enum2 != (Class7.Enum2)11)
					{
						if (enum2 != (Class7.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class7.Class21((ulong)((char)object_0), (Class7.Enum1)8);
					}
					else if ((bool)object_0)
					{
						@class = new Class7.Class21(1UL, (Class7.Enum1)8);
					}
					else
					{
						@class = new Class7.Class21(0UL, (Class7.Enum1)8);
					}
				}
				else
				{
					@class = new Class7.Class21((ulong)object_0, (Class7.Enum1)8);
				}
				break;
			case (Class7.Enum2)9:
				if (enum2 != (Class7.Enum2)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class7.Class23((float)object_0);
				break;
			case (Class7.Enum2)10:
				if (enum2 != (Class7.Enum2)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class7.Class23((double)object_0);
				break;
			case (Class7.Enum2)11:
				switch (enum2)
				{
				case (Class7.Enum2)1:
					@class = new Class7.Class20((sbyte)object_0 != 0);
					goto IL_67D;
				case (Class7.Enum2)2:
					@class = new Class7.Class20((byte)object_0 > 0);
					goto IL_67D;
				case (Class7.Enum2)3:
					@class = new Class7.Class20((short)object_0 != 0);
					goto IL_67D;
				case (Class7.Enum2)4:
					@class = new Class7.Class20((ushort)object_0 > 0);
					goto IL_67D;
				case (Class7.Enum2)5:
					@class = new Class7.Class20((int)object_0 != 0);
					goto IL_67D;
				case (Class7.Enum2)6:
					@class = new Class7.Class20((uint)object_0 > 0U);
					goto IL_67D;
				case (Class7.Enum2)7:
					@class = new Class7.Class20((long)object_0 != 0L);
					goto IL_67D;
				case (Class7.Enum2)8:
					@class = new Class7.Class20((ulong)object_0 > 0UL);
					goto IL_67D;
				case (Class7.Enum2)9:
				case (Class7.Enum2)10:
				case (Class7.Enum2)12:
				case (Class7.Enum2)13:
				case (Class7.Enum2)14:
				case (Class7.Enum2)15:
				case (Class7.Enum2)16:
					throw new InvalidCastException();
				case (Class7.Enum2)11:
					@class = new Class7.Class20((bool)object_0);
					goto IL_67D;
				case (Class7.Enum2)18:
					@class = new Class7.Class20(false);
					goto IL_67D;
				}
				@class = new Class7.Class20(object_0 != null);
				break;
			case (Class7.Enum2)12:
				if (enum2 != (Class7.Enum2)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class7.Class22((IntPtr)object_0);
				break;
			case (Class7.Enum2)13:
				if (enum2 != (Class7.Enum2)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class7.Class22((UIntPtr)object_0);
				break;
			case (Class7.Enum2)14:
				@class = new Class7.Class31(object_0 as string);
				break;
			case (Class7.Enum2)15:
				switch (enum2)
				{
				case (Class7.Enum2)1:
					@class = new Class7.Class20((int)((sbyte)object_0), (Class7.Enum1)15);
					break;
				case (Class7.Enum2)2:
					@class = new Class7.Class20((int)((byte)object_0), (Class7.Enum1)15);
					break;
				case (Class7.Enum2)3:
					@class = new Class7.Class20((int)((short)object_0), (Class7.Enum1)15);
					break;
				case (Class7.Enum2)4:
					@class = new Class7.Class20((int)((ushort)object_0), (Class7.Enum1)15);
					break;
				case (Class7.Enum2)5:
					@class = new Class7.Class20((int)object_0, (Class7.Enum1)15);
					break;
				case (Class7.Enum2)6:
					@class = new Class7.Class20((int)((uint)object_0), (Class7.Enum1)15);
					break;
				default:
					if (enum2 != (Class7.Enum2)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class7.Class20((int)((char)object_0), (Class7.Enum1)15);
					break;
				}
				break;
			case (Class7.Enum2)16:
			case (Class7.Enum2)17:
				@class = Class7.Class18.smethod_2(object_0);
				break;
			case (Class7.Enum2)18:
				throw new InvalidCastException();
			}
			IL_67D:
			if (type_0.IsByRef)
			{
				@class = new Class7.Class29(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00029958 File Offset: 0x00027B58
		private static Class7.Class18 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class7.Class18 @class = Class7.Class18.smethod_3(Class7.Class18.smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class7.Class19;
				}
			}
			return new Class7.Class30(object_0);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		private static Class7.Class19 smethod_3(Class7.Class18 class18_0)
		{
			Class7.Class19 @class = class18_0 as Class7.Class19;
			if (@class == null && class18_0.vmethod_0())
			{
				@class = (class18_0.vmethod_7() as Class7.Class19);
			}
			return @class;
		}

		// Token: 0x040004B8 RID: 1208
		internal Class7.Enum4 enum4_0;
	}

	// Token: 0x02000106 RID: 262
	private class Class30 : Class7.Class18
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x000062C8 File Offset: 0x000044C8
		public Class30() : this(null)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000062D2 File Offset: 0x000044D2
		internal override void vmethod_9(Class7.Class18 class18_1)
		{
			if (class18_1 is Class7.Class30)
			{
				this.class18_0 = ((Class7.Class30)class18_1).class18_0;
				this.type_0 = ((Class7.Class30)class18_1).type_0;
				return;
			}
			this.class18_0 = class18_1.vmethod_7();
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_1)
		{
			this.vmethod_9(class18_1);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000630B File Offset: 0x0000450B
		public Class30(object object_0) : base((Class7.Enum4)0)
		{
			this.class18_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00006323 File Offset: 0x00004523
		public Class30(object object_0, Type type_1) : base((Class7.Enum4)0)
		{
			this.class18_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000299B0 File Offset: 0x00027BB0
		public override string ToString()
		{
			if (this.class18_0 != null)
			{
				return this.class18_0.ToString();
			}
			return ((Class7.Enum5)5).ToString();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000299E4 File Offset: 0x00027BE4
		internal override object vmethod_4(Type type_1)
		{
			if (this.class18_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class18_0 is Class7.Class18))
			{
				object obj = this.class18_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (this.type_0 != null)
			{
				return ((Class7.Class18)this.class18_0).vmethod_4(this.type_0);
			}
			object obj2 = ((Class7.Class18)this.class18_0).vmethod_4(type_1);
			if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
			{
				if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
				{
					obj2 = ((FieldInfo)obj2).FieldHandle;
				}
				else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
				{
					obj2 = ((Type)obj2).TypeHandle;
				}
				else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
				{
					obj2 = ((MethodBase)obj2).MethodHandle;
				}
			}
			return obj2;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00029BD0 File Offset: 0x00027DD0
		internal override bool vmethod_5(Class7.Class18 class18_1)
		{
			if (class18_1.vmethod_0())
			{
				return ((Class7.Class24)class18_1).vmethod_5(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class18_1.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00029C08 File Offset: 0x00027E08
		internal override bool hvnLfEhAw6(Class7.Class18 class18_1)
		{
			if (!class18_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class18_1.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class7.Class24)class18_1).hvnLfEhAw6(this);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00029C44 File Offset: 0x00027E44
		internal override Class7.Class18 vmethod_7()
		{
			Class7.Class18 @class = this.class18_0 as Class7.Class18;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_7();
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00029C6C File Offset: 0x00027E6C
		internal override bool vmethod_6()
		{
			if (this.class18_0 != null)
			{
				Class7.Class18 @class = this.class18_0 as Class7.Class18;
				return @class == null || @class.vmethod_4(null) != null;
			}
			return false;
		}

		// Token: 0x040004B9 RID: 1209
		public Class7.Class18 class18_0;

		// Token: 0x040004BA RID: 1210
		public Type type_0;
	}

	// Token: 0x02000107 RID: 263
	private class Class31 : Class7.Class18
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x0000633B File Offset: 0x0000453B
		public Class31(string string_1) : base((Class7.Enum4)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000634C File Offset: 0x0000454C
		internal override void vmethod_9(Class7.Class18 class18_0)
		{
			this.string_0 = ((Class7.Class31)class18_0).string_0;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004B82 File Offset: 0x00002D82
		internal override void vmethod_2(Class7.Class18 class18_0)
		{
			this.vmethod_9(class18_0);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00029CA4 File Offset: 0x00027EA4
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class7.Enum5)5).ToString();
			}
			return '*'.ToString() + this.string_0 + '*'.ToString();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000635F File Offset: 0x0000455F
		internal override bool vmethod_6()
		{
			return this.string_0 != null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000636A File Offset: 0x0000456A
		internal override object vmethod_4(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00029CEC File Offset: 0x00027EEC
		internal override bool vmethod_5(Class7.Class18 class18_0)
		{
			if (class18_0.vmethod_0())
			{
				return ((Class7.Class24)class18_0).vmethod_5(this);
			}
			object obj = this.string_0;
			object obj2 = class18_0.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00029D24 File Offset: 0x00027F24
		internal override bool hvnLfEhAw6(Class7.Class18 class18_0)
		{
			if (!class18_0.vmethod_0())
			{
				object obj = this.string_0;
				object obj2 = class18_0.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class7.Class24)class18_0).hvnLfEhAw6(this);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00005020 File Offset: 0x00003220
		internal override Class7.Class18 vmethod_7()
		{
			return this;
		}

		// Token: 0x040004BB RID: 1211
		public string string_0;
	}

	// Token: 0x02000108 RID: 264
	internal class Class32
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x00006372 File Offset: 0x00004572
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000637F File Offset: 0x0000457F
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000638C File Offset: 0x0000458C
		public void method_2(Class7.Class18 class18_0)
		{
			this.list_0.Add(class18_0);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000639A File Offset: 0x0000459A
		public Class7.Class18 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000063B4 File Offset: 0x000045B4
		public Class7.Class18 method_4()
		{
			Class7.Class18 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x040004BC RID: 1212
		private List<Class7.Class18> list_0 = new List<Class7.Class18>();
	}

	// Token: 0x02000109 RID: 265
	internal enum Enum5
	{

	}

	// Token: 0x0200010A RID: 266
	[CompilerGenerated]
	[Serializable]
	private sealed class Class33<T>
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x0000624B File Offset: 0x0000444B
		internal int method_0(Class7.Class11 x, Class7.Class11 y)
		{
			return x.class12_0.int_0.CompareTo(y.class12_0.int_0);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00006402 File Offset: 0x00004602
		internal static bool smethod_0()
		{
			return Class7.Class33<T>.object_0 == null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000640C File Offset: 0x0000460C
		internal static object smethod_1()
		{
			return Class7.Class33<T>.object_0;
		}

		// Token: 0x040004BE RID: 1214
		public static readonly Class7.Class33<T> <>9 = new Class7.Class33<T>();

		// Token: 0x040004BF RID: 1215
		public static Comparison<Class7.Class11> <>9__45_0;

		// Token: 0x040004C0 RID: 1216
		private static object object_0;
	}
}
