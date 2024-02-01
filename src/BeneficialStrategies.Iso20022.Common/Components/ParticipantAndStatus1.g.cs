﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ParticipantAndStatus1.  ISO2002 ID# _Odl2BdNSEeWCqoSJYcWUsg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the participant and their operational status.
/// </summary>
public partial record ParticipantAndStatus1
{
    #nullable enable
    
    /// <summary>
    /// Identification of participant.
    /// </summary>
    public required FinancialInstitutionIdentification13 ParticipantIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to indicate how to contact the participant.
    /// </summary>
    public ContactDetails2? ParticipantContactDetails { get; init; } 
    /// <summary>
    /// Provides details on operational availability of the participant business service.
    /// </summary>
    public ServiceAvailability1[] ServiceAvailability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
