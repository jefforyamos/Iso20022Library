﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentCode.  ISO2002 ID# _R2KHERVgEeOrY9qSHVspCA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther2Choice;

/// <summary>
/// Specifies the payment period in coded form and a number of days.
/// </summary>
public partial record PaymentCode : PaymentCodeOrOther2Choice_
{
    #nullable enable
    /// <summary>
    /// Code for the payment.
    /// </summary>
    public required PaymentTime4Code Code { get; init; } 
    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    public IsoNumber? NumberOfDays { get; init; } 
    #nullable disable
}
