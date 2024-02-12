﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsDerogation1.  ISO2002 ID# _N2mR1L6ZEemHTLTzJg7M-A.
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
/// Specifies the derogation related data of settlement fails instructions.
/// </summary>
[IsoId("_N2mR1L6ZEemHTLTzJg7M-A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Fails Derogation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementFailsDerogation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementFailsDerogation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementFailsDerogation1( System.String reqEligibilityIndicator )
    {
        EligibilityIndicator = reqEligibilityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines whether the item is eligible for derogation or not.
    /// </summary>
    [IsoId("_N2mR176ZEemHTLTzJg7M-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Eligibility Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator EligibilityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String EligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EligibilityIndicator { get; init; } 
    #else
    public System.String EligibilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Justification for the derogation.
    /// </summary>
    [IsoId("_gDA-8L6ZEemHTLTzJg7M-A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Justification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFailsJustification1? Justification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFailsJustification1? Justification { get; init; } 
    #else
    public SettlementFailsJustification1? Justification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
