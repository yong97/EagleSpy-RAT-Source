using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x020000C0 RID: 192
[DesignerGenerated]
public partial class smsMaker : Form
{
	// Token: 0x06000849 RID: 2121 RVA: 0x000036CC File Offset: 0x000018CC
	public smsMaker()
	{
		base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud;
		this.InitializeComponent();
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002C7D File Offset: 0x00000E7D
	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000C6800 File Offset: 0x000C4A00
	private void DrakeUIButtonIcon1_click(object sender, EventArgs e)
	{
		if (!this.checkall.Checked && this.numslist.Items.Count == 0)
		{
			Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
		}
		else
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x000C6850 File Offset: 0x000C4A50
	private void Phonetext_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.KeyChar) != 8 && (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57))
		{
			e.Handled = true;
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0000206C File Offset: 0x0000026C
	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud(object sender, EventArgs e)
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0000206C File Offset: 0x0000026C
	private void Checkall_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000C6898 File Offset: 0x000C4A98
	private void Addnum_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(this.phonetext.Text) | string.IsNullOrWhiteSpace(this.phonetext.Text))
		{
			Interaction.MsgBox("Enter Phone Number First", MsgBoxStyle.OkOnly, null);
		}
		else
		{
			this.numslist.Items.Add(this.phonetext.Text);
		}
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x000C68F4 File Offset: 0x000C4AF4
	private void Remnum_Click(object sender, EventArgs e)
	{
		if (this.numslist.Items.Count == 0)
		{
			Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
		}
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 0, false))
		{
			Interaction.MsgBox("select number from list to remove", MsgBoxStyle.OkOnly, null);
		}
		else
		{
			object obj = null;
			object loopObj = null;
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, Operators.SubtractObject(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 1), 1, ref loopObj, ref obj))
			{
				do
				{
					try
					{
						this.numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(this.numslist.SelectedItem, new object[]
						{
							obj
						}, null)));
					}
					catch (Exception)
					{
					}
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
			}
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x000C6A08 File Offset: 0x000C4C08
	private void Selectlist_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Open a Text File";
		openFileDialog.Filter = "Text Files|*.txt";
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileName = openFileDialog.FileName;
					if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrWhiteSpace(fileName))
					{
						string[] array = File.ReadAllLines(fileName);
						if (array.Length != 0)
						{
							int num = array.Length - 1;
							for (int i = 0; i <= num; i++)
							{
								string text = array[i].Replace(" ", "");
								if (Versioned.IsNumeric(text))
								{
									this.numslist.Items.Add(text);
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x000C6AE0 File Offset: 0x000C4CE0
	private void Checkall_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.checkall.Checked)
		{
			this.phonetext.Text = "";
			this.phonetext.Enabled = false;
			this.numslist.Items.Clear();
			this.numslist.Enabled = false;
			this.selectlist.Enabled = false;
			this.addnum.Enabled = false;
			this.remnum.Enabled = false;
		}
		else
		{
			this.phonetext.Text = "";
			this.phonetext.Enabled = true;
			this.numslist.Enabled = true;
			this.selectlist.Enabled = true;
			this.addnum.Enabled = true;
			this.remnum.Enabled = false;
		}
	}

	// Token: 0x04000C35 RID: 3125
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("phonetext")]
	private DrakeUITextBox _phonetext;

	// Token: 0x04000C36 RID: 3126
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	// Token: 0x04000C37 RID: 3127
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	// Token: 0x04000C38 RID: 3128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("remnum")]
	private DrakeUIAvatar _remnum;

	// Token: 0x04000C39 RID: 3129
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnum")]
	private DrakeUIAvatar _addnum;

	// Token: 0x04000C3A RID: 3130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectlist")]
	private DrakeUIAvatar _selectlist;

	// Token: 0x04000C3B RID: 3131
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkall")]
	private DrakeUICheckBox _checkall;
}
