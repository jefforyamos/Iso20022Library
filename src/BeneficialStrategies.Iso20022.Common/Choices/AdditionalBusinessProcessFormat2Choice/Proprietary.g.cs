﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Q4XJZtp-Ed-ak6NoX_4Aeg_455311258.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat2Choice;

/// <summary>
/// Proprietary identification of the additional business process "tax refund" linked to a corporate action event.
/// </summary>
public partial record Proprietary : IAdditionalBusinessProcessFormat2Choice
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
