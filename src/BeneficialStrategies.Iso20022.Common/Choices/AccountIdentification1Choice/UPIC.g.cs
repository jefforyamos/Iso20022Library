﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UPIC.  ISO2002 ID# _PdnCodp-Ed-ak6NoX_4Aeg_-1666130964.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification1Choice;

/// <summary>
/// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
/// </summary>
public partial record UPIC : IAccountIdentification1Choice
{
    public required IsoUPICIdentifier Value { get; init; }
}
