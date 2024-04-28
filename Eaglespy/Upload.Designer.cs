// Token: 0x020000C5 RID: 197
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Upload : global::System.Windows.Forms.Form
{
	// Token: 0x06000880 RID: 2176 RVA: 0x000C964C File Offset: 0x000C784C
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

	// Token: 0x06000881 RID: 2177 RVA: 0x000C9690 File Offset: 0x000C7890
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DGV0 = new global::System.Windows.Forms.DataGridView();
		this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
		this.TimeFinish = new global::System.Windows.Forms.Timer(this.components);
		this.Progr = new global::System.Windows.Forms.Timer(this.components);
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		base.SuspendLayout();
		this.TimeFinish.Tick += new global::System.EventHandler(this.TimeFinish_Tick);
		this.Progr.Tick += new global::System.EventHandler(this.Progr_Tick);
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
			this.Column1,
			this.Column6
		});
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new global::System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(537, 118);
		this.DGV0.TabIndex = 6;
		this.Column1.HeaderText = "info";
		this.Column1.Name = "Column1";
		this.Column1.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column1.Width = 32;
		this.Column6.HeaderText = "  ";
		this.Column6.Name = "Column6";
		this.Column6.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Column6.Width = 15;
		this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.ProgressBar1.Location = new global::System.Drawing.Point(0, 118);
		this.ProgressBar1.Name = "ProgressBar1";
		this.ProgressBar1.Size = new global::System.Drawing.Size(537, 10);
		this.ProgressBar1.TabIndex = 5;
		this.TOpacity.Interval = 1;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(537, 128);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.ProgressBar1);
		base.Name = "Upload";
		base.Opacity = 0.0;
		this.Text = "Upload";
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000CA7 RID: 3239
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000CB7 RID: 3255
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DGV0")]
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x04000CB8 RID: 3256
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ProgressBar1")]
	internal global::System.Windows.Forms.ProgressBar ProgressBar1;

	// Token: 0x04000CB9 RID: 3257
	internal global::System.Windows.Forms.Timer TimeFinish;

	// Token: 0x04000CBA RID: 3258
	internal global::System.Windows.Forms.Timer Progr;

	// Token: 0x04000CBB RID: 3259
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

	// Token: 0x04000CBC RID: 3260
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

	// Token: 0x04000CBD RID: 3261
	internal global::System.Windows.Forms.Timer TOpacity;
}
