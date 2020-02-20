using System.IO;

namespace Captain.CO2NET.Helpers
{
    public class FileHelper
    {
        /// <summary>
        /// 根据完整文件路径获取文件流
        /// </summary>
        /// <param name="fullFilePath"></param>
        /// <returns></returns>
        public static FileStream GetFileStream(string fullFilePath)
        {
            FileStream fileStream = null;
            if (!string.IsNullOrEmpty(fullFilePath) && File.Exists(fullFilePath))
            {
                fileStream = new FileStream(fullFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            }
            return fileStream;
        }
    }
}
