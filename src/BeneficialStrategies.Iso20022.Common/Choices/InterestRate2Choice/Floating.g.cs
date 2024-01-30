﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _lQ3UA-pnEeSsk6KxwbYJ9w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate2Choice;

/// <summary>
/// Provides details about the variable rate.
/// </summary>
public partial record Floating : IInterestRate2Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the reference index for the debt instrument. 
    /// Usage:
    /// Where an identifier exists, the ISIN must be used; otherwise, names will be necessary (such as EURIBOR6M, LIBOR3M) as other identification.
    /// </summary>
    public required IBenchmarkCurveName4Choice ReferenceRate { get; init; } 
    /// <summary>
    /// Term of the index.
    /// </summary>
    public required InterestRateContractTerm1 Term { get; init; } 
    /// <summary>
    /// Provides the number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    public required IsoNumber BasisPointSpread { get; init; } 
    #nullable disable
}
