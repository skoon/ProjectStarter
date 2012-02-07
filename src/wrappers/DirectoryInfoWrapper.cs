using System;
using System.IO;

namespace ProjectStarter
{
    public interface IDirectoryInfoWrapper
    {
        DirectoryInfo CreateSubDirectory(string path);
        string WorkingDirectory { get; set; }
        string FullPath { get; }
        bool Exists(string path);
    }

    public class DirectoryInfoWrapper : IDirectoryInfoWrapper
    {

        public string WorkingDirectory { get; set; }
        public string FullPath
        {
            get
            {
                return Path.GetFullPath(WorkingDirectory);

            }
        }
        
        public bool Exists(string path)
        {
            return Directory.Exists( path);
        }   

        public DirectoryInfoWrapper(string workingDirectory)
        {
            WorkingDirectory = workingDirectory;
        }
        
        public DirectoryInfo CreateSubDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }

    }
}
