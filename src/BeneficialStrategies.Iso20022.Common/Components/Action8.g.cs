﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Action8.  ISO2002 ID# _4si20aziEeaS8qpTeYtFzA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed by the POI (Point Of Interaction) system.
/// </summary>
public partial record Action8
{
    #nullable enable
    
    /// <summary>
    /// Type of action to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    public required ActionType7Code ActionType { get; init; } 
    /// <summary>
    /// Message to be displayed to the cardholder or the cashier.
    /// </summary>
    public ActionMessage2? MessageToPresent { get; init; } 
    
    #nullable disable
}
