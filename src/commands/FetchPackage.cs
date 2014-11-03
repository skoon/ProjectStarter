using System;
using System.ComponentModel.Composition;

namespace ProjectStarter
{
    public class FetchPackage : ICommand
    {

        public void Execute()
        {
            var pathToNuget = GetPathToNuget();
            if!(String.IsNullOrEmpty(pathToNuget)) {

            } else {
                throw new Exception("Could not find nuget.exe in your path.");
            }
        }

        public string Name { get; set; }
        public IConfig Config { get; set; }

    private string GetPathToNuget() {
        var path = string.Empty;
        var pathVar = Environment.GetEnvironmentVariable("PATH");
        var exes = pathVar.split(";");
        foreach(var e in exes) {
            if(e.contains("nuget.exe")) {
                return e;
            }
        }

    }
    }
}
