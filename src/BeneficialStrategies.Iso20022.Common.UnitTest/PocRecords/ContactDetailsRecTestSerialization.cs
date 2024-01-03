namespace BeneficialStrategies.Iso20022.Common.PocRecords;

public class ContactDetailsRecTestSerialization : TestSerialization<ContactDetailsRec>
{
    protected override ContactDetailsRec Sample => new ContactDetailsRec { Name = "Jeff", Email = "jeff@somedomain.com" };

    protected override string ExpectedSampleXml => @"
        <CtctDtls>
            <Nm>Jeff</Nm>
    	    <EmailAdr>jeff@somedomain.com</EmailAdr>
        </CtctDtls>
";
}

