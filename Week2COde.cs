using System;
using System.Linq;
using System.Net;

namespace IPAddress
{
    class Assignment
    {
        /* How to Validate the IPv4 IP Address is Valid or Not in C# */
        static void Main(string[] args)
        {
            IsValidIPAddress("201.52.56.33");
            IsValidIPAddress("172.02.02.30");
            IsValidIPAddress("127.0.0.1");
            IsValidIPAddress("127.0.526.1");
            IsValidIPAddress("5");
            IsValidIPAddress("0.0.0.5");
            IsValidIPAddress("0.0.0.0");
            IsValidIPAddress("0.0.5");

            //pRESS ENTER to exit the program
            Console.ReadKey();
        }

        public static void IsValidIPAddress(string IpAddress)
        {
            try
            {
                IPAddress IP;
                if (IpAddress.Count(c => c == '.') == 3)
                {
                    bool flag = IPAddress.TryParse(IpAddress, out IP);
                    if (flag)
                    {
                        Console.WriteLine("{0} is a valid IP address", IpAddress);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid IP address", IpAddress);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not a valid IP address", IpAddress);
                }
            }
            catch (Exception) { }
        }
    }
}