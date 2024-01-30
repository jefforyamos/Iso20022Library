﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Restriction1.  ISO2002 ID# _PUhYHtp-Ed-ak6NoX_4Aeg_-335182924.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction on capability or operations allowed.
/// </summary>
public partial record Restriction1
{
    #nullable enable
    
    /// <summary>
    /// Type of the restriction.
    /// </summary>
    public required ICodeOrProprietary1Choice RestrictionType { get; init; } 
    /// <summary>
    /// Date from when the restriction is valid.
    /// </summary>
    public required IsoISODateTime ValidFrom { get; init; } 
    /// <summary>
    /// Date until when the restriction is valid.
    /// </summary>
    public IsoISODateTime? ValidUntil { get; init; } 
    
    #nullable disable
}
