using System;
using System.Collections.Generic;
using ProjectStarter;

namespace ProjectStarter_tests {

    public class MockFileSystem : IFileSystem {
        public string WorkingDirectory{get; set;}
        public bool CreateDirectoryCalled = false;
        public bool CreateFileCalled = false;
        public bool CreateDirectoryInWorkingDirectoryCalled = false;

        public List<string> directoriesCreated = new List<string>();
        public List<string> FilesRead = new List<string>();
        
        public void CreateDirectory(string name) {
            CreateDirectoryCalled = true;
            directoriesCreated.Add(name);
        }
        
        public void CreateFile(string name, string contents) {
            CreateFileCalled = true;
        }
        
        public void CreateDirectoryInWorkingDirectory(string name) {
            CreateDirectoryInWorkingDirectoryCalled = true;
            directoriesCreated.Add(name);
        }

        public void ReadFile(string name) {
            FilesRead.Add(name);
        }
    }
}
