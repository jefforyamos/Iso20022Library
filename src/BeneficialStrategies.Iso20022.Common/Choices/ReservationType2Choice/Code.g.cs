﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5xhOIRUNEeusI4XK3oQSyg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationType2Choice;

/// <summary>
/// Liquidity transfer request type, in a coded form.
/// </summary>
public partial record Code : ReservationType2Choice_
{
    public required ExternalReservationType1Code Value { get; init; }
}
