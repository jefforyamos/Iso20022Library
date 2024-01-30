﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndividualPerson43.  ISO2002 ID# _pZCr4fQ0EeqAradXpAelDQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson43
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the proxy.
    /// </summary>
    public IPartyIdentification232Choice? PreassignedProxy { get; init; } 
    /// <summary>
    /// Organisation represented by the person, or for which the person works.
    /// </summary>
    public IPartyIdentification129Choice? EmployingParty { get; init; } 
    
    #nullable disable
}
