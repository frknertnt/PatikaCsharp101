using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffApp
{
    internal class Staff
    {
        public static string domainAddress;

        public string Name { get; set; }
        public string Lastname { get; set; }

        private string _emailaddress;
        public string Emailaddress
        {
            get
            {
                return this._emailaddress;
            }
            set
            {
                this._emailaddress = value.ToLower() + "@" + Staff.domainAddress;
            }
        }

        public int Gender { get; set; }


        public Staff()
        {
            Console.WriteLine("Method that works in every instance");
        }

        static Staff()
        {
            domainAddress = "myfirm.com";
        }
    }
}
