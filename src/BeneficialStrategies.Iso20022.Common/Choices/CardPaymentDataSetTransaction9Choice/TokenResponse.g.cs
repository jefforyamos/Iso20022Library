﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TokenResponse.  ISO2002 ID# _eVYgwC_2EeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice;

/// <summary>
/// Response to a token computation.
/// </summary>
public partial record TokenResponse : ICardPaymentDataSetTransaction9Choice
{
    #nullable enable
    /// <summary>
    /// Identification of an element in a sequence.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #nullable disable
}
