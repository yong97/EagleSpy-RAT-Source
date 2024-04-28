using System;
using System.Windows.Forms;

// Token: 0x0200009D RID: 157
public class PBar : ProgressBar
{
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000A90FC File Offset: 0x000A72FC
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.Style |= 4;
			return createParams;
		}
	}
}
