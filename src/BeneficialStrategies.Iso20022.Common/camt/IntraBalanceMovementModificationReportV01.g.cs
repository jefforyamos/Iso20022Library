﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementModificationReportV01.  ISO2002 ID# _DLtK2TncEem7JZMuWtwtsg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// The IntraBalanceMovementModificationReport message is sent from a settlement infrastructure to an account owner/requestor to provide full details or current status values of the intra-balance movement modification request(s), as defined within the query. ||The message may also be used to: 
/// - re-send a message previously sent (the sub-function of the message is "Duplicate") 
/// - provide a third party with a copy of a message for information (the sub-function of the message is "Copy") 
/// - re-send to a third party a copy of a message for information (the sub-function of the message is "Copy Duplicate").
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The IntraBalanceMovementModificationReport message is sent from a settlement infrastructure to an account owner/requestor to provide full details or current status values of the intra-balance movement modification request(s), as defined within the query. ||The message may also be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"") |- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"") |- re-send to a third party a copy of a message for information (the sub-function of the message is ""Copy Duplicate"").")]
public partial record IntraBalanceMovementModificationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntModRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtK6TncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of the message as known by the account servicer or settlement infrastructure.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    public DocumentIdentification51? Identification { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_DLtK6zncEem7JZMuWtwtsg")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// General characteristics related to the report information.
    /// </summary>
    [IsoId("_DLtK7TncEem7JZMuWtwtsg")]
    [Description(@"General characteristics related to the report information.")]
    [DataMember(Name="RptGnlDtls")]
    [XmlElement(ElementName="RptGnlDtls")]
    [Required]
    public required IntraBalanceReport5 ReportGeneralDetails { get; init; }
    
    /// <summary>
    /// Provides information on report or error resulting from the originating query message.
    /// </summary>
    [IsoId("_DLtK7zncEem7JZMuWtwtsg")]
    [Description(@"Provides information on report or error resulting from the originating query message.")]
    [DataMember(Name="RptOrErr")]
    [XmlElement(ElementName="RptOrErr")]
    public IIntraBalanceOrOperationalError8Choice? ReportOrError { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtK8TncEem7JZMuWtwtsg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementModificationReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementModificationReportV01Document ToDocument()
    {
        return new IntraBalanceMovementModificationReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraBalanceMovementModificationReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntraBalanceMovementModificationReportV01Document : IOuterDocument<IntraBalanceMovementModificationReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.081.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementModificationReportV01"/> is required.
    /// </summary>
    public required IntraBalanceMovementModificationReportV01 Message { get; init; }
}
