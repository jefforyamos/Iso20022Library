﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketInfrastructureTransactionIdentification.  ISO2002 ID# _AcF7lNokEeC60axPepSq7g_-1472748055.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice;

/// <summary>
/// Unambiguous identification of the confirmation transaction as known by the market infrastructure.
/// </summary>
public partial record MarketInfrastructureTransactionIdentification : IIdentificationReference8Choice
{
    public required IsoMax35Text Value { get; init; }
}
