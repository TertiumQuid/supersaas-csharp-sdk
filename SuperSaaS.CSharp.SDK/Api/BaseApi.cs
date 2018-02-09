using System;
namespace SuperSaaS.CSharp.SDK.Api
{
    public class BaseApi
    {
        private IClient client;

        public BaseApi(IClient client)
        {
            this.client = client;
        }
    }
}
