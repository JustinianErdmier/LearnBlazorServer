namespace BlazorApp.Data;

public interface ISampleDataService
{
    List<string> GetMilkshakeTypes();

    List<string> GetMilkshakeSizes();
}
