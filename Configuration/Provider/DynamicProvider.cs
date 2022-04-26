using CustomCs.Configuration.Sources;

namespace CustomCs.Configuration.Provider;

public class DynamicProvider : ConfigurationProvider, IConfigurationProvider
{
    private readonly DynamicSource _source;
    
    public DynamicProvider(DynamicSource source)
    {
        _source = source;
    }

    public override void Load()
    {
        this.Data = _source.DataSource.GetAll();
    }
}