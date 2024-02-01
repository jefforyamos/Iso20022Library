﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _TLJc8CXbEeOFIcNWlDEvdQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InformationTypeFormat1Choice;

/// <summary>
/// Proprietary identification of the information type.
/// </summary>
public partial record Proprietary : InformationTypeFormat1Choice_
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
