using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiApi.Manager.Common
{
    public enum Feedback:int
    {
        //Success
        AddedSuccess = 200,
        EditedSuccess = 201,
        DeletedSuccess = 202,
        SendConfirmToScholar = 203,
        PasswordChanged = 204,
        CheckEmailToReset = 205,
        SMSSuccess=206,

        //Fail
        AddedFaild=400,
        EditedFaild=401,
        DeletedFaild=402,
        SMSFaild=406
        
    }
}
