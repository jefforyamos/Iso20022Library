﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlternatePartyIdentification6.  ISO2002 ID# _PHNIUNooEeCWg-hsBVGrDA_-33380345.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification for a party using an id type, a country code and an text field.
/// </summary>
public partial record AlternatePartyIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
    /// </summary>
    public required IIdentificationType41Choice TypeOfIdentification { get; init; } 
    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    public required CountryCode Country { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public required IsoMax35Text AlternateIdentification { get; init; } 
    
    #nullable disable
}
