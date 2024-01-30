﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IBAN.  ISO2002 ID# _Pdd4sNp-Ed-ak6NoX_4Aeg_-912371557.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification5Choice;

/// <summary>
/// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 "Banking and related financial services - International Bank Account Number (IBAN)" version 1997-10-01, or later revisions.
/// </summary>
public partial record IBAN : ICashAccountIdentification5Choice
{
    public required IsoIBAN2007Identifier Value { get; init; }
}
