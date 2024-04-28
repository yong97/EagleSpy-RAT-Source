// Token: 0x0200008A RID: 138
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Keylogger : global::System.Windows.Forms.Form
{
	// Token: 0x0600063D RID: 1597 RVA: 0x0009FA28 File Offset: 0x0009DC28
	[global::System.Diagnostics.DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0009FA6C File Offset: 0x0009DC6C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.DGV0 = new global::System.Windows.Forms.DataGridView();
		this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.loadinglogs = new global::DrakeUI.Framework.DrakeUILoadingBar();
		this.deleteallbtn = new global::System.Windows.Forms.Button();
		this.backallbtn = new global::System.Windows.Forms.Button();
		this.delbtn = new global::System.Windows.Forms.Button();
		this.savedbtn = new global::System.Windows.Forms.Button();
		this.getbtn = new global::System.Windows.Forms.Button();
		this.combologs = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.Button2 = new global::System.Windows.Forms.Button();
		this.keytabs = new global::DrakeUI.Framework.DrakeUITabControl();
		this.TabPage3 = new global::System.Windows.Forms.TabPage();
		this.TabPage4 = new global::System.Windows.Forms.TabPage();
		this.offlinetext = new global::System.Windows.Forms.RichTextBox();
		this.Panel3 = new global::System.Windows.Forms.Panel();
		this.button1 = new global::System.Windows.Forms.Button();
		this.clearsrchbtn = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.searchtext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.searchbtn = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.clinameinfo = new global::System.Windows.Forms.Label();
		this.exitbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.ClientPic = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxMenu.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.keytabs.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.TabPage4.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.Panel2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		base.SuspendLayout();
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
		this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.Font = new global::System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.Column1,
			this.Column6,
			this.Column3,
			this.Column2
		});
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.Red;
		this.DGV0.Location = new global::System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(856, 626);
		this.DGV0.TabIndex = 4;
		this.Column1.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		this.Column1.HeaderText = "Status";
		this.Column1.Name = "Column1";
		this.Column6.HeaderText = "App Name";
		this.Column6.Name = "Column6";
		this.Column3.FillWeight = 250f;
		this.Column3.HeaderText = "Text";
		this.Column3.Name = "Column3";
		this.Column2.FillWeight = 1f;
		this.Column2.HeaderText = "";
		this.Column2.ImageLayout = global::System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.Column2.MinimumWidth = 2;
		this.Column2.Name = "Column2";
		this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.ctxMenu.ImageScalingSize = new global::System.Drawing.Size(20, 20);
		this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.SaveToolStripMenuItem,
			this.SaveAsToolStripMenuItem
		});
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new global::System.Drawing.Size(90, 48);
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
		this.Panel1.Controls.Add(this.loadinglogs);
		this.Panel1.Controls.Add(this.deleteallbtn);
		this.Panel1.Controls.Add(this.backallbtn);
		this.Panel1.Controls.Add(this.delbtn);
		this.Panel1.Controls.Add(this.savedbtn);
		this.Panel1.Controls.Add(this.getbtn);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new global::System.Drawing.Point(0, 616);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(856, 10);
		this.Panel1.TabIndex = 3;
		this.Panel1.Visible = false;
		this.loadinglogs.BackColor = global::System.Drawing.Color.Transparent;
		this.loadinglogs.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.loadinglogs.Enabled = false;
		this.loadinglogs.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.loadinglogs.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.loadinglogs.Location = new global::System.Drawing.Point(623, 0);
		this.loadinglogs.Name = "loadinglogs";
		this.loadinglogs.Size = new global::System.Drawing.Size(30, 10);
		this.loadinglogs.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.loadinglogs.StyleCustomMode = true;
		this.loadinglogs.TabIndex = 4;
		this.loadinglogs.Text = "DrakeUILoadingBar1";
		this.loadinglogs.Visible = false;
		this.deleteallbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.deleteallbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.deleteallbtn.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.deleteallbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.deleteallbtn.Location = new global::System.Drawing.Point(653, 0);
		this.deleteallbtn.Name = "deleteallbtn";
		this.deleteallbtn.Size = new global::System.Drawing.Size(74, 10);
		this.deleteallbtn.TabIndex = 8;
		this.deleteallbtn.Text = "Delete all";
		this.deleteallbtn.UseVisualStyleBackColor = true;
		this.deleteallbtn.Visible = false;
		this.deleteallbtn.Click += new global::System.EventHandler(this.Button3_Click_1);
		this.backallbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.backallbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.backallbtn.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.backallbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.backallbtn.Location = new global::System.Drawing.Point(727, 0);
		this.backallbtn.Name = "backallbtn";
		this.backallbtn.Size = new global::System.Drawing.Size(74, 10);
		this.backallbtn.TabIndex = 7;
		this.backallbtn.Text = "Backup all";
		this.backallbtn.UseVisualStyleBackColor = true;
		this.backallbtn.Click += new global::System.EventHandler(this.Backallbtn_Click);
		this.delbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.delbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.delbtn.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.delbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.delbtn.Location = new global::System.Drawing.Point(86, 0);
		this.delbtn.Name = "delbtn";
		this.delbtn.Size = new global::System.Drawing.Size(94, 10);
		this.delbtn.TabIndex = 6;
		this.delbtn.Text = "Delete Selected";
		this.delbtn.UseVisualStyleBackColor = true;
		this.delbtn.Visible = false;
		this.delbtn.Click += new global::System.EventHandler(this.Delbtn_Click);
		this.savedbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.savedbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.savedbtn.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.savedbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savedbtn.Location = new global::System.Drawing.Point(801, 0);
		this.savedbtn.Name = "savedbtn";
		this.savedbtn.Size = new global::System.Drawing.Size(55, 10);
		this.savedbtn.TabIndex = 5;
		this.savedbtn.Text = "Saved";
		this.savedbtn.UseVisualStyleBackColor = true;
		this.savedbtn.Click += new global::System.EventHandler(this.Button3_Click);
		this.getbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.getbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.getbtn.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.getbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.getbtn.Location = new global::System.Drawing.Point(0, 0);
		this.getbtn.Name = "getbtn";
		this.getbtn.Size = new global::System.Drawing.Size(86, 10);
		this.getbtn.TabIndex = 0;
		this.getbtn.Text = "Get Selected";
		this.getbtn.UseVisualStyleBackColor = true;
		this.getbtn.Click += new global::System.EventHandler(this.getbtn_click);
		this.combologs.AllowDrop = true;
		this.combologs.BackColor = global::System.Drawing.Color.Transparent;
		this.combologs.CausesValidation = false;
		this.combologs.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.combologs.FillColor = global::System.Drawing.Color.FromArgb(64, 0, 0);
		this.combologs.Font = new global::System.Drawing.Font("Calibri", 11f);
		this.combologs.FormattingEnabled = true;
		this.combologs.ItemHeight = 20;
		this.combologs.Location = new global::System.Drawing.Point(135, 4);
		this.combologs.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.combologs.MaxDropDownItems = 100000;
		this.combologs.MinimumSize = new global::System.Drawing.Size(47, 0);
		this.combologs.Name = "combologs";
		this.combologs.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
		this.combologs.RectColor = global::System.Drawing.Color.FromArgb(230, 80, 80);
		this.combologs.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.combologs.Size = new global::System.Drawing.Size(360, 25);
		this.combologs.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.combologs.TabIndex = 2;
		this.combologs.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = global::System.Drawing.Color.Cyan;
		this.Button2.Location = new global::System.Drawing.Point(612, 154);
		this.Button2.Name = "Button2";
		this.Button2.Size = new global::System.Drawing.Size(127, 26);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "Delete log";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Visible = false;
		this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
		this.keytabs.Controls.Add(this.TabPage3);
		this.keytabs.Controls.Add(this.TabPage4);
		this.keytabs.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.keytabs.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.keytabs.FillColor = global::System.Drawing.Color.Black;
		this.keytabs.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.keytabs.ItemSize = new global::System.Drawing.Size(470, 40);
		this.keytabs.Location = new global::System.Drawing.Point(0, 32);
		this.keytabs.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
		this.keytabs.Name = "keytabs";
		this.keytabs.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
		this.keytabs.SelectedIndex = 0;
		this.keytabs.Size = new global::System.Drawing.Size(856, 666);
		this.keytabs.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
		this.keytabs.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.keytabs.StyleCustomMode = true;
		this.keytabs.TabBackColor = global::System.Drawing.Color.Black;
		this.keytabs.TabIndex = 4;
		this.keytabs.TabSelectedColor = global::System.Drawing.Color.Black;
		this.keytabs.TabSelectedForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.keytabs.TabSelectedHighColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.keytabs.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage3.BackColor = global::System.Drawing.Color.Black;
		this.TabPage3.Controls.Add(this.DGV0);
		this.TabPage3.Location = new global::System.Drawing.Point(0, 40);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new global::System.Drawing.Size(856, 626);
		this.TabPage3.TabIndex = 0;
		this.TabPage3.Text = "Online Keylogger";
		this.TabPage4.BackColor = global::System.Drawing.Color.Black;
		this.TabPage4.Controls.Add(this.offlinetext);
		this.TabPage4.Controls.Add(this.Panel3);
		this.TabPage4.Controls.Add(this.Panel1);
		this.TabPage4.Controls.Add(this.Button2);
		this.TabPage4.Location = new global::System.Drawing.Point(0, 40);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Size = new global::System.Drawing.Size(856, 626);
		this.TabPage4.TabIndex = 1;
		this.TabPage4.Text = "Offline Keylogger";
		this.offlinetext.BackColor = global::System.Drawing.Color.Black;
		this.offlinetext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.offlinetext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.offlinetext.ForeColor = global::System.Drawing.Color.Lime;
		this.offlinetext.Location = new global::System.Drawing.Point(0, 32);
		this.offlinetext.Margin = new global::System.Windows.Forms.Padding(2);
		this.offlinetext.Name = "offlinetext";
		this.offlinetext.ReadOnly = true;
		this.offlinetext.Size = new global::System.Drawing.Size(856, 584);
		this.offlinetext.TabIndex = 5;
		this.offlinetext.Text = "";
		this.Panel3.Controls.Add(this.button1);
		this.Panel3.Controls.Add(this.clearsrchbtn);
		this.Panel3.Controls.Add(this.searchtext);
		this.Panel3.Controls.Add(this.searchbtn);
		this.Panel3.Controls.Add(this.combologs);
		this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel3.Location = new global::System.Drawing.Point(0, 0);
		this.Panel3.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new global::System.Drawing.Size(856, 32);
		this.Panel3.TabIndex = 4;
		this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.button1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.button1.Location = new global::System.Drawing.Point(54, 2);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(65, 28);
		this.button1.TabIndex = 40;
		this.button1.Text = "GET";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.clearsrchbtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.clearsrchbtn.AvatarSize = 25;
		this.clearsrchbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.clearsrchbtn.FillColor = global::System.Drawing.Color.Black;
		this.clearsrchbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.clearsrchbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clearsrchbtn.Location = new global::System.Drawing.Point(824, 7);
		this.clearsrchbtn.Name = "clearsrchbtn";
		this.clearsrchbtn.Size = new global::System.Drawing.Size(20, 21);
		this.clearsrchbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.clearsrchbtn.StyleCustomMode = true;
		this.clearsrchbtn.Symbol = 77;
		this.clearsrchbtn.SymbolSize = 30;
		this.clearsrchbtn.TabIndex = 39;
		this.clearsrchbtn.Visible = false;
		this.clearsrchbtn.Click += new global::System.EventHandler(this.Clearsrchbtn_Click);
		this.searchtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.searchtext.FillColor = global::System.Drawing.Color.Black;
		this.searchtext.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.searchtext.ForeColor = global::System.Drawing.Color.White;
		this.searchtext.Location = new global::System.Drawing.Point(570, 7);
		this.searchtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.searchtext.Maximum = 2147483647.0;
		this.searchtext.Minimum = -2147483648.0;
		this.searchtext.Name = "searchtext";
		this.searchtext.Padding = new global::System.Windows.Forms.Padding(5);
		this.searchtext.Radius = 15;
		this.searchtext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.searchtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.searchtext.Size = new global::System.Drawing.Size(249, 22);
		this.searchtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.searchtext.StyleCustomMode = true;
		this.searchtext.TabIndex = 37;
		this.searchtext.Watermark = "Search offline keyloger";
		this.searchtext.TextChanged += new global::System.EventHandler(this.Searchtext_TextChanged);
		this.searchbtn.AvatarSize = 25;
		this.searchbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.searchbtn.FillColor = global::System.Drawing.Color.Black;
		this.searchbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.searchbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.searchbtn.Location = new global::System.Drawing.Point(538, 3);
		this.searchbtn.Name = "searchbtn";
		this.searchbtn.Size = new global::System.Drawing.Size(25, 26);
		this.searchbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.searchbtn.StyleCustomMode = true;
		this.searchbtn.Symbol = 85;
		this.searchbtn.SymbolSize = 30;
		this.searchbtn.TabIndex = 38;
		this.searchbtn.Click += new global::System.EventHandler(this.Searchbtn_Click);
		this.Panel2.BackColor = global::System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clinameinfo);
		this.Panel2.Controls.Add(this.exitbtn);
		this.Panel2.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel2.Controls.Add(this.ClientPic);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel2.ForeColor = global::System.Drawing.Color.Red;
		this.Panel2.Location = new global::System.Drawing.Point(0, 0);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(856, 32);
		this.Panel2.TabIndex = 5;
		this.clinameinfo.BackColor = global::System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = global::System.Drawing.Color.Lime;
		this.clinameinfo.Location = new global::System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new global::System.Drawing.Size(684, 32);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.exitbtn.BackColor = global::System.Drawing.Color.Transparent;
		this.exitbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.exitbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.exitbtn.FillColor = global::System.Drawing.Color.Transparent;
		this.exitbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.exitbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.exitbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.exitbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.exitbtn.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.exitbtn.ForePressColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.exitbtn.Location = new global::System.Drawing.Point(716, 0);
		this.exitbtn.Name = "exitbtn";
		this.exitbtn.Radius = 10;
		this.exitbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.exitbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.exitbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.exitbtn.RectPressColor = global::System.Drawing.Color.White;
		this.exitbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.exitbtn.Size = new global::System.Drawing.Size(70, 32);
		this.exitbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.exitbtn.SymbolSize = 0;
		this.exitbtn.TabIndex = 49;
		this.exitbtn.Text = "Stop";
		this.exitbtn.Visible = false;
		this.exitbtn.Click += new global::System.EventHandler(this.Exitbtn_Click);
		this.DrakeUIButtonIcon1.BackColor = global::System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Transparent;
		this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(786, 0);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 10;
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(70, 32);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.SymbolSize = 0;
		this.DrakeUIButtonIcon1.TabIndex = 50;
		this.DrakeUIButtonIcon1.Text = "Start";
		this.DrakeUIButtonIcon1.Visible = false;
		this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
		this.ClientPic.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new global::System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new global::System.Drawing.Size(32, 32);
		this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(856, 698);
		base.Controls.Add(this.keytabs);
		base.Controls.Add(this.Panel2);
		this.MaximumSize = new global::System.Drawing.Size(872, 737);
		this.MinimumSize = new global::System.Drawing.Size(872, 737);
		base.Name = "Keylogger";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Keylogger";
		base.Load += new global::System.EventHandler(this.Keylogger_Load);
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxMenu.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.keytabs.ResumeLayout(false);
		this.TabPage3.ResumeLayout(false);
		this.TabPage4.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x0400090C RID: 2316
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000925 RID: 2341
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000926 RID: 2342
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DGV0")]
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x04000927 RID: 2343
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
	internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

	// Token: 0x04000928 RID: 2344
	internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

	// Token: 0x04000929 RID: 2345
	internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

	// Token: 0x0400092A RID: 2346
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("combologs")]
	internal global::DrakeUI.Framework.DrakeUIComboBox combologs;

	// Token: 0x0400092B RID: 2347
	internal global::System.Windows.Forms.Button getbtn;

	// Token: 0x0400092C RID: 2348
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x0400092D RID: 2349
	internal global::System.Windows.Forms.Button Button2;

	// Token: 0x0400092E RID: 2350
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("keytabs")]
	internal global::DrakeUI.Framework.DrakeUITabControl keytabs;

	// Token: 0x0400092F RID: 2351
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage3")]
	internal global::System.Windows.Forms.TabPage TabPage3;

	// Token: 0x04000930 RID: 2352
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage4")]
	internal global::System.Windows.Forms.TabPage TabPage4;

	// Token: 0x04000931 RID: 2353
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("loadinglogs")]
	internal global::DrakeUI.Framework.DrakeUILoadingBar loadinglogs;

	// Token: 0x04000932 RID: 2354
	internal global::System.Windows.Forms.Button savedbtn;

	// Token: 0x04000933 RID: 2355
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

	// Token: 0x04000934 RID: 2356
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

	// Token: 0x04000935 RID: 2357
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column3")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;

	// Token: 0x04000936 RID: 2358
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
	internal global::System.Windows.Forms.DataGridViewImageColumn Column2;

	// Token: 0x04000937 RID: 2359
	internal global::System.Windows.Forms.Button delbtn;

	// Token: 0x04000938 RID: 2360
	internal global::System.Windows.Forms.Button deleteallbtn;

	// Token: 0x04000939 RID: 2361
	internal global::System.Windows.Forms.Button backallbtn;

	// Token: 0x0400093A RID: 2362
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x0400093B RID: 2363
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
	internal global::System.Windows.Forms.PictureBox ClientPic;

	// Token: 0x0400093C RID: 2364
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
	internal global::System.Windows.Forms.Label clinameinfo;

	// Token: 0x0400093D RID: 2365
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel3")]
	internal global::System.Windows.Forms.Panel Panel3;

	// Token: 0x0400093E RID: 2366
	internal global::DrakeUI.Framework.DrakeUIAvatar clearsrchbtn;

	// Token: 0x0400093F RID: 2367
	internal global::DrakeUI.Framework.DrakeUITextBox searchtext;

	// Token: 0x04000940 RID: 2368
	internal global::DrakeUI.Framework.DrakeUIAvatar searchbtn;

	// Token: 0x04000941 RID: 2369
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("offlinetext")]
	internal global::System.Windows.Forms.RichTextBox offlinetext;

	// Token: 0x04000942 RID: 2370
	internal global::DrakeUI.Framework.DrakeUIButtonIcon exitbtn;

	// Token: 0x04000943 RID: 2371
	internal global::System.Windows.Forms.Button button1;

	// Token: 0x04000944 RID: 2372
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;
}
