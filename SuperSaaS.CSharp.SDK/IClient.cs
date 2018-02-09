using System;
using System.Collections.Generic;

namespace SuperSaaS.CSharp.SDK
{
    public enum HttpMethod {GET, POST, PUT, DELETE}; 

    public interface IClient
    {
        void request(HttpMethod method, string path);
    }
}
