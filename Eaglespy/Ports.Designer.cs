// Token: 0x020000A1 RID: 161
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Ports : global::System.Windows.Forms.Form
{
	// Token: 0x060006DF RID: 1759 RVA: 0x000ACD28 File Offset: 0x000AAF28
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

	// Token: 0x060006E0 RID: 1760 RVA: 0x000ACD6C File Offset: 0x000AAF6C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.notpass = new global::System.Windows.Forms.NotifyIcon(this.components);
		this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
		this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
		this.loginworker = new global::System.ComponentModel.BackgroundWorker();
		this.DrakeUILabel1 = new global::DrakeUI.Framework.DrakeUILabel();
		this.KeyAuthRegister = new global::Guna.UI2.WinForms.Guna2GradientButton();
		this.KeyAuthPass = new global::Guna.UI2.WinForms.Guna2TextBox();
		this.KeyAuthUser = new global::Guna.UI2.WinForms.Guna2TextBox();
		this.DrakeUILabel2 = new global::DrakeUI.Framework.DrakeUILabel();
		this.SPanel1 = new global::Sipaa.Framework.SPanel();
		this.KeyAuthKey = new global::Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
		this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.Login = new global::Guna.UI2.WinForms.Guna2GradientButton();
		this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
		this.Guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
		this.SPanel1.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.Guna2PictureBox1).BeginInit();
		base.SuspendLayout();
		this.notpass.Text = "NotifyIcon1";
		this.notpass.Visible = true;
		this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
		this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
		this.DrakeUIToolTip1.OwnerDraw = true;
		this.loginworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Loginworker_DoWork);
		this.DrakeUILabel1.Font = new global::System.Drawing.Font("Bahnschrift", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUILabel1.ForeColor = global::System.Drawing.Color.Red;
		this.DrakeUILabel1.Location = new global::System.Drawing.Point(42, 10);
		this.DrakeUILabel1.Name = "DrakeUILabel1";
		this.DrakeUILabel1.Size = new global::System.Drawing.Size(178, 31);
		this.DrakeUILabel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUILabel1.TabIndex = 57;
		this.DrakeUILabel1.Text = "Licence Panel";
		this.DrakeUILabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.KeyAuthRegister.Animated = true;
		this.KeyAuthRegister.AutoRoundedCorners = true;
		this.KeyAuthRegister.BorderColor = global::System.Drawing.Color.Red;
		this.KeyAuthRegister.BorderRadius = 14;
		this.KeyAuthRegister.BorderThickness = 2;
		this.KeyAuthRegister.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.KeyAuthRegister.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.KeyAuthRegister.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.KeyAuthRegister.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.KeyAuthRegister.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.KeyAuthRegister.FillColor = global::System.Drawing.Color.Red;
		this.KeyAuthRegister.FillColor2 = global::System.Drawing.Color.Red;
		this.KeyAuthRegister.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.KeyAuthRegister.ForeColor = global::System.Drawing.Color.White;
		this.KeyAuthRegister.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
		this.KeyAuthRegister.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
		this.KeyAuthRegister.Location = new global::System.Drawing.Point(30, 340);
		this.KeyAuthRegister.Name = "KeyAuthRegister";
		this.KeyAuthRegister.Size = new global::System.Drawing.Size(201, 31);
		this.KeyAuthRegister.TabIndex = 55;
		this.KeyAuthRegister.Text = "OK";
		this.KeyAuthRegister.Click += new global::System.EventHandler(this.KeyAuthRegister_Click);
		this.KeyAuthPass.BorderColor = global::System.Drawing.Color.Red;
		this.KeyAuthPass.BorderRadius = 4;
		this.KeyAuthPass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.KeyAuthPass.DefaultText = "";
		this.KeyAuthPass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.KeyAuthPass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.KeyAuthPass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthPass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthPass.FillColor = global::System.Drawing.Color.Black;
		this.KeyAuthPass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthPass.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
		this.KeyAuthPass.ForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthPass.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthPass.Location = new global::System.Drawing.Point(30, 120);
		this.KeyAuthPass.Margin = new global::System.Windows.Forms.Padding(5, 4, 5, 4);
		this.KeyAuthPass.Name = "KeyAuthPass";
		this.KeyAuthPass.PasswordChar = '\0';
		this.KeyAuthPass.PlaceholderForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthPass.PlaceholderText = "Password";
		this.KeyAuthPass.SelectedText = "";
		this.KeyAuthPass.Size = new global::System.Drawing.Size(200, 36);
		this.KeyAuthPass.TabIndex = 55;
		this.KeyAuthPass.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.KeyAuthUser.BorderColor = global::System.Drawing.Color.Red;
		this.KeyAuthUser.BorderRadius = 4;
		this.KeyAuthUser.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.KeyAuthUser.DefaultText = "";
		this.KeyAuthUser.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.KeyAuthUser.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.KeyAuthUser.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthUser.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthUser.FillColor = global::System.Drawing.Color.Black;
		this.KeyAuthUser.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthUser.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 12f, global::System.Drawing.FontStyle.Bold);
		this.KeyAuthUser.ForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthUser.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthUser.Location = new global::System.Drawing.Point(31, 62);
		this.KeyAuthUser.Margin = new global::System.Windows.Forms.Padding(5, 4, 5, 4);
		this.KeyAuthUser.Name = "KeyAuthUser";
		this.KeyAuthUser.PasswordChar = '\0';
		this.KeyAuthUser.PlaceholderForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthUser.PlaceholderText = "User/Email";
		this.KeyAuthUser.SelectedText = "";
		this.KeyAuthUser.Size = new global::System.Drawing.Size(200, 36);
		this.KeyAuthUser.TabIndex = 54;
		this.KeyAuthUser.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.DrakeUILabel2.Font = new global::System.Drawing.Font("Bahnschrift", 36f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUILabel2.ForeColor = global::System.Drawing.Color.Red;
		this.DrakeUILabel2.Location = new global::System.Drawing.Point(30, 10);
		this.DrakeUILabel2.Name = "DrakeUILabel2";
		this.DrakeUILabel2.Size = new global::System.Drawing.Size(263, 68);
		this.DrakeUILabel2.TabIndex = 71;
		this.DrakeUILabel2.Text = "EagleSpy";
		this.DrakeUILabel2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.SPanel1.BackColor = global::System.Drawing.Color.Black;
		this.SPanel1.BorderColor = global::System.Drawing.Color.Black;
		this.SPanel1.BorderRadius = 6;
		this.SPanel1.BorderSize = 0;
		this.SPanel1.Controls.Add(this.DrakeUILabel1);
		this.SPanel1.Controls.Add(this.KeyAuthPass);
		this.SPanel1.Controls.Add(this.KeyAuthUser);
		this.SPanel1.Controls.Add(this.KeyAuthKey);
		this.SPanel1.ForeColor = global::System.Drawing.Color.FromArgb(0, 189, 66);
		this.SPanel1.Location = new global::System.Drawing.Point(3, 81);
		this.SPanel1.Name = "SPanel1";
		this.SPanel1.Size = new global::System.Drawing.Size(246, 253);
		this.SPanel1.TabIndex = 66;
		this.KeyAuthKey.BorderColor = global::System.Drawing.Color.Red;
		this.KeyAuthKey.BorderRadius = 4;
		this.KeyAuthKey.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.KeyAuthKey.DefaultText = "";
		this.KeyAuthKey.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
		this.KeyAuthKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
		this.KeyAuthKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
		this.KeyAuthKey.FillColor = global::System.Drawing.Color.Black;
		this.KeyAuthKey.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthKey.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.KeyAuthKey.ForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthKey.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
		this.KeyAuthKey.Location = new global::System.Drawing.Point(31, 175);
		this.KeyAuthKey.Margin = new global::System.Windows.Forms.Padding(5, 4, 5, 4);
		this.KeyAuthKey.Name = "KeyAuthKey";
		this.KeyAuthKey.PasswordChar = '*';
		this.KeyAuthKey.PlaceholderForeColor = global::System.Drawing.Color.Red;
		this.KeyAuthKey.PlaceholderText = "Key";
		this.KeyAuthKey.SelectedText = "";
		this.KeyAuthKey.Size = new global::System.Drawing.Size(200, 36);
		this.KeyAuthKey.TabIndex = 53;
		this.KeyAuthKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2BorderlessForm1.ContainerControl = this;
		this.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
		this.Guna2BorderlessForm1.TransparentWhileDrag = true;
		this.notifyIcon1.Text = "NotifyIcon1";
		this.notifyIcon1.Visible = true;
		this.TOpacity.Interval = 1;
		this.Login.Animated = true;
		this.Login.BorderColor = global::System.Drawing.Color.Red;
		this.Login.BorderRadius = 4;
		this.Login.BorderThickness = 2;
		this.Login.CheckedState.FillColor = global::System.Drawing.Color.Red;
		this.Login.CheckedState.FillColor2 = global::System.Drawing.Color.Red;
		this.Login.DisabledState.BorderColor = global::System.Drawing.Color.Red;
		this.Login.DisabledState.CustomBorderColor = global::System.Drawing.Color.Red;
		this.Login.DisabledState.FillColor = global::System.Drawing.Color.Red;
		this.Login.DisabledState.FillColor2 = global::System.Drawing.Color.Red;
		this.Login.DisabledState.ForeColor = global::System.Drawing.Color.White;
		this.Login.FillColor = global::System.Drawing.Color.Red;
		this.Login.FillColor2 = global::System.Drawing.Color.Red;
		this.Login.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Login.ForeColor = global::System.Drawing.Color.White;
		this.Login.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
		this.Login.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
		this.Login.Location = new global::System.Drawing.Point(351, 356);
		this.Login.Name = "Login";
		this.Login.Size = new global::System.Drawing.Size(201, 31);
		this.Login.TabIndex = 63;
		this.Login.Text = "LOGIN";
		this.Login.Click += new global::System.EventHandler(this.Login_Click);
		this.PictureBox2.Image = global::Craxs_Rat_Applications.icons8_x_30;
		this.PictureBox2.Location = new global::System.Drawing.Point(599, 2);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new global::System.Drawing.Size(34, 29);
		this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 70;
		this.PictureBox2.TabStop = false;
		this.PictureBox2.Click += new global::System.EventHandler(this.PictureBox2_Click);
		this.Guna2PictureBox1.FillColor = global::System.Drawing.Color.Black;
		this.Guna2PictureBox1.Image = global::Craxs_Rat_Applications.eagle;
		this.Guna2PictureBox1.ImageRotate = 0f;
		this.Guna2PictureBox1.Location = new global::System.Drawing.Point(278, 2);
		this.Guna2PictureBox1.Name = "Guna2PictureBox1";
		this.Guna2PictureBox1.Size = new global::System.Drawing.Size(355, 348);
		this.Guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Guna2PictureBox1.TabIndex = 72;
		this.Guna2PictureBox1.TabStop = false;
		this.Guna2PictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Guna2PictureBox1_MouseDown);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(636, 401);
		base.Controls.Add(this.PictureBox2);
		base.Controls.Add(this.KeyAuthRegister);
		base.Controls.Add(this.Guna2PictureBox1);
		base.Controls.Add(this.DrakeUILabel2);
		base.Controls.Add(this.SPanel1);
		base.Controls.Add(this.Login);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		this.MaximumSize = new global::System.Drawing.Size(636, 401);
		this.MinimumSize = new global::System.Drawing.Size(636, 401);
		base.Name = "Ports";
		base.Opacity = 0.9;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Ports";
		base.Load += new global::System.EventHandler(this.Ports_Load);
		base.Click += new global::System.EventHandler(this.Ports_Click);
		this.SPanel1.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.Guna2PictureBox1).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000A23 RID: 2595
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000A3C RID: 2620
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("notpass")]
	internal global::System.Windows.Forms.NotifyIcon notpass;

	// Token: 0x04000A3D RID: 2621
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
	internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

	// Token: 0x04000A3E RID: 2622
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ToolTip1")]
	internal global::System.Windows.Forms.Timer Timer1;

	// Token: 0x04000A3F RID: 2623
	internal global::System.Windows.Forms.PictureBox PictureBox2;

	// Token: 0x04000A40 RID: 2624
	internal global::Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;

	// Token: 0x04000A41 RID: 2625
	internal global::DrakeUI.Framework.DrakeUILabel DrakeUILabel1;

	// Token: 0x04000A42 RID: 2626
	internal global::Guna.UI2.WinForms.Guna2GradientButton KeyAuthRegister;

	// Token: 0x04000A43 RID: 2627
	internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthPass;

	// Token: 0x04000A44 RID: 2628
	internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthUser;

	// Token: 0x04000A45 RID: 2629
	internal global::DrakeUI.Framework.DrakeUILabel DrakeUILabel2;

	// Token: 0x04000A46 RID: 2630
	internal global::Sipaa.Framework.SPanel SPanel1;

	// Token: 0x04000A47 RID: 2631
	internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthKey;

	// Token: 0x04000A48 RID: 2632
	internal global::Guna.UI2.WinForms.Guna2BorderlessForm Guna2BorderlessForm1;

	// Token: 0x04000A49 RID: 2633
	internal global::Guna.UI2.WinForms.Guna2GradientButton Login;

	// Token: 0x04000A4A RID: 2634
	internal global::System.Windows.Forms.NotifyIcon notifyIcon1;

	// Token: 0x04000A4B RID: 2635
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000A4C RID: 2636
	internal global::System.ComponentModel.BackgroundWorker loginworker;
}
