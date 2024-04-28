using System;
using System.Drawing;

// Token: 0x0200009B RID: 155
public sealed class Notifications
{
	// Token: 0x060006BF RID: 1727 RVA: 0x00003376 File Offset: 0x00001576
	public Notifications()
	{
		this.sizeHeight = MyProject.Forms.Report.Height;
	}

	// Token: 0x040009E4 RID: 2532
	public Bitmap FLAG;

	// Token: 0x040009E5 RID: 2533
	public string TEXT;

	// Token: 0x040009E6 RID: 2534
	public int sizeHeight;

	// Token: 0x040009E7 RID: 2535
	public DateTime start;

	// Token: 0x040009E8 RID: 2536
	public bool startTime;
}
