// Token: 0x02000099 RID: 153
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class nonetform : global::System.Windows.Forms.Form
{
	// Token: 0x060006B2 RID: 1714 RVA: 0x000A70E0 File Offset: 0x000A52E0
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

	// Token: 0x060006B3 RID: 1715 RVA: 0x000A7124 File Offset: 0x000A5324
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.DrakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.DrakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
		base.SuspendLayout();
		this.DrakeUIAvatar1.Click += new global::System.EventHandler(this.DrakeUIAvatar1_Click);
		this.DrakeUIAvatar1.AvatarSize = 45;
		this.DrakeUIAvatar1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIAvatar1.Dock = global::System.Windows.Forms.DockStyle.Right;
		this.DrakeUIAvatar1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIAvatar1.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar1.Icon = global::DrakeUI.Framework.DrakeUIAvatar.UIIcon.Text;
		this.DrakeUIAvatar1.Location = new global::System.Drawing.Point(494, 0);
		this.DrakeUIAvatar1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
		this.DrakeUIAvatar1.Size = new global::System.Drawing.Size(87, 81);
		this.DrakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar1.StyleCustomMode = true;
		this.DrakeUIAvatar1.Symbol = 61452;
		this.DrakeUIAvatar1.SymbolSize = 25;
		this.DrakeUIAvatar1.TabIndex = 0;
		this.DrakeUIAvatar1.Text = "OK";
		this.Label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.Label1.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = global::System.Drawing.Color.White;
		this.Label1.Location = new global::System.Drawing.Point(95, 0);
		this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(399, 81);
		this.Label1.TabIndex = 1;
		this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check you internet and try again.";
		this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
		this.DrakeUIAvatar2.AvatarSize = 45;
		this.DrakeUIAvatar2.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.DrakeUIAvatar2.FillColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIAvatar2.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.DrakeUIAvatar2.ForeColor = global::System.Drawing.Color.Black;
		this.DrakeUIAvatar2.Location = new global::System.Drawing.Point(0, 0);
		this.DrakeUIAvatar2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
		this.DrakeUIAvatar2.Size = new global::System.Drawing.Size(95, 81);
		this.DrakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIAvatar2.StyleCustomMode = true;
		this.DrakeUIAvatar2.Symbol = 61553;
		this.DrakeUIAvatar2.SymbolSize = 25;
		this.DrakeUIAvatar2.TabIndex = 2;
		this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(581, 81);
		base.ControlBox = false;
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.DrakeUIAvatar2);
		base.Controls.Add(this.DrakeUIAvatar1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
		base.Name = "nonetform";
		base.ShowIcon = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "nonetform";
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	// Token: 0x040009C4 RID: 2500
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040009C6 RID: 2502
	internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar1;

	// Token: 0x040009C7 RID: 2503
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x040009C8 RID: 2504
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIAvatar2")]
	internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar2;
}
