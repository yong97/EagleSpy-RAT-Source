﻿// Token: 0x0200004A RID: 74
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Color_Box0 : global::System.Windows.Forms.Form
{
	// Token: 0x06000355 RID: 853 RVA: 0x00050CC8 File Offset: 0x0004EEC8
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

	// Token: 0x06000356 RID: 854 RVA: 0x00050D0C File Offset: 0x0004EF0C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.C_Box3 = new global::System.Windows.Forms.PictureBox();
		this.C_Box2 = new global::System.Windows.Forms.PictureBox();
		this.BTN_OK = new global::System.Windows.Forms.Button();
		this.C_Box0 = new global::System.Windows.Forms.PictureBox();
		this.ti = new global::System.Windows.Forms.Timer(this.components);
		this.CK1 = new global::System.Windows.Forms.CheckBox();
		this.BoxTitle = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.C_Box3).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.C_Box2).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.C_Box0).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		base.SuspendLayout();
		this.C_Box2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.C_Box2_Paint);
		this.C_Box2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.C_Box2_MouseDown);
		this.C_Box2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.C_Box2_MouseMove);
		this.C_Box2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.C_Box2_MouseUp);
		this.C_Box2.Click += new global::System.EventHandler(this.C_Box2_Click);
		this.BTN_OK.Click += new global::System.EventHandler(this.BTN_OK_Click);
		this.C_Box0.Paint += new global::System.Windows.Forms.PaintEventHandler(this.C_Box0_Paint);
		this.C_Box0.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.C_Box0_MouseDown);
		this.C_Box0.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.C_Box0_MouseMove);
		this.C_Box0.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.C_Box0_MouseUp);
		this.C_Box0.Click += new global::System.EventHandler(this.C_Box0_Click);
		this.ti.Tick += new global::System.EventHandler(this.ti_Tick);
		this.CK1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.CK1_MouseDown);
		this.CK1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.CK1_MouseUp);
		this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
		this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
		this.BoxTitle.Click += new global::System.EventHandler(this.BoxTitle_Click);
		this.C_Box3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box3.Location = new global::System.Drawing.Point(98, 117);
		this.C_Box3.Name = "C_Box3";
		this.C_Box3.Size = new global::System.Drawing.Size(50, 48);
		this.C_Box3.TabIndex = 7;
		this.C_Box3.TabStop = false;
		this.C_Box2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box2.Location = new global::System.Drawing.Point(3, 117);
		this.C_Box2.Name = "C_Box2";
		this.C_Box2.Size = new global::System.Drawing.Size(93, 19);
		this.C_Box2.TabIndex = 6;
		this.C_Box2.TabStop = false;
		this.BTN_OK.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
		this.BTN_OK.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.BTN_OK.ForeColor = global::System.Drawing.Color.Black;
		this.BTN_OK.Location = new global::System.Drawing.Point(3, 142);
		this.BTN_OK.Name = "BTN_OK";
		this.BTN_OK.Size = new global::System.Drawing.Size(93, 23);
		this.BTN_OK.TabIndex = 5;
		this.BTN_OK.Text = "OK";
		this.BTN_OK.UseVisualStyleBackColor = false;
		this.C_Box0.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.C_Box0.Location = new global::System.Drawing.Point(3, 3);
		this.C_Box0.Name = "C_Box0";
		this.C_Box0.Size = new global::System.Drawing.Size(145, 86);
		this.C_Box0.TabIndex = 4;
		this.C_Box0.TabStop = false;
		this.CK1.AutoSize = true;
		this.CK1.Location = new global::System.Drawing.Point(3, 94);
		this.CK1.Name = "CK1";
		this.CK1.Size = new global::System.Drawing.Size(93, 17);
		this.CK1.TabIndex = 8;
		this.CK1.Tag = "";
		this.CK1.Text = "Color Dropper";
		this.CK1.UseVisualStyleBackColor = true;
		this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
		this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new global::System.Drawing.Point(0, 169);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new global::System.Drawing.Size(151, 18);
		this.BoxTitle.TabIndex = 9;
		this.BoxTitle.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(151, 187);
		base.Controls.Add(this.BoxTitle);
		base.Controls.Add(this.CK1);
		base.Controls.Add(this.C_Box3);
		base.Controls.Add(this.C_Box2);
		base.Controls.Add(this.BTN_OK);
		base.Controls.Add(this.C_Box0);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Color_Box0";
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Color Box";
		((global::System.ComponentModel.ISupportInitialize)this.C_Box3).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.C_Box2).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.C_Box0).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040003B8 RID: 952
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040003CA RID: 970
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("C_Box3")]
	internal global::System.Windows.Forms.PictureBox C_Box3;

	// Token: 0x040003CB RID: 971
	internal global::System.Windows.Forms.PictureBox C_Box2;

	// Token: 0x040003CC RID: 972
	internal global::System.Windows.Forms.Button BTN_OK;

	// Token: 0x040003CD RID: 973
	internal global::System.Windows.Forms.PictureBox C_Box0;

	// Token: 0x040003CE RID: 974
	internal global::System.Windows.Forms.Timer ti;

	// Token: 0x040003CF RID: 975
	internal global::System.Windows.Forms.CheckBox CK1;

	// Token: 0x040003D0 RID: 976
	internal global::System.Windows.Forms.PictureBox BoxTitle;
}
