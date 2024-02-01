using BeneficialStrategies.Iso20022.Components;
using Xunit.Abstractions;
using Iso = BeneficialStrategies.Iso20022;

namespace BeneficialStrategies.Iso20022.Components;

public class GroupHeader95_A : TestPublishedSample<GroupHeader95>
{
    public GroupHeader95_A(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Test() { }
    
    protected override GroupHeader95 Sample => new()
        {
            MessageIdentification = "ABC/120928/CCT001",
            CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
            NumberOfTransactions = "3",
            ControlSum = 11500000,
            InitiatingParty = new()
            {
                Name = "ABC Corporation",
                PostalAddress = new()
                {
                    StreetName = "Times Square",
                    BuildingNumber = "7",
                    PostCode = "NY 10036",
                    TownName = "New York",
                    Country = "US"
                },
            },
        };
}