using Microsoft.Extensions.Configuration;
using System.IO;

static class ConfigurationManager
{
    public static IConfiguration variablesSettings { get; }
    static ConfigurationManager()
    {
        variablesSettings = (IConfiguration)new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("variables.json").Build();
    }
}