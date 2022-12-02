namespace AppVersion.entities
{
    public class appVersionAssembly
    {
        public string GetAssemblyVersion()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
