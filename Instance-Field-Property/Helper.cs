using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffApp
{
    public static class Helper
    {
        // Classes marked as static cannot be instantiated.
        //  Helper H1 = new Helper();
        /*
            public void Test()
        {

        }

            Standard methods cannot be used in static classes. (non-static methods)

            public string Tanim { get; set; }

            Non-static field definitions cannot be made within static classes. 
         */

        //public Helper()
        //{
        // The application runs the standard constructor method whenever an object is instantiated. 
        //}

        static Helper()
        {
            // No matter how many times they are called within the application, they only work on the first call...
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void SendEmail(string receiverEmailAddress, string objectt, string content)
        {
            // Email sending operations will continue...
            Console.WriteLine("Sending email process is successful");
        }
    }
}
