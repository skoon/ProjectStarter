using System;
using System.IO;

namespace ProjectStarter
{
    public interface IDirectoryInfoWrapper
    {
        DirectoryInfo CreateSubDirectory(string path);
        string WorkingDirectory { get; set; }
    }

    public class DirectoryInfoWrapper : IDirectoryInfoWrapper
    {
        public string WorkingDirectory { get; set; }

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
