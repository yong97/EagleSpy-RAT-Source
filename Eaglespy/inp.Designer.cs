// Token: 0x02000081 RID: 129
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class inp : global::System.Windows.Forms.Form
{
	// Token: 0x060005E7 RID: 1511 RVA: 0x000971DC File Offset: 0x000953DC
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

	// Token: 0x060005E8 RID: 1512 RVA: 0x00097220 File Offset: 0x00095420
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.BOXX = new global::System.Windows.Forms.Panel();
		this.CheckHidden = new global::System.Windows.Forms.CheckBox();
		this.CheckFolder = new global::System.Windows.Forms.CheckBox();
		this.LTitle = new global::System.Windows.Forms.Label();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.InputText = new global::DrakeUI.Framework.DrakeUITextBox();
		this.b_ok = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.Panel1.SuspendLayout();
		this.BOXX.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.b_ok.Click += new global::System.EventHandler(this.B_ok_Click_1);
		this.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.b_ok);
		this.Panel1.Controls.Add(this.InputText);
		this.Panel1.Controls.Add(this.BOXX);
		this.Panel1.Controls.Add(this.LTitle);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(576, 160);
		this.Panel1.TabIndex = 0;
		this.BOXX.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.BOXX.Controls.Add(this.CheckHidden);
		this.BOXX.Controls.Add(this.CheckFolder);
		this.BOXX.Location = new global::System.Drawing.Point(16, 117);
		this.BOXX.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.BOXX.Name = "BOXX";
		this.BOXX.Size = new global::System.Drawing.Size(435, 28);
		this.BOXX.TabIndex = 4;
		this.BOXX.Visible = false;
		this.CheckHidden.AutoSize = true;
		this.CheckHidden.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.CheckHidden.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.CheckHidden.Location = new global::System.Drawing.Point(292, 0);
		this.CheckHidden.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.CheckHidden.Name = "CheckHidden";
		this.CheckHidden.Size = new global::System.Drawing.Size(73, 28);
		this.CheckHidden.TabIndex = 1;
		this.CheckHidden.Text = "hidden";
		this.CheckHidden.UseVisualStyleBackColor = true;
		this.CheckFolder.AutoSize = true;
		this.CheckFolder.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.CheckFolder.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.CheckFolder.Location = new global::System.Drawing.Point(365, 0);
		this.CheckFolder.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.CheckFolder.Name = "CheckFolder";
		this.CheckFolder.Size = new global::System.Drawing.Size(70, 28);
		this.CheckFolder.TabIndex = 0;
		this.CheckFolder.Text = "Folder";
		this.CheckFolder.UseVisualStyleBackColor = true;
		this.LTitle.AutoSize = true;
		this.LTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.LTitle.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.LTitle.Location = new global::System.Drawing.Point(16, 28);
		this.LTitle.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.LTitle.Name = "LTitle";
		this.LTitle.Size = new global::System.Drawing.Size(42, 25);
		this.LTitle.TabIndex = 1;
		this.LTitle.Text = "null";
		this.TOpacity.Interval = 1;
		this.InputText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
		this.InputText.FillColor = global::System.Drawing.Color.Black;
		this.InputText.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.InputText.ForeColor = global::System.Drawing.Color.White;
		this.InputText.Location = new global::System.Drawing.Point(19, 64);
		this.InputText.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
		this.InputText.Maximum = 2147483647.0;
		this.InputText.Minimum = -2147483648.0;
		this.InputText.Name = "InputText";
		this.InputText.Padding = new global::System.Windows.Forms.Padding(7, 6, 7, 6);
		this.InputText.Radius = 10;
		this.InputText.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.InputText.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.InputText.Size = new global::System.Drawing.Size(541, 32);
		this.InputText.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.InputText.StyleCustomMode = true;
		this.InputText.TabIndex = 44;
		this.InputText.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
		this.InputText.Watermark = "";
		this.b_ok.BackColor = global::System.Drawing.Color.Transparent;
		this.b_ok.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.b_ok.FillColor = global::System.Drawing.Color.Transparent;
		this.b_ok.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.b_ok.FillPressColor = global::System.Drawing.Color.Black;
		this.b_ok.FillSelectedColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.b_ok.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.ForePressColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.b_ok.Location = new global::System.Drawing.Point(459, 117);
		this.b_ok.Margin = new global::System.Windows.Forms.Padding(4);
		this.b_ok.Name = "b_ok";
		this.b_ok.Radius = 10;
		this.b_ok.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.b_ok.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.b_ok.RectHoverColor = global::System.Drawing.Color.White;
		this.b_ok.RectPressColor = global::System.Drawing.Color.White;
		this.b_ok.RectSelectedColor = global::System.Drawing.Color.White;
		this.b_ok.Size = new global::System.Drawing.Size(105, 32);
		this.b_ok.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.b_ok.SymbolSize = 0;
		this.b_ok.TabIndex = 49;
		this.b_ok.Text = "OK";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(576, 160);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "inp";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "inp";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.BOXX.ResumeLayout(false);
		this.BOXX.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x0400085D RID: 2141
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000862 RID: 2146
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000863 RID: 2147
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("LTitle")]
	internal global::System.Windows.Forms.Label LTitle;

	// Token: 0x04000864 RID: 2148
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("BOXX")]
	internal global::System.Windows.Forms.Panel BOXX;

	// Token: 0x04000865 RID: 2149
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("CheckHidden")]
	internal global::System.Windows.Forms.CheckBox CheckHidden;

	// Token: 0x04000866 RID: 2150
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("CheckFolder")]
	internal global::System.Windows.Forms.CheckBox CheckFolder;

	// Token: 0x04000867 RID: 2151
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000868 RID: 2152
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("InputText")]
	internal global::DrakeUI.Framework.DrakeUITextBox InputText;

	// Token: 0x04000869 RID: 2153
	internal global::DrakeUI.Framework.DrakeUIButtonIcon b_ok;
}
