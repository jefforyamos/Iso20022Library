﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PortfolioTransferNotificationIdentification.  ISO2002 ID# _USz3B9p-Ed-ak6NoX_4Aeg_-1699094780.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References3Choice;

/// <summary>
/// Identification of the portfolio transfer.
/// </summary>
public partial record PortfolioTransferNotificationIdentification : IReferences3Choice
{
    public required IsoMax35Text Value { get; init; }
}
