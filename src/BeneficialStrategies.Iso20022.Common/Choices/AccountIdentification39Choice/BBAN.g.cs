﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BBAN.  ISO2002 ID# _mpl8admpEeeN3v2fup_Shw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification39Choice;

/// <summary>
/// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, that is, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
/// </summary>
public partial record BBAN : IAccountIdentification39Choice
{
    public required IsoBBANIdentifier Value { get; init; }
}
