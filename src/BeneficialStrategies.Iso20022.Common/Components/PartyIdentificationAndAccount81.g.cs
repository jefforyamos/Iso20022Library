﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount81.  ISO2002 ID# _6tege_70EeCKvdA5_Kg7Aw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount81
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public IPartyIdentification43Choice? Identification { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    /// <summary>
    /// Nationality of the investor or country of incorporation (for a company).
    /// </summary>
    public CountryCode? Nationality { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
    #nullable disable
}
