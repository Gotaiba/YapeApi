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
        public enum RegistrationType : int
        {
            CardWithNewiPAN=10,
            CardWithExistingiPAN=12,           
        }
        public enum AuthenticationType:int
        {
            PAN_iPIN=00,
            EntityId_iPIN=10,
            EnityId_Password=11,
            Username_iPIN=20,
            Username_Password=21

        }
        public enum EntityGroup: int
        {
            AllChannels=1,
            OneChannel=0
        }



    }
}
