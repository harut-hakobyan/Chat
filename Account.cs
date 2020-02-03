using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat
{
    static class Account
    {
        public static string nickname { get; set; }
        public static string name { get; set; }
        public static string surname { get; set; }
        public static string email { get; set; }
        public static string password { get; set; }
        public static string date { get; set; }
        public static string gender { get; set; }
        public static bool signed = false;
        public static bool admin = false;
        public static int id = 0;
        public static int verificationCode = 0;
        public static int resetCode = 0;
    }
}
