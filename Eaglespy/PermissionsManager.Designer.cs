// Token: 0x0200009E RID: 158
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class PermissionsManager : global::System.Windows.Forms.Form
{
	// Token: 0x060006C5 RID: 1733 RVA: 0x000A9124 File Offset: 0x000A7324
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

	// Token: 0x060006C6 RID: 1734 RVA: 0x000A9168 File Offset: 0x000A7368
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DrakeUITabControl1 = new global::DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new global::System.Windows.Forms.TabPage();
		this.DGVPRIM = new global::System.Windows.Forms.DataGridView();
		this.iconprim = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.primname = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Status = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.TabPage2 = new global::System.Windows.Forms.TabPage();
		this.Button1 = new global::System.Windows.Forms.Button();
		this.Button2 = new global::System.Windows.Forms.Button();
		this.Primslist = new global::DrakeUI.Framework.DrakeUIListBox();
		this.addactiv = new global::System.Windows.Forms.Button();
		this.comboproms = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.checkinstall = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.Label6 = new global::System.Windows.Forms.Label();
		this.checkbattery = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.checkdraw = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.checkacess = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.Label3 = new global::System.Windows.Forms.Label();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.TabPage3 = new global::System.Windows.Forms.TabPage();
		this.Checkbg = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.checkautostart = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.Label5 = new global::System.Windows.Forms.Label();
		this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
		this.Label4 = new global::System.Windows.Forms.Label();
		this.TextBox1 = new global::System.Windows.Forms.TextBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.statustext = new global::System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Panel3 = new global::System.Windows.Forms.Panel();
		this.clinameinfo = new global::System.Windows.Forms.Label();
		this.ClientPic = new global::System.Windows.Forms.PictureBox();
		this.DrakeUITabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.DGVPRIM).BeginInit();
		this.TabPage2.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.TabPage3.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		base.SuspendLayout();
		this.DrakeUITabControl1.Controls.Add(this.TabPage1);
		this.DrakeUITabControl1.Controls.Add(this.TabPage2);
		this.DrakeUITabControl1.Controls.Add(this.TabPage3);
		this.DrakeUITabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DrakeUITabControl1.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.DrakeUITabControl1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUITabControl1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUITabControl1.ItemSize = new global::System.Drawing.Size(250, 40);
		this.DrakeUITabControl1.Location = new global::System.Drawing.Point(0, 32);
		this.DrakeUITabControl1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.DrakeUITabControl1.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
		this.DrakeUITabControl1.Name = "DrakeUITabControl1";
		this.DrakeUITabControl1.SelectedIndex = 0;
		this.DrakeUITabControl1.Size = new global::System.Drawing.Size(700, 431);
		this.DrakeUITabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
		this.DrakeUITabControl1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUITabControl1.TabBackColor = global::System.Drawing.Color.Black;
		this.DrakeUITabControl1.TabIndex = 0;
		this.DrakeUITabControl1.TabSelectedColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.DrakeUITabControl1.TabSelectedForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUITabControl1.TabSelectedHighColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUITabControl1.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage1.BackColor = global::System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.DGVPRIM);
		this.TabPage1.Controls.Add(this.DrakeUIButtonIcon3);
		this.TabPage1.Location = new global::System.Drawing.Point(0, 40);
		this.TabPage1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new global::System.Drawing.Size(700, 391);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Manage";
		this.DGVPRIM.AllowUserToAddRows = false;
		this.DGVPRIM.AllowUserToDeleteRows = false;
		this.DGVPRIM.AllowUserToResizeColumns = false;
		this.DGVPRIM.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Black;
		this.DGVPRIM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVPRIM.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVPRIM.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVPRIM.BackgroundColor = global::System.Drawing.Color.Black;
		this.DGVPRIM.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGVPRIM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVPRIM.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVPRIM.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.iconprim,
			this.primname,
			this.Status
		});
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGVPRIM.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVPRIM.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGVPRIM.EnableHeadersVisualStyles = false;
		this.DGVPRIM.GridColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DGVPRIM.Location = new global::System.Drawing.Point(0, 54);
		this.DGVPRIM.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.DGVPRIM.Name = "DGVPRIM";
		dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Calibri", 12f);
		dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGVPRIM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVPRIM.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
		this.DGVPRIM.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVPRIM.RowTemplate.Height = 24;
		this.DGVPRIM.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVPRIM.ShowCellErrors = false;
		this.DGVPRIM.ShowEditingIcon = false;
		this.DGVPRIM.ShowRowErrors = false;
		this.DGVPRIM.Size = new global::System.Drawing.Size(700, 337);
		this.DGVPRIM.TabIndex = 0;
		this.iconprim.FillWeight = 20f;
		this.iconprim.HeaderText = " ";
		this.iconprim.Name = "iconprim";
		this.primname.FillWeight = 73.85786f;
		this.primname.HeaderText = "Permission";
		this.primname.Name = "primname";
		this.Status.FillWeight = 45f;
		this.Status.HeaderText = "isActive";
		this.Status.Name = "Status";
		this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(0, 0);
		this.DrakeUIButtonIcon3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(700, 54);
		this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61473;
		this.DrakeUIButtonIcon3.TabIndex = 34;
		this.DrakeUIButtonIcon3.Text = "Refresh";
		this.DrakeUIButtonIcon3.Click += new global::System.EventHandler(this.DrakeUIButtonIcon3_Click);
		this.TabPage2.BackColor = global::System.Drawing.Color.Black;
		this.TabPage2.Controls.Add(this.Button1);
		this.TabPage2.Controls.Add(this.Button2);
		this.TabPage2.Controls.Add(this.Primslist);
		this.TabPage2.Controls.Add(this.addactiv);
		this.TabPage2.Controls.Add(this.comboproms);
		this.TabPage2.Controls.Add(this.Panel1);
		this.TabPage2.Location = new global::System.Drawing.Point(0, 40);
		this.TabPage2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new global::System.Drawing.Size(700, 391);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Request";
		this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Button1.Location = new global::System.Drawing.Point(532, 324);
		this.Button1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Button1.Name = "Button1";
		this.Button1.Size = new global::System.Drawing.Size(128, 34);
		this.Button1.TabIndex = 30;
		this.Button1.Text = "Request Now";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
		this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Button2.Location = new global::System.Drawing.Point(612, 120);
		this.Button2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Button2.Name = "Button2";
		this.Button2.Size = new global::System.Drawing.Size(49, 28);
		this.Button2.TabIndex = 31;
		this.Button2.Text = "-";
		this.DrakeUIToolTip1.SetToolTip(this.Button2, "REMOVE");
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
		this.Primslist.BackColor = global::System.Drawing.Color.Black;
		this.Primslist.FillColor = global::System.Drawing.Color.Black;
		this.Primslist.FillDisableColor = global::System.Drawing.Color.Black;
		this.Primslist.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Primslist.ForeColor = global::System.Drawing.Color.White;
		this.Primslist.HoverColor = global::System.Drawing.Color.Silver;
		this.Primslist.ItemSelectBackColor = global::System.Drawing.Color.FromArgb(140, 140, 140);
		this.Primslist.ItemSelectForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Primslist.Location = new global::System.Drawing.Point(35, 156);
		this.Primslist.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Primslist.Name = "Primslist";
		this.Primslist.Padding = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
		this.Primslist.Radius = 15;
		this.Primslist.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Primslist.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Primslist.Size = new global::System.Drawing.Size(625, 162);
		this.Primslist.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.Primslist.StyleCustomMode = true;
		this.Primslist.TabIndex = 29;
		this.Primslist.Text = "DrakeUIListBox1";
		this.addactiv.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.addactiv.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.addactiv.Location = new global::System.Drawing.Point(549, 120);
		this.addactiv.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.addactiv.Name = "addactiv";
		this.addactiv.Size = new global::System.Drawing.Size(49, 28);
		this.addactiv.TabIndex = 28;
		this.addactiv.Text = "+";
		this.DrakeUIToolTip1.SetToolTip(this.addactiv, "ADD");
		this.addactiv.UseVisualStyleBackColor = true;
		this.addactiv.Click += new global::System.EventHandler(this.Addactiv_Click);
		this.comboproms.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comboproms.FillColor = global::System.Drawing.Color.White;
		this.comboproms.Font = new global::System.Drawing.Font("Calibri", 14f);
		this.comboproms.Items.AddRange(new object[]
		{
			"Send SMS",
			"Record Calls",
			"Change Wallpaper",
			"Read SMS",
			"Read Call Logs",
			"Read Contacts",
			"Read Accounts",
			"Camera",
			"Microphone",
			"Location",
			"Make Calls"
		});
		this.comboproms.Location = new global::System.Drawing.Point(35, 120);
		this.comboproms.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.comboproms.MinimumSize = new global::System.Drawing.Size(47, 0);
		this.comboproms.Name = "comboproms";
		this.comboproms.Padding = new global::System.Windows.Forms.Padding(0, 0, 22, 0);
		this.comboproms.RectColor = global::System.Drawing.Color.FromArgb(56, 142, 60);
		this.comboproms.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.comboproms.Size = new global::System.Drawing.Size(500, 30);
		this.comboproms.Style = global::DrakeUI.Framework.UIStyle.Green;
		this.comboproms.TabIndex = 27;
		this.comboproms.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.Panel1.Controls.Add(this.checkinstall);
		this.Panel1.Controls.Add(this.Label6);
		this.Panel1.Controls.Add(this.checkbattery);
		this.Panel1.Controls.Add(this.checkdraw);
		this.Panel1.Controls.Add(this.checkacess);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(700, 97);
		this.Panel1.TabIndex = 0;
		this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
		this.checkinstall.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkinstall.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkinstall.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkinstall.Location = new global::System.Drawing.Point(22, 63);
		this.checkinstall.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.checkinstall.Name = "checkinstall";
		this.checkinstall.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkinstall.Size = new global::System.Drawing.Size(32, 24);
		this.checkinstall.TabIndex = 17;
		this.checkinstall.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.DrakeUICheckBox1_MouseClick);
		this.Label6.AutoSize = true;
		this.Label6.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label6.ForeColor = global::System.Drawing.Color.White;
		this.Label6.Location = new global::System.Drawing.Point(58, 65);
		this.Label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new global::System.Drawing.Size(85, 19);
		this.Label6.TabIndex = 16;
		this.Label6.Text = "Install Apps";
		this.checkbattery.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkbattery.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkbattery.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkbattery.Location = new global::System.Drawing.Point(531, 28);
		this.checkbattery.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.checkbattery.Name = "checkbattery";
		this.checkbattery.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkbattery.Size = new global::System.Drawing.Size(32, 24);
		this.checkbattery.TabIndex = 15;
		this.checkbattery.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.checkbattery_MouseClick);
		this.checkdraw.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkdraw.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkdraw.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkdraw.Location = new global::System.Drawing.Point(286, 28);
		this.checkdraw.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.checkdraw.Name = "checkdraw";
		this.checkdraw.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkdraw.Size = new global::System.Drawing.Size(32, 24);
		this.checkdraw.TabIndex = 14;
		this.checkdraw.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkdraw_MouseClick);
		this.checkacess.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkacess.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkacess.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkacess.Location = new global::System.Drawing.Point(22, 28);
		this.checkacess.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.checkacess.Name = "checkacess";
		this.checkacess.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkacess.Size = new global::System.Drawing.Size(32, 24);
		this.checkacess.TabIndex = 13;
		this.checkacess.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkacess_MouseClick);
		this.Label3.AutoSize = true;
		this.Label3.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label3.ForeColor = global::System.Drawing.Color.White;
		this.Label3.Location = new global::System.Drawing.Point(568, 28);
		this.Label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new global::System.Drawing.Size(127, 19);
		this.Label3.TabIndex = 12;
		this.Label3.Text = "Battery optimizing";
		this.Label2.AutoSize = true;
		this.Label2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label2.ForeColor = global::System.Drawing.Color.White;
		this.Label2.Location = new global::System.Drawing.Point(316, 28);
		this.Label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(131, 19);
		this.Label2.TabIndex = 9;
		this.Label2.Text = "Drawing over Apps";
		this.Label1.AutoSize = true;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label1.ForeColor = global::System.Drawing.Color.White;
		this.Label1.Location = new global::System.Drawing.Point(58, 29);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(147, 19);
		this.Label1.TabIndex = 7;
		this.Label1.Text = "Accessibility Services";
		this.TabPage3.BackColor = global::System.Drawing.Color.Black;
		this.TabPage3.Controls.Add(this.Checkbg);
		this.TabPage3.Controls.Add(this.checkautostart);
		this.TabPage3.Controls.Add(this.PictureBox2);
		this.TabPage3.Controls.Add(this.Label5);
		this.TabPage3.Controls.Add(this.PictureBox1);
		this.TabPage3.Controls.Add(this.Label4);
		this.TabPage3.Controls.Add(this.TextBox1);
		this.TabPage3.Location = new global::System.Drawing.Point(0, 40);
		this.TabPage3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new global::System.Drawing.Size(700, 391);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "MIUI (oppo,vevo,etc...)";
		this.Checkbg.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.Checkbg.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.Checkbg.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Checkbg.Location = new global::System.Drawing.Point(456, 53);
		this.Checkbg.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Checkbg.Name = "Checkbg";
		this.Checkbg.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.Checkbg.Size = new global::System.Drawing.Size(32, 24);
		this.Checkbg.TabIndex = 17;
		this.Checkbg.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkbg_MouseClick);
		this.checkautostart.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.checkautostart.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkautostart.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkautostart.Location = new global::System.Drawing.Point(70, 53);
		this.checkautostart.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.checkautostart.Name = "checkautostart";
		this.checkautostart.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
		this.checkautostart.Size = new global::System.Drawing.Size(32, 24);
		this.checkautostart.TabIndex = 16;
		this.checkautostart.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Toggle2_MouseClick);
		this.PictureBox2.Location = new global::System.Drawing.Point(44, 87);
		this.PictureBox2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new global::System.Drawing.Size(184, 241);
		this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 15;
		this.PictureBox2.TabStop = false;
		this.Label5.AutoSize = true;
		this.Label5.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label5.ForeColor = global::System.Drawing.Color.White;
		this.Label5.Location = new global::System.Drawing.Point(107, 56);
		this.Label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new global::System.Drawing.Size(73, 19);
		this.Label5.TabIndex = 14;
		this.Label5.Text = "Auto Start";
		this.PictureBox1.Location = new global::System.Drawing.Point(396, 87);
		this.PictureBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new global::System.Drawing.Size(264, 241);
		this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 12;
		this.PictureBox1.TabStop = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label4.ForeColor = global::System.Drawing.Color.White;
		this.Label4.Location = new global::System.Drawing.Point(493, 56);
		this.Label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new global::System.Drawing.Size(130, 19);
		this.Label4.TabIndex = 11;
		this.Label4.Text = "Run in Background";
		this.TextBox1.BackColor = global::System.Drawing.Color.Black;
		this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.TextBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TextBox1.Location = new global::System.Drawing.Point(0, 320);
		this.TextBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new global::System.Drawing.Size(700, 71);
		this.TextBox1.TabIndex = 0;
		this.TextBox1.Text = "this options is not fully tested as there is different kinds of chinese phones , if the phone is not supported nothing will show up on the phone";
		this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.Panel2.BackColor = global::System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.statustext);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new global::System.Drawing.Point(0, 439);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(700, 24);
		this.Panel2.TabIndex = 31;
		this.statustext.BackColor = global::System.Drawing.Color.Black;
		this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.statustext.ForeColor = global::System.Drawing.Color.Lime;
		this.statustext.Location = new global::System.Drawing.Point(0, 0);
		this.statustext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.statustext.Name = "statustext";
		this.statustext.Size = new global::System.Drawing.Size(700, 24);
		this.statustext.TabIndex = 1;
		this.statustext.Text = "...";
		this.statustext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.Panel3.BackColor = global::System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.clinameinfo);
		this.Panel3.Controls.Add(this.ClientPic);
		this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel3.ForeColor = global::System.Drawing.Color.Red;
		this.Panel3.Location = new global::System.Drawing.Point(0, 0);
		this.Panel3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new global::System.Drawing.Size(700, 32);
		this.Panel3.TabIndex = 32;
		this.clinameinfo.BackColor = global::System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clinameinfo.Location = new global::System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new global::System.Drawing.Size(668, 32);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
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
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(700, 463);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.DrakeUITabControl1);
		base.Controls.Add(this.Panel3);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
		base.Name = "PermissionsManager";
		base.ShowIcon = false;
		this.Text = "PermissionsManager";
		base.TopMost = true;
		this.DrakeUITabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.DGVPRIM).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x040009EE RID: 2542
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040009FF RID: 2559
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUITabControl1")]
	internal global::DrakeUI.Framework.DrakeUITabControl DrakeUITabControl1;

	// Token: 0x04000A00 RID: 2560
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage1")]
	internal global::System.Windows.Forms.TabPage TabPage1;

	// Token: 0x04000A01 RID: 2561
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage2")]
	internal global::System.Windows.Forms.TabPage TabPage2;

	// Token: 0x04000A02 RID: 2562
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DGVPRIM")]
	internal global::System.Windows.Forms.DataGridView DGVPRIM;

	// Token: 0x04000A03 RID: 2563
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon3;

	// Token: 0x04000A04 RID: 2564
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000A05 RID: 2565
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000A06 RID: 2566
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x04000A07 RID: 2567
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("comboproms")]
	internal global::DrakeUI.Framework.DrakeUIComboBox comboproms;

	// Token: 0x04000A08 RID: 2568
	internal global::System.Windows.Forms.Button addactiv;

	// Token: 0x04000A09 RID: 2569
	internal global::System.Windows.Forms.Button Button1;

	// Token: 0x04000A0A RID: 2570
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Primslist")]
	internal global::DrakeUI.Framework.DrakeUIListBox Primslist;

	// Token: 0x04000A0B RID: 2571
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label3")]
	internal global::System.Windows.Forms.Label Label3;

	// Token: 0x04000A0C RID: 2572
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000A0D RID: 2573
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("statustext")]
	internal global::System.Windows.Forms.Label statustext;

	// Token: 0x04000A0E RID: 2574
	internal global::System.Windows.Forms.Button Button2;

	// Token: 0x04000A0F RID: 2575
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
	internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

	// Token: 0x04000A10 RID: 2576
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("iconprim")]
	internal global::System.Windows.Forms.DataGridViewImageColumn iconprim;

	// Token: 0x04000A11 RID: 2577
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("primname")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn primname;

	// Token: 0x04000A12 RID: 2578
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Status")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Status;

	// Token: 0x04000A13 RID: 2579
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage3")]
	internal global::System.Windows.Forms.TabPage TabPage3;

	// Token: 0x04000A14 RID: 2580
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PictureBox2")]
	internal global::System.Windows.Forms.PictureBox PictureBox2;

	// Token: 0x04000A15 RID: 2581
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label5")]
	internal global::System.Windows.Forms.Label Label5;

	// Token: 0x04000A16 RID: 2582
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PictureBox1")]
	internal global::System.Windows.Forms.PictureBox PictureBox1;

	// Token: 0x04000A17 RID: 2583
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
	internal global::System.Windows.Forms.Label Label4;

	// Token: 0x04000A18 RID: 2584
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TextBox1")]
	internal global::System.Windows.Forms.TextBox TextBox1;

	// Token: 0x04000A19 RID: 2585
	internal global::DrakeUI.Framework.DrakeUICheckBox checkbattery;

	// Token: 0x04000A1A RID: 2586
	internal global::DrakeUI.Framework.DrakeUICheckBox checkdraw;

	// Token: 0x04000A1B RID: 2587
	internal global::DrakeUI.Framework.DrakeUICheckBox checkacess;

	// Token: 0x04000A1C RID: 2588
	internal global::DrakeUI.Framework.DrakeUICheckBox Checkbg;

	// Token: 0x04000A1D RID: 2589
	internal global::DrakeUI.Framework.DrakeUICheckBox checkautostart;

	// Token: 0x04000A1E RID: 2590
	internal global::DrakeUI.Framework.DrakeUICheckBox checkinstall;

	// Token: 0x04000A1F RID: 2591
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label6")]
	internal global::System.Windows.Forms.Label Label6;

	// Token: 0x04000A20 RID: 2592
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel3")]
	internal global::System.Windows.Forms.Panel Panel3;

	// Token: 0x04000A21 RID: 2593
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
	internal global::System.Windows.Forms.Label clinameinfo;

	// Token: 0x04000A22 RID: 2594
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
	internal global::System.Windows.Forms.PictureBox ClientPic;
}
