﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _sGXPIyDAEeWPMvNwVtiMsA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatementFrequencyReason2Choice;

/// <summary>
/// Statement frequency expressed as a proprietary code.
/// </summary>
public partial record Proprietary : IStatementFrequencyReason2Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoExact4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    /// <summary>
    /// Short textual description of the scheme.
    /// </summary>
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    #nullable disable
}
