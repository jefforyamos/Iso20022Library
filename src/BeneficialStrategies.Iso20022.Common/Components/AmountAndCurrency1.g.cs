﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrency1.  ISO2002 ID# _nuIgAIolEeSaAcF2oE2GNQ.
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
/// Amount to be authorised by the issuer.
/// </summary>
[IsoId("_nuIgAIolEeSaAcF2oE2GNQ")]
[DisplayName("Amount And Currency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndCurrency1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndCurrency1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndCurrency1( System.Decimal reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_0LTLUIolEeSaAcF2oE2GNQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    [IsoSimpleType(IsoSimpleType.ImpliedCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_4QPncIolEeSaAcF2oE2GNQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
