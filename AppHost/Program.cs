var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("cash")
    .WithRedisCommander();

var api = builder.AddProject<Projects.Api>("api")
    .WithReference(redis);

var app = builder.AddProject<Projects.MyWeatherHub>("myweatherhub")
    .WithReference(api)
    .WithExternalHttpEndpoints();

builder.Build().Run();