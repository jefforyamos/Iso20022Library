﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _4-vxgdopEeCWg-hsBVGrDA_-1375317726.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethod2Choice;

/// <summary>
/// Interest computation method is determined using a data source scheme.
/// </summary>
public partial record Proprietary : InterestComputationMethod2Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoExact4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    #nullable disable
}
