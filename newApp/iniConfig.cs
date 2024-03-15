using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newApp
{
    internal class iniConfig
    {
        public static string readIni(string iniPath, string sectionName, string keyName)
        {
            // Đọc các dòng trong tệp INI
            string[] lines = File.ReadAllLines(iniPath);

            // Lưu các giá trị từ tệp INI vào từ điển
            Dictionary<string, string> iniValues = new Dictionary<string, string>();
            string currentSection = null;
            foreach (string line in lines)
            {
                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    // Đánh dấu phần tử đang được đọc
                    currentSection = line.Trim('[', ']');
                }
                else if (!string.IsNullOrWhiteSpace(line) && line.Contains("="))
                {
                    // Lưu giá trị vào từ điển
                    string[] keyValue = line.Split('=');
                    if (keyValue.Length == 2 && currentSection == sectionName)
                    {
                        string key = keyValue[0].Trim();
                        if (key == keyName)
                        {
                            string value = keyValue[1].Trim();
                            return value;
                            break;
                        }

                        //iniValues.Add(key, value);
                    }
                }
            }
            return null;
        }
        public static string RelativeToFullPath(string relativePath)
        {
            DirectoryInfo di = new DirectoryInfo(relativePath);
            string fullPath = di.FullName;
            return fullPath;
        }
    }
}
