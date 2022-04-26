namespace CustomCs.Configuration.Sources;

public interface IDataSource
{
    Dictionary<string, string> GetAll();
}