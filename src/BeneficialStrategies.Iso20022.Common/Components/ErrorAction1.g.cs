﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ErrorAction1.  ISO2002 ID# _KsEK031DEeCF8NjrBemJWQ_1638245776.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform in case of error on the related action in progress.
/// </summary>
public partial record ErrorAction1
{
    #nullable enable
    
    /// <summary>
    /// List of error action result codes.
    /// </summary>
    public TerminalManagementActionResult1Code[] ActionResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Action to be processed for the related errors.
    /// </summary>
    public required TerminalManagementErrorAction1Code ActionToProcess { get; init; } 
    
    #nullable disable
}
