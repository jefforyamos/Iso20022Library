﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Action13.  ISO2002 ID# _2bVsUcVgEeuips4fuphvoQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of actions to be performed.
/// </summary>
public partial record Action13
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
    /// Contact information.
    /// </summary>
    public Contact6? Contact { get; init; } 
    /// <summary>
    /// Additional action information.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
