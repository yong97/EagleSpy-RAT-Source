// Token: 0x02000020 RID: 32
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class AccountManager : global::System.Windows.Forms.Form
{
	// Token: 0x06000159 RID: 345 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
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

	// Token: 0x0600015A RID: 346 RVA: 0x0000C5FC File Offset: 0x0000A7FC
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DGV0 = new global::System.Windows.Forms.DataGridView();
		this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.PB = new global::System.Windows.Forms.ProgressBar();
		this.BoxTitle = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctxMenu.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		base.SuspendLayout();
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = global::System.Drawing.Color.FromArgb(10, 0, 10);
		this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
		this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.Column1,
			this.Column6,
			this.Column2
		});
		this.DGV0.ContextMenuStrip = this.ctxMenu;
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.Red;
		this.DGV0.Location = new global::System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.RowHeadersVisible = false;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(466, 295);
		this.DGV0.TabIndex = 3;
		this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
		this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
		this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
		this.Column1.HeaderText = "Program";
		this.Column1.Name = "Column1";
		this.Column1.Width = 69;
		this.Column6.HeaderText = "Account";
		this.Column6.Name = "Column6";
		this.Column6.Width = 69;
		this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column2.FillWeight = 1f;
		this.Column2.HeaderText = "";
		this.Column2.MinimumWidth = 2;
		this.Column2.Name = "Column2";
		this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column2.Width = 2;
		this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.SaveToolStripMenuItem,
			this.SaveAsToolStripMenuItem
		});
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new global::System.Drawing.Size(90, 48);
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new global::System.Drawing.Point(0, 295);
		this.PB.Name = "PB";
		this.PB.Size = new global::System.Drawing.Size(466, 10);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
		this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new global::System.Drawing.Point(0, 305);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new global::System.Drawing.Size(466, 18);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
		this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(466, 323);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.BoxTitle);
		base.Name = "AccountManager";
		base.Opacity = 0.0;
		this.Text = "AccountManager";
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxMenu.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000097 RID: 151
	private global::System.ComponentModel.IContainer components;

	// Token: 0x040000A0 RID: 160
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x040000A1 RID: 161
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
	internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

	// Token: 0x040000A2 RID: 162
	internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

	// Token: 0x040000A3 RID: 163
	internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

	// Token: 0x040000A4 RID: 164
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x040000A5 RID: 165
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
	internal global::System.Windows.Forms.ProgressBar PB;

	// Token: 0x040000A6 RID: 166
	internal global::System.Windows.Forms.PictureBox BoxTitle;

	// Token: 0x040000A7 RID: 167
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

	// Token: 0x040000A8 RID: 168
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

	// Token: 0x040000A9 RID: 169
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
	internal global::System.Windows.Forms.DataGridViewImageColumn Column2;
}
