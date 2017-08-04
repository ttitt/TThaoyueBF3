using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
namespace TThaoyueBF3Master
{
    class HTTP
    {
        /*
        Http报头分为：通用报头、请求报头、响应报头和实体报头 
        请求方Http报头结构：通用报头、请求报头、实体报头 
        响应方Http报头结构：通用报头、响应报头、实体报头 
        */
        /// <summary>
        /// UserAgent标识
        /// </summary>                    
        private static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        /// <summary>
        /// 请求头Accept
        /// </summary>
        private static string Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        /// <summary>
        /// 实体报头ContentType
        /// </summary>       
        private static string ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
        //private static string ContentType = "Application/javascript";
        /// <summary>
        /// Cookies
        /// </summary>
        public static CookieContainer Cookies = new CookieContainer();
        /// <summary>
        /// Times33算法
        /// </summary>
        /// <param name="skey">skey字符串</param>
        public static int Getg_tk(string skey)
        {
            int num = 0x1505;
            int num2 = 0;
            while (num2 < skey.Length) { num += (num << 5) + skey[num2++]; }
            return (num & 0x7fffffff);
        }
        /// <summary>
        /// 获取HTTP协议Headers标头之SetCookie
        /// </summary>
        /// <param name="Url">Url地址</param>
        /// <param name="Referer">Referer地址</param>
        public static string GetHttpSetCookie(string Url, string Referer = null)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            WebHeaderCollection headerCollection = null;
            string resHeadersCookie = string.Empty;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(Url);
                req.AllowAutoRedirect = false;
                req.Method = "GET";
                req.Timeout = 3000;
                req.UserAgent = UserAgent;
                req.Accept = Accept;
                req.ProtocolVersion = HttpVersion.Version11;
                req.Referer = Referer == null ? null : Referer;
                req.Proxy = null;
                res = (HttpWebResponse)req.GetResponse();
                headerCollection = res.Headers;
                if (headerCollection != null)
                {
                    foreach (string h in headerCollection.AllKeys)
                    {
                        if (h == "Set-Cookie") { resHeadersCookie = (headerCollection[h]); }
                    }
                }
                return resHeadersCookie;
            }
            catch (Exception) { return resHeadersCookie; }
            finally { if (req != null) { req.Abort(); } if (res != null) { res.Close(); } if (headerCollection != null) { headerCollection.Clear(); } }
        }
        /// <summary>
        /// 获取HTTP请求网站
        /// </summary>
        /// <param name="Url">Url地址</param>
        /// <param name="Referer">Referer地址</param>
        public static void GetHttp1_1(string Url, string Referer = null)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(Url);
                req.CookieContainer = Cookies;
                req.AllowAutoRedirect = false;
                req.Method = "GET";
                req.Timeout = 3000;
                req.UserAgent = UserAgent;
                req.Accept = Accept;
                req.ProtocolVersion = HttpVersion.Version11;
                req.Referer = Referer == null ? null : Referer;
                req.Proxy = null;
                res = (HttpWebResponse)req.GetResponse();
                Cookies.Add(res.Cookies);
            }
            catch (Exception ex) { throw ex; }
            finally { if (res != null) { res.Close(); } if (req != null) { req.Abort(); } }
        }
        /// <summary>
        /// HTTP_Get
        /// </summary>
        /// <param name="Url">Get地址</param>
        /// <param name="Referer">referer地址</param>
        /// <param name="Encode">字符编码</param>
        /// <returns>HTTP_Get数据</returns>
        public static string Get(string Url, string Referer = null, Encoding Encode = null)
        {
            string GetData = string.Empty;
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                req = (HttpWebRequest)WebRequest.Create(Url);
                req.CookieContainer = Cookies;
                req.AllowAutoRedirect = false;
                req.Method = "GET";
                req.Timeout = 3000;
                req.UserAgent = UserAgent;
                req.Accept = Accept;
                req.ProtocolVersion = HttpVersion.Version11;
                req.Referer = Referer == null ? null : Referer;
                req.Proxy = null;
                res = (HttpWebResponse)req.GetResponse();
                Cookies.Add(res.Cookies);
                using (StreamReader reader = new StreamReader(res.GetResponseStream(), Encode == null ? Encoding.UTF8 : Encode)) { GetData = reader.ReadToEnd(); }
                //using (FileStream fs = new FileStream("HTTP_Get_Data.txt", FileMode.Create)) { byte[] data = Encoding.UTF8.GetBytes(GetData); fs.Write(data, 0, data.Length); }
            }
            catch
            {
                return GetData;
            }
            //catch (HttpException httpex)
            //{
            //    return "HttpException:" + httpex + "";
            //}
            //catch (WebException webex)
            //{
            //    return "WebException:" + webex + "";
            //}
            finally
            {
                if (res != null) { res.Close(); } if (req != null) { req.Abort(); }
            }
            return GetData;
        }
        /// <summary>
        /// HTTP_Post
        /// </summary>
        /// <param name="Url">Post地址</param>
        /// <param name="postdata">Post数据</param>
        /// <param name="Referer">referer地址</param>
        /// <param name="Encode">字符编码</param>
        /// <returns>HTTP_Post数据</returns>
        public static string Post(string Url, string postdata, string Referer = null, Encoding Encode = null)
        {
            string PostData = string.Empty;
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                req = WebRequest.Create(Url) as HttpWebRequest;
                req.CookieContainer = Cookies;
                req.ContentType = ContentType;
                req.Method = "POST";
                req.Proxy = null;
                req.Timeout = 3000;
                req.UserAgent = UserAgent;
                req.Accept = Accept;
                req.ProtocolVersion = HttpVersion.Version11;
                req.Referer = Referer == null ? null : Referer;

                byte[] mybyte = Encoding.Default.GetBytes(postdata);
                req.ContentLength = mybyte.Length;

                Stream stream = req.GetRequestStream();
                stream.Write(mybyte, 0, mybyte.Length);
                res = req.GetResponse() as HttpWebResponse;
                Cookies.Add(res.Cookies);
                stream.Close();

                using (StreamReader SR = new StreamReader(res.GetResponseStream(), Encode == null ? Encoding.UTF8 : Encode)) { PostData = SR.ReadToEnd(); }
                //using (FileStream fs = new FileStream("HTTP_Get_Data.txt", FileMode.Create)) { byte[] data = Encoding.UTF8.GetBytes(GetData); fs.Write(data, 0, data.Length); }
            }
            catch
            {
                return PostData;
            }
            //catch (HttpException httpex)
            //{
            //    return "HttpException:" + httpex + "";
            //}
            //catch (WebException webex)
            //{
            //    return "WebException:" + webex + "";
            //}
            finally
            {
                if (res != null) { res.Close(); } if (req != null) { req.Abort(); }
            }
            return PostData;
        }
        /// <summary>
        /// Post_Async_Action
        /// </summary>
        /// <param name="ActionData">ActionData</param>
        public delegate void Post_Async_Action(string ActionData);
        /// <summary>
        /// Post_Async_Data
        /// </summary>
        private class Post_Async_Data
        {
            public HttpWebRequest req;
            public Post_Async_Action post_Async_Action;
        }
        /// <summary>
        /// Post_Async
        /// </summary>
        /// <param name="Url">Post地址</param>
        /// <param name="PostData">Post数据</param>
        /// <param name="Action">Post_Async_Data</param>
        /// <param name="Referer">referer地址</param>
        public static void Post_Async(string Url, string PostData, Post_Async_Action Action, string Referer = null)
        {
            HttpWebRequest req = WebRequest.Create(Url) as HttpWebRequest;
            req.CookieContainer = Cookies;
            req.ContentType = ContentType;
            req.Method = "POST";
            req.Referer = Referer == null ? null : Referer;
            req.UserAgent = UserAgent;
            req.Accept = Accept;
            req.Proxy = null;
            req.ProtocolVersion = HttpVersion.Version11;
            req.Timeout = 3000;

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(PostData);
            Stream stream = req.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            Post_Async_Data PostAsyncData = new Post_Async_Data();
            PostAsyncData.req = req;
            PostAsyncData.post_Async_Action = Action;
            req.BeginGetResponse(new AsyncCallback(Post_Async_ResponesProceed), PostAsyncData);
        }
        /// <summary>
        /// Post_Async_ResponesProceed
        /// </summary>
        private static void Post_Async_ResponesProceed(IAsyncResult ar)
        {
            Post_Async_Data dat = ar.AsyncState as Post_Async_Data;
            HttpWebRequest req = dat.req;
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            StreamReader reader = null;
            string Temp = string.Empty;
            using (reader = new StreamReader(res.GetResponseStream()))
            {
                Temp = reader.ReadToEnd();
                res.Close();
                req.Abort();
                dat.post_Async_Action(Temp);
            }
        }
        /// <summary>
        /// 获取Cookies
        /// </summary>
        /// <returns>Cookies字符串</returns>
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
        public static string GetCookies(string url)
        {
            uint pcchCookieData = 0x400;
            StringBuilder pchCookieData = new StringBuilder((int)pcchCookieData);
            if (!InternetGetCookieEx(url, null, pchCookieData, ref pcchCookieData, 0x2000, IntPtr.Zero))
            {
                if (pcchCookieData < 0)
                { return null; }
                pchCookieData = new StringBuilder((int)pcchCookieData);
                if (!InternetGetCookieEx(url, null, pchCookieData, ref pcchCookieData, 0x2000, IntPtr.Zero))
                { return null; }
            }
            return pchCookieData.ToString();
        }
    }
}