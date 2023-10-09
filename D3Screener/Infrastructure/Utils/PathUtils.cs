using System.IO;
using System.Reflection;

namespace D3Screener.Infrastructure.Utils
{
    public static class PathUtils
    {
        public static string GetTemplateFolderPathByAssembly()
        {
            var app = Assembly.GetExecutingAssembly().GetName().Name;
            var tempFolderPath = Path.GetTempPath();
            var appTempFolderPath = Path.Combine(tempFolderPath, app);

            if (!Directory.Exists(appTempFolderPath))
                Directory.CreateDirectory(appTempFolderPath);

            return appTempFolderPath;
        }

        public static string GenereateFileNameByTime(DateTime time, string extention)
        {
            var path = String.Format("{0}.{1}", time.ToFileTime(), extention);

            return path;
        }
    }
}
