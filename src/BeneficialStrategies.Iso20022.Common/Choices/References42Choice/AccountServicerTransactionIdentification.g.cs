﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountServicerTransactionIdentification.  ISO2002 ID# _GEafhTp-EeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References42Choice;

/// <summary>
/// Unambiguous identification of the transaction as known by the account servicer.
/// </summary>
public partial record AccountServicerTransactionIdentification : References42Choice_
{
    public required IsoMax35Text Value { get; init; }
}
