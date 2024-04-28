// Token: 0x020000C0 RID: 192
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class smsMaker : global::System.Windows.Forms.Form
{
	// Token: 0x0600084A RID: 2122 RVA: 0x000C58D8 File Offset: 0x000C3AD8
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

	// Token: 0x0600084B RID: 2123 RVA: 0x000C591C File Offset: 0x000C3B1C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.phonetext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.msgtext = new global::DrakeUI.Framework.DrakeUITextBox();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.Label34 = new global::System.Windows.Forms.Label();
		this.numslist = new global::DrakeUI.Framework.DrakeUIListBox();
		this.remnum = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.addnum = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.selectlist = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.checkall = new global::DrakeUI.Framework.DrakeUICheckBox();
		base.SuspendLayout();
		this.phonetext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.phonetext.FillColor = global::System.Drawing.Color.White;
		this.phonetext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.phonetext.Location = new global::System.Drawing.Point(76, 348);
		this.phonetext.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.phonetext.Maximum = 2147483647.0;
		this.phonetext.Minimum = -2147483648.0;
		this.phonetext.Name = "phonetext";
		this.phonetext.Padding = new global::System.Windows.Forms.Padding(4);
		this.phonetext.RectColor = global::System.Drawing.Color.FromArgb(56, 142, 60);
		this.phonetext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.phonetext.Size = new global::System.Drawing.Size(170, 27);
		this.phonetext.Style = global::DrakeUI.Framework.UIStyle.Green;
		this.phonetext.TabIndex = 0;
		this.phonetext.TextAlignment = global::System.Drawing.ContentAlignment.BottomCenter;
		this.phonetext.Watermark = "Phone Number";
		this.phonetext.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.Phonetext_KeyPress);
		this.msgtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.msgtext.FillColor = global::System.Drawing.Color.White;
		this.msgtext.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.msgtext.Location = new global::System.Drawing.Point(305, 32);
		this.msgtext.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.msgtext.Maximum = 2147483647.0;
		this.msgtext.MaxLength = 160;
		this.msgtext.Minimum = -2147483648.0;
		this.msgtext.Multiline = true;
		this.msgtext.Name = "msgtext";
		this.msgtext.Padding = new global::System.Windows.Forms.Padding(4);
		this.msgtext.RectColor = global::System.Drawing.Color.FromArgb(230, 80, 80);
		this.msgtext.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.msgtext.Size = new global::System.Drawing.Size(274, 294);
		this.msgtext.Style = global::DrakeUI.Framework.UIStyle.Red;
		this.msgtext.StyleCustomMode = true;
		this.msgtext.TabIndex = 1;
		this.msgtext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
		this.DrakeUIToolTip1.SetToolTip(this.msgtext, "Max limit 160");
		this.msgtext.Watermark = "";
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(478, 409);
		this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(102, 28);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 61768;
		this.DrakeUIButtonIcon1.TabIndex = 2;
		this.DrakeUIButtonIcon1.Text = "Send";
		this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_click);
		this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(365, 409);
		this.DrakeUIButtonIcon2.Margin = new global::System.Windows.Forms.Padding(2);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(103, 28);
		this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61453;
		this.DrakeUIButtonIcon2.TabIndex = 3;
		this.DrakeUIButtonIcon2.Text = "Cancel";
		this.DrakeUIButtonIcon2.Click += new global::System.EventHandler(this.DrakeUIButtonIcon2_Click);
		this.Label1.AutoSize = true;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label1.Location = new global::System.Drawing.Point(87, 7);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(118, 19);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "Phones Numbers";
		this.Label34.AutoSize = true;
		this.Label34.BackColor = global::System.Drawing.Color.Transparent;
		this.Label34.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Label34.ForeColor = global::System.Drawing.Color.White;
		this.Label34.Location = new global::System.Drawing.Point(438, 349);
		this.Label34.Name = "Label34";
		this.Label34.Size = new global::System.Drawing.Size(89, 19);
		this.Label34.TabIndex = 66;
		this.Label34.Text = "All contacts";
		this.numslist.FillColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
		this.numslist.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.numslist.ItemSelectBackColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.numslist.ItemSelectForeColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
		this.numslist.Location = new global::System.Drawing.Point(14, 32);
		this.numslist.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
		this.numslist.Name = "numslist";
		this.numslist.Padding = new global::System.Windows.Forms.Padding(2);
		this.numslist.RectColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
		this.numslist.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.numslist.Size = new global::System.Drawing.Size(274, 294);
		this.numslist.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.numslist.StyleCustomMode = true;
		this.numslist.TabIndex = 67;
		this.numslist.Text = "DrakeUIListBox1";
		this.remnum.AvatarSize = 30;
		this.remnum.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.remnum.FillColor = global::System.Drawing.Color.Black;
		this.remnum.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.remnum.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.remnum.Location = new global::System.Drawing.Point(11, 349);
		this.remnum.Name = "remnum";
		this.remnum.Size = new global::System.Drawing.Size(26, 24);
		this.remnum.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.remnum.Symbol = 61526;
		this.remnum.SymbolSize = 30;
		this.remnum.TabIndex = 69;
		this.remnum.Text = "DrakeUIAvatar2";
		this.DrakeUIToolTip1.SetToolTip(this.remnum, "Remove numer from list");
		this.remnum.Click += new global::System.EventHandler(this.Remnum_Click);
		this.addnum.AvatarSize = 30;
		this.addnum.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.addnum.FillColor = global::System.Drawing.Color.Black;
		this.addnum.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.addnum.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.addnum.Location = new global::System.Drawing.Point(44, 349);
		this.addnum.Name = "addnum";
		this.addnum.Size = new global::System.Drawing.Size(26, 24);
		this.addnum.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.addnum.Symbol = 61525;
		this.addnum.SymbolSize = 30;
		this.addnum.TabIndex = 68;
		this.addnum.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.addnum, "add number to list");
		this.addnum.Click += new global::System.EventHandler(this.Addnum_Click);
		this.selectlist.AvatarSize = 30;
		this.selectlist.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.selectlist.FillColor = global::System.Drawing.Color.Black;
		this.selectlist.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.selectlist.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.selectlist.Location = new global::System.Drawing.Point(260, 348);
		this.selectlist.Name = "selectlist";
		this.selectlist.Size = new global::System.Drawing.Size(26, 24);
		this.selectlist.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.selectlist.Symbol = 61462;
		this.selectlist.SymbolSize = 30;
		this.selectlist.TabIndex = 70;
		this.selectlist.Text = "DrakeUIAvatar1";
		this.DrakeUIToolTip1.SetToolTip(this.selectlist, "get numbers from text file");
		this.selectlist.Click += new global::System.EventHandler(this.Selectlist_Click);
		this.Label2.AutoSize = true;
		this.Label2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.Label2.Location = new global::System.Drawing.Point(398, 7);
		this.Label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(97, 19);
		this.Label2.TabIndex = 71;
		this.Label2.Text = "Message text";
		this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.Black;
		this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.DrakeUIToolTip1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkall.CheckBoxColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.checkall.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.checkall.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.checkall.Location = new global::System.Drawing.Point(401, 344);
		this.checkall.Margin = new global::System.Windows.Forms.Padding(2);
		this.checkall.Name = "checkall";
		this.checkall.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.checkall.Size = new global::System.Drawing.Size(32, 24);
		this.checkall.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.checkall.StyleCustomMode = true;
		this.checkall.TabIndex = 72;
		this.checkall.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Checkall_MouseClick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(590, 447);
		base.ControlBox = false;
		base.Controls.Add(this.checkall);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.selectlist);
		base.Controls.Add(this.remnum);
		base.Controls.Add(this.addnum);
		base.Controls.Add(this.numslist);
		base.Controls.Add(this.Label34);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.DrakeUIButtonIcon2);
		base.Controls.Add(this.DrakeUIButtonIcon1);
		base.Controls.Add(this.msgtext);
		base.Controls.Add(this.phonetext);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new global::System.Windows.Forms.Padding(2);
		this.MaximumSize = new global::System.Drawing.Size(606, 486);
		this.MinimumSize = new global::System.Drawing.Size(606, 486);
		base.Name = "smsMaker";
		base.Opacity = 0.1;
		base.ShowIcon = false;
		this.Text = "SEND SMS";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000C34 RID: 3124
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000C3C RID: 3132
	internal global::DrakeUI.Framework.DrakeUITextBox phonetext;

	// Token: 0x04000C3D RID: 3133
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("msgtext")]
	internal global::DrakeUI.Framework.DrakeUITextBox msgtext;

	// Token: 0x04000C3E RID: 3134
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x04000C3F RID: 3135
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon2;

	// Token: 0x04000C40 RID: 3136
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x04000C41 RID: 3137
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label34")]
	internal global::System.Windows.Forms.Label Label34;

	// Token: 0x04000C42 RID: 3138
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("numslist")]
	internal global::DrakeUI.Framework.DrakeUIListBox numslist;

	// Token: 0x04000C43 RID: 3139
	internal global::DrakeUI.Framework.DrakeUIAvatar remnum;

	// Token: 0x04000C44 RID: 3140
	internal global::DrakeUI.Framework.DrakeUIAvatar addnum;

	// Token: 0x04000C45 RID: 3141
	internal global::DrakeUI.Framework.DrakeUIAvatar selectlist;

	// Token: 0x04000C46 RID: 3142
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000C47 RID: 3143
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
	internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

	// Token: 0x04000C48 RID: 3144
	internal global::DrakeUI.Framework.DrakeUICheckBox checkall;
}
