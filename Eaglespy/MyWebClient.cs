using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000095 RID: 149
public class MyWebClient : WebClient
{
	// Token: 0x060006A7 RID: 1703 RVA: 0x000A70A0 File Offset: 0x000A52A0
	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
			httpWebRequest.ClientCertificates.Add(new X509Certificate());
		}
		return webRequest;
	}
}
