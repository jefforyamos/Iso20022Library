﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdateLogContact1.  ISO2002 ID# _YBkCQ2jTEeiRg5NzP0jkQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the old and new values for the contact details
/// </summary>
public partial record UpdateLogContact1
{
    #nullable enable
    
    /// <summary>
    /// Old value before change
    /// </summary>
    public required Contact5 Old { get; init; } 
    /// <summary>
    /// New value after change
    /// </summary>
    public required Contact5 New { get; init; } 
    
    #nullable disable
}
