﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DisputeData3.  ISO2002 ID# _T53CMTEBEeyjbpgZW6G1Fg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to be present in a dispute.
/// </summary>
[IsoId("_T53CMTEBEeyjbpgZW6G1Fg")]
[DisplayName("Dispute Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisputeData3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the cycle of presentment or of the chargeback  (1= first cycle for chargeback, 2= second cycle of presentment or chargeback, etc.).
    /// </summary>
    [IsoId("_UAP-ETEBEeyjbpgZW6G1Fg")]
    [DisplayName("Presentment Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntmntCycl")]
    #endif
    [IsoXmlTag("PresntmntCycl")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? PresentmentCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PresentmentCycle { get; init; } 
    #else
    public System.String? PresentmentCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Condition of the dispute.
    /// </summary>
    [IsoId("_UAP-EzEBEeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptCond")]
    #endif
    [IsoXmlTag("DsptCond")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DisputeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisputeCondition { get; init; } 
    #else
    public System.String? DisputeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Status of dispute.
    /// </summary>
    [IsoId("_UAP-FTEBEeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptSts")]
    #endif
    [IsoXmlTag("DsptSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DisputeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisputeStatus { get; init; } 
    #else
    public System.String? DisputeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Partial dispute indicator.
    /// </summary>
    [IsoId("_UAP-FzEBEeyjbpgZW6G1Fg")]
    [DisplayName("Partial Dispute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlDspt")]
    #endif
    [IsoXmlTag("PrtlDspt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialDispute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialDispute { get; init; } 
    #else
    public System.String? PartialDispute { get; set; } 
    #endif
    
    /// <summary>
    /// Reference for the dispute.
    /// </summary>
    [IsoId("_UAP-GTEBEeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptRef")]
    #endif
    [IsoXmlTag("DsptRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisputeReference1? DisputeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeReference1? DisputeReference { get; init; } 
    #else
    public DisputeReference1? DisputeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the dispute documentation.
    /// </summary>
    [IsoId("_UAP-GzEBEeyjbpgZW6G1Fg")]
    [DisplayName("Documentation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DcmnttnSts")]
    #endif
    [IsoXmlTag("DcmnttnSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DocumentationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DocumentationStatus { get; init; } 
    #else
    public System.String? DocumentationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the dispute.
    /// </summary>
    [IsoId("_UAP-HTEBEeyjbpgZW6G1Fg")]
    [DisplayName("Additional Dispute Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDsptData")]
    #endif
    [IsoXmlTag("AddtlDsptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalDisputeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalDisputeData { get; init; } 
    #else
    public AdditionalData1? AdditionalDisputeData { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for rejecting a dispute.
    /// </summary>
    [IsoId("_UAP-HzEBEeyjbpgZW6G1Fg")]
    [DisplayName("Dispute Reject Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptRjctRsn")]
    #endif
    [IsoXmlTag("DsptRjctRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DisputeRejectReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DisputeRejectReason { get; init; } 
    #else
    public System.String? DisputeRejectReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides transaction chargeback eligibility conditions.
    /// </summary>
    [IsoId("_UAP-ITEBEeyjbpgZW6G1Fg")]
    [DisplayName("Chargeback Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgbckElgblty")]
    #endif
    [IsoXmlTag("ChrgbckElgblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ChargebackEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargebackEligibility { get; init; } 
    #else
    public System.String? ChargebackEligibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}
