namespace BlazorApp.Data;

public class SampleDataService
    : ISampleDataService
{
    public List<string> GetMilkshakeTypes() => new List<string> { "Chocolate", "Vanilla", "Peanut Butter", "Strawberry" };

    public List<string> GetMilkshakeSizes() => new List<string> { "Small", "Medium", "Large", "Extra Large" };
}
