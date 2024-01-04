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

//          <CtctDtls xmlns:i=""http://www.w3.org/2001/XMLSchema-instance""><EmailAdr>jeff@somedomain.com</EmailAdr><Nm>Jeff</Nm></CtctDtls>
// xmlns:i=""http://www.w3.org/2001/XMLSchema-instance""
