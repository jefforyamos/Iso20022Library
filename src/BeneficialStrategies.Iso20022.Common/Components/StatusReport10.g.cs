﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReport10.  ISO2002 ID# _zzj0YSi1Eeurkfo6MpvKDA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
public partial record StatusReport10
{
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    public required GenericIdentification176 POIIdentification { get; init; } 
    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    public TriggerInformation2? InitiatingTrigger { get; init; } 
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    public required StatusReportDataSetRequest2 DataSet { get; init; } 
    
    #nullable disable
}
