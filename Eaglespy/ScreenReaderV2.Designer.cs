// Token: 0x020000B8 RID: 184
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class ScreenReaderV2 : global::System.Windows.Forms.Form
{
	// Token: 0x060007A6 RID: 1958 RVA: 0x000B4D30 File Offset: 0x000B2F30
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

	// Token: 0x060007A7 RID: 1959 RVA: 0x000B4D74 File Offset: 0x000B2F74
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.activetext = new global::System.Windows.Forms.Label();
		this.ctrlpanel = new global::System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.presstimer = new global::System.Windows.Forms.Timer(this.components);
		this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.savetimer = new global::System.Windows.Forms.Timer(this.components);
		this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
		this.Panel3 = new global::System.Windows.Forms.Panel();
		this.clinameinfo = new global::System.Windows.Forms.Label();
		this.ClientPic = new global::System.Windows.Forms.PictureBox();
		this.keyboardpanel = new global::System.Windows.Forms.Panel();
		this.Button5 = new global::System.Windows.Forms.PictureBox();
		this.Button7 = new global::System.Windows.Forms.PictureBox();
		this.Button6 = new global::System.Windows.Forms.PictureBox();
		this.buttompanel = new global::System.Windows.Forms.Panel();
		this.viewpic = new global::System.Windows.Forms.PictureBox();
		this.textsend = new global::Guna.UI2.WinForms.Guna2TextBox();
		this.Enterbutton = new global::Guna.UI2.WinForms.Guna2Button();
		this.DrakeUILabel1 = new global::DrakeUI.Framework.DrakeUILabel();
		this.ctrlpanel.SuspendLayout();
		this.Panel3.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		this.keyboardpanel.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.Button5).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.Button7).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.Button6).BeginInit();
		this.buttompanel.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.viewpic).BeginInit();
		base.SuspendLayout();
		this.activetext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.activetext.ForeColor = global::System.Drawing.Color.Lime;
		this.activetext.Location = new global::System.Drawing.Point(74, 646);
		this.activetext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.activetext.Name = "activetext";
		this.activetext.Size = new global::System.Drawing.Size(216, 23);
		this.activetext.TabIndex = 24;
		this.activetext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.ctrlpanel.BackColor = global::System.Drawing.Color.Black;
		this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon1);
		this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon4);
		this.ctrlpanel.Location = new global::System.Drawing.Point(237, 557);
		this.ctrlpanel.Name = "ctrlpanel";
		this.ctrlpanel.Size = new global::System.Drawing.Size(36, 30);
		this.ctrlpanel.TabIndex = 2;
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(129, 0);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 10;
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(57, 30);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57353;
		this.DrakeUIButtonIcon1.TabIndex = 22;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon1, "Home");
		this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
		this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.IsCircle = true;
		this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(283, 0);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 10;
		this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(53, 27);
		this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61524;
		this.DrakeUIButtonIcon4.TabIndex = 23;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon4, "Return");
		this.DrakeUIButtonIcon4.Click += new global::System.EventHandler(this.DrakeUIButtonIcon4_Click);
		this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(117, 557);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 10;
		this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(101, 30);
		this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61641;
		this.DrakeUIButtonIcon3.SymbolSize = 20;
		this.DrakeUIButtonIcon3.TabIndex = 21;
		this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon3, "Recent");
		this.DrakeUIButtonIcon3.Click += new global::System.EventHandler(this.DrakeUIButtonIcon3_Click);
		this.presstimer.Interval = 1000;
		this.presstimer.Tick += new global::System.EventHandler(this.Presstimer_Tick);
		this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.Black;
		this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIToolTip1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.savetimer.Interval = 1000;
		this.savetimer.Tick += new global::System.EventHandler(this.Savetimer_Tick);
		this.Panel3.BackColor = global::System.Drawing.Color.Black;
		this.Panel3.Controls.Add(this.clinameinfo);
		this.Panel3.Controls.Add(this.ClientPic);
		this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel3.ForeColor = global::System.Drawing.Color.Red;
		this.Panel3.Location = new global::System.Drawing.Point(0, 0);
		this.Panel3.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new global::System.Drawing.Size(353, 24);
		this.Panel3.TabIndex = 6;
		this.clinameinfo.BackColor = global::System.Drawing.Color.Transparent;
		this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clinameinfo.Location = new global::System.Drawing.Point(31, 0);
		this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new global::System.Drawing.Size(373, 24);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.ClientPic.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new global::System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new global::System.Drawing.Size(31, 24);
		this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		this.keyboardpanel.Controls.Add(this.Button5);
		this.keyboardpanel.Controls.Add(this.Button7);
		this.keyboardpanel.Controls.Add(this.Button6);
		this.keyboardpanel.Location = new global::System.Drawing.Point(0, 0);
		this.keyboardpanel.Margin = new global::System.Windows.Forms.Padding(2);
		this.keyboardpanel.Name = "keyboardpanel";
		this.keyboardpanel.Size = new global::System.Drawing.Size(351, 30);
		this.keyboardpanel.TabIndex = 7;
		this.keyboardpanel.Tag = "b";
		this.Button5.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.Button5.Image = global::Craxs_Rat_Applications.icons8_back_64;
		this.Button5.Location = new global::System.Drawing.Point(258, 2);
		this.Button5.Name = "Button5";
		this.Button5.Size = new global::System.Drawing.Size(32, 28);
		this.Button5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.Button5.TabIndex = 95;
		this.Button5.TabStop = false;
		this.Button5.Click += new global::System.EventHandler(this.Button5_Click);
		this.Button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.Button7.Image = global::Craxs_Rat_Applications.icons8_xbox_menu_30;
		this.Button7.Location = new global::System.Drawing.Point(60, 2);
		this.Button7.Name = "Button7";
		this.Button7.Size = new global::System.Drawing.Size(32, 28);
		this.Button7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.Button7.TabIndex = 94;
		this.Button7.TabStop = false;
		this.Button7.Click += new global::System.EventHandler(this.Button7_Click);
		this.Button6.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.Button6.Image = global::Craxs_Rat_Applications.icons8_stop_100;
		this.Button6.Location = new global::System.Drawing.Point(156, 2);
		this.Button6.Name = "Button6";
		this.Button6.Size = new global::System.Drawing.Size(32, 28);
		this.Button6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.Button6.TabIndex = 93;
		this.Button6.TabStop = false;
		this.Button6.Click += new global::System.EventHandler(this.Button6_Click);
		this.buttompanel.Controls.Add(this.keyboardpanel);
		this.buttompanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.buttompanel.Location = new global::System.Drawing.Point(0, 691);
		this.buttompanel.Margin = new global::System.Windows.Forms.Padding(2);
		this.buttompanel.Name = "buttompanel";
		this.buttompanel.Size = new global::System.Drawing.Size(353, 30);
		this.buttompanel.TabIndex = 8;
		this.viewpic.Location = new global::System.Drawing.Point(0, 47);
		this.viewpic.Margin = new global::System.Windows.Forms.Padding(2);
		this.viewpic.Name = "viewpic";
		this.viewpic.Size = new global::System.Drawing.Size(351, 614);
		this.viewpic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.viewpic.TabIndex = 3;
		this.viewpic.TabStop = false;
		this.viewpic.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
		this.viewpic.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseMove);
		this.viewpic.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseUp);
		this.textsend.BorderColor = global::System.Drawing.Color.Red;
		this.textsend.BorderRadius = 5;
		this.textsend.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.textsend.DefaultText = "";
		this.textsend.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.textsend.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.textsend.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.textsend.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.textsend.FillColor = global::System.Drawing.Color.Black;
		this.textsend.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.textsend.Font = new global::System.Drawing.Font("Segoe UI", 9f);
		this.textsend.ForeColor = global::System.Drawing.Color.White;
		this.textsend.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.textsend.Location = new global::System.Drawing.Point(23, 666);
		this.textsend.Name = "textsend";
		this.textsend.PasswordChar = '\0';
		this.textsend.PlaceholderText = "Enter text";
		this.textsend.SelectedText = "";
		this.textsend.Size = new global::System.Drawing.Size(293, 20);
		this.textsend.TabIndex = 99;
		this.Enterbutton.AutoRoundedCorners = true;
		this.Enterbutton.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
		this.Enterbutton.BorderRadius = 9;
		this.Enterbutton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.Enterbutton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.Enterbutton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.Enterbutton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.Enterbutton.FillColor = global::System.Drawing.Color.Transparent;
		this.Enterbutton.Font = new global::System.Drawing.Font("Segoe UI", 9f);
		this.Enterbutton.ForeColor = global::System.Drawing.Color.White;
		this.Enterbutton.HoverState.BorderColor = global::System.Drawing.Color.Aqua;
		this.Enterbutton.Image = global::Craxs_Rat_Applications.icons8_send_30;
		this.Enterbutton.Location = new global::System.Drawing.Point(331, 666);
		this.Enterbutton.Name = "Enterbutton";
		this.Enterbutton.Size = new global::System.Drawing.Size(20, 20);
		this.Enterbutton.TabIndex = 100;
		this.Enterbutton.Click += new global::System.EventHandler(this.Enterbutton_Click);
		this.DrakeUILabel1.Font = new global::System.Drawing.Font("Bahnschrift", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUILabel1.ForeColor = global::System.Drawing.Color.Red;
		this.DrakeUILabel1.Location = new global::System.Drawing.Point(56, 17);
		this.DrakeUILabel1.Name = "DrakeUILabel1";
		this.DrakeUILabel1.Size = new global::System.Drawing.Size(274, 28);
		this.DrakeUILabel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUILabel1.TabIndex = 101;
		this.DrakeUILabel1.Text = "Screen Reader";
		this.DrakeUILabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(353, 721);
		base.Controls.Add(this.DrakeUILabel1);
		base.Controls.Add(this.Enterbutton);
		base.Controls.Add(this.textsend);
		base.Controls.Add(this.activetext);
		base.Controls.Add(this.buttompanel);
		base.Controls.Add(this.viewpic);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.DrakeUIButtonIcon3);
		base.Controls.Add(this.ctrlpanel);
		this.ForeColor = global::System.Drawing.Color.Red;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new global::System.Windows.Forms.Padding(2);
		this.MaximumSize = new global::System.Drawing.Size(369, 760);
		this.MinimumSize = new global::System.Drawing.Size(369, 760);
		base.Name = "ScreenReaderV2";
		this.Text = "Screen Reader";
		base.Load += new global::System.EventHandler(this.ScreenReaderV2_Load);
		this.ctrlpanel.ResumeLayout(false);
		this.Panel3.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		this.keyboardpanel.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.Button5).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.Button7).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.Button6).EndInit();
		this.buttompanel.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.viewpic).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000AE0 RID: 2784
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000AFE RID: 2814
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctrlpanel")]
	internal global::System.Windows.Forms.Panel ctrlpanel;

	// Token: 0x04000AFF RID: 2815
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x04000B00 RID: 2816
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon3;

	// Token: 0x04000B01 RID: 2817
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon4;

	// Token: 0x04000B02 RID: 2818
	internal global::System.Windows.Forms.Timer presstimer;

	// Token: 0x04000B03 RID: 2819
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
	internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

	// Token: 0x04000B04 RID: 2820
	internal global::System.Windows.Forms.Timer savetimer;

	// Token: 0x04000B05 RID: 2821
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("activetext")]
	internal global::System.Windows.Forms.Label activetext;

	// Token: 0x04000B06 RID: 2822
	internal global::System.Windows.Forms.PictureBox viewpic;

	// Token: 0x04000B07 RID: 2823
	internal global::System.Windows.Forms.Timer Timer1;

	// Token: 0x04000B08 RID: 2824
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel3")]
	internal global::System.Windows.Forms.Panel Panel3;

	// Token: 0x04000B09 RID: 2825
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
	internal global::System.Windows.Forms.Label clinameinfo;

	// Token: 0x04000B0A RID: 2826
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
	internal global::System.Windows.Forms.PictureBox ClientPic;

	// Token: 0x04000B0B RID: 2827
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("keyboardpanel")]
	internal global::System.Windows.Forms.Panel keyboardpanel;

	// Token: 0x04000B0C RID: 2828
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("buttompanel")]
	internal global::System.Windows.Forms.Panel buttompanel;

	// Token: 0x04000B0D RID: 2829
	private global::Guna.UI2.WinForms.Guna2TextBox textsend;

	// Token: 0x04000B0E RID: 2830
	internal global::Guna.UI2.WinForms.Guna2Button Enterbutton;

	// Token: 0x04000B0F RID: 2831
	internal global::System.Windows.Forms.PictureBox Button5;

	// Token: 0x04000B10 RID: 2832
	internal global::System.Windows.Forms.PictureBox Button7;

	// Token: 0x04000B11 RID: 2833
	internal global::DrakeUI.Framework.DrakeUILabel DrakeUILabel1;

	// Token: 0x04000B12 RID: 2834
	internal global::System.Windows.Forms.PictureBox Button6;
}
