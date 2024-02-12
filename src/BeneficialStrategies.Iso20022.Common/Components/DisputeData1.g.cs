﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DisputeData1.  ISO2002 ID# _k5AXMENiEeiut6dbx3wnBg.
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
[IsoId("_k5AXMENiEeiut6dbx3wnBg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Dispute Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisputeData1
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
    [IsoId("_21nGsENiEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Presentment Cycle")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
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
    [IsoId("_dBw4sENjEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Condition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_2aqaoENjEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_MZfCYENkEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Partial Dispute")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_qnBp9UNiEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
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
    [IsoId("_qnBp-UNiEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Documentation Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_33w1UENkEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Dispute Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? AdditionalDisputeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalDisputeData { get; init; } 
    #else
    public System.String? AdditionalDisputeData { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for rejecting a dispute.
    /// </summary>
    [IsoId("_ChtPgENlEeiut6dbx3wnBg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Reject Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
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
    [IsoId("_xWWa4JKaEempjNUC7bi_Ng")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Chargeback Eligibility")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ChargebackEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargebackEligibility { get; init; } 
    #else
    public System.String? ChargebackEligibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}
