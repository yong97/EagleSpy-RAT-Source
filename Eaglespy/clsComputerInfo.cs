using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000044 RID: 68
public class clsComputerInfo
{
	// Token: 0x060002F9 RID: 761 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
	public static string GetSerialNumber()
	{
		SelectQuery query = new SelectQuery("Win32_BaseBoard");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		string result = null;
		using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)enumerator.Current;
				result = managementObject["SerialNumber"].ToString();
				return result;
			}
		}
		return result;
	}

	// Token: 0x060002FA RID: 762 RVA: 0x0004E160 File Offset: 0x0004C360
	public static string GetProcessorID()
	{
		SelectQuery query = new SelectQuery("Win32_processor");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		string result = null;
		using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				ManagementObject managementObject = (ManagementObject)enumerator.Current;
				result = managementObject["processorId"].ToString();
				return result;
			}
		}
		return result;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0004E1DC File Offset: 0x0004C3DC
	public static string GenerateHash(string input)
	{
		byte[] source = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input + clsComputerInfo.GetVolumeSerial("C")));
		return string.Concat(from b in source
		select b.ToString("x2"));
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0004E23C File Offset: 0x0004C43C
	internal static string GetVolumeSerial(string strDriveLetter = "C")
	{
		ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");
		managementObject.Get();
		return managementObject["VolumeSerialNumber"].ToString();
	}
}
