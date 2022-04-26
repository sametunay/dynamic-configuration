namespace CustomCs.Configuration.Sources;

public class TestSource : IDataSource
{
    public Dictionary<string, string> GetAll()
    {
        return new Dictionary<string, string>() { { "appName", "dynamic-configuration" } };
    }
}