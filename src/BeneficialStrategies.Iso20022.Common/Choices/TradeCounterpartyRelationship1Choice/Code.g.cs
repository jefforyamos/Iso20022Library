﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _uWGXECb_Ee2BYL6XeAmCWw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeCounterpartyRelationship1Choice;

/// <summary>
/// Classification of the party relationship via a pre-determined code list.
/// </summary>
public partial record Code : TradeCounterpartyRelationship1Choice_
{
    public required ExternalPartyRelationshipType1Code Value { get; init; }
}
