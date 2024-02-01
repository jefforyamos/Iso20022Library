﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RegulatoryTransactionReportStatusV01.  ISO2002 ID# _gJ-K8MIFEeGllrOKQRUTYA_-1798409708.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A regulator or an intermediary sends the RegulatoryTransactionReportStatus to a reporting institution to provide the status of a RegulatoryTransactionReport previously sent by the reporting institution.
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
[Description(@"Scope|A regulator or an intermediary sends the RegulatoryTransactionReportStatus to a reporting institution to provide the status of a RegulatoryTransactionReport previously sent by the reporting institution.|Usage|The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:|- Completed, or,|- Pending, or,|- Rejected.|If the status is rejected, then reason for the rejection must be specified.")]
public partial record RegulatoryTransactionReportStatusV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptStsV01";
    
    #nullable enable
    /// <summary>
    /// Identification of the RegulatoryTransactionReportStatus document.
    /// </summary>
    [IsoId("_gJ-K8cIFEeGllrOKQRUTYA_-1414225965")]
    [Description(@"Identification of the RegulatoryTransactionReportStatus document.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification8 Identification { get; init; }
    
    /// <summary>
    /// Identification of the firm that is legally responsible for sending the transaction report.
    /// </summary>
    [IsoId("_gJ-K8sIFEeGllrOKQRUTYA_1208200865")]
    [Description(@"Identification of the firm that is legally responsible for sending the transaction report.")]
    [DataMember(Name="RptgInstn")]
    [XmlElement(ElementName="RptgInstn")]
    [Required]
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; }
    
    /// <summary>
    /// Provides the status of the entire RegulatoryTransactionReport that was previously sent by the reporting institution.
    /// </summary>
    [IsoId("_gJ-K88IFEeGllrOKQRUTYA_963266001")]
    [Description(@"Provides the status of the entire RegulatoryTransactionReport that was previously sent by the reporting institution.")]
    [DataMember(Name="RptSts")]
    [XmlElement(ElementName="RptSts")]
    [Required]
    public required ReportStatusAndReason1 ReportStatus { get; init; }
    
    /// <summary>
    /// Provides the status of one or more transactions that were previously sent within a RegulatoryTransactionReport by the reporting institution.
    /// </summary>
    [IsoId("_gJ-K9MIFEeGllrOKQRUTYA_1351125442")]
    [Description(@"Provides the status of one or more transactions that were previously sent within a RegulatoryTransactionReport by the reporting institution.")]
    [DataMember(Name="IndvTxSts")]
    [XmlElement(ElementName="IndvTxSts")]
    [Required]
    public required TradeTransactionStatusAndReason1 IndividualTransactionStatus { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RegulatoryTransactionReportStatusV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RegulatoryTransactionReportStatusV01Document ToDocument()
    {
        return new RegulatoryTransactionReportStatusV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RegulatoryTransactionReportStatusV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RegulatoryTransactionReportStatusV01Document : IOuterDocument<RegulatoryTransactionReportStatusV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RegulatoryTransactionReportStatusV01"/> is required.
    /// </summary>
    public required RegulatoryTransactionReportStatusV01 Message { get; init; }
}
