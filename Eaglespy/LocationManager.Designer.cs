// Token: 0x02000090 RID: 144
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class LocationManager : global::System.Windows.Forms.Form
{
	// Token: 0x0600066A RID: 1642 RVA: 0x000A3488 File Offset: 0x000A1688
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

	// Token: 0x0600066B RID: 1643 RVA: 0x000A34CC File Offset: 0x000A16CC
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.Map = new global::System.Windows.Forms.PictureBox();
		this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.OpenUsingGoogleMapsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.OpenUsingMapBoxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.TextBox1 = new global::System.Windows.Forms.TextBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.DrakeUICheckBox1 = new global::DrakeUI.Framework.DrakeUICheckBox();
		this.savetimer = new global::System.Windows.Forms.Timer(this.components);
		this.guna2GradientTileButton1 = new global::Guna.UI2.WinForms.Guna2GradientTileButton();
		((global::System.ComponentModel.ISupportInitialize)this.Map).BeginInit();
		this.ctxMenu.SuspendLayout();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Map.BackColor = global::System.Drawing.Color.Black;
		this.Map.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Map.Location = new global::System.Drawing.Point(0, 0);
		this.Map.Name = "Map";
		this.Map.Size = new global::System.Drawing.Size(434, 354);
		this.Map.TabIndex = 0;
		this.Map.TabStop = false;
		this.Map.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Map_Paint);
		this.Map.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.Map_MouseDoubleClick);
		this.Map.MouseLeave += new global::System.EventHandler(this.Map_MouseLeave);
		this.Map.MouseHover += new global::System.EventHandler(this.Map_MouseHover);
		this.Map.MouseWheel += new global::System.Windows.Forms.MouseEventHandler(this.Map_MouseWheel);
		this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.ProgressBar1.Location = new global::System.Drawing.Point(0, 354);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new global::System.Drawing.Size(574, 10);
		this.ProgressBar1.TabIndex = 1;
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.SaveToolStripMenuItem,
			this.SaveAsToolStripMenuItem,
			this.OpenUsingGoogleMapsToolStripMenuItem,
			this.OpenUsingMapBoxToolStripMenuItem
		});
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new global::System.Drawing.Size(184, 92);
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
		this.OpenUsingGoogleMapsToolStripMenuItem.Name = "OpenUsingGoogleMapsToolStripMenuItem";
		this.OpenUsingGoogleMapsToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
		this.OpenUsingGoogleMapsToolStripMenuItem.Text = "Open using Google Maps";
		this.OpenUsingGoogleMapsToolStripMenuItem.Click += new global::System.EventHandler(this.OpenUsingGoogleMapsToolStripMenuItem_Click);
		this.OpenUsingMapBoxToolStripMenuItem.Name = "OpenUsingMapBoxToolStripMenuItem";
		this.OpenUsingMapBoxToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
		this.OpenUsingMapBoxToolStripMenuItem.Text = "Open using Mapbox";
		this.OpenUsingMapBoxToolStripMenuItem.Click += new global::System.EventHandler(this.OpenUsingMapBoxToolStripMenuItem_Click);
		this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
		this.Panel1.Controls.Add(this.TextBox1);
		this.Panel1.Controls.Add(this.Panel2);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.Panel1.Location = new global::System.Drawing.Point(434, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(140, 354);
		this.Panel1.TabIndex = 2;
		this.TextBox1.BackColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
		this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.TextBox1.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Bold);
		this.TextBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.TextBox1.Location = new global::System.Drawing.Point(0, 0);
		this.TextBox1.Multiline = true;
		this.TextBox1.Name = "TextBox1";
		this.TextBox1.ReadOnly = true;
		this.TextBox1.Size = new global::System.Drawing.Size(140, 314);
		this.TextBox1.TabIndex = 0;
		this.Panel2.Controls.Add(this.DrakeUICheckBox1);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel2.Location = new global::System.Drawing.Point(0, 314);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(140, 40);
		this.Panel2.TabIndex = 3;
		this.DrakeUICheckBox1.CheckBoxColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUICheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUICheckBox1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUICheckBox1.ForeColor = global::System.Drawing.Color.White;
		this.DrakeUICheckBox1.Location = new global::System.Drawing.Point(39, 6);
		this.DrakeUICheckBox1.Name = "DrakeUICheckBox1";
		this.DrakeUICheckBox1.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
		this.DrakeUICheckBox1.Size = new global::System.Drawing.Size(69, 29);
		this.DrakeUICheckBox1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUICheckBox1.TabIndex = 0;
		this.DrakeUICheckBox1.Text = "Save";
		this.DrakeUICheckBox1.ValueChanged += new global::DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.DrakeUICheckBox1_ValueChanged);
		this.savetimer.Tick += new global::System.EventHandler(this.Savetimer_Tick);
		this.guna2GradientTileButton1.AutoRoundedCorners = true;
		this.guna2GradientTileButton1.BackColor = global::System.Drawing.Color.Black;
		this.guna2GradientTileButton1.BorderColor = global::System.Drawing.Color.FromArgb(128, 255, 128);
		this.guna2GradientTileButton1.BorderRadius = 19;
		this.guna2GradientTileButton1.BorderThickness = 2;
		this.guna2GradientTileButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2GradientTileButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2GradientTileButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2GradientTileButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2GradientTileButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2GradientTileButton1.FillColor = global::System.Drawing.Color.Teal;
		this.guna2GradientTileButton1.FillColor2 = global::System.Drawing.Color.MediumSeaGreen;
		this.guna2GradientTileButton1.Font = new global::System.Drawing.Font("Segoe UI Black", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.guna2GradientTileButton1.ForeColor = global::System.Drawing.Color.White;
		this.guna2GradientTileButton1.Location = new global::System.Drawing.Point(55, 297);
		this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
		this.guna2GradientTileButton1.Size = new global::System.Drawing.Size(276, 40);
		this.guna2GradientTileButton1.TabIndex = 5;
		this.guna2GradientTileButton1.Text = "OPEN MAP";
		this.guna2GradientTileButton1.Click += new global::System.EventHandler(this.guna2GradientTileButton1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(574, 364);
		base.Controls.Add(this.guna2GradientTileButton1);
		base.Controls.Add(this.Map);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.ProgressBar1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		this.MaximumSize = new global::System.Drawing.Size(590, 403);
		base.Name = "LocationManager";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "LocationManager";
		((global::System.ComponentModel.ISupportInitialize)this.Map).EndInit();
		this.ctxMenu.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x0400095B RID: 2395
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000979 RID: 2425
	internal global::System.Windows.Forms.PictureBox Map;

	// Token: 0x0400097A RID: 2426
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ProgressBar1")]
	internal global::System.Windows.Forms.ProgressBar ProgressBar1;

	// Token: 0x0400097B RID: 2427
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x0400097C RID: 2428
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
	internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

	// Token: 0x0400097D RID: 2429
	internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

	// Token: 0x0400097E RID: 2430
	internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

	// Token: 0x0400097F RID: 2431
	internal global::System.Windows.Forms.ToolStripMenuItem OpenUsingGoogleMapsToolStripMenuItem;

	// Token: 0x04000980 RID: 2432
	internal global::System.Windows.Forms.ToolStripMenuItem OpenUsingMapBoxToolStripMenuItem;

	// Token: 0x04000981 RID: 2433
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000982 RID: 2434
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TextBox1")]
	internal global::System.Windows.Forms.TextBox TextBox1;

	// Token: 0x04000983 RID: 2435
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000984 RID: 2436
	internal global::DrakeUI.Framework.DrakeUICheckBox DrakeUICheckBox1;

	// Token: 0x04000985 RID: 2437
	internal global::System.Windows.Forms.Timer savetimer;

	// Token: 0x04000986 RID: 2438
	private global::Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
}
