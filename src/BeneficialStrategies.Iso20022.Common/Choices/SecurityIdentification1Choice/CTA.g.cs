﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CTA.  ISO2002 ID# _VcIPhNp-Ed-ak6NoX_4Aeg_-371877997.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification1Choice;

/// <summary>
/// Identifier of a security assigned by the Consolidated Tape Association.
/// </summary>
public partial record CTA : SecurityIdentification1Choice_
{
    public required IsoConsolidatedTapeAssociationIdentifier Value { get; init; }
}
