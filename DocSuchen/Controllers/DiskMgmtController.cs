namespace DocSuchen.Controllers
{
    public static class DiskMgmtController
    {
        public static List<string> GetExistingDirectories(string mainPath)
        {
            List<string> directories = new List<string>();

            try
            {
                if (Directory.Exists(mainPath))
                {
                    var unformattedDirectories = Directory.GetDirectories(mainPath).ToList();

                    foreach (string dir in unformattedDirectories)
                    {
                        directories.Add(Path.GetFileName(dir));
                    }
                }
                else
                {
                    // Log Error
                }
            }
            catch (Exception ex)
            {
                // Log Error
            }

            return directories;
        }
    }
}