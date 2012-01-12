using System;
using System.IO;
using Xunit;
using ProjectStarter;

namespace ProjectStarter.Tests.IntegrationTests
{
    public class when_creating_a_new_project
    {

        private ArgParser parser;
        private string[] args;
        private DirectoryInfoWrapper dirInfoWrapper;        
        public when_creating_a_new_project() {
            dirInfoWrapper = new DirectoryInfoWrapper(Environment.CurrentDirectory);
            args = new string[] {"Test"};
            parser = new ArgParser(args, new FileSystem( dirInfoWrapper, new FileInfoWrapper()));
        }
    

        public void it_should_create_the_project_directory()
        {
            Assert.True(Directory.Exists(dirInfoWrapper.FullPath));
        }
    }
}
