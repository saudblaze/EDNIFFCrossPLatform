using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.APIModels
{
    public class vwAuthToken
    {

    }
    public class AuthDetails
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string displayName { get; set; }
        public string userName { get; set; }
        public string userid { get; set; }
        public DateTime? lastLogin { get; set; }
        public DateTime? expires { get; set; }
    }
    public class vwLoginError
    {
        public string error { get; set; }
        public string error_description { get; set; }
    }
}
