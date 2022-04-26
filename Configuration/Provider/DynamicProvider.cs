namespace CustomCs.Configuration.Provider;

public class DynamicProvider : ConfigurationProvider, IConfigurationProvider
{
    public override void Load()
    {
        base.Load();
    }

    public override void Set(string key, string value)
    {
        base.Set(key, value);
    }
}