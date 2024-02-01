﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessorTransactionIdentification.  ISO2002 ID# _7VjBCSgPEeym1_Zp1BTvEw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References72Choice;

/// <summary>
/// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
/// </summary>
public partial record ProcessorTransactionIdentification : References72Choice_
{
    public required IsoMax35Text Value { get; init; }
}
