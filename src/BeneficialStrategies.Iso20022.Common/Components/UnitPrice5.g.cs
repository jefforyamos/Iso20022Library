﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnitPrice5.  ISO2002 ID# _U4glF9p-Ed-ak6NoX_4Aeg_1893016197.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record UnitPrice5
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required PriceType1 Type { get; init; } 
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
    public IAmountPrice1Choice? TaxableIncomePerShare { get; init; } 
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    public TaxableIncomePerShareCalculated1? TaxableIncomePerShareCalculated { get; init; } 
    
    #nullable disable
}
