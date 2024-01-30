﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryQuantity.  ISO2002 ID# _KADDMxuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity48Choice;

/// <summary>
/// Proprietary quantity of security format.
/// </summary>
public partial record ProprietaryQuantity : IQuantity48Choice
{
    #nullable enable
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    public required IsoDecimalNumber Quantity { get; init; } 
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    public required IsoExact4AlphaNumericText QuantityType { get; init; } 
    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    #nullable disable
}
