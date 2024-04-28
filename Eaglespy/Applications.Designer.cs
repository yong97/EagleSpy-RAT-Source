// Token: 0x0200002E RID: 46
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Applications : global::System.Windows.Forms.Form
{
	// Token: 0x060001B2 RID: 434 RVA: 0x00011428 File Offset: 0x0000F628
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

	// Token: 0x060001B3 RID: 435 RVA: 0x0001146C File Offset: 0x0000F66C
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
		this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.ctx = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.PropertiesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.UninstallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.ClearAppDataToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.PB = new global::System.Windows.Forms.ProgressBar();
		this.BoxTitle = new global::System.Windows.Forms.PictureBox();
		this.Panel2 = new global::System.Windows.Forms.Panel();
		this.clinameinfo = new global::System.Windows.Forms.Label();
		this.ClientPic = new global::System.Windows.Forms.PictureBox();
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
		this.ctx.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
		this.Panel2.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
		base.SuspendLayout();
		this.DGV0.AllowUserToAddRows = false;
		this.DGV0.AllowUserToDeleteRows = false;
		this.DGV0.AllowUserToResizeColumns = false;
		this.DGV0.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Black;
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
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.Column1,
			this.Column6,
			this.Column9,
			this.Column2,
			this.Column3
		});
		this.DGV0.ContextMenuStrip = this.ctx;
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
		this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		this.DGV0.EnableHeadersVisualStyles = false;
		this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
		this.DGV0.Location = new global::System.Drawing.Point(0, 32);
		this.DGV0.Name = "DGV0";
		this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
		dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DGV0.RowHeadersVisible = false;
		dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
		this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DGV0.Size = new global::System.Drawing.Size(370, 371);
		this.DGV0.TabIndex = 4;
		this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
		this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
		this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
		this.Column1.HeaderText = "App Name";
		this.Column1.Name = "Column1";
		this.Column1.Width = 78;
		this.Column6.HeaderText = "Type";
		this.Column6.Name = "Column6";
		this.Column6.Width = 52;
		this.Column9.HeaderText = "App ID";
		this.Column9.Name = "Column9";
		this.Column9.Width = 61;
		this.Column2.HeaderText = "Install Time";
		this.Column2.Name = "Column2";
		this.Column2.Width = 83;
		this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.Column3.FillWeight = 1f;
		this.Column3.HeaderText = "";
		this.Column3.MinimumWidth = 2;
		this.Column3.Name = "Column3";
		this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
		this.Column3.Width = 2;
		this.ctx.BackColor = global::System.Drawing.Color.Black;
		this.ctx.ImageScalingSize = new global::System.Drawing.Size(20, 20);
		this.ctx.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.OpenToolStripMenuItem,
			this.RefreshToolStripMenuItem,
			this.PropertiesToolStripMenuItem,
			this.SaveToolStripMenuItem,
			this.SaveAsToolStripMenuItem,
			this.UninstallToolStripMenuItem,
			this.ClearAppDataToolStripMenuItem,
			this.EnableToolStripMenuItem
		});
		this.ctx.Name = "ctx";
		this.ctx.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
		this.ctx.ShowImageMargin = false;
		this.ctx.Size = new global::System.Drawing.Size(156, 218);
		this.OpenToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.OpenToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
		this.OpenToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.OpenToolStripMenuItem.Text = "Open";
		this.OpenToolStripMenuItem.Click += new global::System.EventHandler(this.OpenToolStripMenuItem_Click);
		this.RefreshToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.RefreshToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
		this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.RefreshToolStripMenuItem.Text = "Refresh";
		this.RefreshToolStripMenuItem.Click += new global::System.EventHandler(this.RefreshToolStripMenuItem_Click);
		this.PropertiesToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.PropertiesToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
		this.PropertiesToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.PropertiesToolStripMenuItem.Text = "Properties";
		this.PropertiesToolStripMenuItem.Click += new global::System.EventHandler(this.PropertiesToolStripMenuItem_Click);
		this.SaveToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.SaveToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
		this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.SaveToolStripMenuItem.Text = "Save";
		this.SaveToolStripMenuItem.Visible = false;
		this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
		this.SaveAsToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.SaveAsToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
		this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.SaveAsToolStripMenuItem.Text = "Save As";
		this.SaveAsToolStripMenuItem.Visible = false;
		this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
		this.UninstallToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.UninstallToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem";
		this.UninstallToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.UninstallToolStripMenuItem.Text = "uninstall";
		this.UninstallToolStripMenuItem.Click += new global::System.EventHandler(this.UninstallToolStripMenuItem_Click);
		this.ClearAppDataToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.ClearAppDataToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.ClearAppDataToolStripMenuItem.Name = "ClearAppDataToolStripMenuItem";
		this.ClearAppDataToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.ClearAppDataToolStripMenuItem.Text = "Disable";
		this.ClearAppDataToolStripMenuItem.Click += new global::System.EventHandler(this.ClearAppDataToolStripMenuItem_Click);
		this.EnableToolStripMenuItem.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.EnableToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
		this.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem";
		this.EnableToolStripMenuItem.Size = new global::System.Drawing.Size(155, 24);
		this.EnableToolStripMenuItem.Text = "Enable";
		this.EnableToolStripMenuItem.Click += new global::System.EventHandler(this.EnableToolStripMenuItem_Click);
		this.TOpacity.Interval = 1;
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.PB.Location = new global::System.Drawing.Point(0, 403);
		this.PB.Name = "PB";
		this.PB.Size = new global::System.Drawing.Size(370, 10);
		this.PB.TabIndex = 6;
		this.BoxTitle.BackColor = global::System.Drawing.Color.Black;
		this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.BoxTitle.ErrorImage = null;
		this.BoxTitle.InitialImage = null;
		this.BoxTitle.Location = new global::System.Drawing.Point(0, 413);
		this.BoxTitle.Name = "BoxTitle";
		this.BoxTitle.Size = new global::System.Drawing.Size(370, 18);
		this.BoxTitle.TabIndex = 7;
		this.BoxTitle.TabStop = false;
		this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
		this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
		this.Panel2.BackColor = global::System.Drawing.Color.Black;
		this.Panel2.Controls.Add(this.clinameinfo);
		this.Panel2.Controls.Add(this.ClientPic);
		this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel2.ForeColor = global::System.Drawing.Color.Red;
		this.Panel2.Location = new global::System.Drawing.Point(0, 0);
		this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new global::System.Drawing.Size(370, 32);
		this.Panel2.TabIndex = 8;
		this.clinameinfo.BackColor = global::System.Drawing.Color.Transparent;
		this.clinameinfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
		this.clinameinfo.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.clinameinfo.Location = new global::System.Drawing.Point(32, 0);
		this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
		this.clinameinfo.Name = "clinameinfo";
		this.clinameinfo.Size = new global::System.Drawing.Size(338, 32);
		this.clinameinfo.TabIndex = 12;
		this.clinameinfo.Text = "...";
		this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
		this.ClientPic.Dock = global::System.Windows.Forms.DockStyle.Left;
		this.ClientPic.Location = new global::System.Drawing.Point(0, 0);
		this.ClientPic.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
		this.ClientPic.Name = "ClientPic";
		this.ClientPic.Size = new global::System.Drawing.Size(32, 32);
		this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.ClientPic.TabIndex = 11;
		this.ClientPic.TabStop = false;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(370, 431);
		base.Controls.Add(this.DGV0);
		base.Controls.Add(this.PB);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.BoxTitle);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Name = "Applications";
		base.Opacity = 0.0;
		base.ShowIcon = false;
		this.Text = "Applications";
		((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
		this.ctx.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
		this.Panel2.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x0400010E RID: 270
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000122 RID: 290
	internal global::System.Windows.Forms.DataGridView DGV0;

	// Token: 0x04000123 RID: 291
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctx")]
	internal global::System.Windows.Forms.ContextMenuStrip ctx;

	// Token: 0x04000124 RID: 292
	internal global::System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;

	// Token: 0x04000125 RID: 293
	internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

	// Token: 0x04000126 RID: 294
	internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

	// Token: 0x04000127 RID: 295
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000128 RID: 296
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
	internal global::System.Windows.Forms.ProgressBar PB;

	// Token: 0x04000129 RID: 297
	internal global::System.Windows.Forms.PictureBox BoxTitle;

	// Token: 0x0400012A RID: 298
	internal global::System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;

	// Token: 0x0400012B RID: 299
	internal global::System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;

	// Token: 0x0400012C RID: 300
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

	// Token: 0x0400012D RID: 301
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

	// Token: 0x0400012E RID: 302
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column9")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column9;

	// Token: 0x0400012F RID: 303
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

	// Token: 0x04000130 RID: 304
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column3")]
	internal global::System.Windows.Forms.DataGridViewImageColumn Column3;

	// Token: 0x04000131 RID: 305
	internal global::System.Windows.Forms.ToolStripMenuItem UninstallToolStripMenuItem;

	// Token: 0x04000132 RID: 306
	internal global::System.Windows.Forms.ToolStripMenuItem ClearAppDataToolStripMenuItem;

	// Token: 0x04000133 RID: 307
	internal global::System.Windows.Forms.ToolStripMenuItem EnableToolStripMenuItem;

	// Token: 0x04000134 RID: 308
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
	internal global::System.Windows.Forms.Panel Panel2;

	// Token: 0x04000135 RID: 309
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
	internal global::System.Windows.Forms.Label clinameinfo;

	// Token: 0x04000136 RID: 310
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
	internal global::System.Windows.Forms.PictureBox ClientPic;
}
