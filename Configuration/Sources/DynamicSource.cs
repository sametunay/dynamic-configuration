using CustomCs.Configuration.Provider;

namespace CustomCs.Configuration.Sources;

public class DynamicSource : IConfigurationSource
{
    public IDataSource DataSource { get; set; }

    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new DynamicProvider(this);
    }
}