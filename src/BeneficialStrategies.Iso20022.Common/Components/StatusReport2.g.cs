﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReport2.  ISO2002 ID# _dTvNEQyVEeK5P9Ihqok3VA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI, its components and their installed versions.
/// </summary>
public partial record StatusReport2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    public required GenericIdentification35 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    public GenericIdentification35? TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    public TerminalManagementDataSet4? DataSet { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
