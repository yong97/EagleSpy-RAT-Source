// Token: 0x0200006B RID: 107
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class DialogPloice : global::System.Windows.Forms.Form
{
	// Token: 0x06000507 RID: 1287 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
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

	// Token: 0x06000508 RID: 1288 RVA: 0x0007DE38 File Offset: 0x0007C038
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
		this.Cancel_Button = new global::System.Windows.Forms.Button();
		this.OK_Button = new global::System.Windows.Forms.Button();
		this.MainText = new global::System.Windows.Forms.TextBox();
		this.Button1 = new global::System.Windows.Forms.Button();
		this.Button2 = new global::System.Windows.Forms.Button();
		this.Acccheck = new global::System.Windows.Forms.CheckBox();
		this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.label4 = new global::System.Windows.Forms.Label();
		this.label6 = new global::System.Windows.Forms.Label();
		this.label7 = new global::System.Windows.Forms.Label();
		this.label8 = new global::System.Windows.Forms.Label();
		this.label5 = new global::System.Windows.Forms.Label();
		this.TableLayoutPanel1.SuspendLayout();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.TableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.TableLayoutPanel1.ColumnCount = 2;
		this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
		this.TableLayoutPanel1.Location = new global::System.Drawing.Point(227, 495);
		this.TableLayoutPanel1.Name = "TableLayoutPanel1";
		this.TableLayoutPanel1.RowCount = 1;
		this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
		this.TableLayoutPanel1.Size = new global::System.Drawing.Size(205, 37);
		this.TableLayoutPanel1.TabIndex = 0;
		this.Cancel_Button.Anchor = global::System.Windows.Forms.AnchorStyles.None;
		this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.Cancel_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Cancel_Button.Location = new global::System.Drawing.Point(120, 7);
		this.Cancel_Button.Name = "Cancel_Button";
		this.Cancel_Button.Size = new global::System.Drawing.Size(67, 23);
		this.Cancel_Button.TabIndex = 1;
		this.Cancel_Button.Text = "Cancel";
		this.Cancel_Button.Click += new global::System.EventHandler(this.Cancel_Button_Click);
		this.OK_Button.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.OK_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.OK_Button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.OK_Button.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
		this.OK_Button.Location = new global::System.Drawing.Point(0, 476);
		this.OK_Button.Name = "OK_Button";
		this.OK_Button.Size = new global::System.Drawing.Size(444, 58);
		this.OK_Button.TabIndex = 0;
		this.OK_Button.Text = "OK";
		this.OK_Button.Click += new global::System.EventHandler(this.OK_Button_Click);
		this.MainText.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.MainText.Location = new global::System.Drawing.Point(170, 127);
		this.MainText.Multiline = true;
		this.MainText.Name = "MainText";
		this.MainText.Size = new global::System.Drawing.Size(34, 27);
		this.MainText.TabIndex = 1;
		this.MainText.Visible = false;
		this.Button1.Location = new global::System.Drawing.Point(91, 127);
		this.Button1.Name = "Button1";
		this.Button1.Size = new global::System.Drawing.Size(50, 32);
		this.Button1.TabIndex = 2;
		this.Button1.Text = "English";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
		this.Button2.Location = new global::System.Drawing.Point(218, 127);
		this.Button2.Name = "Button2";
		this.Button2.Size = new global::System.Drawing.Size(76, 32);
		this.Button2.TabIndex = 3;
		this.Button2.Text = "العربية";
		this.Button2.UseVisualStyleBackColor = true;
		this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
		this.Acccheck.AutoSize = true;
		this.Acccheck.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.Acccheck.Location = new global::System.Drawing.Point(12, 274);
		this.Acccheck.Name = "Acccheck";
		this.Acccheck.Size = new global::System.Drawing.Size(202, 17);
		this.Acccheck.TabIndex = 4;
		this.Acccheck.Text = "I read all text above, And Accepted All";
		this.Acccheck.UseVisualStyleBackColor = true;
		this.Timer1.Interval = 1000;
		this.Timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
		this.panel1.BackColor = global::System.Drawing.Color.Black;
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label6);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.OK_Button);
		this.panel1.Controls.Add(this.label5);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new global::System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(444, 534);
		this.panel1.TabIndex = 5;
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = global::System.Drawing.Color.Lime;
		this.label4.Location = new global::System.Drawing.Point(87, 0);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(176, 24);
		this.label4.TabIndex = 29;
		this.label4.Text = "Terms && Conditions";
		this.label6.AutoSize = true;
		this.label6.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = global::System.Drawing.Color.Red;
		this.label6.Location = new global::System.Drawing.Point(36, 315);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(378, 100);
		this.label6.TabIndex = 28;
		this.label6.Text = "3. you are the only responsible for any \r\nillegal usage of this software   \r\nowner is not responsible for any \r\ndamage caused by this software.";
		this.label7.AutoSize = true;
		this.label7.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = global::System.Drawing.Color.Red;
		this.label7.Location = new global::System.Drawing.Point(35, 157);
		this.label7.Name = "label7";
		this.label7.Size = new global::System.Drawing.Size(372, 125);
		this.label7.TabIndex = 27;
		this.label7.Text = "2.  You are granted a non-transferable\r\n license for intended use only. \r\nAny form of unauthorized \r\ndistribution or modification is\r\n against the terms of use.";
		this.label8.AutoSize = true;
		this.label8.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = global::System.Drawing.Color.Red;
		this.label8.Location = new global::System.Drawing.Point(35, 37);
		this.label8.Name = "label8";
		this.label8.Size = new global::System.Drawing.Size(319, 100);
		this.label8.TabIndex = 26;
		this.label8.Text = "1.  keep your license key secure, \r\nand ensure that your use of \r\nthe software complies with all\r\n applicable laws and regulations.";
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = global::System.Drawing.Color.Lime;
		this.label5.Location = new global::System.Drawing.Point(116, 87);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(176, 24);
		this.label5.TabIndex = 10;
		this.label5.Text = "Terms && Conditions";
		base.AcceptButton = this.OK_Button;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.Cancel_Button;
		base.ClientSize = new global::System.Drawing.Size(444, 534);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.Acccheck);
		base.Controls.Add(this.Button2);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.MainText);
		base.Controls.Add(this.TableLayoutPanel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		this.MaximumSize = new global::System.Drawing.Size(460, 573);
		base.MinimizeBox = false;
		this.MinimumSize = new global::System.Drawing.Size(460, 573);
		base.Name = "DialogPloice";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = " Privacy Policy & Terms of Service";
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.DialogPloice_Load_1);
		this.TableLayoutPanel1.ResumeLayout(false);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040006AF RID: 1711
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040006B9 RID: 1721
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TableLayoutPanel1")]
	internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;

	// Token: 0x040006BA RID: 1722
	internal global::System.Windows.Forms.Button OK_Button;

	// Token: 0x040006BB RID: 1723
	internal global::System.Windows.Forms.Button Cancel_Button;

	// Token: 0x040006BC RID: 1724
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("MainText")]
	internal global::System.Windows.Forms.TextBox MainText;

	// Token: 0x040006BD RID: 1725
	internal global::System.Windows.Forms.Button Button1;

	// Token: 0x040006BE RID: 1726
	internal global::System.Windows.Forms.Button Button2;

	// Token: 0x040006BF RID: 1727
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Acccheck")]
	internal global::System.Windows.Forms.CheckBox Acccheck;

	// Token: 0x040006C0 RID: 1728
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x040006C1 RID: 1729
	private global::System.Windows.Forms.Label label5;

	// Token: 0x040006C2 RID: 1730
	private global::System.Windows.Forms.Label label4;

	// Token: 0x040006C3 RID: 1731
	private global::System.Windows.Forms.Label label6;

	// Token: 0x040006C4 RID: 1732
	private global::System.Windows.Forms.Label label7;

	// Token: 0x040006C5 RID: 1733
	private global::System.Windows.Forms.Label label8;

	// Token: 0x040006C6 RID: 1734
	internal global::System.Windows.Forms.Timer Timer1;
}
