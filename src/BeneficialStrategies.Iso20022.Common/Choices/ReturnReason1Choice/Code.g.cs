﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TOkLyNp-Ed-ak6NoX_4Aeg_191375030.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason1Choice;

/// <summary>
/// Reason for the return in a coded form.
/// </summary>
public partial record Code : ReturnReason1Choice_
{
    public required TransactionRejectReason2Code Value { get; init; }
}
