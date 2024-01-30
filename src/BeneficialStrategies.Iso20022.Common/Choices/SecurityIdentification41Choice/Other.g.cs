﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _idD061o2Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice;

/// <summary>
/// Other identification of an underlier.
/// </summary>
public partial record Other : ISecurityIdentification41Choice
{
    #nullable enable
    /// <summary>
    /// Indicates other identifier of an underlier.
    /// </summary>
    public required IsoMax210Text Identification { get; init; } 
    /// <summary>
    /// Indicates the source of the identifier that represent the underlier.
    /// </summary>
    public required IsoMax100Text Source { get; init; } 
    #nullable disable
}
