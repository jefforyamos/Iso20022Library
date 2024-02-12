﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Tax22.  ISO2002 ID# _m4A6oTAXEeOKib24wnHaFg.
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
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_m4A6oTAXEeOKib24wnHaFg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Tax")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax22 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax22( TaxType2Choice_ reqType,System.Decimal reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_nTxpkTAXEeOKib24wnHaFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType2Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TaxType2Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType2Choice_ Type { get; init; } 
    #else
    public TaxType2Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the tax as an amount.
    /// </summary>
    [IsoId("_uJ7pEDAXEeOKib24wnHaFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
