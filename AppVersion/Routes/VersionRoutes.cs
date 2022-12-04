using AppVersion.ViewModel;
using System.Reflection;

namespace AppVersion.Routes
{
    public static class Version_Routes
    {
        public static IEndpointRouteBuilder MapVersions(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/appVersion", () =>
            {
                var assembly = Assembly.GetEntryAssembly().GetName().Version.ToString();
                var fileVersion = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version.ToString();
                var version = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion.ToString();

                return new AppVersionAssembly(assembly, fileVersion, version);
            })
            .WithName("GetVersion");

            return builder;
        }
    }
}
