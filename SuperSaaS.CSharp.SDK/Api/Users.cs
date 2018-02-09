using System;
namespace SuperSaaS.CSharp.SDK.Api
{
    public class Users : BaseApi
    {
        public enum Roles {BLOCKED = -1, USER = 3, SUPERUSER = 4}; 

        public Users(IClient client) : base(client)
        {
        }
    }
}
