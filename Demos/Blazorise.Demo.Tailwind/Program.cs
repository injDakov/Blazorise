﻿#region Using directives
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazorise.Tailwind;
using Blazorise.Icons.FontAwesome;
using Blazorise.RichTextEdit;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
#endregion

namespace Blazorise.Demo.Tailwind;

public class Program
{
    public static async Task Main( string[] args )
    {
        var builder = WebAssemblyHostBuilder.CreateDefault( args );

        builder.Services
            .SetupDemoServices()
            .AddTailwindProviders()
            .AddFontAwesomeIcons();

        builder.RootComponents.Add<App>( "#app" );
        builder.Services.AddScoped( sp => new HttpClient { BaseAddress = new Uri( builder.HostEnvironment.BaseAddress ) } );

        await builder.Build().RunAsync();
    }
}