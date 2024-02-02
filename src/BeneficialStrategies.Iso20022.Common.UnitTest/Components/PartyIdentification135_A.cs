using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Components;

public class PartyIdentification135_A : TestPublishedSample<PartyIdentification135>
{
    public PartyIdentification135_A(ITestOutputHelper output) : base(output)
    {
    }

    protected override PartyIdentification135 Sample => new()
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
            };
}
