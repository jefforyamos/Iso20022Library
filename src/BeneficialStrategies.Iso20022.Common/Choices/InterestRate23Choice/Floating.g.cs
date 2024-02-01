﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _6ao5k1fREeqqKf65rDYWYw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate23Choice;

/// <summary>
/// Attributes related specifically to floating rate of an interest rate contract.
/// </summary>
public partial record Floating : InterestRate23Choice_
{
    #nullable enable
    /// <summary>
    /// Indication of the floating rate used.
    /// </summary>
    public FloatingRateIdentification4Choice_? Rate { get; init; } 
    /// <summary>
    /// Information related to reference period.
    /// </summary>
    public InterestRateContractTerm4? ReferencePeriod { get; init; } 
    /// <summary>
    /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
    /// </summary>
    public SecuritiesTransactionPrice13Choice_? Spread { get; init; } 
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
    #nullable disable
}
