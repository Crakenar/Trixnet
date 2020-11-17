using Microsoft.Extensions.Configuration;
using System.IO;

//Teo berguerre 17/11/2020
static class ConfigurationManager
{
    public static IConfiguration variablesSettings { get; }
    static ConfigurationManager()
    {
        variablesSettings = (IConfiguration)new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("variables.json").Build();
    }
}