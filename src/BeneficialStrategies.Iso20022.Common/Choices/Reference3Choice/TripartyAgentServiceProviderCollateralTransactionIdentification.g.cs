﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TripartyAgentServiceProviderCollateralTransactionIdentification.  ISO2002 ID# _ul6FcQLyEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice;

/// <summary>
/// Unique reference identifying the triparty-agent/service-provider collateral management transaction from the triparty-agent's/service-provider's point of view.
/// </summary>
public partial record TripartyAgentServiceProviderCollateralTransactionIdentification : Reference3Choice_
{
    public required IsoMax35Text Value { get; init; }
}
