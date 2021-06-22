using Microsoft.Extensions.Configuration;

namespace AuthoritySystem.Common.Helper
{
    public class ConfigHelper
    {
   

        public static string GetValue(string key)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var root= configurationBuilder.Build();
            return root[key];
        }
    }
}
