﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HongKongBankCode.  ISO2002 ID# _TDF7ldp-Ed-ak6NoX_4Aeg_1990860882.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Hong Kong Bank Code - identifies Hong Kong financial institutions on the Hong Kong local clearing system.
/// </summary>
public partial record HongKongBankCode : IClearingSystemMemberIdentification2Choice
{
    public required IsoHongKongBankIdentifier Value { get; init; }
}
