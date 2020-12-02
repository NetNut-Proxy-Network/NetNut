//Set a simple http request
HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://www.msn.com");
          
//Set Proxy - this example is the German proxy
var proxyURI = new Uri("http://gw.ntnt.io:5959");
myReq.Proxy = new WebProxy(proxyURI);
myReq.Proxy.Credentials = new NetworkCredential("username-cc-any", "password");
myReq.Credentials = new NetworkCredential("username-cc-any", "password");
HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
