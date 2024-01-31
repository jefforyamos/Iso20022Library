﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PowerOfAttorneyRequirements2.  ISO2002 ID# _T5CFEtp-Ed-ak6NoX_4Aeg_-1322861866.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions to be filled in to obtain a valid power of attorney.
/// </summary>
public partial record PowerOfAttorneyRequirements2
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the power of attorney needs to be validated by some authority.
    /// </summary>
    public IReadOnlyCollection<PowerOfAttorneyLegalisation1Code> LegalRequirement { get; init; } = [];
    /// <summary>
    /// Specifies the documents needed to obtain a valid power of attorney.
    /// </summary>
    public IsoMax350Text? OtherDocumentation { get; init; } 
    
    #nullable disable
}
