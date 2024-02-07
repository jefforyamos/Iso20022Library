﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CollateralSubstitutionResponseV04.  ISO2002 ID# _5bGyoYFrEeWtPe6Crjmeug.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.colr.CollateralSubstitutionResponseV04>;

namespace BeneficialStrategies.Iso20022.colr;


/// <summary>
/// This record is an implementation of the colr.011.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected.
/// </summary>
[Serializable]
[Description(@"Scope|The CollateralSubstitutionResponse message is sent by either the collateral taker or its collateral manager to the collateral giver or its collateral manager. This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected. If the collateral proposed is rejected then a new CollateralSubstitutionRequest should be sent. Note: There are cases where the collateral giver will send this message when the collateral taker has initiated the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This is a response to the CollateralSubstitutionRequest message and the collateral proposed in the substitution request can be accepted or rejected.")]
public partial record CollateralSubstitutionResponseV04 : IOuterRecord<CollateralSubstitutionResponseV04,CollateralSubstitutionResponseV04Document>
    ,IIsoXmlSerilizable<CollateralSubstitutionResponseV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.011.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CollateralSubstitutionResponseV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_5bGyo4FrEeWtPe6Crjmeug")]
    [Description(@"Unambiguous identification of the transaction as know by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required IsoMax35Text TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_5bGypYFrEeWtPe6Crjmeug")]
    [Description(@"Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.")]
    [DataMember(Name="Oblgtn")]
    [XmlElement(ElementName="Oblgtn")]
    [Required]
    public required Obligation4 Obligation { get; init; }
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_5bGyp4FrEeWtPe6Crjmeug")]
    [Description(@"Agreement details for the over the counter market.")]
    [DataMember(Name="Agrmt")]
    [XmlElement(ElementName="Agrmt")]
    public Agreement4? Agreement { get; init; }
    
    /// <summary>
    /// Provides details about the collateral substitution response.
    /// </summary>
    [IsoId("_5bGyqYFrEeWtPe6Crjmeug")]
    [Description(@"Provides details about the collateral substitution response.")]
    [DataMember(Name="SbstitnRspn")]
    [XmlElement(ElementName="SbstitnRspn")]
    [Required]
    public required SubstitutionResponse1 SubstitutionResponse { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_5bGyq4FrEeWtPe6Crjmeug")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CollateralSubstitutionResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CollateralSubstitutionResponseV04Document ToDocument()
    {
        return new CollateralSubstitutionResponseV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("CollSbstitnRspn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Oblgtn", xmlNamespace );
        Obligation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Agreement is Agreement4 AgreementValue)
        {
            writer.WriteStartElement(null, "Agrmt", xmlNamespace );
            AgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SbstitnRspn", xmlNamespace );
        SubstitutionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralSubstitutionResponseV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CollateralSubstitutionResponseV04"/>.
/// </summary>
[Serializable]
public partial record CollateralSubstitutionResponseV04Document : IOuterDocument<CollateralSubstitutionResponseV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.011.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CollateralSubstitutionResponseV04"/> is required.
    /// </summary>
    [DataMember(Name=CollateralSubstitutionResponseV04.XmlTag)]
    public required CollateralSubstitutionResponseV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(CollateralSubstitutionResponseV04.XmlTag);
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
