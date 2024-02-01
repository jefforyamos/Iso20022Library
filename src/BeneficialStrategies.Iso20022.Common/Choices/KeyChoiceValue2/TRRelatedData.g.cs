﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TRRelatedData.  ISO2002 ID# _FjgS07TqEeeQy4o2AayYHg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.KeyChoiceValue2;

/// <summary>
/// Data block for a TR31 or TR34 block, where the block does not contain a key (for example the TR34 unbind which contains the signed authorization data).
/// </summary>
public partial record TRRelatedData : KeyChoiceValue2_
{
    #nullable enable
    /// <summary>
    /// Specific TR34 command where the TRBlock is a TR34 block.
    /// </summary>
    public TR34Command1Code? TR34Command { get; init; } 
    /// <summary>
    /// TR31 or TR34 data block.
    /// </summary>
    public IsoMax100KBinary? TRBlock { get; init; } 
    #nullable disable
}
