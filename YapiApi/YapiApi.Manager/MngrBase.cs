using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapiApi.Manager.Common;
using YapiApi.Data;

namespace YapiApi.Manager
{
    public class MngrBase
    {
        internal protected YapiEntities db = new YapiEntities();
        Feedback feedback = new Feedback();
    }
}
