// Token: 0x0200004B RID: 75
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class comptableform : global::System.Windows.Forms.Form
{
	// Token: 0x06000372 RID: 882 RVA: 0x0005218C File Offset: 0x0005038C
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

	// Token: 0x06000373 RID: 883 RVA: 0x000521D0 File Offset: 0x000503D0
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.loginbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.label5 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.label1 = new global::System.Windows.Forms.Label();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Panel1.Controls.Add(this.loginbtn);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new global::System.Drawing.Point(0, 493);
		this.Panel1.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(484, 63);
		this.Panel1.TabIndex = 0;
		this.loginbtn.BackColor = global::System.Drawing.Color.Transparent;
		this.loginbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.loginbtn.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.loginbtn.FillColor = global::System.Drawing.Color.Transparent;
		this.loginbtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.loginbtn.FillPressColor = global::System.Drawing.Color.Black;
		this.loginbtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.loginbtn.ForeColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.ForePressColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
		this.loginbtn.Location = new global::System.Drawing.Point(0, 3);
		this.loginbtn.Name = "loginbtn";
		this.loginbtn.Radius = 10;
		this.loginbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.loginbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.loginbtn.RectHoverColor = global::System.Drawing.Color.White;
		this.loginbtn.RectPressColor = global::System.Drawing.Color.White;
		this.loginbtn.RectSelectedColor = global::System.Drawing.Color.White;
		this.loginbtn.Size = new global::System.Drawing.Size(484, 60);
		this.loginbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.loginbtn.SymbolSize = 0;
		this.loginbtn.TabIndex = 29;
		this.loginbtn.Text = "OK";
		this.loginbtn.Click += new global::System.EventHandler(this.Loginbtn_Click);
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = global::System.Drawing.Color.Lime;
		this.label5.Location = new global::System.Drawing.Point(108, 39);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(176, 24);
		this.label5.TabIndex = 29;
		this.label5.Text = "Terms && Conditions";
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = global::System.Drawing.Color.Red;
		this.label3.Location = new global::System.Drawing.Point(75, 361);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(378, 100);
		this.label3.TabIndex = 28;
		this.label3.Text = "3. you are the only responsible for any \r\nillegal usage of this software   \r\nowner is not responsible for any \r\ndamage caused by this software.";
		this.label2.AutoSize = true;
		this.label2.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = global::System.Drawing.Color.Red;
		this.label2.Location = new global::System.Drawing.Point(75, 207);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(372, 125);
		this.label2.TabIndex = 27;
		this.label2.Text = "2.  You are granted a non-transferable\r\n license for intended use only. \r\nAny form of unauthorized \r\ndistribution or modification is\r\n against the terms of use.";
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = global::System.Drawing.Color.Red;
		this.label1.Location = new global::System.Drawing.Point(75, 83);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(319, 100);
		this.label1.TabIndex = 26;
		this.label1.Text = "1.  keep your license key secure, \r\nand ensure that your use of \r\nthe software complies with all\r\n applicable laws and regulations.";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(484, 556);
		base.ControlBox = false;
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.Panel1);
		this.ForeColor = global::System.Drawing.Color.White;
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new global::System.Windows.Forms.Padding(2);
		this.MaximumSize = new global::System.Drawing.Size(484, 556);
		this.MinimumSize = new global::System.Drawing.Size(484, 556);
		base.Name = "comptableform";
		base.ShowIcon = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "comptableform";
		base.TopMost = true;
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040003D1 RID: 977
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040003D5 RID: 981
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x040003D6 RID: 982
	private global::System.Windows.Forms.Label label5;

	// Token: 0x040003D7 RID: 983
	private global::System.Windows.Forms.Label label3;

	// Token: 0x040003D8 RID: 984
	private global::System.Windows.Forms.Label label2;

	// Token: 0x040003D9 RID: 985
	private global::System.Windows.Forms.Label label1;

	// Token: 0x040003DA RID: 986
	internal global::DrakeUI.Framework.DrakeUIButtonIcon loginbtn;
}
