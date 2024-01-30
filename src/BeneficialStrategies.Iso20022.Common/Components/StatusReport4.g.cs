﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReport4.  ISO2002 ID# _yceqIWpJEeSR-ZWLvO-1dg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
public partial record StatusReport4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    public required GenericIdentification71 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    public GenericIdentification71? TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    public required TerminalManagementDataSet13 DataSet { get; init; } 
    
    #nullable disable
}
