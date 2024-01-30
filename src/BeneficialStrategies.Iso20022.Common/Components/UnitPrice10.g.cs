﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice10.  ISO2002 ID# _QfLNW9p-Ed-ak6NoX_4Aeg_617785517.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record UnitPrice10
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required TypeOfPrice10Code Type { get; init; } 
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required IsoExtended350Code ExtendedType { get; init; } 
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required PriceValue1 Value { get; init; } 
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    public PriceMethod1Code? PriceMethod { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    public IsoExtended350Code? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    /// <summary>
    /// Specifies the reason why the price is different from the current market price.
    /// </summary>
    public IsoMax350Text? PriceDifferenceReason { get; init; } 
    
    #nullable disable
}
