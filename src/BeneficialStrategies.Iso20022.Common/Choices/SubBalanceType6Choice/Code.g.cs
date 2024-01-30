﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QYBcfdp-Ed-ak6NoX_4Aeg_1024248319.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType6Choice;

/// <summary>
/// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
/// </summary>
public partial record Code : ISubBalanceType6Choice
{
    public required SecuritiesBalanceType7Code Value { get; init; }
}
