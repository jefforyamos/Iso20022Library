﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _pvYN8-4CEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification229Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : IPartyIdentification229Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
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
