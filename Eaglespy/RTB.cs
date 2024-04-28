using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x020000B3 RID: 179
public class RTB : RichTextBox
{
	// Token: 0x06000780 RID: 1920 RVA: 0x0000350E File Offset: 0x0000170E
	public RTB()
	{
		base.SetStyle(ControlStyles.EnableNotifyMessage, true);
		RTB.HideCaret(base.Handle);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x000B25C8 File Offset: 0x000B07C8
	protected override void WndProc(ref Message m)
	{
		if (m.Msg != 522 || !this.ctrlPressed)
		{
			base.WndProc(ref m);
		}
		RTB.HideCaret(base.Handle);
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x000B2604 File Offset: 0x000B0804
	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e.Modifiers == Keys.Control)
		{
			this.ctrlPressed = true;
		}
		base.OnKeyDown(e);
		RTB.HideCaret(base.Handle);
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x0000352E File Offset: 0x0000172E
	protected override void OnKeyUp(KeyEventArgs e)
	{
		this.ctrlPressed = false;
		base.OnKeyUp(e);
		RTB.HideCaret(base.Handle);
	}

	// Token: 0x06000784 RID: 1924
	[DllImport("user32.dll")]
	public static extern bool HideCaret(IntPtr hwnd);

	// Token: 0x04000AB8 RID: 2744
	private bool ctrlPressed;
}
