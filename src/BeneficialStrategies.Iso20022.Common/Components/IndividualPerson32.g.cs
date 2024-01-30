﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson32.  ISO2002 ID# _bpZkkTheEeamLZQeccJa7w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson32
{
    #nullable enable
    
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that party.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Date on which the person is born.
    /// </summary>
    public IsoISODate? BirthDate { get; init; } 
    /// <summary>
    /// Country and residential status of the individual, for example, non-permanent resident.
    /// </summary>
    public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; } 
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    public GenericIdentification164? OtherIdentification { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
