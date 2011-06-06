using System;
using System.Collections.Generic;
using ProjectStarter;

namespace ProjectStarter_Tests.Mocks {

    public class MockFileSystem : IFileSystem {
        public string WorkingDirectory{get; set;}
        public bool CreateDirectoryCalled = false;
        public bool CreateFileCalled = false;
        public bool CreateDirectoryInWorkingDirectoryCalled = false;
        

        public List<string> DirectoriesCreated = new List<string>();
        public List<string> FilesRead = new List<string>();
        public List<string> FilesCreated = new List<string>();

        public string ReturnFromReadFile = "{test:'test'}"; 

        public void CreateDirectory(string name) {
            CreateDirectoryCalled = true;
            DirectoriesCreated.Add(name);
        }
        
        public void CreateFile(string name, string contents) {
            CreateFileCalled = true;
            FilesCreated.Add(name);
        }
        
        public void CreateDirectoryInWorkingDirectory(string name) {
            CreateDirectoryInWorkingDirectoryCalled = true;
            DirectoriesCreated.Add(name);
        }

        public string ReadFile(string name) {
            FilesRead.Add(name);
            return ReturnFromReadFile; 
        }
    }
}
