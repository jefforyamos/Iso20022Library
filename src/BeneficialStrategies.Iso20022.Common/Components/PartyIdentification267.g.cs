﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification267.  ISO2002 ID# _6sPMvwauEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
public partial record PartyIdentification267
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public required IsoAnyBICDec2014Identifier BIC { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    public required GenericIdentification36 ProprietaryIdentification { get; init; } 
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    public NameAndAddress13? NameAndAddress { get; init; } 
    
    #nullable disable
}
