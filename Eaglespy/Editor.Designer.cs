// Token: 0x02000072 RID: 114
[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Editor : global::System.Windows.Forms.Form
{
	// Token: 0x06000542 RID: 1346 RVA: 0x00082F68 File Offset: 0x00081168
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

	// Token: 0x06000543 RID: 1347 RVA: 0x00082FAC File Offset: 0x000811AC
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new global::System.ComponentModel.Container();
		this.EditText = new global::System.Windows.Forms.RichTextBox();
		this.b_ok = new global::System.Windows.Forms.Button();
		this.Panel1 = new global::System.Windows.Forms.Panel();
		this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
		this.CMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
		this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.Panel1.SuspendLayout();
		this.CMenu.SuspendLayout();
		base.SuspendLayout();
		this.EditText.TextChanged += new global::System.EventHandler(this.EditText_TextChanged);
		this.b_ok.Click += new global::System.EventHandler(this.b_ok_Click);
		this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
		this.CutToolStripMenuItem.Click += new global::System.EventHandler(this.CutToolStripMenuItem_Click);
		this.CopyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
		this.PasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click);
		this.EditText.BackColor = global::System.Drawing.Color.Black;
		this.EditText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
		this.EditText.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.EditText.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.EditText.Location = new global::System.Drawing.Point(0, 0);
		this.EditText.Name = "EditText";
		this.EditText.Size = new global::System.Drawing.Size(414, 213);
		this.EditText.TabIndex = 1;
		this.EditText.Text = "";
		this.EditText.WordWrap = false;
		this.b_ok.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.b_ok.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.b_ok.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
		this.b_ok.ForeColor = global::System.Drawing.Color.Black;
		this.b_ok.Location = new global::System.Drawing.Point(343, 3);
		this.b_ok.Name = "b_ok";
		this.b_ok.Size = new global::System.Drawing.Size(67, 23);
		this.b_ok.TabIndex = 2;
		this.b_ok.Text = "save";
		this.b_ok.UseVisualStyleBackColor = false;
		this.b_ok.Visible = false;
		this.Panel1.BackColor = global::System.Drawing.Color.Black;
		this.Panel1.Controls.Add(this.b_ok);
		this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
		this.Panel1.Location = new global::System.Drawing.Point(0, 213);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new global::System.Drawing.Size(414, 28);
		this.Panel1.TabIndex = 3;
		this.TOpacity.Interval = 1;
		this.CMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.CutToolStripMenuItem,
			this.CopyToolStripMenuItem,
			this.PasteToolStripMenuItem
		});
		this.CMenu.Name = "CMenu";
		this.CMenu.ShowImageMargin = false;
		this.CMenu.Size = new global::System.Drawing.Size(156, 92);
		this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
		this.CutToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
		this.CutToolStripMenuItem.Text = "Cut";
		this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
		this.CopyToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
		this.CopyToolStripMenuItem.Text = "Copy";
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
		this.PasteToolStripMenuItem.Text = "Paste";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(414, 241);
		base.Controls.Add(this.EditText);
		base.Controls.Add(this.Panel1);
		base.Name = "Editor";
		base.Opacity = 0.0;
		this.Text = "Editor";
		this.Panel1.ResumeLayout(false);
		this.CMenu.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x04000733 RID: 1843
	private global::System.ComponentModel.IContainer components;

	// Token: 0x0400073F RID: 1855
	internal global::System.Windows.Forms.RichTextBox EditText;

	// Token: 0x04000740 RID: 1856
	internal global::System.Windows.Forms.Button b_ok;

	// Token: 0x04000741 RID: 1857
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
	internal global::System.Windows.Forms.Panel Panel1;

	// Token: 0x04000742 RID: 1858
	internal global::System.Windows.Forms.Timer TOpacity;

	// Token: 0x04000743 RID: 1859
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("CMenu")]
	internal global::System.Windows.Forms.ContextMenuStrip CMenu;

	// Token: 0x04000744 RID: 1860
	internal global::System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;

	// Token: 0x04000745 RID: 1861
	internal global::System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;

	// Token: 0x04000746 RID: 1862
	internal global::System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
}
