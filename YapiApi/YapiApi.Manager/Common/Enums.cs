using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiApi.Manager.Common
{
    public class Enums
    {
        public enum AppConfig : byte
        {
            RegisterEmail = 0,
            RegisterEmailPassword,
            RegisterEmailHost,
            RegisterEmailPort,
            ContactUsEmail

        }
        public enum CountryCode : int
        {
            SudanCode=249
        }

    }
}
