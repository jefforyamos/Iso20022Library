﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TRGiZ9p-Ed-ak6NoX_4Aeg_-1877638996.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;

/// <summary>
/// Reason for the status, as published in an external reason code list.
/// </summary>
public partial record Code : IStatusReason6Choice
{
    public required ExternalStatusReason1Code Value { get; init; }
}
