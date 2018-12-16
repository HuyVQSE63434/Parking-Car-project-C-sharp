using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace parkingScreen.DAO
{
    class SMSSender
    {
        private string phone;
        private string content;
        private string sercetKey;
        private string ApiKey;
        public bool sendSMS(string phoneNum, string keyCode)
        {

            phone = phoneNum;
            content = "Ma xac thuc cua ban la "+keyCode;
            ApiKey = "415E5D0B6B9E0192149B7FFCADFB2F";
            sercetKey = "3BEBBD9E06AFB623CE9C25E78DBE70";
            string URL = "http://rest.esms.vn/MainService.svc/json/SendMultipleMessage_V4_get?Phone=" + phone
                + "&Content=" + content + "&ApiKey=" + ApiKey + "&SecretKey=" + sercetKey
                + "&IsUnicode=0&Brandname=Verify&SmsType=2";

            string result = SendGetRequest(URL);
            JObject ojb = JObject.Parse(result);
            int CodeResult = (int)ojb["CodeResult"];//100 is successfull
            if (CodeResult == 100)
            {
                return true;
            }
            return false;
        }
        private string SendGetRequest(string RequestUrl)
        {
            Uri address = new Uri(RequestUrl);
            HttpWebRequest request;
            HttpWebResponse response = null;
            StreamReader reader;
            if (address == null) { throw new ArgumentNullException("address"); }
            try
            {
                request = WebRequest.Create(address) as HttpWebRequest;
                request.UserAgent = ".NET Sample";
                request.KeepAlive = false;
                request.Timeout = 15 * 1000;
                response = request.GetResponse() as HttpWebResponse;
                if (request.HaveResponse == true && response != null)
                {
                    reader = new StreamReader(response.GetResponseStream());
                    string result = reader.ReadToEnd();
                    result = result.Replace("</string>", "");
                    return result;
                }
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (HttpWebResponse errorResponse = (HttpWebResponse)wex.Response)
                    {
                        Console.WriteLine(
                            "The server returned '{0}' with the status code {1} ({2:d}).",
                            errorResponse.StatusDescription, errorResponse.StatusCode,
                            errorResponse.StatusCode);
                    }
                }
            }
            finally
            {
                if (response != null) { response.Close(); }
            }
            return null;
        }
    }
}
