﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PowerOfAttorneyRequirements4.  ISO2002 ID# _loYSf609EemDtrWpq90Ckg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Conditions to get power of attorney.
/// </summary>
public partial record PowerOfAttorneyRequirements4
{
    #nullable enable
    
    /// <summary>
    /// Authority that must validate the power of attorney.
    /// </summary>
    public PowerOfAttorneyLegalisation1Code[] LegalRequirement { get; init; } = [];
    /// <summary>
    /// Documents needed to obtain a valid power of attorney.
    /// </summary>
    public IsoMax350Text? OtherDocumentation { get; init; } 
    /// <summary>
    /// Date by which the requested documents must be provided.
    /// </summary>
    public DateFormat58Choice_? DocumentSubmissionDeadline { get; init; } 
    
    #nullable disable
}
