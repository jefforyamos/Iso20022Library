﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPeriod7.  ISO2002 ID# _Nt3jYeENEd-qUMZtd_eZuQ.
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
/// Specifies periods related to a corporate action option.
/// </summary>
[IsoId("_Nt3jYeENEd-qUMZtd_eZuQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Period")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriod7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_Nt3jY-ENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Price Calculation Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? PriceCalculationPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? PriceCalculationPeriod { get; init; } 
    #else
    public Period3Choice_? PriceCalculationPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which both old and new equity may be traded simultaneously, for example, consolidation of equity or splitting of equity.
    /// </summary>
    [IsoId("_Nt3jZeENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Parallel Trading Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? ParallelTradingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? ParallelTradingPeriod { get; init; } 
    #else
    public Period3Choice_? ParallelTradingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the specified option, or all options of the event, remains valid, for example, offer period.
    /// </summary>
    [IsoId("_Nt3jZ-ENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Action Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? ActionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? ActionPeriod { get; init; } 
    #else
    public Period3Choice_? ActionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the shareholder can revoke, change or withdraw its instruction.
    /// </summary>
    [IsoId("_Nt3jaeENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Revocability Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? RevocabilityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? RevocabilityPeriod { get; init; } 
    #else
    public Period3Choice_? RevocabilityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the privilege is not available, for example, this can happen whenever a meeting takes place or whenever a coupon payment is due.
    /// </summary>
    [IsoId("_Nt3ja-ENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Privilege Suspension Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? PrivilegeSuspensionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? PrivilegeSuspensionPeriod { get; init; } 
    #else
    public Period3Choice_? PrivilegeSuspensionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the participant of the account servicer can revoke change or withdraw its instructions.
    /// </summary>
    [IsoId("_Nt3jbeENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Servicer Revocability Period")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? AccountServicerRevocabilityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? AccountServicerRevocabilityPeriod { get; init; } 
    #else
    public Period3Choice_? AccountServicerRevocabilityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period defining the last date on which withdrawal in street name requests on the outturn security will be accepted and the date on which the suspension will be released and withdrawal by transfer processing on the outturn security will resume.
    /// </summary>
    [IsoId("_Nt3jb-ENEd-qUMZtd_eZuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Depository Suspension Period For Withdrawal")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; } 
    #else
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawal { get; set; } 
    #endif
    
    
    #nullable disable
    
}
