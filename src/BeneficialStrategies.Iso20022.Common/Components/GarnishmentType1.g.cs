﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GarnishmentType1.  ISO2002 ID# _LLLooYnnEeOORMXOfBk1Bw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of garnishment.
/// </summary>
public partial record GarnishmentType1
{
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the garnishment.
    /// </summary>
    public required IGarnishmentType1Choice CodeOrProprietary { get; init; } 
    /// <summary>
    /// Identification of the issuer of the garnishment type.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
    #nullable disable
}
