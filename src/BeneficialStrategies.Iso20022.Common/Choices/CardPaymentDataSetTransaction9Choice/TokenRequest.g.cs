﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TokenRequest.  ISO2002 ID# _Qd_6MC_2EeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction9Choice;

/// <summary>
/// Request for a token computation.
/// </summary>
public partial record TokenRequest : CardPaymentDataSetTransaction9Choice_
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
