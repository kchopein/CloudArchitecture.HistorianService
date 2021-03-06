﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HistorianService;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HistorianService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(
                    options => options.Listen(IPAddress.Any, 5000, listenOptions => 
                    {
                        listenOptions.UseConnectionLogging();
                    })
                )
                .UseUrls("http://+:5000")
                .UseStartup<Startup>()
                .Build();
                
    }
}
