using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Collections.Specialized;

namespace YapiApi.Models
{
    public class Helper
    {
        public string SendSMS()
        {
            String message = HttpUtility.UrlEncode("Hello From Yapi Again this is the second time :)");
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"apikey" , "WNmhglAL5rQ-hgz1vmh873VdkXiOWa68rotmYgApwW"},
                {"numbers" , "249912130176"},
                {"message" , message},
                {"sender" , "Gotaiba Saeed"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }
    }
}