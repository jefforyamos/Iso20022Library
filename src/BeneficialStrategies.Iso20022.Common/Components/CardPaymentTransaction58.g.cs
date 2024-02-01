﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransaction58.  ISO2002 ID# _1sM8wY1EEeWsypzzYao74A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
public partial record CardPaymentTransaction58
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    public required AuthorisationResult12 AuthorisationResult { get; init; } 
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public Action6[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
