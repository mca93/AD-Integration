using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB_AD.Idenetity.Utils
{
    public class AdUserUtil
    {
        public string JsonUser(AdUser adUser)
        {
            string jsonUser = Newtonsoft.Json.JsonConvert.SerializeObject(adUser);
            return jsonUser;
        }
    }
}
