using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Common
{
    public static class Global
    {
        // global int
        //public static string userid;

        public static string access_token { get; set; }
        public static string token_type { get; set; }
        public static int expires_in { get; set; }
        public static string displayName { get; set; }
        public static string userName { get; set; }
        public static string userid { get; set; }
        public static DateTime? lastLogin { get; set; }
        public static DateTime? expires { get; set; }

        //// global function
        //public static string HelloWorld()
        //{
        //    return "Hello World";
        //}

        // global int using get/set
        static string _getsetuserid;
        public static string _userid
        {
            set { _getsetuserid = value; }
            get { return _getsetuserid; }
        }


        static string _getsetaccess_token;
        public static string _access_token
        {
            set { _getsetaccess_token = value; }
            get { return _getsetaccess_token; }
        }

        static string _getsettoken_type { get; set; }
        public static string _token_type
        {
            set { _getsettoken_type = value; }
            get { return _getsettoken_type; }
        }

        static int _getsetexpires_in { get; set; }
        public static int _expires_in
        {
            set { _getsetexpires_in = value; }
            get { return _getsetexpires_in; }
        }


        static string _getsetdisplayName { get; set; }
        public static string _displayName
        {
            set { _getsetdisplayName = value; }
            get { return _getsetdisplayName; }
        }

        static string _getsetuserName { get; set; }
        public static string _userName
        {
            set { _getsetuserName = value; }
            get { return _getsetuserName; }
        }


        static DateTime? _getsetlastLogin { get; set; }
        public static DateTime? _lastLogin
        {
            set { _getsetlastLogin = value; }
            get { return _getsetlastLogin; }
        }


        static DateTime? _getsetexpires { get; set; }
        public static DateTime? _expires
        {
            set { _getsetexpires = value; }
            get { return _getsetexpires; }
        }

    }
}
