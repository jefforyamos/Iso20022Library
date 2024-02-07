﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlStatusAdviceV03.  ISO2002 ID# _Nz8avx3pEeuiRvbpCaJe6A.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.auth.CurrencyControlStatusAdviceV03>;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.027.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.
/// 
/// Usage: 
/// The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.
/// </summary>
[Serializable]
[Description(@"The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.||Usage: |The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.")]
public partial record CurrencyControlStatusAdviceV03 : IOuterRecord<CurrencyControlStatusAdviceV03,CurrencyControlStatusAdviceV03Document>
    ,IIsoXmlSerilizable<CurrencyControlStatusAdviceV03>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.027.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CurrencyControlStatusAdviceV03Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_Nz8awR3pEeuiRvbpCaJe6A")]
    [Description(@"Characteristics shared by all individual items included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required CurrencyControlHeader6 GroupHeader { get; init; }
    
    /// <summary>
    /// Provides the group status for the global message.
    /// </summary>
    [IsoId("_Nz8awx3pEeuiRvbpCaJe6A")]
    [Description(@"Provides the group status for the global message.")]
    [DataMember(Name="GrpSts")]
    [XmlElement(ElementName="GrpSts")]
    [Required]
    public required CurrencyControlGroupStatus2 GroupStatus { get; init; }
    
    /// <summary>
    /// Provides the status of the package in the message, which may contain the individual records.
    /// </summary>
    [IsoId("_Nz8axR3pEeuiRvbpCaJe6A")]
    [Description(@"Provides the status of the package in the message, which may contain the individual records.")]
    [DataMember(Name="PackgSts")]
    [XmlElement(ElementName="PackgSts")]
    public CurrencyControlPackageStatus2? PackageStatus { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Nz8axx3pEeuiRvbpCaJe6A")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CurrencyControlStatusAdviceV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CurrencyControlStatusAdviceV03Document ToDocument()
    {
        return new CurrencyControlStatusAdviceV03Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CcyCtrlStsAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "GrpHdr", xmlNamespace );
        GroupHeader.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "GrpSts", xmlNamespace );
        GroupStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PackageStatus is CurrencyControlPackageStatus2 PackageStatusValue)
        {
            writer.WriteStartElement(null, "PackgSts", xmlNamespace );
            PackageStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CurrencyControlStatusAdviceV03 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CurrencyControlStatusAdviceV03"/>.
/// </summary>
[Serializable]
public partial record CurrencyControlStatusAdviceV03Document : IOuterDocument<CurrencyControlStatusAdviceV03>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.027.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CurrencyControlStatusAdviceV03"/> is required.
    /// </summary>
    [DataMember(Name=CurrencyControlStatusAdviceV03.XmlTag)]
    public required CurrencyControlStatusAdviceV03 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CurrencyControlStatusAdviceV03.XmlTag);
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
