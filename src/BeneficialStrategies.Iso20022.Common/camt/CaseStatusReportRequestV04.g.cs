﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CaseStatusReportRequestV04.  ISO2002 ID# _eYI_NW2PEei3KuUgpx7Xcw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.038.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CaseStatusReportRequest message is sent by a case creator or case assigner to a case assignee.
/// This message is used to request the status of a case.
/// Usage
/// The CaseStatusReportRequest message must be answered with a CaseStatusReport message. It can be used to request the status of a:
/// - request to cancel payment case;
/// - request to modify payment case;
/// - unable to apply case;
/// - claim non receipt case.
/// The CaseStatusReportRequest message covers one and only one case at a time. If a case creator or case assigner needs the status of several cases, then multiple CaseStatusReportRequest messages must be sent.
/// The CaseStatusReportRequest message may be forwarded to subsequent case assignee(s) in the case processing chain.
/// The processing of a case generates NotificationOfCaseAssignment and/or ResolutionOfInvestigation messages to the case creator/case assigner. They alone should provide collaborating parties sufficient information about the progress of the investigation. The CaseStatusReportRequest must therefore only be used when no information has been received from the case assignee within the expected time frame.
/// An agent may suspend an investigation by classifying it as overdue if, this agent, after sending the request for the status of the investigation, does not receive any response after a long time. Agents may set their individual threshold wait-time.
/// </summary>
[Description(@"Scope|The CaseStatusReportRequest message is sent by a case creator or case assigner to a case assignee.|This message is used to request the status of a case.|Usage|The CaseStatusReportRequest message must be answered with a CaseStatusReport message. It can be used to request the status of a:|- request to cancel payment case;|- request to modify payment case;|- unable to apply case;|- claim non receipt case.|The CaseStatusReportRequest message covers one and only one case at a time. If a case creator or case assigner needs the status of several cases, then multiple CaseStatusReportRequest messages must be sent.|The CaseStatusReportRequest message may be forwarded to subsequent case assignee(s) in the case processing chain.|The processing of a case generates NotificationOfCaseAssignment and/or ResolutionOfInvestigation messages to the case creator/case assigner. They alone should provide collaborating parties sufficient information about the progress of the investigation. The CaseStatusReportRequest must therefore only be used when no information has been received from the case assignee within the expected time frame.|An agent may suspend an investigation by classifying it as overdue if, this agent, after sending the request for the status of the investigation, does not receive any response after a long time. Agents may set their individual threshold wait-time.")]
[IsoId("_eYI_NW2PEei3KuUgpx7Xcw")]
[DisplayName("Case Status Report Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CaseStatusReportRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.038.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CaseStsRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.038.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CaseStatusReportRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CaseStatusReportRequestV04( ReportHeader5 reqRequestHeader,Case5 reqCase )
    {
        RequestHeader = reqRequestHeader;
        Case = reqCase;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the party requesting the status, the requested party, the identification and the date of the status.
    /// </summary>
    [IsoId("_eYI_N22PEei3KuUgpx7Xcw")]
    [DisplayName("Request Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdr")]
    #endif
    [IsoXmlTag("ReqHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportHeader5 RequestHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportHeader5 RequestHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportHeader5 RequestHeader { get; init; } 
    #else
    public ReportHeader5 RequestHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eYI_OW2PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Case5 Case { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Case5 Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case5 Case { get; init; } 
    #else
    public Case5 Case { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_O22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CaseStatusReportRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CaseStatusReportRequestV04.

