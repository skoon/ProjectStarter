using System;
using Xunit;
using ProjectStarter;
using ProjectStarter_Tests.Mocks;

namespace ProjectStarter_Tests.UnitTests
{

    public class when_executing_the_NewProject_command : when_executing_a_command
    {

        [Fact]
        public void the_root_directory_should_be_created()
        {
            Assert.Contains(projectname, _mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_src_directory_should_be_created()
        {
            Assert.Contains("src", _mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_tests_directory_should_be_created()
        {
            Assert.Contains("tests", _mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_lib_directory_should_be_created()
        {
            Assert.Contains("lib", _mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_packages_directory_should_be_created()
        {
            Assert.Contains("packages", _mockFileSystem.DirectoriesCreated);
        }

        [Fact]
        public void the_configs_directory_should_be_created()
        {
            Assert.Contains("configs", _mockFileSystem.DirectoriesCreated);
        }
    }
}
