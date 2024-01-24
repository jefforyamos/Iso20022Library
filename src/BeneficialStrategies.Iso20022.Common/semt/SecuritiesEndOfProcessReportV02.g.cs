﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesEndOfProcessReportV02.  ISO2002 ID# _j5E4gQNmEe2P7e2qGFFOGg.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
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
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.|It may also be sent through Central Matching Utility (CMU).|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Executing Party, CMU or Instructing Party|Respondent: Custodian or an affirming party does not need to respond.")]
public partial record SecuritiesEndOfProcessReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesEndOfPrcRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_j5E4hwNmEe2P7e2qGFFOGg")]
    [Description(@"Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public SomePaginationRecord? Pagination { get; init; }
    
    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_j5E4iQNmEe2P7e2qGFFOGg")]
    [Description(@"Notifies the type of report transmitted.")]
    [DataMember(Name="RptGnlDtls")]
    [XmlElement(ElementName="RptGnlDtls")]
    [Required]
    public required SomeReportGeneralDetailsRecord ReportGeneralDetails { get; init; }
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_j5E4iwNmEe2P7e2qGFFOGg")]
    [Description(@"Parties involved in the confirmation of the details of a trade.")]
    [DataMember(Name="ConfPties")]
    [XmlElement(ElementName="ConfPties")]
    public SomeConfirmationPartiesRecord? ConfirmationParties { get; init; }
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_j5E4jQNmEe2P7e2qGFFOGg")]
    [Description(@"Party that identifies the underlying investor.")]
    [DataMember(Name="Invstr")]
    [XmlElement(ElementName="Invstr")]
    public SomeInvestorRecord? Investor { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_j5E4jwNmEe2P7e2qGFFOGg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesEndOfProcessReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesEndOfProcessReportV02Document ToDocument()
    {
        return new SecuritiesEndOfProcessReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesEndOfProcessReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesEndOfProcessReportV02Document : IOuterDocument<SecuritiesEndOfProcessReportV02>
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
    public required SecuritiesEndOfProcessReportV02 Message { get; init; }
}
