var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHttpClients(configuration);
        services.AddScoped<IDocCoreHandler, DocCoreHandler>();
        services.AddHttpClient();
        services.AddRepositories();
        services.AddSingleton<IApplication, DocCoreTemplateHandler.Application>();
    })
    .UseLogging(useCloudEnabledServices)
    .Build();