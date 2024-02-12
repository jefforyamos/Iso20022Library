﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherDistributionStrategy1.  ISO2002 ID# _q5CaAD8PEeih8-WNbS6hbA.
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
/// Other distribution strategy.
/// </summary>
[IsoId("_q5CaAD8PEeih8-WNbS6hbA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Other Distribution Strategy")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherDistributionStrategy1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of distribution strategy.
    /// </summary>
    [IsoId("_TfymMj8QEeih8-WNbS6hbA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Distribution Strategy Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DistributionStrategyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DistributionStrategyType { get; init; } 
    #else
    public System.String? DistributionStrategyType { get; set; } 
    #endif
    
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of return profile.
    /// </summary>
    [IsoId("_TfymMz8QEeih8-WNbS6hbA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Target")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionStrategy1Choice_? Target { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionStrategy1Choice_? Target { get; init; } 
    #else
    public DistributionStrategy1Choice_? Target { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the target market and the investor's risk tolerance.
    /// </summary>
    [IsoId("_l4QyUT8QEeih8-WNbS6hbA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
