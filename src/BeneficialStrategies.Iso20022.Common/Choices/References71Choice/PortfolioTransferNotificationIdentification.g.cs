﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PortfolioTransferNotificationIdentification.  ISO2002 ID# _KDxvySAaEeu4a6pNulzZ4Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References71Choice;

/// <summary>
/// Identification of the portfolio transfer.
/// </summary>
public partial record PortfolioTransferNotificationIdentification : IReferences71Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
