using System;
using Xunit;

namespace ProjectStarter_Tests.UnitTests {
    public class the_NewProject_command_should_use_the_config_file_when_creating_the_project : when_using_a_json_config_file {

        [Fact]
        public void the_root_directory_should_be_created() {
            Assert.Contains("Test", _mockFileSystem.FilesCreated);
        }
    }
}
