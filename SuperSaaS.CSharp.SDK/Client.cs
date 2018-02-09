using System;
using System.Net;
using SuperSaaS.CSharp.SDK.Api;

namespace SuperSaaS.CSharp.SDK
{
    public class Client : IClient
    {
        public const string API_VERSION = "1";
        public const string VERSION = "0.1.0";

        public string AccountName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Host { get; set; }
        public bool Test { get; set; }

        public Appointments Appointments { get; set; }
        public Forms Forms { get; set; }
        public Users Users { get; set; }

        public Client(Configuration configuration)
        {
            this.AccountName = configuration.accountName;
            this.Password = configuration.password;
            this.UserName = configuration.userName;
            this.Host = configuration.host;
            this.Test = configuration.test;

            this.Appointments = new Appointments(this);
            this.Forms = new Forms(this);
            this.Users = new Users(this);
        }

        public void request(HttpMethod method, string path)
        {
            string url = this.Host + "/" + path;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

        }

        private string userAgent() {
            return "SSS/" + VERSION + " DOTNET/" + Environment.Version + " API/" + API_VERSION;
        }
    }
}
