﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesEndOfProcessReportV02.  ISO2002 ID# _j5E4gQNmEe2P7e2qGFFOGg.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.semt.SecuritiesEndOfProcessReportV02>;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// This record is an implementation of the semt.023.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.
/// It may also be sent through Central Matching Utility (CMU).
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Executing Party, CMU or Instructing Party
/// Respondent: Custodian or an affirming party does not need to respond.
/// </summary>
[Serializable]
[Description(@"Scope|Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.|It may also be sent through Central Matching Utility (CMU).|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Executing Party, CMU or Instructing Party|Respondent: Custodian or an affirming party does not need to respond.")]
public partial record SecuritiesEndOfProcessReportV02 : IOuterRecord<SecuritiesEndOfProcessReportV02,SecuritiesEndOfProcessReportV02Document>
    ,IIsoXmlSerilizable<SecuritiesEndOfProcessReportV02>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.023.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesEndOfPrcRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesEndOfProcessReportV02Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_j5E4hwNmEe2P7e2qGFFOGg")]
    [Description(@"Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination1? Pagination { get; init; }
    
    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_j5E4iQNmEe2P7e2qGFFOGg")]
    [Description(@"Notifies the type of report transmitted.")]
    [DataMember(Name="RptGnlDtls")]
    [XmlElement(ElementName="RptGnlDtls")]
    [Required]
    public required Report6 ReportGeneralDetails { get; init; }
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_j5E4iwNmEe2P7e2qGFFOGg")]
    [Description(@"Parties involved in the confirmation of the details of a trade.")]
    [DataMember(Name="ConfPties")]
    [XmlElement(ElementName="ConfPties")]
    public ConfirmationParties7? ConfirmationParties { get; init; }
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_j5E4jQNmEe2P7e2qGFFOGg")]
    [Description(@"Party that identifies the underlying investor.")]
    [DataMember(Name="Invstr")]
    [XmlElement(ElementName="Invstr")]
    public PartyIdentificationAndAccount220? Investor { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_j5E4jwNmEe2P7e2qGFFOGg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesEndOfProcessReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesEndOfProcessReportV02Document ToDocument()
    {
        return new SecuritiesEndOfProcessReportV02Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesEndOfPrcRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Pagination is Pagination1 PaginationValue)
        {
            writer.WriteStartElement(null, "Pgntn", xmlNamespace );
            PaginationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RptGnlDtls", xmlNamespace );
        ReportGeneralDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ConfirmationParties is ConfirmationParties7 ConfirmationPartiesValue)
        {
            writer.WriteStartElement(null, "ConfPties", xmlNamespace );
            ConfirmationPartiesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Investor is PartyIdentificationAndAccount220 InvestorValue)
        {
            writer.WriteStartElement(null, "Invstr", xmlNamespace );
            InvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesEndOfProcessReportV02 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesEndOfProcessReportV02"/>.
/// </summary>
[Serializable]
public partial record SecuritiesEndOfProcessReportV02Document : IOuterDocument<SecuritiesEndOfProcessReportV02>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.023.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesEndOfProcessReportV02"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesEndOfProcessReportV02.XmlTag)]
    public required SecuritiesEndOfProcessReportV02 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesEndOfProcessReportV02.XmlTag);
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
