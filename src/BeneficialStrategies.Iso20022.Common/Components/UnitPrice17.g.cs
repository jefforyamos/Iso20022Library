﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice17.  ISO2002 ID# _WL9J-dp-Ed-ak6NoX_4Aeg_-680211431.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record UnitPrice17
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required TypeOfPrice15Code Type { get; init; } 
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required PriceValue6 Value { get; init; } 
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    
    #nullable disable
}
