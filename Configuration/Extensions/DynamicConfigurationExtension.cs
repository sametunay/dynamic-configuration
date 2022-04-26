using CustomCs.Configuration.Sources;

namespace CustomCs.Configuration.Extensions;

public static class DynamicConfigurationExtension
{
    public static IConfigurationBuilder AddDynamicConfiguration(this IConfigurationBuilder builder, Action<DynamicSource> options)
    {
        return builder.Add<DynamicSource>(options);
    }
}