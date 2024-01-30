﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestCalculation3.  ISO2002 ID# _SNCWMWjgEeSwb7MzI8qnfQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the interest calculation.
/// </summary>
public partial record InterestCalculation3
{
    #nullable enable
    
    /// <summary>
    /// Indicates the calculation date of the interest amount.
    /// </summary>
    public required IsoISODate CalculationDate { get; init; } 
    /// <summary>
    /// Provides the identification of the collateral account.
    /// </summary>
    public AccountIdentification26? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Provides the collateral amount used to calculate the interest amount and includes debit/short or credit/long positions.
    /// </summary>
    public required AmountAndDirection20 EffectivePrincipalAmount { get; init; } 
    /// <summary>
    /// Provides the collateral amount posted before taking into account the collateral movement amount.
    /// </summary>
    public AmountAndDirection20? PrincipalAmount { get; init; } 
    /// <summary>
    /// Provides the additional amount of collateral posted between two calculation dates.
    /// </summary>
    public AmountAndDirection20? MovementAmount { get; init; } 
    /// <summary>
    /// Indicates the number of days for the calculation of the interest.
    /// </summary>
    public IsoNumber? NumberOfDays { get; init; } 
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    public required IsoPercentageRate EffectiveRate { get; init; } 
    /// <summary>
    /// Specifies the percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    public IsoPercentageRate? InterestRate { get; init; } 
    /// <summary>
    /// Indicates the differences in interest rates.
    /// </summary>
    public IsoPercentageRate? Spread { get; init; } 
    /// <summary>
    /// Specifies the amount of money representing an interest payment.
    /// </summary>
    public required AmountAndDirection20 AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Specifies the total amount of money representing an interest payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AggregatedInterestAmount { get; init; } 
    
    #nullable disable
}
