﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SpanishDomesticInterbankingIdentification.  ISO2002 ID# _TDF7k9p-Ed-ak6NoX_4Aeg_1990860804.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Spanish Domestic Interbanking Code - identifies Spanish financial institutions on the Spanish national clearing system. The code is assigned by the Centro de Cooperacion Interbancaria (CCI).
/// </summary>
public partial record SpanishDomesticInterbankingIdentification : IClearingSystemMemberIdentification2Choice
{
    public required IsoSpanishDomesticInterbankingIdentifier Value { get; init; }
}
