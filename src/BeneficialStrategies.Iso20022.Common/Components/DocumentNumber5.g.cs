﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentNumber5.  ISO2002 ID# _WBN2AeZlEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
public partial record DocumentNumber5
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required DocumentNumber1Choice_ Number { get; init; } 
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    public Identification6[] References { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
