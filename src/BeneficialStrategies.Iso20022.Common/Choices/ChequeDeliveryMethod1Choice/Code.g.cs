﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QbwF59p-Ed-ak6NoX_4Aeg_1044150030.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice;

/// <summary>
/// Specifies the delivery method of the cheque by the debtor's agent.
/// </summary>
public partial record Code : ChequeDeliveryMethod1Choice_
{
    public required ChequeDelivery1Code Value { get; init; }
}
