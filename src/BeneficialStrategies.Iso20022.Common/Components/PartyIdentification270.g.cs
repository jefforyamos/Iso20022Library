﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification270.  ISO2002 ID# _ArjoiTUDEe2tRf29bleifQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
public partial record PartyIdentification270
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification246Choice Identification { get; init; } 
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    public IPartyAdditionalIdentification2Choice? AdditionalIdentificationInformation { get; init; } 
    
    #nullable disable
}
