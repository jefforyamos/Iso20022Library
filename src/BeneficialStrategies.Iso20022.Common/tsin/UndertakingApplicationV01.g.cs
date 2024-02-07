﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingApplicationV01.  ISO2002 ID# _9fRMkHltEeG7BsjMvd1mEw_980511566.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.tsin.UndertakingApplicationV01>;

namespace BeneficialStrategies.Iso20022.tsin;


/// <summary>
/// This record is an implementation of the tsin.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.
/// </summary>
[Serializable]
[Description(@"The UndertakingApplication message is sent by the party requesting issuance of the undertaking (applicant or obligor) to the party issuing the undertaking. It is used to request the issuance of an undertaking (demand guarantee or standby letter of credit or suretyship) or counter-undertaking (counter-guarantee or counter-standby or suretyship), and provides details on the applicable rules, terms, conditions and content of the undertaking to be issued.")]
public partial record UndertakingApplicationV01 : IOuterRecord<UndertakingApplicationV01,UndertakingApplicationV01Document>
    ,IIsoXmlSerilizable<UndertakingApplicationV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.005.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAppl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => UndertakingApplicationV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Details of the application for an independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.
    /// </summary>
    [IsoId("_9fRMkXltEeG7BsjMvd1mEw_-1409870883")]
    [Description(@"Details of the application for an independent undertaking, such as a demand guarantee or standby letter of credit, that provides financial assurance, to be collected on the presentation of documents that comply with its terms and conditions.")]
    [DataMember(Name="UdrtkgApplDtls")]
    [XmlElement(ElementName="UdrtkgApplDtls")]
    [Required]
    public required Undertaking1 UndertakingApplicationDetails { get; init; }
    
    /// <summary>
    /// Instructions specific to the bank receiving the message.
    /// </summary>
    [IsoId("__KBlo3_5EeGOn4dfTT_QdQ")]
    [Description(@"Instructions specific to the bank receiving the message.")]
    [DataMember(Name="InstrsToBk")]
    [XmlElement(ElementName="InstrsToBk")]
    public required SimpleValueList<IsoMax2000Text> InstructionsToBank { get; init; } = []; // Min=0, Max=5
    
    /// <summary>
    /// Digital signature of the undertaking application.
    /// </summary>
    [IsoId("_9fRMknltEeG7BsjMvd1mEw_-448392239")]
    [Description(@"Digital signature of the undertaking application.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingApplicationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingApplicationV01Document ToDocument()
    {
        return new UndertakingApplicationV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("UdrtkgAppl");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "UdrtkgApplDtls", xmlNamespace );
        UndertakingApplicationDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InstrsToBk", xmlNamespace );
        InstructionsToBank.Serialize(writer, xmlNamespace, "Max2000Text", SerializationFormatter.IsoMax2000Text );
        writer.WriteEndElement();
        if (DigitalSignature is PartyAndSignature2 DigitalSignatureValue)
        {
            writer.WriteStartElement(null, "DgtlSgntr", xmlNamespace );
            DigitalSignatureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static UndertakingApplicationV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingApplicationV01"/>.
/// </summary>
[Serializable]
public partial record UndertakingApplicationV01Document : IOuterDocument<UndertakingApplicationV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.005.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingApplicationV01"/> is required.
    /// </summary>
    [DataMember(Name=UndertakingApplicationV01.XmlTag)]
    public required UndertakingApplicationV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(UndertakingApplicationV01.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
