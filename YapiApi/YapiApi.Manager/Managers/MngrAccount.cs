using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiApi.Manager.Managers
{
    public class MngrAccount:MngrBase
    {
        public bool IsPhoneNumberTaken(string phoneNumber)
        {        
            var PhoneCount = db.AspNetUsers.Where(a => a.PhoneNumber == phoneNumber).Count();
            if (PhoneCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmailTaken(string Email)
        {
            var EmailCount = db.AspNetUsers.Where(e => e.Email == Email).Count();
            if (EmailCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
