﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReportContent12.  ISO2002 ID# _EHWrEXI6Ee299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the status report.
/// </summary>
public partial record StatusReportContent12
{
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionComponent14? POIComponent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    public IsoMax35Text? POIGroupIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    public required IsoISODateTime POIDateTime { get; init; } 
    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    public DataSetRequest4? DataSetRequired { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    public TMSEvent10? Event { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    public IsoMax140Text? Errors { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
