﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentNumber6.  ISO2002 ID# _D2Ul8fJlEd-DocZblYEqZw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the status being requested.
/// </summary>
public partial record DocumentNumber6
{
    #nullable enable
    
    /// <summary>
    /// Number used to identify a message or document.
    /// </summary>
    public required IDocumentNumber1Choice Number { get; init; } 
    /// <summary>
    /// References of transaction for which the status is requested.
    /// </summary>
    public Identification7? References { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
