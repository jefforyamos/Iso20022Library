﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount150.  ISO2002 ID# _IpGdnZBfEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
public partial record PartyIdentificationAndAccount150
{
    #nullable enable
    
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    public PartyIdentification117Choice_? Identification { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public IsoMax35Text? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    public CountryCode? CountryOfResidence { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification8? AlternateIdentification { get; init; } 
    
    #nullable disable
}
