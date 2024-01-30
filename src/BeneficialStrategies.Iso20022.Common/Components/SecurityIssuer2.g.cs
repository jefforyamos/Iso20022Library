﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityIssuer2.  ISO2002 ID# _cD9apbQ0EemI67HK7aviyg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of the issuer of a security.
/// </summary>
public partial record SecurityIssuer2
{
    #nullable enable
    
    /// <summary>
    /// Legal entity identification of the issuer of the security.
    /// </summary>
    public IOrganisationIdentification9Choice? Identification { get; init; } 
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. In case of securities issued by a foreign subsidiary, the jurisdiction of the ultimate parent company shall be reported or, if not known, jurisdiction of the subsidiary.
    /// </summary>
    public required CountryCode JurisdictionCountry { get; init; } 
    
    #nullable disable
}
