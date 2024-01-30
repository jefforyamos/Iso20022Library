﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPricePerAmount1.  ISO2002 ID# _QbAfAtp-Ed-ak6NoX_4Aeg_-795428506.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: Amount price per amount.||Example:|ISIN US629377AS17. Repurchase USD1087.17 cash for every USD1000 stock (NRG Energy Inc 8% Senior Notes 15/12/13).
/// </summary>
public partial record AmountPricePerAmount1
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required IAmountPriceType1FormatChoice AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    /// <summary>
    /// The amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    #nullable disable
}
