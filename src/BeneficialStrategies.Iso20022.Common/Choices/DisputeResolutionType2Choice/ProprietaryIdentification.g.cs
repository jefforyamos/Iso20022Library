﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _Un0dsNp-Ed-ak6NoX_4Aeg_-230305339.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DisputeResolutionType2Choice;

/// <summary>
/// Proprietary identification of the type of dispute that is to be resolved regarding the disputed collateral amount.
/// </summary>
public partial record ProprietaryIdentification : IDisputeResolutionType2Choice
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
