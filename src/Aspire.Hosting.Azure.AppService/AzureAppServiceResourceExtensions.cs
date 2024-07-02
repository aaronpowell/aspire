using System.Diagnostics.CodeAnalysis;
using Aspire.Hosting.ApplicationModel;

namespace Aspire.Hosting;

/// <summary>
/// Extension methods for adding Azure AppService resources to the application model.
/// </summary>
public static class AzureAppServiceResourceExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    [Experimental("AZPROVISION001", UrlFormat = "https://aka.ms/dotnet/aspire/diagnostics#{0}")]
    public static IResourceBuilder<ProjectResource> PublishAsAppService(this IResourceBuilder<ProjectResource> builder)
    {
        var annotation = new ProjectHostingAnnotation("azure", "appservice");
        builder.WithAnnotation(annotation);
        return builder;
    }
}
