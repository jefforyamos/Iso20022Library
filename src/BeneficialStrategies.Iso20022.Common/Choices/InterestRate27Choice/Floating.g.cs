﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _Z-T6U8g6Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate27Choice;

/// <summary>
/// Details about the variable rate.
/// </summary>
public partial record Floating : InterestRate27Choice_
{
    #nullable enable
    /// <summary>
    /// Identifies the reference index for the debt instrument.
    /// </summary>
    public BenchmarkCurveName10Choice_? ReferenceRate { get; init; } 
    /// <summary>
    /// Term of the reference rate of the floating rate bond. The term shall be expressed in days, weeks, months or years.
    /// </summary>
    public InterestRateContractTerm2? Term { get; init; } 
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    public InterestRateContractTerm2? PaymentFrequency { get; init; } 
    /// <summary>
    /// Information related to the reset of payment frequency.
    /// </summary>
    public InterestRateContractTerm2? ResetFrequency { get; init; } 
    /// <summary>
    /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
    /// </summary>
    public SecuritiesTransactionPrice18Choice_? Spread { get; init; } 
    /// <summary>
    /// Specifies the rate adjustments as determined by the rate schedule.
    /// </summary>
    public RateAdjustment1? RateAdjustment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Method for calculating the accrued interest on the principal amount for a fixed rate.
    /// </summary>
    public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
    #nullable disable
}
