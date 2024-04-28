using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200004E RID: 78
[StandardModule]
internal sealed class EagleAlert
{
	// Token: 0x0600038D RID: 909 RVA: 0x00053E94 File Offset: 0x00052094
	public static void ShowCustome(string msg, Bitmap img, Color backcolor, Color rondcolor)
	{
		try
		{
			alertform alertform = new alertform(msg);
			alertform.Show();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00053EC4 File Offset: 0x000520C4
	public static void ShowSucess(string msg)
	{
		alertform alertform = new alertform(msg);
		alertform.Show();
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00053EC4 File Offset: 0x000520C4
	public static void ShowWarning(string msg)
	{
		alertform alertform = new alertform(msg);
		alertform.Show();
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00053EC4 File Offset: 0x000520C4
	public static void Showinformation(string msg)
	{
		alertform alertform = new alertform(msg);
		alertform.Show();
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00053EC4 File Offset: 0x000520C4
	public static void ShowError(string msg)
	{
		alertform alertform = new alertform(msg);
		alertform.Show();
	}
}
