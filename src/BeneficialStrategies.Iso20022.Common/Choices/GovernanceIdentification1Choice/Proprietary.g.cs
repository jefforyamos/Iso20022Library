﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _929T0nltEeG7BsjMvd1mEw_524135810.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GovernanceIdentification1Choice;

/// <summary>
/// Governance identification information expressed as a proprietary code.
/// </summary>
public partial record Proprietary : IGovernanceIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
