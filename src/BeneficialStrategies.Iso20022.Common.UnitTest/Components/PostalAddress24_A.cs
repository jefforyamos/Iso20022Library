using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Components;

public class PostalAddress24_A : TestPublishedSample<PostalAddress24>
{
    public PostalAddress24_A(ITestOutputHelper output) : base(output)
    {
    }

    protected override PostalAddress24 Sample => new()
                {
                    StreetName = "Times Square",
                    BuildingNumber = "7",
                    PostCode = "NY 10036",
                    TownName = "New York",
                    Country = "US"
                };
  
    [Fact]
    public void TestValueEquivalentList()
    {
        var list1 = new SimpleValueList<string> { "One", "Two", "Three"};
        var list2 = new SimpleValueList<string> { "One", "Two", "Three"};
        Assert.Equal(list1, list2);
    }

    [Fact]
    public void Test()
    {
        var a = new PostalAddress24 { AddressLine = ["ABC"]};
        var b = new PostalAddress24 { AddressLine = ["ABC"]};

        var aHC = a.AddressLine.GetHashCode();
        var bHC = b.AddressLine.GetHashCode();

        var aHC0 = a.AddressLine[0].GetHashCode();
        var bHC0 = b.AddressLine[0].GetHashCode();

        a = new PostalAddress24 { BuildingNumber = "1"};
        b = new PostalAddress24 { BuildingNumber = "1"};

        Assert.Equal( a, b);
    }




}
