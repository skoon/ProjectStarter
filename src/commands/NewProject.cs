using System;
using System.ComponentModel.Composition;
using NuGet;

namespace ProjectStarter
{
    [Export(typeof(ICommand))]
    public class NewProject : ICommand
    {

        private readonly IFileSystem _fileSystem;
        public string Name { get; set; }
        public IConfig Config { get; set; }

        public NewProject(IFileSystem FileSystem)
        {
            _fileSystem = FileSystem;
        }

        public void Execute()
        {
            CreateDirectories();
            FetchPackages();    
        }
        

        private void CreateDirectories()
        {
            if (!String.IsNullOrEmpty(Name))
                Config.RootDirectory = Name;
            _fileSystem.CreateDirectory(Config.RootDirectory);
            foreach (var dir in Config.SubDirectories)
            {
                _fileSystem.CreateDirectoryInWorkingDirectory(dir);
            }
        }
        private void FetchPackages()
        {
            if (Config.Packages != null)
            {
                IPackageRepository repo = PackageRepositoryFactory.Default.CreateRepository("https://packages.nuget.org/api/v2");
                PackageManager packageManager = new PackageManager(repo, Config.LibPath);

                try
                {
                    foreach (var package in Config.Packages)
                    {
                        packageManager.InstallPackage(package.PackageId, SemanticVersion.Parse(package.Version));
                    }
                }
                catch (Exception ex)
                {
                    throw new NewProjectException("Could not fetch pacakges",ex);            
                }
            }

        }
    }
    public class NewProjectException : Exception
    {
        public NewProjectException(string message, Exception ex)
        {

        }
    }
}