﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessorTransactionIdentification.  ISO2002 ID# _mKuVSf7xEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References27Choice;

/// <summary>
/// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
/// </summary>
public partial record ProcessorTransactionIdentification : IReferences27Choice
{
    public required IsoMax35Text Value { get; init; }
}
