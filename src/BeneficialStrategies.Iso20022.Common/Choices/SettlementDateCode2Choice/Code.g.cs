﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QurB5dp-Ed-ak6NoX_4Aeg_-1955127215.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDateCode2Choice;

/// <summary>
/// Settlement date expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SettlementDateCode2Choice_
{
    public required DateType4Code Value { get; init; }
}
