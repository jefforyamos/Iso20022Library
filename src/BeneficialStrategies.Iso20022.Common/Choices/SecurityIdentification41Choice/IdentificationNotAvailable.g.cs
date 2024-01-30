﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IdentificationNotAvailable.  ISO2002 ID# _idD07Vo2Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice;

/// <summary>
/// Indicates that underlying identification is not available.
/// </summary>
public partial record IdentificationNotAvailable : ISecurityIdentification41Choice
{
    public required UnderlyingIdentification1Code Value { get; init; }
}
