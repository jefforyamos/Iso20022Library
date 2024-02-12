﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RegulatoryTransactionReportCancellationStatusV01.  ISO2002 ID# _gJrQAcIFEeGllrOKQRUTYA_-231568037.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.
/// Usage
/// The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:
/// - Completed, or,
/// - Pending, or,
/// - Rejected.
/// If the status is rejected, then reason for the rejection must be specified.
/// </summary>
[Description(@"Scope|A regulator or an intermediary sends the RegulatoryTransactionReportCancellationStatus to a reporting institution to provide the status of a RegulatoryTransactionReportCancellationRequest previously sent by the reporting institution.|Usage|The message definition may be used to provide a status for the entire report or to provide a status at the level of individual transactions within the report. One of the following statuses can be reported:|- Completed, or,|- Pending, or,|- Rejected.|If the status is rejected, then reason for the rejection must be specified.")]
[IsoId("_gJrQAcIFEeGllrOKQRUTYA_-231568037")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Regulatory Transaction Report Cancellation Status V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryTransactionReportCancellationStatusV01 : IOuterRecord<RegulatoryTransactionReportCancellationStatusV01,RegulatoryTransactionReportCancellationStatusV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RgltryTxRptCxlStsV01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => RegulatoryTransactionReportCancellationStatusV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RegulatoryTransactionReportCancellationStatusV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RegulatoryTransactionReportCancellationStatusV01( DocumentIdentification8 reqIdentification,PartyIdentification23Choice_ reqReportingInstitution,ReportStatusAndReason2 reqReportCancellationStatus,TradeTransactionStatusAndReason2 reqIndividualTransactionCancellationStatus )
    {
        Identification = reqIdentification;
        ReportingInstitution = reqReportingInstitution;
        ReportCancellationStatus = reqReportCancellationStatus;
        IndividualTransactionCancellationStatus = reqIndividualTransactionCancellationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the RegulatoryTransactionReportCancellationStatus document.
    /// </summary>
    [IsoId("_gJrQAsIFEeGllrOKQRUTYA_1165719728")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the firm that executed the transaction.
    /// </summary>
    [IsoId("_gJrQA8IFEeGllrOKQRUTYA_1815879851")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting Institution")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification23Choice_ ReportingInstitution { get; init; } 
    #else
    public PartyIdentification23Choice_ ReportingInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the entire RegulatoryTransactionReportCancellationRequest document that was previously sent by a reporting institution.||.
    /// </summary>
    [IsoId("_gJrQBMIFEeGllrOKQRUTYA_-1473248173")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Cancellation Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportStatusAndReason2 ReportCancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReportStatusAndReason2 ReportCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportStatusAndReason2 ReportCancellationStatus { get; init; } 
    #else
    public ReportStatusAndReason2 ReportCancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the cancellation status of one or more transactions within a RegulatoryTransactionReportCancellationRequest that was previously sent by a reporting institution.
    /// </summary>
    [IsoId("_gJrQBcIFEeGllrOKQRUTYA_-1483406141")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Individual Transaction Cancellation Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransactionStatusAndReason2 IndividualTransactionCancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeTransactionStatusAndReason2 IndividualTransactionCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionStatusAndReason2 IndividualTransactionCancellationStatus { get; init; } 
    #else
    public TradeTransactionStatusAndReason2 IndividualTransactionCancellationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
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
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RegulatoryTransactionReportCancellationStatusV01 Message { get; init; }
    #else
    public RegulatoryTransactionReportCancellationStatusV01 Message { get; init; }
    #endif
}
