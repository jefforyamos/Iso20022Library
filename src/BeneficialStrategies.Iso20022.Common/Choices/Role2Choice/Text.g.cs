﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Text.  ISO2002 ID# _Qwm7ltp-Ed-ak6NoX_4Aeg_409012393.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Role2Choice;

/// <summary>
/// Role of the party in the activity.
/// </summary>
public partial record Text : Role2Choice_
{
    public required IsoMax350Text Value { get; init; }
}
