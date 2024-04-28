// Token: 0x02000022 RID: 34
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class AddNumber : global::System.Windows.Forms.Form
{
	// Token: 0x0600016B RID: 363 RVA: 0x0000D260 File Offset: 0x0000B460
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

	// Token: 0x0600016C RID: 364 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.InputText1 = new global::System.Windows.Forms.TextBox();
		this.L1 = new global::System.Windows.Forms.Label();
		this.InputText0 = new global::System.Windows.Forms.TextBox();
		this.L0 = new global::System.Windows.Forms.Label();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
		this.Panel1.Controls.Add(this.InputText1);
		this.Panel1.Controls.Add(this.L1);
		this.Panel1.Controls.Add(this.InputText0);
		this.Panel1.Controls.Add(this.L0);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(449, 196);
		this.Panel1.TabIndex = 1;
		this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
		this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(15, 158);
		this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
		this.DrakeUIButtonIcon3.Radius = 25;
		this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(416, 26);
		this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon3.Symbol = 61543;
		this.DrakeUIButtonIcon3.TabIndex = 19;
		this.DrakeUIButtonIcon3.Text = "Add New Number";
		this.DrakeUIButtonIcon3.Click += new global::System.EventHandler(this.DrakeUIButtonIcon3_Click);
		this.InputText1.BackColor = global::System.Drawing.Color.White;
		this.InputText1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.InputText1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.InputText1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.InputText1.Location = new global::System.Drawing.Point(12, 122);
		this.InputText1.Name = "InputText1";
		this.InputText1.Size = new global::System.Drawing.Size(419, 19);
		this.InputText1.TabIndex = 5;
		this.L1.AutoSize = true;
		this.L1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.L1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.L1.Location = new global::System.Drawing.Point(12, 89);
		this.L1.Name = "L1";
		this.L1.Size = new global::System.Drawing.Size(143, 19);
		this.L1.TabIndex = 4;
		this.L1.Text = "New contact number";
		this.InputText0.BackColor = global::System.Drawing.Color.White;
		this.InputText0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.InputText0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.InputText0.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.InputText0.Location = new global::System.Drawing.Point(12, 56);
		this.InputText0.Name = "InputText0";
		this.InputText0.Size = new global::System.Drawing.Size(419, 19);
		this.InputText0.TabIndex = 2;
		this.L0.AutoSize = true;
		this.L0.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.L0.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.L0.Location = new global::System.Drawing.Point(12, 23);
		this.L0.Name = "L0";
		this.L0.Size = new global::System.Drawing.Size(130, 19);
		this.L0.TabIndex = 1;
		this.L0.Text = "New contact name";
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(449, 196);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "AddNumber";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Add Number";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x040000AD RID: 173
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000B0 RID: 176
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040000B1 RID: 177
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("InputText1")]
	internal global::System.Windows.Forms.TextBox InputText1;

	// Token: 0x040000B2 RID: 178
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("L1")]
	internal global::System.Windows.Forms.Label L1;

	// Token: 0x040000B3 RID: 179
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("InputText0")]
	internal global::System.Windows.Forms.TextBox InputText0;

	// Token: 0x040000B4 RID: 180
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("L0")]
	internal global::System.Windows.Forms.Label L0;

	// Token: 0x040000B5 RID: 181
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x040000B6 RID: 182
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon3;
}
