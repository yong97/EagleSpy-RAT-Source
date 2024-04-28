using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200001D RID: 29
public static class encryption
{
	// Token: 0x0600014F RID: 335 RVA: 0x0000C34C File Offset: 0x0000A54C
	public static string HashHMAC(string enckey, string resp)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(enckey);
		byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
		HMACSHA256 hmacsha = new HMACSHA256(bytes);
		return encryption.byte_arr_to_str(hmacsha.ComputeHash(bytes2));
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000C388 File Offset: 0x0000A588
	public static string byte_arr_to_str(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
	public static byte[] str_to_byte_arr(string hex)
	{
		byte[] result;
		try
		{
			int length = hex.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			result = array;
		}
		catch
		{
			Environment.Exit(0);
			result = null;
		}
		return result;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000C434 File Offset: 0x0000A634
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool CheckStringsFixedTime(string str1, string str2)
	{
		bool result;
		if (str1.Length != str2.Length)
		{
			result = false;
		}
		else
		{
			int num = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				num |= (int)(str1[i] ^ str2[i]);
			}
			result = (num == 0);
		}
		return result;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000C488 File Offset: 0x0000A688
	public static string iv_key()
	{
		return Guid.NewGuid().ToString().Substring(0, 16);
	}
}
