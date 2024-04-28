using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

// Token: 0x020000A9 RID: 169
[StandardModule]
internal sealed class RegistryHandler
{
	// Token: 0x06000716 RID: 1814 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
	public static void iniliz()
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			try
			{
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey(RegistryHandler.mainpath);
				}
			}
			catch (Exception)
			{
			}
			registryKey2.Close();
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x000AE358 File Offset: 0x000AC558
	public static string Get_EMAIL()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("EmailV6"));
					if (objectValue != null)
					{
						return Codes.AES_Decrypt(registryKey2.GetValue("EmailV6").ToString(), "W3Ndxet0sdZYtqykGiGCeiIMDoF");
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x000AE404 File Offset: 0x000AC604
	public static void Set_EMAIL(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			RegistryHandler.Set_OldEmail(key);
			registryKey2.SetValue("EmailV6", Codes.Encrypt(key, "W3Ndxet0sdZYtqykGiGCeiIMDoF"));
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x000AE468 File Offset: 0x000AC668
	public static void Set_OldEmail(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("Email", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x000AE4BC File Offset: 0x000AC6BC
	public static string getworning()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("wrn"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("wrn").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x000AE55C File Offset: 0x000AC75C
	public static void setworning(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("wrn", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x000AE5B0 File Offset: 0x000AC7B0
	public static string getwtipanti()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("tipanti"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("tipanti").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x000AE650 File Offset: 0x000AC850
	public static void settipanti(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("tipanti", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x000AE6A4 File Offset: 0x000AC8A4
	public static string Get_ID_ASSIST()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("ID"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("ID").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x000AE744 File Offset: 0x000AC944
	public static void Set_ID_ASSIST(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("ID", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x000AE798 File Offset: 0x000AC998
	public static string GET_FTtip()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("TipFT"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("TipFT").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x000AE838 File Offset: 0x000ACA38
	public static void Set_FTtip(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("TipFT", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x000AE88C File Offset: 0x000ACA8C
	public static string Get_Language()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("UserLanguage"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("UserLanguage").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x000AE92C File Offset: 0x000ACB2C
	public static void Set_Language(string key)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue("UserLanguage", key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x000AE980 File Offset: 0x000ACB80
	public static string GET_Tip(string id)
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(id));
					if (objectValue != null)
					{
						return registryKey2.GetValue(id).ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x000AEA18 File Offset: 0x000ACC18
	public static void SET_Tip(string key, string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue(id, key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x000AEA68 File Offset: 0x000ACC68
	public static string GET_SoundID()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(RegistryHandler.Selectedsound));
					if (objectValue != null)
					{
						return registryKey2.GetValue(RegistryHandler.Selectedsound).ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000AEA18 File Offset: 0x000ACC18
	public static void SET_qulity(string key, string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue(id, key);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x000AEB08 File Offset: 0x000ACD08
	public static string GET_qulity()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(RegistryHandler.Selectedqulity));
					if (objectValue != null)
					{
						return registryKey2.GetValue(RegistryHandler.Selectedqulity).ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
	public static void SET_SoundID(string id)
	{
		try
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
			registryKey2.SetValue(RegistryHandler.Selectedsound, id);
			registryKey2.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x000AEBFC File Offset: 0x000ACDFC
	public static string passkey()
	{
		try
		{
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("SK"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("SK").ToString();
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000AECA0 File Offset: 0x000ACEA0
	public static void SetUserHandleLimit()
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, true);
			registryKey.SetValue("USERProcessHandleQuota", 18000, RegistryValueKind.DWord);
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x04000A74 RID: 2676
	private static string mainpath = "Software\\\\EagleSpy";

	// Token: 0x04000A75 RID: 2677
	public static string ShowScrenShotTip = "STIP";

	// Token: 0x04000A76 RID: 2678
	public static string ShowScrenReadTip = "SRETIP";

	// Token: 0x04000A77 RID: 2679
	public static string Selectedsound = "SOUND";

	// Token: 0x04000A78 RID: 2680
	public static string Selectedqulity = "Quality";
}
