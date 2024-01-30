﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExtendedParty4.  ISO2002 ID# _Sxi3wROHEeKjmvxNCObNeQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other type of party.
/// </summary>
public partial record ExtendedParty4
{
    #nullable enable
    
    /// <summary>
    /// Other type of party's role.
    /// </summary>
    public required IsoExtended350Code ExtendedPartyRole { get; init; } 
    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    public required InvestmentAccountOwnershipInformation7 OtherPartyDetails { get; init; } 
    
    #nullable disable
}
