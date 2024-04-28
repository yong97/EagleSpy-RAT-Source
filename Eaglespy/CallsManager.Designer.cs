// Token: 0x0200003C RID: 60
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class CallsManager : global::System.Windows.Forms.Form
{
	// Token: 0x060002AA RID: 682 RVA: 0x00048B18 File Offset: 0x00046D18
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

	// Token: 0x060002AB RID: 683 RVA: 0x00048B5C File Offset: 0x00046D5C
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DGV0 = new global::System.Windows.Forms.DataGridView();
		this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
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
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.White;
		this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
		this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
		this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.Column1,
			this.Column6,
			this.Column9,
			this.Column7,
			this.Column2,
			this.Column3
		});
		this.DGV0.ContextMenuStrip = this.ctxMenu;
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.Red;
		this.DGV0.Location = new global::System.Drawing.Point(0, 0);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.Red;
		dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.White;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(508, 419);
		this.DGV0.TabIndex = 2;
		this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
		this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
		this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
		this.Column1.HeaderText = "number";
		this.Column1.Name = "Column1";
		this.Column1.Width = 67;
		this.Column6.HeaderText = "name";
		this.Column6.Name = "Column6";
		this.Column6.Width = 56;
		this.Column9.HeaderText = "type";
		this.Column9.Name = "Column9";
		this.Column9.Width = 51;
		this.Column7.HeaderText = "date";
		this.Column7.Name = "Column7";
		this.Column7.Width = 51;
		this.Column2.HeaderText = "duration";
		this.Column2.Name = "Column2";
		this.Column2.Width = 69;
		this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column3.FillWeight = 1f;
		this.Column3.HeaderText = "";
		this.Column3.MinimumWidth = 2;
		this.Column3.Name = "Column3";
		this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column3.Width = 2;
		this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.RefreshToolStripMenuItem,
			this.DeleteToolStripMenuItem,
			this.SaveToolStripMenuItem,
			this.SaveAsToolStripMenuItem
		});
		this.ctxMenu.Name = "ctxMenu";
		this.ctxMenu.ShowImageMargin = false;
		this.ctxMenu.Size = new global::System.Drawing.Size(90, 92);
		this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
		this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.RefreshToolStripMenuItem.Text = "Refresh";
		this.RefreshToolStripMenuItem.Click += new global::System.EventHandler(this.RefreshToolStripMenuItem_Click);
		this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
		this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
		this.DeleteToolStripMenuItem.Text = "Delete";
		this.DeleteToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteToolStripMenuItem_Click);
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
		this.PB.Location = new global::System.Drawing.Point(0, 419);
		this.PB.Name = "PB";
		this.PB.Size = new global::System.Drawing.Size(508, 10);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = global::System.Drawing.Color.Red;
		this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new global::System.Drawing.Point(0, 429);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new global::System.Drawing.Size(508, 18);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
		this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(508, 447);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.BoxTitle);
		base.Name = "CallsManager";
		base.Opacity = 0.0;
		this.Text = "CallsManager";
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctxMenu.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04000320 RID: 800
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000330 RID: 816
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x04000331 RID: 817
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
	internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

	// Token: 0x04000332 RID: 818
	internal global::System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;

	// Token: 0x04000333 RID: 819
	internal global::System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;

	// Token: 0x04000334 RID: 820
	internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

	// Token: 0x04000335 RID: 821
	internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

	// Token: 0x04000336 RID: 822
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000337 RID: 823
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
	internal global::System.Windows.Forms.ProgressBar PB;

	// Token: 0x04000338 RID: 824
	internal global::System.Windows.Forms.PictureBox BoxTitle;

	// Token: 0x04000339 RID: 825
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

	// Token: 0x0400033A RID: 826
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

	// Token: 0x0400033B RID: 827
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column9")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column9;

	// Token: 0x0400033C RID: 828
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column7")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column7;

	// Token: 0x0400033D RID: 829
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

	// Token: 0x0400033E RID: 830
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column3")]
	internal global::System.Windows.Forms.DataGridViewImageColumn Column3;
}
