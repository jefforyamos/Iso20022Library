﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _CRCiEyJLEe2zWP9pqvmqdw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate33Choice;

/// <summary>
/// Attributes related specifically to floating rate of an interest rate contract.
/// </summary>
public partial record Floating : InterestRate33Choice_
{
    #nullable enable
    /// <summary>
    /// Identifier of the security subject of the transaction
    /// </summary>
    public IsoISINOct2015Identifier? Identification { get; init; } 
    /// <summary>
    /// The full name of the interest rate as assigned by the index provider.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Indication of the floating rate used.
    /// </summary>
    public FloatingRateIdentification8Choice_? Rate { get; init; } 
    /// <summary>
    /// Information related to reference period.
    /// </summary>
    public InterestRateContractTerm4? ReferencePeriod { get; init; } 
    /// <summary>
    /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
    /// </summary>
    public SecuritiesTransactionPrice20Choice_? Spread { get; init; } 
    /// <summary>
    /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
    /// </summary>
    public InterestComputationMethodFormat7? DayCount { get; init; } 
    /// <summary>
    /// Specifies the time unit associated with the frequency of payments.
    /// </summary>
    public InterestRateFrequency3Choice_? PaymentFrequency { get; init; } 
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    public InterestRateFrequency3Choice_? ResetFrequency { get; init; } 
    /// <summary>
    /// Indicates the nearest date in the future at which the floating reference rate will be reset.
    /// </summary>
    public ResetDateAndValue1? NextFloatingReset { get; init; } 
    /// <summary>
    /// Most recent date and value at which the floating reference rate was reset.
    /// </summary>
    public ResetDateAndValue1? LastFloatingReset { get; init; } 
    #nullable disable
}
