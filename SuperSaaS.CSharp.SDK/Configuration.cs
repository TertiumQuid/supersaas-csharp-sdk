using System;
namespace SuperSaaS.CSharp.SDK
{
    public class Configuration
    {
        public const string DEFAULT_HOST = "http://localhost:3000";

        public string accountName;
        public string password;
        public string userName;
        public string host;
        public bool test;

        public Configuration()
        {
            this.accountName = Environment.GetEnvironmentVariable("SSS_SDK_ACCOUNT_NAME");
            this.password = Environment.GetEnvironmentVariable("SSS_SDK_PASSWORD");
            this.userName = Environment.GetEnvironmentVariable("SSS_SDK_USER_NAME");
            this.test = false;
            this.host = Configuration.DEFAULT_HOST;
        }
    }
}
