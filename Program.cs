using System;
using System.Net;

namespace ClientServer1.Libraries
{
    public class Dnslib
    {
        public void TestUri()
        {
            var uri = GetASimpleUri();

            Console.WriteLine("Uri: {0}", uri.ToString());
            
        }
        public void GetDnsInfo(string webDomainName)
        {
            var domain = Dns.GetHostEntry(webDomainName);

            Console.WriteLine("Hostname: {0}", domain.HostName);
            foreach (var a in domain.AddressList)
            {
                Console.WriteLine("Addresslist: {0}", a);
            }

        }
        private Uri GetASimpleUri()
        {
            var builder = new UriBuilder();
            builder.Scheme = "http";
            builder.Host = "google.com";

            return builder.Uri;
        }
    
}
       public class TestUri
		{
		public static void Main()
		{
		Dnslib d=new Dnslib();
		d.TestUri();
		d.GetDnsInfo("www.google.Com");
		}
		}
}



