﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PolishNationalClearingCode.  ISO2002 ID# _TDPFhNp-Ed-ak6NoX_4Aeg_-1877438256.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Polish National Clearing Code - identifies Polish financial institutions on the Polish national clearing system.
/// </summary>
public partial record PolishNationalClearingCode : IClearingSystemMemberIdentification2Choice
{
    public required IsoPolishNationalClearingCodeIdentifier Value { get; init; }
}
