using System;
using System.Web.Script.Serialization;

namespace ProjectStarter {

    public interface IConfig {
        string RawConfig { get; set; }
        string RootDirectory { get; set; }
        string[] SubDirectories { get; set; }
    }

    public class Config : IConfig{

        public string RawConfig { get; set; }
        public string RootDirectory { get; set; }
        public string[] SubDirectories { get; set; }

        public static IConfig LoadConfig(string configFileContents) {
            if(String.IsNullOrEmpty(configFileContents))
                throw new ArgumentException("The file contents must contain valid JSON");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var config = serializer.Deserialize<Config>(configFileContents);
            config.RawConfig = configFileContents;
            return config;

        }
    }    

}

