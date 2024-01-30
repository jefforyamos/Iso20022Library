﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ManagementPlan8.  ISO2002 ID# _TVsscQ01EeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
public partial record ManagementPlan8
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    public GenericIdentification176? POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    public required TerminalManagementDataSet29 DataSet { get; init; } 
    
    #nullable disable
}
