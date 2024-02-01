﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestAmount2.  ISO2002 ID# _SQk5gtp-Ed-ak6NoX_4Aeg_1384086328.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the elements related to the interest amount calculation.
/// </summary>
public partial record InterestAmount2
{
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    public required IsoActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    public required DateAndDateTimeChoice_ ValueDate { get; init; } 
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    public required InterestMethod1Code InterestMethod { get; init; } 
    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    public required DatePeriodDetails InterestPeriod { get; init; } 
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    public InterestRate1Choice_? InterestRate { get; init; } 
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; } 
    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    public Frequency1Code? CalculationFrequency { get; init; } 
    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
