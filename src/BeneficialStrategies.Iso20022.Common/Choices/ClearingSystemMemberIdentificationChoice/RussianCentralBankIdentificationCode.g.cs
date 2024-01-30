﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RussianCentralBankIdentificationCode.  ISO2002 ID# _TDY2htp-Ed-ak6NoX_4Aeg_-896562590.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice;

/// <summary>
/// Russian Central Bank Identification Code - identifies Russian financial institutions on the Russian national clearing system.
/// </summary>
public partial record RussianCentralBankIdentificationCode : IClearingSystemMemberIdentificationChoice
{
    public required IsoRussianCentralBankIdentificationCodeIdentifier Value { get; init; }
}
