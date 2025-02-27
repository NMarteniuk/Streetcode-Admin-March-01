﻿using DbUp;
using Microsoft.Extensions.Configuration;

string migrationPath = Path.Combine(Directory.GetCurrentDirectory(), "Streetcode.DAL", "Persistence", "ScriptsMigration");

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Local";

var configuration = new ConfigurationBuilder()
    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Streetcode.WebApi"))
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables("STREETCODE_")
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");

string pathToScript = string.Empty;

Console.WriteLine("Enter '-m' to MIGRATE or '-s' to SEED db:");
pathToScript = Console.ReadLine() ?? string.Empty;

pathToScript = migrationPath;

var upgrader =
    DeployChanges.To
        .SqlDatabase(connectionString)
        .WithScriptsFromFileSystem(pathToScript)
        .LogToConsole()
        .Build();

var result = upgrader.PerformUpgrade();

if (!result.Successful)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(result.Error);
    Console.ResetColor();
#if DEBUG
    Console.ReadLine();
#endif
    return -1;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Success!");
Console.ResetColor();
return 0;