﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesTradeConfirmationCancellationV01.  ISO2002 ID# _RJ4jMOQXEeCGktPI9k4Dlw_1174499492.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.setr.SecuritiesTradeConfirmationCancellationV01>;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.
/// Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Serializable]
[Description(@"Scope|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.|Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.")]
public partial record SecuritiesTradeConfirmationCancellationV01 : IOuterRecord<SecuritiesTradeConfirmationCancellationV01,SecuritiesTradeConfirmationCancellationV01Document>
    ,IIsoXmlSerilizable<SecuritiesTradeConfirmationCancellationV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfCxl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesTradeConfirmationCancellationV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_RJ4jMeQXEeCGktPI9k4Dlw_-1509857852")]
    [Description(@"Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required TransactiontIdentification4 Identification { get; init; }
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_RJ4jMuQXEeCGktPI9k4Dlw_135409583")]
    [Description(@"Link to another transaction that must be processed after, before or at the same time.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    public Linkages15? References { get; init; }
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_RJ4jM-QXEeCGktPI9k4Dlw_588788110")]
    [Description(@"Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.")]
    [DataMember(Name="OthrBizPties")]
    [XmlElement(ElementName="OthrBizPties")]
    public OtherParties18? OtherBusinessParties { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RJ4jNOQXEeCGktPI9k4Dlw_-206107615")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesTradeConfirmationCancellationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesTradeConfirmationCancellationV01Document ToDocument()
    {
        return new SecuritiesTradeConfirmationCancellationV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesTradConfCxl");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (References is Linkages15 ReferencesValue)
        {
            writer.WriteStartElement(null, "Refs", xmlNamespace );
            ReferencesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherBusinessParties is OtherParties18 OtherBusinessPartiesValue)
        {
            writer.WriteStartElement(null, "OthrBizPties", xmlNamespace );
            OtherBusinessPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesTradeConfirmationCancellationV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesTradeConfirmationCancellationV01"/>.
/// </summary>
[Serializable]
public partial record SecuritiesTradeConfirmationCancellationV01Document : IOuterDocument<SecuritiesTradeConfirmationCancellationV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.029.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesTradeConfirmationCancellationV01"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesTradeConfirmationCancellationV01.XmlTag)]
    public required SecuritiesTradeConfirmationCancellationV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesTradeConfirmationCancellationV01.XmlTag);
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
