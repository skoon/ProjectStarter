using System;
using Xunit;
using ProjectStarter_Tests.Mocks;
using ProjectStarter;
    
namespace ProjectStarter_Tests.UnitTests {
    public class when_there_is_no_config_file_present {
        private readonly MockFileSystem _mockFileSystem;
        private readonly ArgParser _parser;


        public when_there_is_no_config_file_present() {
            _mockFileSystem = new MockFileSystem() { ReturnFromReadFile = null };
            _parser = new ArgParser(null, _mockFileSystem);
        }


        [Fact]
        public void should_look_for_the_default_config_file() {
            Assert.Contains("default.json", _mockFileSystem.FilesRead);
        }

        [Fact]
        public void should_create_the_default_config_file_if_it_does_not_exist() {
            Assert.Contains("default.json", _mockFileSystem.FilesCreated);
        }

    }
}
