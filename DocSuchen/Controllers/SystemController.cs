using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.Json;
using DocSuchen.Models;
using File = System.IO.File;

namespace DocSuchen.Controllers
{
    public static class SystemController
    {
        private static int DetectNumberCPUCores()
        {
            int coreCount = 0;

            foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString()!);
            }

            return coreCount;
        }

        public static Config LoadConfig(string filePath)
        {
            string configFilePath = string.Concat(filePath, @"\config.json");

            if (!File.Exists(configFilePath))
                CreateConfigIfUnexisting(filePath);
            
            string jsonString = File.ReadAllText(configFilePath);
            return JsonSerializer.Deserialize<Config>(jsonString)!;
        }

        public static void CreateConfigIfUnexisting(string filePath)
        {
            Config newConfig = new Config()
            {
                NumberOfCores = DetectNumberCPUCores(),
                WorkingDirectory = "",
                AvailableDirectories = DiskMgmtController.GetExistingDirectories(filePath)
            };

            string jsonString = JsonSerializer.Serialize(newConfig);
            string configFilePath = string.Concat(filePath, @"\config.json");
            File.WriteAllText(configFilePath, jsonString);
        }

        public static TaskStatus UpdateConfig(string mainPath, Config updatedConfig)
        {
            string configFilePath = string.Concat(mainPath, @"\config.json");

            List<string> existingDirectories = DiskMgmtController.GetExistingDirectories(mainPath);

            if (updatedConfig == null)
            {
                return TaskStatus.Faulted;
            }

            File.Delete(configFilePath);

            string jsonString = JsonSerializer.Serialize(updatedConfig);

            File.WriteAllText(configFilePath, jsonString);

            return TaskStatus.RanToCompletion;
        }
    }
}