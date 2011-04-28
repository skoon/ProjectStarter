using System;
using System.IO;

namespace ProjectStarter
{
    public interface IFileSystem
    {
        string WorkingDirectory{get; set;}
        void CreateDirectory(string name);
        void CreateFile(string name, string contents);
        void CreateDirectoryInWorkingDirectory(string name);
        string ReadFile(string name);
    }

    public class FileSystem : IFileSystem
    {
        private IDirectoryInfoWrapper _currentDirectory;
        private IFileInfoWrapper _fileInfoWrapper;
        public FileSystem(IDirectoryInfoWrapper currentDirectory, IFileInfoWrapper fileInfoWrapper)
        {
            _currentDirectory = currentDirectory;
            _fileInfoWrapper = fileInfoWrapper;
            WorkingDirectory = _currentDirectory.WorkingDirectory;
        }

        public string WorkingDirectory { get; set; }

        public void CreateDirectory(string name)
        {
            WorkingDirectory = name;
            _currentDirectory.CreateSubDirectory(name);
        }

        public void CreateDirectoryInWorkingDirectory(string name)
        {
            _currentDirectory.CreateSubDirectory(String.Format("{0}\\{1}", WorkingDirectory, name));
        }

        public void CreateFile(string name, string contents)
        {
            _fileInfoWrapper.CreateFile(name, contents);
        }

        public string ReadFile(string name) {
            return string.Empty;   
        }
    }
        
}
