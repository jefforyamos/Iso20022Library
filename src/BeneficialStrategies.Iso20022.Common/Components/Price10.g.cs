﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Price10.  ISO2002 ID# _UjRo0QycEeuG8M5giQ2e0w.
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
/// Type and information about a price.
/// </summary>
[IsoId("_UjRo0QycEeuG8M5giQ2e0w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Price")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Price10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Price10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Price10( YieldedOrValueType2Choice_ reqType,PriceRateOrAmount3Choice_ reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specification of the price type.
    /// </summary>
    [IsoId("_UyctQQycEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required YieldedOrValueType2Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public YieldedOrValueType2Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldedOrValueType2Choice_ Type { get; init; } 
    #else
    public YieldedOrValueType2Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_UyctQwycEeuG8M5giQ2e0w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceRateOrAmount3Choice_ Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PriceRateOrAmount3Choice_ Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceRateOrAmount3Choice_ Value { get; init; } 
    #else
    public PriceRateOrAmount3Choice_ Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
