using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YapiApi.Manager.Common;
using System.Web;
using Newtonsoft.Json.Linq;

namespace YapiApi.Manager.API
{
    public class MngrAPI:MngrBase
    {
        public Feedback SendSMSCode(string Phone,string Code)
        {
            String message = HttpUtility.UrlEncode("Welcome to Yapi Your Code: "+Code);
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"apikey" , "WNmhglAL5rQ-hgz1vmh873VdkXiOWa68rotmYgApwW"},
                {"numbers" ,Phone},
                {"message" , message},
                {"sender" , "Yapi"}
                });
                string result = Encoding.UTF8.GetString(response);               
                var data = JObject.Parse(result);
                var status = (string)data.SelectToken("status");
                if(status=="success")
                {
                    return Feedback.SMSSuccess;
                }
                return Feedback.SMSFaild;                
            }
        }
    }
}
