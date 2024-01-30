﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UPIC.  ISO2002 ID# _5q1Fq1HSEey4xOoMoOPSJQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification54Choice;

/// <summary>
/// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
/// </summary>
public partial record UPIC : IAccountIdentification54Choice
{
    public required IsoUPICIdentifier Value { get; init; }
}
