﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryQuantity.  ISO2002 ID# _cfAup5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Quantity21Choice;

/// <summary>
/// Proprietary quantity of security format.
/// </summary>
public partial record ProprietaryQuantity : IQuantity21Choice
{
    #nullable enable
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    public required IsoExact4AlphaNumericText QuantityType { get; init; } 
    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    #nullable disable
}
