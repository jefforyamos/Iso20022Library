﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HellenicBankIdentificationCode.  ISO2002 ID# _TDPFg9p-Ed-ak6NoX_4Aeg_-1906990554.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Hellenic Bank Identification Code - identifies Hellenic financial institutions on the Hellenic national clearing system.
/// </summary>
public partial record HellenicBankIdentificationCode : ClearingSystemMemberIdentification2Choice_
{
    public required IsoHellenicBankIdentificationCodeIdentifier Value { get; init; }
}
