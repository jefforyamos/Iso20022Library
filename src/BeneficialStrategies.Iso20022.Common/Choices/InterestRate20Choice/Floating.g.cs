﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _hFv8E6x2Eem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate20Choice;

/// <summary>
/// Details about the variable rate.
/// </summary>
public partial record Floating : IInterestRate20Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the reference index for the debt instrument.
    /// </summary>
    public IBenchmarkCurveName10Choice? ReferenceRate { get; init; } 
    /// <summary>
    /// Term of the reference rate of the floating rate bond. The term shall be expressed in days, weeks, months or years.
    /// </summary>
    public InterestRateContractTerm2? Term { get; init; } 
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    public InterestRateContractTerm2? PaymentFrequency { get; init; } 
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    public InterestRateContractTerm2? ResetFrequency { get; init; } 
    /// <summary>
    /// Provides the number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// </summary>
    public IsoDecimalNumber? BasisPointSpread { get; init; } 
    /// <summary>
    /// Specifies the rate adjustments as determined by the rate schedule.
    /// </summary>
    public RateAdjustment1? RateAdjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Method for calculating the accrued interest on the principal amount for a fixed rate.
    /// </summary>
    public IInterestComputationMethodFormat6Choice? DayCountBasis { get; init; } 
    #nullable disable
}
