﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClientCollateralTransactionIdentification.  ISO2002 ID# _qTRyoQLyEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice;

/// <summary>
/// Unique reference identifying the collateral management transaction from the client's point of view. Present in case of a decrease.
/// </summary>
public partial record ClientCollateralTransactionIdentification : Reference3Choice_
{
    public required IsoMax35Text Value { get; init; }
}
