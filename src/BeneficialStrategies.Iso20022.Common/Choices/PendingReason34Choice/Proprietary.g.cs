﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _cel4VZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason34Choice;

/// <summary>
/// Proprietary identification of the reason why the instruction/event has a pending status.
/// </summary>
public partial record Proprietary : IPendingReason34Choice
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
