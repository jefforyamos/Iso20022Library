﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyProgramme1.  ISO2002 ID# _kSpocF--Eee_oqB7UglxLw.
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
/// Loyalty programme used for partial payment in loyalty value (debit) and computation of loyalty value gained on the monetary value paid by the customer (credit).
/// </summary>
[IsoId("_kSpocF--Eee_oqB7UglxLw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Loyalty Programme")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyProgramme1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Eligibility for loyalty.
    /// True: Eligible for loyalty
    /// False: Not eligible for loyalty
    /// Default: False.
    /// </summary>
    [IsoId("_VQTYsF_AEee_oqB7UglxLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Programme Eligibility Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProgrammeEligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgrammeEligibilityIndicator { get; init; } 
    #else
    public System.String? ProgrammeEligibilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Entity issuing the loyalty programme.
    /// </summary>
    [IsoId("_czqccF_AEee_oqB7UglxLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Programme Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProgrammeIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgrammeIssuer { get; init; } 
    #else
    public System.String? ProgrammeIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Details about the member of the loyalty programme
    /// </summary>
    [IsoId("_oon4QF_AEee_oqB7UglxLw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Loyalty Member")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyMember1? LoyaltyMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyMember1? LoyaltyMember { get; init; } 
    #else
    public LoyaltyMember1? LoyaltyMember { get; set; } 
    #endif
    
    
    #nullable disable
    
}
