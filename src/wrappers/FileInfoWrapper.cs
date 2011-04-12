using System.IO;
namespace ProjectStarter 
{
    public interface IFileInfoWrapper
    {
        void CreateFile(string path, string contents);
    }

    public class FileInfoWrapper : IFileInfoWrapper
    {
        public void CreateFile(string path, string contents)
        {
            var writer = File.CreateText(path);
            writer.Write(contents);
            writer.Close();
            writer.Dispose();
        }

    }
}
