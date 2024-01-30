﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessorTransactionIdentification.  ISO2002 ID# _5Qz0-5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References51Choice;

/// <summary>
/// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
/// </summary>
public partial record ProcessorTransactionIdentification : IReferences51Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
