﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericOrganisationIdentification2.  ISO2002 ID# _8mFNgRBAEeGyZLI6olyk-Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification, for example, party identification or account identification.
/// </summary>
public partial record GenericOrganisationIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoRestrictedFINXMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IOrganisationIdentificationSchemeName2Choice? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoRestrictedFINXMax35Text? Issuer { get; init; } 
    
    #nullable disable
}
