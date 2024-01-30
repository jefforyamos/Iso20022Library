﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareInterestRate1.  ISO2002 ID# _ufZIwM3MEeuiU4QSC_BouQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the values defined as part of the Margin Loan Attribute are matching or not.
/// </summary>
public partial record CompareInterestRate1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    
    #nullable disable
}
