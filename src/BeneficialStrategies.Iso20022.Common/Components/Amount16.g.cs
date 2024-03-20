﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amount16.  ISO2002 ID# _X3LzYZJQEeuuktRxxQZoNQ.
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
/// Signed amount in a given numeric currency
/// </summary>
[IsoId("_X3LzYZJQEeuuktRxxQZoNQ")]
[DisplayName("Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amount16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amount16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amount16( ImpliedCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_X9M70ZJQEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_X9M705JQEeuuktRxxQZoNQ")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebit3Code? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code? CreditDebit { get; init; } 
    #else
    public CreditDebit3Code? CreditDebit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
