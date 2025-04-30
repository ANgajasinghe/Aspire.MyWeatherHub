var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Api>("api");
var app = builder.AddProject<Projects.MyWeatherHub>("myweatherhub");

builder.Build().Run();