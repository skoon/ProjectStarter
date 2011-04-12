using System;
using Xunit;
using Moq;
using ProjectStarter;

namespace ProjectStarter_Tests.UnitTests
{
    public class when_creating_files_using_the_filesystem
    {
        private FileSystem _fileSystem;
        private Mock<IDirectoryInfoWrapper> _mockDirectoryWrapper;
        private Mock<IFileInfoWrapper> _mockFileInfoWrapper;
        public when_creating_files_using_the_filesystem()
        {
            _mockDirectoryWrapper = new Mock<IDirectoryInfoWrapper>();
            _mockFileInfoWrapper = new Mock<IFileInfoWrapper>();
            _fileSystem = new FileSystem(_mockDirectoryWrapper.Object, _mockFileInfoWrapper.Object);
        }

        [Fact]
        public void should_call_the_CreateSubDirectory_method()
        {
            _fileSystem.CreateDirectory("test");
            _mockDirectoryWrapper.Verify(m => m.CreateSubDirectory(It.IsAny<String>()));
        }

        [Fact]
        public void should_call_the_CreateFile_method()
        {
            _fileSystem.CreateFile("test.txt", "test");
            _mockFileInfoWrapper.Verify(f => f.CreateFile(It.IsAny<String>(), It.IsAny<String>()));
        }
    }
}
