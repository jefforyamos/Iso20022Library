﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SpecialProgrammeDetails1.  ISO2002 ID# _nfCugEU8Eeea-M6VZkEPUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of values assigned to a special programme.
/// </summary>
public partial record SpecialProgrammeDetails1
{
    #nullable enable
    
    /// <summary>
    /// Name of the special programme detail.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    /// <summary>
    /// Special programme detail value.
    /// </summary>
    public IsoMax35Text? Value { get; init; } 
    
    #nullable disable
}
