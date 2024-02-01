﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingPartyAndTime8.  ISO2002 ID# _jg-jkZQPEeiok48Eh9lW9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty clearing time.
/// </summary>
public partial record ClearingPartyAndTime8
{
    #nullable enable
    
    /// <summary>
    /// In the case of a contract that has been cleared, the unique code for the CCP that has cleared the contract.
    /// </summary>
    public OrganisationIdentification9Choice_? CCP { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    
    #nullable disable
}
