namespace DocSuchen.Controllers
{
    public static class FileController
    {
        public static int CountFilesInFolder(string targetFolder)
        {
            return Directory.GetFiles(targetFolder).Length;
        }
    }
}