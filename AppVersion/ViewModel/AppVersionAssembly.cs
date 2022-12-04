using System.Reflection;

namespace AppVersion.ViewModel
{
    public class AppVersionAssembly
    {
        public AppVersionAssembly(string assemblyVersion, string fileVersion, string version)
        {
            AssemblyVersion = assemblyVersion;
            FileVersion = fileVersion;
            Version = version;
        }

        public string AssemblyVersion { get; set; }
        public string FileVersion { get; set; }
        public string Version { get; set; }

    }
    
}
