﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAmount4.  ISO2002 ID# _945Ng3ltEeG7BsjMvd1mEw_1350790559.
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
/// Defined variation amount and balance.
/// </summary>
[IsoId("_945Ng3ltEeG7BsjMvd1mEw_1350790559")]
[DisplayName("Undertaking Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingAmount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingAmount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingAmount4( System.Decimal reqVariationAmount )
    {
        VariationAmount = reqVariationAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Variation amount and currency.
    /// </summary>
    [IsoId("_945NhHltEeG7BsjMvd1mEw_1236951493")]
    [DisplayName("Variation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnAmt")]
    #endif
    [IsoXmlTag("VartnAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount VariationAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal VariationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal VariationAmount { get; init; } 
    #else
    public System.Decimal VariationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Calculated undertaking available balance amount resulting from the application of the variation amount.
    /// </summary>
    [IsoId("_95C-gHltEeG7BsjMvd1mEw_1336485232")]
    [DisplayName("Balance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalAmt")]
    #endif
    [IsoXmlTag("BalAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? BalanceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? BalanceAmount { get; init; } 
    #else
    public System.Decimal? BalanceAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
