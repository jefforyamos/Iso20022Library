using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common.PocRecords;

public class ContactDetailsRecTestSerialization : TestSerialization<ContactDetailsRec>
{

    public ContactDetailsRecTestSerialization(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
    protected override ContactDetailsRec Sample => new ContactDetailsRec { Name = "Jeff", Email = "jeff@somedomain.com" };

    protected override string ExpectedSampleXml => @"
        <CtctDtls>
            <Nm>Jeff</Nm>
    	    <EmailAdr>jeff@somedomain.com</EmailAdr>
        </CtctDtls>
";
}

