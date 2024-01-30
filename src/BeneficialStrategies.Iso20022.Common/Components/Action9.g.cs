﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Action9.  ISO2002 ID# _B1YNAEXVEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed.
/// </summary>
public partial record Action9
{
    #nullable enable
    
    /// <summary>
    /// Destination of the action.
    /// </summary>
    public PartyType20Code? Destination { get; init; } 
    /// <summary>
    /// Action type to be performed.
    /// </summary>
    public ActionType11Code? ActionType { get; init; } 
    /// <summary>
    /// Other action type to be performed.
    /// </summary>
    public IsoMax35Text? OtherActionType { get; init; } 
    /// <summary>
    /// Additional information to the type of action to be performed (for example, channel to be used for additional verification or authentication).
    /// </summary>
    public IsoMax70Text? ActionInformation { get; init; } 
    
    #nullable disable
}
