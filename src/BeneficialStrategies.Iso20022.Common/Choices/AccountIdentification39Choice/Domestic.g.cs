﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Domestic.  ISO2002 ID# _mpl8bdmpEeeN3v2fup_Shw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification39Choice;

/// <summary>
/// Account number used by financial institutions in individual countries to identify an account of a customer, but not necessarily the bank and branch of the financial institution in which the account is held.
/// </summary>
public partial record Domestic : AccountIdentification39Choice_
{
    public required IsoMax35Text Value { get; init; }
}
