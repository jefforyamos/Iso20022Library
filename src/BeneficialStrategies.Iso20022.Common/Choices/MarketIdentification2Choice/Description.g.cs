﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Description.  ISO2002 ID# _XK10Etp-Ed-ak6NoX_4Aeg_1009207657.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarketIdentification2Choice;

/// <summary>
/// Description of the market when no Market Identifier Code is available.
/// </summary>
public partial record Description : IMarketIdentification2Choice
{
    public required IsoRestrictedFINXMax30Text Value { get; init; }
}
