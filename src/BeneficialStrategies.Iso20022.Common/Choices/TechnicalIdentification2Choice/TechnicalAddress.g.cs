﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TechnicalAddress.  ISO2002 ID# _YD53k711Eeiut6mmSKzDFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TechnicalIdentification2Choice;

/// <summary>
/// Technical address of the party is defined in a free text format.
/// </summary>
public partial record TechnicalAddress : ITechnicalIdentification2Choice
{
    public required IsoMax256Text Value { get; init; }
}
