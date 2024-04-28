// Token: 0x020000C6 RID: 198
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class WebViewMonitor : global::System.Windows.Forms.Form
{
	// Token: 0x06000889 RID: 2185 RVA: 0x000CA010 File Offset: 0x000C8210
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

	// Token: 0x0600088A RID: 2186 RVA: 0x000CA054 File Offset: 0x000C8254
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.Panel7 = new global::System.Windows.Forms.Panel();
		this.SaveCheck = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.Panel6 = new global::System.Windows.Forms.Panel();
		this.TargetLink = new global::DrakeUI.Framework.DrakeUITextBox();
		this.Mytitle = new global::System.Windows.Forms.Label();
		this.DrakeUIComboBox1 = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.openbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.statustext = new global::System.Windows.Forms.Label();
		this.Panel3 = new global::System.Windows.Forms.Panel();
		this.tabcontrols = new global::DrakeUI.Framework.DrakeUITabControl();
		this.TabPage1 = new global::System.Windows.Forms.TabPage();
		this.vewimage = new global::System.Windows.Forms.PictureBox();
		this.vsbar = new global::DrakeUI.Framework.DrakeUIScrollBar();
		this.TabPage2 = new global::System.Windows.Forms.TabPage();
		this.resulttext = new global::System.Windows.Forms.Label();
		this.Panel4 = new global::System.Windows.Forms.Panel();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.selecthtmlbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.TabPage3 = new global::System.Windows.Forms.TabPage();
		this.datapanel = new global::DrakeUI.Framework.DrakeUITitlePanel();
		this.datalogtext = new global::DrakeUI.Framework.DrakeUIRichTextBox();
		this.linkspanel = new global::DrakeUI.Framework.DrakeUITitlePanel();
		this.Panel8 = new global::System.Windows.Forms.Panel();
		this.Panel9 = new global::System.Windows.Forms.Panel();
		this.comandcombo = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.namescombo = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.commndbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.idtext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.nametext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.linktext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.refbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.savbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.clrbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.cpybtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.BWloader = new global::System.ComponentModel.BackgroundWorker();
		this.timeloader = new global::System.Windows.Forms.Timer(this.components);
		this.Panel5 = new global::System.Windows.Forms.Panel();
		this.clinameinfo = new global::System.Windows.Forms.Label();
		this.ClientPic = new global::System.Windows.Forms.PictureBox();
		this.sPanel1 = new global::Sipaa.Framework.SPanel();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label6 = new global::System.Windows.Forms.Label();
		this.drakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.label5 = new global::System.Windows.Forms.Label();
		this.label4 = new global::System.Windows.Forms.Label();
		this.sPanel3 = new global::Sipaa.Framework.SPanel();
		this.sPanel2 = new global::Sipaa.Framework.SPanel();
		this.drakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.Panel1.SuspendLayout();
		this.Panel7.SuspendLayout();
		this.Panel6.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Panel3.SuspendLayout();
		this.tabcontrols.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.vewimage).BeginInit();
		this.TabPage2.SuspendLayout();
		this.Panel4.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.datapanel.SuspendLayout();
		this.Panel5.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.sPanel1.SuspendLayout();
		this.sPanel3.SuspendLayout();
		this.sPanel2.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.Panel7);
		this.Panel1.Controls.Add(this.Panel6);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(90, 56);
		this.Panel1.TabIndex = 1;
		this.Panel7.Controls.Add(this.SaveCheck);
		this.Panel7.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel7.Location = new global::System.Drawing.Point(0, 0);
		this.Panel7.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel7.Name = "Panel7";
		this.Panel7.Size = new global::System.Drawing.Size(90, 26);
		this.Panel7.TabIndex = 24;
		this.SaveCheck.CheckBoxColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.SaveCheck.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.SaveCheck.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.SaveCheck.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.SaveCheck.ForeColor = global::System.Drawing.Color.White;
		this.SaveCheck.Location = new global::System.Drawing.Point(17, 0);
		this.SaveCheck.Margin = new global::System.Windows.Forms.Padding(2);
		this.SaveCheck.Name = "SaveCheck";
		this.SaveCheck.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.SaveCheck.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
		this.SaveCheck.Size = new global::System.Drawing.Size(73, 26);
		this.SaveCheck.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.SaveCheck.StyleCustomMode = true;
		this.SaveCheck.TabIndex = 22;
		this.SaveCheck.Text = "Record";
		this.SaveCheck.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
		this.Panel6.Controls.Add(this.TargetLink);
		this.Panel6.Controls.Add(this.Mytitle);
		this.Panel6.Controls.Add(this.DrakeUIComboBox1);
		this.Panel6.Controls.Add(this.openbtn);
		this.Panel6.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel6.Location = new global::System.Drawing.Point(0, 26);
		this.Panel6.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel6.Name = "Panel6";
		this.Panel6.Size = new global::System.Drawing.Size(90, 30);
		this.Panel6.TabIndex = 23;
		this.TargetLink.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.TargetLink.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.TargetLink.FillColor = global::System.Drawing.Color.Black;
		this.TargetLink.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.TargetLink.ForeColor = global::System.Drawing.Color.White;
		this.TargetLink.Location = new global::System.Drawing.Point(126, 0);
		this.TargetLink.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.TargetLink.Maximum = 2147483647.0;
		this.TargetLink.Minimum = -2147483648.0;
		this.TargetLink.Name = "TargetLink";
		this.TargetLink.Padding = new global::System.Windows.Forms.Padding(5);
		this.TargetLink.Radius = 15;
		this.TargetLink.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TargetLink.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.TargetLink.Size = new global::System.Drawing.Size(0, 27);
		this.TargetLink.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.TargetLink.TabIndex = 19;
		this.TargetLink.Watermark = "Enter Link";
		this.TargetLink.WordWarp = false;
		this.TargetLink.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.DrakeUITextBox1_MouseDown);
		this.Mytitle.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.Mytitle.Font = new global::System.Drawing.Font("Calibri", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Mytitle.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Mytitle.Location = new global::System.Drawing.Point(0, 0);
		this.Mytitle.Name = "Mytitle";
		this.Mytitle.Size = new global::System.Drawing.Size(126, 30);
		this.Mytitle.TabIndex = 20;
		this.Mytitle.Text = "Website Link";
		this.DrakeUIComboBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.DrakeUIComboBox1.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.DrakeUIComboBox1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIComboBox1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIComboBox1.ForeColor = global::System.Drawing.Color.White;
		this.DrakeUIComboBox1.Items.AddRange(new object[]
		{
			"Just Open",
			"Open + Monitor"
		});
		this.DrakeUIComboBox1.Location = new global::System.Drawing.Point(-124, 0);
		this.DrakeUIComboBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.DrakeUIComboBox1.MinimumSize = new global::System.Drawing.Size(63, 0);
		this.DrakeUIComboBox1.Name = "DrakeUIComboBox1";
		this.DrakeUIComboBox1.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
		this.DrakeUIComboBox1.Radius = 15;
		this.DrakeUIComboBox1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIComboBox1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIComboBox1.Size = new global::System.Drawing.Size(115, 27);
		this.DrakeUIComboBox1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIComboBox1.TabIndex = 21;
		this.DrakeUIComboBox1.Text = "Just Open";
		this.DrakeUIComboBox1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.openbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.openbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.openbtn.FillColor = global::System.Drawing.Color.Black;
		this.openbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.openbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.openbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.openbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.openbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.openbtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.openbtn.Location = new global::System.Drawing.Point(-9, 0);
		this.openbtn.Name = "openbtn";
		this.openbtn.Radius = 25;
		this.openbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.openbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.openbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.openbtn.RectPressColor = global::System.Drawing.Color.White;
		this.openbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.openbtn.Size = new global::System.Drawing.Size(99, 30);
		this.openbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.openbtn.Symbol = 57571;
		this.openbtn.TabIndex = 18;
		this.openbtn.Text = "Open";
		this.openbtn.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx);
		this.Panel2.BackColor = global::System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.statustext);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new global::System.Drawing.Point(0, 26);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(90, 18);
		this.Panel2.TabIndex = 2;
		this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.statustext.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.statustext.ForeColor = global::System.Drawing.Color.Lime;
		this.statustext.Location = new global::System.Drawing.Point(0, 0);
		this.statustext.Name = "statustext";
		this.statustext.Size = new global::System.Drawing.Size(90, 18);
		this.statustext.TabIndex = 21;
		this.statustext.Text = "...";
		this.Panel3.Controls.Add(this.tabcontrols);
		this.Panel3.Controls.Add(this.Panel2);
		this.Panel3.Location = new global::System.Drawing.Point(12, 176);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new global::System.Drawing.Size(90, 44);
		this.Panel3.TabIndex = 3;
		this.Panel3.Visible = false;
		this.tabcontrols.Controls.Add(this.TabPage1);
		this.tabcontrols.Controls.Add(this.TabPage2);
		this.tabcontrols.Controls.Add(this.TabPage3);
		this.tabcontrols.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tabcontrols.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
		this.tabcontrols.FillColor = global::System.Drawing.Color.Black;
		this.tabcontrols.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.tabcontrols.ItemSize = new global::System.Drawing.Size(380, 40);
		this.tabcontrols.Location = new global::System.Drawing.Point(0, 0);
		this.tabcontrols.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
		this.tabcontrols.Multiline = true;
		this.tabcontrols.Name = "tabcontrols";
		this.tabcontrols.SelectedIndex = 0;
		this.tabcontrols.Size = new global::System.Drawing.Size(90, 26);
		this.tabcontrols.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
		this.tabcontrols.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.tabcontrols.TabBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
		this.tabcontrols.TabIndex = 2;
		this.tabcontrols.TabSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.tabcontrols.TabSelectedForeColor = global::System.Drawing.Color.Black;
		this.tabcontrols.TabSelectedHighColor = global::System.Drawing.Color.Black;
		this.tabcontrols.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
		this.TabPage1.BackColor = global::System.Drawing.Color.Black;
		this.TabPage1.Controls.Add(this.vewimage);
		this.TabPage1.Controls.Add(this.vsbar);
		this.TabPage1.Controls.Add(this.Panel1);
		this.TabPage1.Location = new global::System.Drawing.Point(0, 120);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Size = new global::System.Drawing.Size(90, 0);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "General";
		this.vewimage.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.vewimage.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.vewimage.Location = new global::System.Drawing.Point(0, 56);
		this.vewimage.Margin = new global::System.Windows.Forms.Padding(2);
		this.vewimage.Name = "vewimage";
		this.vewimage.Size = new global::System.Drawing.Size(71, 0);
		this.vewimage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.vewimage.TabIndex = 3;
		this.vewimage.TabStop = false;
		this.vsbar.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.vsbar.FillColor = global::System.Drawing.Color.Black;
		this.vsbar.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.vsbar.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.vsbar.Location = new global::System.Drawing.Point(71, 56);
		this.vsbar.Name = "vsbar";
		this.vsbar.PressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.vsbar.Size = new global::System.Drawing.Size(19, 0);
		this.vsbar.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.vsbar.TabIndex = 1;
		this.vsbar.Text = "DrakeUIScrollBar1";
		this.vsbar.ValueChanged += new global::System.EventHandler(this.Vsbar_ValueChanged);
		this.TabPage2.BackColor = global::System.Drawing.Color.Black;
		this.TabPage2.Controls.Add(this.resulttext);
		this.TabPage2.Controls.Add(this.Panel4);
		this.TabPage2.Location = new global::System.Drawing.Point(0, 120);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Size = new global::System.Drawing.Size(90, 0);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Custome";
		this.resulttext.BackColor = global::System.Drawing.Color.Black;
		this.resulttext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.resulttext.ForeColor = global::System.Drawing.Color.White;
		this.resulttext.Location = new global::System.Drawing.Point(0, 59);
		this.resulttext.Name = "resulttext";
		this.resulttext.Size = new global::System.Drawing.Size(90, 0);
		this.resulttext.TabIndex = 1;
		this.resulttext.Text = "Client Result";
		this.resulttext.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
		this.Panel4.BackColor = global::System.Drawing.Color.Black;
		this.Panel4.Controls.Add(this.Label2);
		this.Panel4.Controls.Add(this.selecthtmlbtn);
		this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel4.Location = new global::System.Drawing.Point(0, 0);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new global::System.Drawing.Size(90, 59);
		this.Panel4.TabIndex = 2;
		this.Label2.AutoSize = true;
		this.Label2.Font = new global::System.Drawing.Font("Calibri", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label2.Location = new global::System.Drawing.Point(12, 9);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(183, 33);
		this.Label2.TabIndex = 20;
		this.Label2.Text = "Add Html View";
		this.selecthtmlbtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.selecthtmlbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.selecthtmlbtn.FillColor = global::System.Drawing.Color.Black;
		this.selecthtmlbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.selecthtmlbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.selecthtmlbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selecthtmlbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.selecthtmlbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selecthtmlbtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selecthtmlbtn.Location = new global::System.Drawing.Point(-90, 20);
		this.selecthtmlbtn.Name = "selecthtmlbtn";
		this.selecthtmlbtn.Radius = 25;
		this.selecthtmlbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selecthtmlbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.selecthtmlbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.selecthtmlbtn.RectPressColor = global::System.Drawing.Color.White;
		this.selecthtmlbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.selecthtmlbtn.Size = new global::System.Drawing.Size(170, 26);
		this.selecthtmlbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.selecthtmlbtn.Symbol = 61543;
		this.selecthtmlbtn.TabIndex = 18;
		this.selecthtmlbtn.Text = "Select Html File";
		this.selecthtmlbtn.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys);
		this.TabPage3.BackColor = global::System.Drawing.Color.Black;
		this.TabPage3.Controls.Add(this.datapanel);
		this.TabPage3.Controls.Add(this.linkspanel);
		this.TabPage3.Controls.Add(this.Panel8);
		this.TabPage3.Controls.Add(this.Panel9);
		this.TabPage3.Location = new global::System.Drawing.Point(0, 120);
		this.TabPage3.Margin = new global::System.Windows.Forms.Padding(2);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Size = new global::System.Drawing.Size(90, 0);
		this.TabPage3.TabIndex = 0;
		this.TabPage3.Text = "Passwords";
		this.datapanel.Controls.Add(this.datalogtext);
		this.datapanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.datapanel.FillColor = global::System.Drawing.Color.Black;
		this.datapanel.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.datapanel.ForeColor = global::System.Drawing.Color.White;
		this.datapanel.Location = new global::System.Drawing.Point(284, 41);
		this.datapanel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.datapanel.Name = "datapanel";
		this.datapanel.Padding = new global::System.Windows.Forms.Padding(0, 28, 0, 0);
		this.datapanel.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.datapanel.Size = new global::System.Drawing.Size(0, 0);
		this.datapanel.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.datapanel.TabIndex = 1;
		this.datapanel.Text = "Captured Passwords";
		this.datapanel.TitleColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.datalogtext.AutoWordSelection = true;
		this.datalogtext.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.datalogtext.FillColor = global::System.Drawing.Color.Black;
		this.datalogtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.datalogtext.ForeColor = global::System.Drawing.Color.White;
		this.datalogtext.Location = new global::System.Drawing.Point(0, 28);
		this.datalogtext.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.datalogtext.Name = "datalogtext";
		this.datalogtext.Padding = new global::System.Windows.Forms.Padding(2);
		this.datalogtext.RectColor = global::System.Drawing.Color.FromArgb(130, 130, 130);
		this.datalogtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.datalogtext.RectSides = (global::System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom | global::System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | global::System.Windows.Forms.ToolStripStatusLabelBorderSides.Right);
		this.datalogtext.Size = new global::System.Drawing.Size(0, 0);
		this.datalogtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.datalogtext.StyleCustomMode = true;
		this.datalogtext.TabIndex = 0;
		this.linkspanel.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.linkspanel.FillColor = global::System.Drawing.Color.Black;
		this.linkspanel.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.linkspanel.ForeColor = global::System.Drawing.Color.White;
		this.linkspanel.Location = new global::System.Drawing.Point(0, 41);
		this.linkspanel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.linkspanel.Name = "linkspanel";
		this.linkspanel.Padding = new global::System.Windows.Forms.Padding(0, 28, 0, 0);
		this.linkspanel.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.linkspanel.Size = new global::System.Drawing.Size(284, 0);
		this.linkspanel.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.linkspanel.TabIndex = 2;
		this.linkspanel.Text = "Captured Sites";
		this.linkspanel.TitleColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Panel8.BackColor = global::System.Drawing.Color.Black;
		this.Panel8.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel8.Location = new global::System.Drawing.Point(0, 0);
		this.Panel8.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel8.Name = "Panel8";
		this.Panel8.Size = new global::System.Drawing.Size(90, 41);
		this.Panel8.TabIndex = 0;
		this.Panel9.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel9.Location = new global::System.Drawing.Point(0, -43);
		this.Panel9.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel9.Name = "Panel9";
		this.Panel9.Size = new global::System.Drawing.Size(90, 43);
		this.Panel9.TabIndex = 21;
		this.comandcombo.BackColor = global::System.Drawing.Color.Black;
		this.comandcombo.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.comandcombo.FillColor = global::System.Drawing.Color.Black;
		this.comandcombo.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.comandcombo.ForeColor = global::System.Drawing.Color.White;
		this.comandcombo.Items.AddRange(new object[]
		{
			"Add",
			"Remove",
			"Edit",
			"Clean"
		});
		this.comandcombo.Location = new global::System.Drawing.Point(136, 419);
		this.comandcombo.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.comandcombo.MinimumSize = new global::System.Drawing.Size(47, 0);
		this.comandcombo.Name = "comandcombo";
		this.comandcombo.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
		this.comandcombo.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.comandcombo.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.comandcombo.Size = new global::System.Drawing.Size(119, 27);
		this.comandcombo.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.comandcombo.TabIndex = 48;
		this.comandcombo.Text = "Add";
		this.comandcombo.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.namescombo.BackColor = global::System.Drawing.Color.Black;
		this.namescombo.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.namescombo.FillColor = global::System.Drawing.Color.Black;
		this.namescombo.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.namescombo.ForeColor = global::System.Drawing.Color.White;
		this.namescombo.Location = new global::System.Drawing.Point(56, 22);
		this.namescombo.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.namescombo.MinimumSize = new global::System.Drawing.Size(47, 0);
		this.namescombo.Name = "namescombo";
		this.namescombo.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
		this.namescombo.Radius = 15;
		this.namescombo.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.namescombo.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.namescombo.Size = new global::System.Drawing.Size(194, 27);
		this.namescombo.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.namescombo.TabIndex = 47;
		this.namescombo.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.namescombo.SelectedIndexChanged += new global::System.EventHandler(this.Namescombo_SelectedIndexChanged);
		this.commndbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.commndbtn.FillColor = global::System.Drawing.Color.Black;
		this.commndbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.commndbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.commndbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.commndbtn.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.commndbtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.commndbtn.Location = new global::System.Drawing.Point(54, 482);
		this.commndbtn.Name = "commndbtn";
		this.commndbtn.Radius = 25;
		this.commndbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.commndbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.commndbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.commndbtn.RectPressColor = global::System.Drawing.Color.White;
		this.commndbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.commndbtn.Size = new global::System.Drawing.Size(283, 46);
		this.commndbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.commndbtn.Symbol = 61947;
		this.commndbtn.TabIndex = 20;
		this.commndbtn.Text = "Start Injection";
		this.commndbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon6_Click);
		this.idtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.idtext.FillColor = global::System.Drawing.Color.Black;
		this.idtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.idtext.ForeColor = global::System.Drawing.Color.White;
		this.idtext.Location = new global::System.Drawing.Point(21, 136);
		this.idtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.idtext.Maximum = 2147483647.0;
		this.idtext.Minimum = -2147483648.0;
		this.idtext.Name = "idtext";
		this.idtext.Padding = new global::System.Windows.Forms.Padding(5);
		this.idtext.Radius = 10;
		this.idtext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.idtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.idtext.Size = new global::System.Drawing.Size(287, 27);
		this.idtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.idtext.StyleCustomMode = true;
		this.idtext.TabIndex = 46;
		this.idtext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.idtext.Watermark = "App Package Name";
		this.nametext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.nametext.FillColor = global::System.Drawing.Color.Black;
		this.nametext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.nametext.ForeColor = global::System.Drawing.Color.White;
		this.nametext.Location = new global::System.Drawing.Point(24, 30);
		this.nametext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.nametext.Maximum = 2147483647.0;
		this.nametext.Minimum = -2147483648.0;
		this.nametext.Name = "nametext";
		this.nametext.Padding = new global::System.Windows.Forms.Padding(5);
		this.nametext.Radius = 10;
		this.nametext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.nametext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.nametext.Size = new global::System.Drawing.Size(284, 27);
		this.nametext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.nametext.StyleCustomMode = true;
		this.nametext.TabIndex = 45;
		this.nametext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.nametext.Watermark = "App Name";
		this.linktext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.linktext.FillColor = global::System.Drawing.Color.Black;
		this.linktext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.linktext.ForeColor = global::System.Drawing.Color.White;
		this.linktext.Location = new global::System.Drawing.Point(24, 82);
		this.linktext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.linktext.Maximum = 2147483647.0;
		this.linktext.Minimum = -2147483648.0;
		this.linktext.Name = "linktext";
		this.linktext.Padding = new global::System.Windows.Forms.Padding(5);
		this.linktext.Radius = 10;
		this.linktext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.linktext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.linktext.Size = new global::System.Drawing.Size(284, 27);
		this.linktext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.linktext.StyleCustomMode = true;
		this.linktext.TabIndex = 44;
		this.linktext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.linktext.Watermark = "Custom Url";
		this.refbtn.BackColor = global::System.Drawing.Color.Black;
		this.refbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.refbtn.FillColor = global::System.Drawing.Color.Black;
		this.refbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.refbtn.Location = new global::System.Drawing.Point(12, 89);
		this.refbtn.Name = "refbtn";
		this.refbtn.Radius = 25;
		this.refbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.refbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.refbtn.Size = new global::System.Drawing.Size(100, 26);
		this.refbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.refbtn.StyleCustomMode = true;
		this.refbtn.Symbol = 61473;
		this.refbtn.TabIndex = 20;
		this.refbtn.Text = "Refresh";
		this.refbtn.Visible = false;
		this.refbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon7_Click);
		this.savbtn.BackColor = global::System.Drawing.Color.Black;
		this.savbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.savbtn.FillColor = global::System.Drawing.Color.Black;
		this.savbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.savbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.savbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.savbtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savbtn.Location = new global::System.Drawing.Point(118, 89);
		this.savbtn.Name = "savbtn";
		this.savbtn.Radius = 25;
		this.savbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.savbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.savbtn.RectPressColor = global::System.Drawing.Color.White;
		this.savbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.savbtn.Size = new global::System.Drawing.Size(100, 26);
		this.savbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.savbtn.Symbol = 61717;
		this.savbtn.TabIndex = 24;
		this.savbtn.Text = "Saved";
		this.savbtn.Visible = false;
		this.savbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon9_Click);
		this.clrbtn.BackColor = global::System.Drawing.Color.Black;
		this.clrbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.clrbtn.FillColor = global::System.Drawing.Color.Black;
		this.clrbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.clrbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.clrbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clrbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.clrbtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clrbtn.Location = new global::System.Drawing.Point(12, 139);
		this.clrbtn.Name = "clrbtn";
		this.clrbtn.Radius = 25;
		this.clrbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clrbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.clrbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.clrbtn.RectPressColor = global::System.Drawing.Color.White;
		this.clrbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.clrbtn.Size = new global::System.Drawing.Size(100, 26);
		this.clrbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.clrbtn.Symbol = 61741;
		this.clrbtn.TabIndex = 23;
		this.clrbtn.Text = "Clear";
		this.clrbtn.Visible = false;
		this.clrbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon5_Click);
		this.cpybtn.BackColor = global::System.Drawing.Color.Black;
		this.cpybtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.cpybtn.FillColor = global::System.Drawing.Color.Black;
		this.cpybtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.cpybtn.FillPressColor = global::System.Drawing.Color.Black;
		this.cpybtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.cpybtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.cpybtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.cpybtn.Location = new global::System.Drawing.Point(118, 139);
		this.cpybtn.Name = "cpybtn";
		this.cpybtn.Radius = 25;
		this.cpybtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.cpybtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.cpybtn.RectHoverColor = global::System.Drawing.Color.White;
		this.cpybtn.RectPressColor = global::System.Drawing.Color.White;
		this.cpybtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.cpybtn.Size = new global::System.Drawing.Size(100, 26);
		this.cpybtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.cpybtn.Symbol = 62029;
		this.cpybtn.TabIndex = 22;
		this.cpybtn.Text = "Copy";
		this.cpybtn.Visible = false;
		this.cpybtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon8_Click);
		this.BWloader.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BWloader_DoWork);
		this.timeloader.Interval = 30;
		this.timeloader.Tick += new global::System.EventHandler(this.Timeloader_Tick);
		this.Panel5.BackColor = global::System.Drawing.Color.Black;
		this.Panel5.Controls.Add(this.clinameinfo);
		this.Panel5.Controls.Add(this.ClientPic);
		this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel5.ForeColor = global::System.Drawing.Color.Red;
		this.Panel5.Location = new global::System.Drawing.Point(0, 0);
		this.Panel5.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new global::System.Drawing.Size(404, 32);
		this.Panel5.TabIndex = 6;
		this.clinameinfo.BackColor = global::System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clinameinfo.Location = new global::System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new global::System.Drawing.Size(372, 32);
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
		this.sPanel1.BackColor = global::System.Drawing.Color.Black;
		this.sPanel1.BorderColor = global::System.Drawing.Color.Red;
		this.sPanel1.BorderRadius = 6;
		this.sPanel1.BorderSize = 2;
		this.sPanel1.Controls.Add(this.label3);
		this.sPanel1.Controls.Add(this.label6);
		this.sPanel1.Controls.Add(this.drakeUIAvatar1);
		this.sPanel1.Controls.Add(this.label5);
		this.sPanel1.Controls.Add(this.label4);
		this.sPanel1.Controls.Add(this.sPanel3);
		this.sPanel1.Controls.Add(this.sPanel2);
		this.sPanel1.Controls.Add(this.comandcombo);
		this.sPanel1.Controls.Add(this.commndbtn);
		this.sPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.sPanel1.ForeColor = global::System.Drawing.Color.White;
		this.sPanel1.Location = new global::System.Drawing.Point(0, 32);
		this.sPanel1.Name = "sPanel1";
		this.sPanel1.Size = new global::System.Drawing.Size(404, 556);
		this.sPanel1.TabIndex = 50;
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new global::System.Drawing.Point(71, 423);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(54, 19);
		this.label3.TabIndex = 62;
		this.label3.Text = "Action";
		this.label6.AutoSize = true;
		this.label6.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new global::System.Drawing.Point(132, 94);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(142, 19);
		this.label6.TabIndex = 61;
		this.label6.Text = "List of added Apps";
		this.drakeUIAvatar1.FillColor = global::System.Drawing.Color.Black;
		this.drakeUIAvatar1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.drakeUIAvatar1.ForeColor = global::System.Drawing.Color.Lime;
		this.drakeUIAvatar1.Location = new global::System.Drawing.Point(3, 3);
		this.drakeUIAvatar1.Name = "drakeUIAvatar1";
		this.drakeUIAvatar1.Size = new global::System.Drawing.Size(60, 60);
		this.drakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.drakeUIAvatar1.Symbol = 61852;
		this.drakeUIAvatar1.TabIndex = 60;
		this.drakeUIAvatar1.Text = "drakeUIAvatar1";
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Bahnschrift", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = global::System.Drawing.Color.Lime;
		this.label5.Location = new global::System.Drawing.Point(59, 21);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(337, 33);
		this.label5.TabIndex = 59;
		this.label5.Text = "EagleSpy banking Injection";
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new global::System.Drawing.Point(131, 199);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(163, 19);
		this.label4.TabIndex = 57;
		this.label4.Text = "Add / Modify Injection";
		this.sPanel3.BackColor = global::System.Drawing.Color.Black;
		this.sPanel3.BorderColor = global::System.Drawing.Color.Red;
		this.sPanel3.BorderRadius = 6;
		this.sPanel3.BorderSize = 1;
		this.sPanel3.Controls.Add(this.nametext);
		this.sPanel3.Controls.Add(this.linktext);
		this.sPanel3.Controls.Add(this.idtext);
		this.sPanel3.ForeColor = global::System.Drawing.Color.White;
		this.sPanel3.Location = new global::System.Drawing.Point(22, 210);
		this.sPanel3.Name = "sPanel3";
		this.sPanel3.Size = new global::System.Drawing.Size(356, 184);
		this.sPanel3.TabIndex = 58;
		this.sPanel2.BackColor = global::System.Drawing.Color.Black;
		this.sPanel2.BorderColor = global::System.Drawing.Color.Red;
		this.sPanel2.BorderRadius = 6;
		this.sPanel2.BorderSize = 1;
		this.sPanel2.Controls.Add(this.drakeUIAvatar2);
		this.sPanel2.Controls.Add(this.namescombo);
		this.sPanel2.ForeColor = global::System.Drawing.Color.White;
		this.sPanel2.Location = new global::System.Drawing.Point(43, 106);
		this.sPanel2.Name = "sPanel2";
		this.sPanel2.Size = new global::System.Drawing.Size(323, 62);
		this.sPanel2.TabIndex = 57;
		this.drakeUIAvatar2.FillColor = global::System.Drawing.Color.Black;
		this.drakeUIAvatar2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
		this.drakeUIAvatar2.ForeColor = global::System.Drawing.Color.Red;
		this.drakeUIAvatar2.Location = new global::System.Drawing.Point(279, 22);
		this.drakeUIAvatar2.Name = "drakeUIAvatar2";
		this.drakeUIAvatar2.Size = new global::System.Drawing.Size(29, 27);
		this.drakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.drakeUIAvatar2.Symbol = 61666;
		this.drakeUIAvatar2.SymbolSize = 30;
		this.drakeUIAvatar2.TabIndex = 48;
		this.drakeUIAvatar2.Text = "drakeUIAvatar2";
		this.drakeUIAvatar2.Click += new global::System.EventHandler(this.drakeUIAvatar2_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(404, 588);
		base.Controls.Add(this.sPanel1);
		base.Controls.Add(this.refbtn);
		base.Controls.Add(this.savbtn);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.clrbtn);
		base.Controls.Add(this.cpybtn);
		base.Controls.Add(this.Panel5);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "WebViewMonitor";
		base.ShowIcon = false;
		this.Text = "Smart Injection";
		this.Panel1.ResumeLayout(false);
		this.Panel7.ResumeLayout(false);
		this.Panel6.ResumeLayout(false);
		this.Panel2.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		this.tabcontrols.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.vewimage).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.Panel4.ResumeLayout(false);
		this.Panel4.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.datapanel.ResumeLayout(false);
		this.Panel5.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.sPanel1.ResumeLayout(false);
		this.sPanel1.PerformLayout();
		this.sPanel3.ResumeLayout(false);
		this.sPanel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04000CBF RID: 3263
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000CD1 RID: 3281
	internal global::DrakeUI.Framework.DrakeUITextBox TargetLink;

	// Token: 0x04000CD2 RID: 3282
	internal global::DrakeUI.Framework.DrakeUIButtonIcon openbtn;

	// Token: 0x04000CD3 RID: 3283
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIComboBox1")]
	internal global::DrakeUI.Framework.DrakeUIComboBox DrakeUIComboBox1;

	// Token: 0x04000CD4 RID: 3284
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Mytitle")]
	internal global::System.Windows.Forms.Label Mytitle;

	// Token: 0x04000CD5 RID: 3285
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("statustext")]
	internal global::System.Windows.Forms.Label statustext;

	// Token: 0x04000CD6 RID: 3286
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel3")]
	internal global::System.Windows.Forms.Panel Panel3;

	// Token: 0x04000CD7 RID: 3287
	internal global::DrakeUI.Framework.DrakeUIScrollBar vsbar;

	// Token: 0x04000CD8 RID: 3288
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("tabcontrols")]
	internal global::DrakeUI.Framework.DrakeUITabControl tabcontrols;

	// Token: 0x04000CD9 RID: 3289
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage1")]
	internal global::System.Windows.Forms.TabPage TabPage1;

	// Token: 0x04000CDA RID: 3290
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage2")]
	internal global::System.Windows.Forms.TabPage TabPage2;

	// Token: 0x04000CDB RID: 3291
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("resulttext")]
	internal global::System.Windows.Forms.Label resulttext;

	// Token: 0x04000CDC RID: 3292
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel4")]
	internal global::System.Windows.Forms.Panel Panel4;

	// Token: 0x04000CDD RID: 3293
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000CDE RID: 3294
	internal global::DrakeUI.Framework.DrakeUIButtonIcon selecthtmlbtn;

	// Token: 0x04000CDF RID: 3295
	internal global::System.ComponentModel.BackgroundWorker BWloader;

	// Token: 0x04000CE0 RID: 3296
	internal global::System.Windows.Forms.Timer timeloader;

	// Token: 0x04000CE1 RID: 3297
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000CE2 RID: 3298
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000CE3 RID: 3299
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("SaveCheck")]
	internal global::DrakeUI.Framework.DrakeUICheckBox SaveCheck;

	// Token: 0x04000CE4 RID: 3300
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("vewimage")]
	internal global::System.Windows.Forms.PictureBox vewimage;

	// Token: 0x04000CE5 RID: 3301
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel5")]
	internal global::System.Windows.Forms.Panel Panel5;

	// Token: 0x04000CE6 RID: 3302
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
	internal global::System.Windows.Forms.Label clinameinfo;

	// Token: 0x04000CE7 RID: 3303
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
	internal global::System.Windows.Forms.PictureBox ClientPic;

	// Token: 0x04000CE8 RID: 3304
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel7")]
	internal global::System.Windows.Forms.Panel Panel7;

	// Token: 0x04000CE9 RID: 3305
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel6")]
	internal global::System.Windows.Forms.Panel Panel6;

	// Token: 0x04000CEA RID: 3306
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage3")]
	internal global::System.Windows.Forms.TabPage TabPage3;

	// Token: 0x04000CEB RID: 3307
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("linkspanel")]
	internal global::DrakeUI.Framework.DrakeUITitlePanel linkspanel;

	// Token: 0x04000CEC RID: 3308
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("datapanel")]
	internal global::DrakeUI.Framework.DrakeUITitlePanel datapanel;

	// Token: 0x04000CED RID: 3309
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel8")]
	internal global::System.Windows.Forms.Panel Panel8;

	// Token: 0x04000CF8 RID: 3320
	internal global::DrakeUI.Framework.DrakeUIButtonIcon commndbtn;

	// Token: 0x04000CF9 RID: 3321
	internal global::DrakeUI.Framework.DrakeUIButtonIcon refbtn;

	// Token: 0x04000CFA RID: 3322
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("datalogtext")]
	internal global::DrakeUI.Framework.DrakeUIRichTextBox datalogtext;

	// Token: 0x04000CFB RID: 3323
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("linktext")]
	internal global::DrakeUI.Framework.DrakeUITextBox linktext;

	// Token: 0x04000CFC RID: 3324
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("comandcombo")]
	internal global::DrakeUI.Framework.DrakeUIComboBox comandcombo;

	// Token: 0x04000CFD RID: 3325
	internal global::DrakeUI.Framework.DrakeUIComboBox namescombo;

	// Token: 0x04000CFE RID: 3326
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("idtext")]
	internal global::DrakeUI.Framework.DrakeUITextBox idtext;

	// Token: 0x04000CFF RID: 3327
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("nametext")]
	internal global::DrakeUI.Framework.DrakeUITextBox nametext;

	// Token: 0x04000D00 RID: 3328
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel9")]
	internal global::System.Windows.Forms.Panel Panel9;

	// Token: 0x04000D01 RID: 3329
	internal global::DrakeUI.Framework.DrakeUIButtonIcon cpybtn;

	// Token: 0x04000D02 RID: 3330
	internal global::DrakeUI.Framework.DrakeUIButtonIcon savbtn;

	// Token: 0x04000D03 RID: 3331
	private global::Sipaa.Framework.SPanel sPanel1;

	// Token: 0x04000D04 RID: 3332
	private global::System.Windows.Forms.Label label6;

	// Token: 0x04000D05 RID: 3333
	private global::DrakeUI.Framework.DrakeUIAvatar drakeUIAvatar1;

	// Token: 0x04000D06 RID: 3334
	private global::System.Windows.Forms.Label label5;

	// Token: 0x04000D07 RID: 3335
	private global::System.Windows.Forms.Label label4;

	// Token: 0x04000D08 RID: 3336
	private global::Sipaa.Framework.SPanel sPanel3;

	// Token: 0x04000D09 RID: 3337
	private global::Sipaa.Framework.SPanel sPanel2;

	// Token: 0x04000D0A RID: 3338
	private global::DrakeUI.Framework.DrakeUIAvatar drakeUIAvatar2;

	// Token: 0x04000D0B RID: 3339
	private global::System.Windows.Forms.Label label3;

	// Token: 0x04000D0C RID: 3340
	internal global::DrakeUI.Framework.DrakeUIButtonIcon clrbtn;
}
