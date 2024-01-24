﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RegulatoryTransactionReportCancellationStatusV01.  ISO2002 ID# _gJrQAcIFEeGllrOKQRUTYA_-231568037.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// Scope
/// A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.
/// Usage
/// The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:
/// - Completed, or,
/// - Pending, or,
/// - Rejected.
/// If the status is rejected, then reason for the rejection must be specified.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.|Usage|The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:|- Completed, or,|- Pending, or,|- Rejected.|If the status is rejected, then reason for the rejection must be specified.")]
public partial record RegulatoryTransactionReportCancellationStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptCxlStsV01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification of the RegulatoryTransactionReportCancellationStatus document.
    /// </summary>
    [IsoId("_gJrQAsIFEeGllrOKQRUTYA_1165719728")]
    [Description(@"Identification of the RegulatoryTransactionReportCancellationStatus document.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Identification of the firm that executed the transaction.
    /// </summary>
    [IsoId("_gJrQA8IFEeGllrOKQRUTYA_1815879851")]
    [Description(@"Identification of the firm that executed the transaction.")]
    [DataMember(Name="RptgInstn")]
    [XmlElement(ElementName="RptgInstn")]
    [Required]
    public required SomeReportingInstitutionRecord ReportingInstitution { get; init; }
    
    /// <summary>
    /// Provides the status of the entire RegulatoryTransactionReportCancellationRequest document that was previously sent by a reporting institution.||.
    /// </summary>
    [IsoId("_gJrQBMIFEeGllrOKQRUTYA_-1473248173")]
    [Description(@"Provides the status of the entire RegulatoryTransactionReportCancellationRequest document that was previously sent by a reporting institution.||.")]
    [DataMember(Name="RptCxlSts")]
    [XmlElement(ElementName="RptCxlSts")]
    [Required]
    public required SomeReportCancellationStatusRecord ReportCancellationStatus { get; init; }
    
    /// <summary>
    /// Provides the cancellation status of one or more transactions within a RegulatoryTransactionReportCancellationRequest that was previously sent by a reporting institution.
    /// </summary>
    [IsoId("_gJrQBcIFEeGllrOKQRUTYA_-1483406141")]
    [Description(@"Provides the cancellation status of one or more transactions within a RegulatoryTransactionReportCancellationRequest that was previously sent by a reporting institution.")]
    [DataMember(Name="IndvTxCxlSts")]
    [XmlElement(ElementName="IndvTxCxlSts")]
    [Required]
    public required SomeIndividualTransactionCancellationStatusRecord IndividualTransactionCancellationStatus { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RegulatoryTransactionReportCancellationStatusV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RegulatoryTransactionReportCancellationStatusV01Document ToDocument()
    {
        return new RegulatoryTransactionReportCancellationStatusV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RegulatoryTransactionReportCancellationStatusV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RegulatoryTransactionReportCancellationStatusV01Document : IOuterDocument<RegulatoryTransactionReportCancellationStatusV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RegulatoryTransactionReportCancellationStatusV01"/> is required.
    /// </summary>
    public required RegulatoryTransactionReportCancellationStatusV01 Message { get; init; }
}
