using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Common.PocRecords;

public class RecordsPocTesting
{
    private readonly ITestOutputHelper _output;

    private readonly InitiatingPartyRec SampleRec = new InitiatingPartyRec
    {
        Name = "Virgay",
        PostalAddress = new PostalAddresRec
        {
            StreetName = "Virginia Lane",
            BuildingNumber = "36",
            PostalCode = "NJ 07311",
            TownName = "Jersey City",
            Country = "US"
        },
        ContactDetails = new ContactDetailsRec
        {
            Name = "J.Thompson",
            Email = "Thompson@virgay.com"
        }
    };

    private readonly string SampleRecText = @"
        <InitgPty>
	        <Nm>Virgay</Nm>
	        <PstlAdr>
		        <StrtNm>Virginia Lane</StrtNm>
		        <BldgNb>36</BldgNb>
		        <PstCd>NJ 07311</PstCd>
		        <TwnNm>Jersey City</TwnNm>
		        <Ctry>US</Ctry>
	        </PstlAdr>
	        <CtctDtls>
		        <Nm>J.Thompson</Nm>
		        <EmailAdr>Thompson@virgay.com</EmailAdr>
	        </CtctDtls>
        </InitgPty>
";

    public RecordsPocTesting(ITestOutputHelper testOutputHelper)
    {
        _output = testOutputHelper;
    }

    [Fact]
    public async Task BasicSerialization()
    {
        var party = SampleRec with { Name = "Virgay2" };

        _output.WriteLine(party.ToString());

        var sb = new StringBuilder();
        using (var xmlWriter = XmlWriter.Create(sb, new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true, Async = true }))
        {
            await party.SerializeAsync(xmlWriter);
            xmlWriter.Flush();
        }
        _output.WriteLine(sb.ToString());

        await SampleRec.AssertSerializationMatchesArtifact(SampleRecText, _output);

        // Now for Deserialization

        // using (var XmlReader = new XmlReader())
    }

    [Fact]
    public async Task RoundtripMustWork()
    {
        await SampleRec.AssertSerializationRoundTripWorks(_output);
    }

    [Fact]
    public async Task BasicDeserialization()
    {
        using var stringReader = new StringReader(SampleRecText);
        using var xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings { Async = true });
        var copy = await InitiatingPartyRec.DeserializeAsync(xmlReader);
        Assert.Equal("Virgay", copy.Name);
        Assert.Equal("J.Thompson", copy.ContactDetails.Name);
        Assert.Equal("Thompson@virgay.com", copy.ContactDetails.Email);
        Assert.Equal("Virginia Lane", copy.PostalAddress.StreetName);
        Assert.Equal(SampleRec, copy);
    }

    [Fact]
    public async Task ContactDetailsRoundTrip()
    {
        await SampleRec.ContactDetails.AssertSerializationRoundTripWorks(_output);
    }

    [Fact]
    public async Task InitiatingPartyJsonSerialization()
    {
        await SampleRec.AssertJsonSerializationRoundTrip(_output);
    }

    [Fact]
    public async Task ContactDetailsJsonSerialization()
    {
        await SampleRec.ContactDetails.AssertJsonSerializationRoundTrip(_output);
    }

    [Fact]
    public async Task PostalAddressJsonSerialization()
    {
        await SampleRec.PostalAddress.AssertJsonSerializationRoundTrip(_output);
    }

}

# region Probably not

public class Iso20022XmlDictionaryReader : XmlDictionaryReader
{
    public override int AttributeCount => throw new NotImplementedException();

    public override string BaseURI => throw new NotImplementedException();

    public override int Depth => throw new NotImplementedException();

    public override bool EOF => throw new NotImplementedException();

    public override bool IsEmptyElement => throw new NotImplementedException();

    public override string LocalName => throw new NotImplementedException();

    public override string NamespaceURI => throw new NotImplementedException();

    public override XmlNameTable NameTable => throw new NotImplementedException();

    public override XmlNodeType NodeType => throw new NotImplementedException();

    public override string Prefix => throw new NotImplementedException();

    public override ReadState ReadState => throw new NotImplementedException();

    public override string Value => throw new NotImplementedException();

    public override string GetAttribute(int i)
    {
        throw new NotImplementedException();
    }

    public override string? GetAttribute(string name)
    {
        throw new NotImplementedException();
    }

    public override string? GetAttribute(string name, string? namespaceURI)
    {
        throw new NotImplementedException();
    }

    public override string? LookupNamespace(string prefix)
    {
        throw new NotImplementedException();
    }

    public override bool MoveToAttribute(string name)
    {
        throw new NotImplementedException();
    }

    public override bool MoveToAttribute(string name, string? ns)
    {
        throw new NotImplementedException();
    }

    public override bool MoveToElement()
    {
        throw new NotImplementedException();
    }

    public override bool MoveToFirstAttribute()
    {
        throw new NotImplementedException();
    }

    public override bool MoveToNextAttribute()
    {
        throw new NotImplementedException();
    }

    public override bool Read()
    {
        throw new NotImplementedException();
    }

    public override bool ReadAttributeValue()
    {
        throw new NotImplementedException();
    }

    public override void ResolveEntity()
    {
        throw new NotImplementedException();
    }
}

public class Iso20022ObjectSerializer : XmlObjectSerializer
{
    public override bool IsStartObject(XmlDictionaryReader reader)
    {
        throw new NotImplementedException();
    }

    public override object? ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
    {
        throw new NotImplementedException();
    }

    public override void WriteEndObject(XmlDictionaryWriter writer)
    {
        throw new NotImplementedException();
    }

    public override void WriteObjectContent(XmlDictionaryWriter writer, object? graph)
    {
        throw new NotImplementedException();
    }

    public override void WriteStartObject(XmlDictionaryWriter writer, object? graph)
    {
        throw new NotImplementedException();
    }
}

//public class ContactDetailsRecSerializer : IIsoSerialize<ContactDetailsRec>
//{
//    public static string RootElementLocalName => throw new NotImplementedException();

//    public static Task<ContactDetailsRec> DeserializeAsync(XmlReader reader)
//    {
//        throw new NotImplementedException();
//    }

//    public Task SerializeAsync(XmlWriter writer)
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion

//<InitgPty>
//	<Nm>Virgay</Nm>
//	<PstlAdr>
//		<StrtNm>Virginia Lane</StrtNm>
//		<BldgNb>36</BldgNb>
//		<PstCd>NJ 07311</PstCd>
//		<TwnNm>Jersey City</TwnNm>
//		<Ctry>US</Ctry>
//	</PstlAdr>
//	<CtctDtls>
//		<Nm>J.Thompson</Nm>
//		<EmailAdr>Thompson @virgay.com</EmailAdr>
//	</CtctDtls>
//</InitgPty>
