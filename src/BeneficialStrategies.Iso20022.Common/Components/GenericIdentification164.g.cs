﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification164.  ISO2002 ID# _BXLWUThQEeaTjZWmPo-9OA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
public partial record GenericIdentification164
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Specifies the nature of the identifier.
    /// </summary>
    public required OtherIdentification3Choice_ IdentificationType { get; init; } 
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
    #nullable disable
}
