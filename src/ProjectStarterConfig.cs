using System;
using System.Web.Script.Serialization;

namespace ProjectStarter {

    public class ProjectStarterConfig {

        public string Config { get; set; }
        public string RootDirectory { get; set; }

        public static ProjectStarterConfig LoadConfig(string configFileContents) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var config = serializer.Deserialize<ProjectStarterConfig>(configFileContents);
            config.Config = configFileContents;
            return config;

        }
    }    

}

