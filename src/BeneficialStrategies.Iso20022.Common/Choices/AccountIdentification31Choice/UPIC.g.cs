﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UPIC.  ISO2002 ID# _su6ahfSaEeSfzLT5J5kvFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification31Choice;

/// <summary>
/// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
/// </summary>
public partial record UPIC : IAccountIdentification31Choice
{
    public required IsoUPICIdentifier Value { get; init; }
}
