﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MSISDN.  ISO2002 ID# _mpl8Y9mpEeeN3v2fup_Shw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification39Choice;

/// <summary>
/// Mobile Subscriber Integrated Service Digital Network (i.e. mobile phone number of the SIM card).
/// </summary>
public partial record MSISDN : IAccountIdentification39Choice
{
    public required IsoMax16Text Value { get; init; }
}
