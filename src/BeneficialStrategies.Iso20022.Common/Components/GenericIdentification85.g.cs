﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericIdentification85.  ISO2002 ID# _cdSQJ5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification expressed as a proprietary type and narrative description.
/// </summary>
public partial record GenericIdentification85
{
    #nullable enable
    
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required GenericIdentification47 Type { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity.
    /// </summary>
    public IsoRestrictedFINXMax30Text? Identification { get; init; } 
    
    #nullable disable
}
