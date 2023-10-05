using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;


namespace Broker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().UseUrls("http://127.0.0.1:5001").Build().Run();
        }

    }
}
