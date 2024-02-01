﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReportContent8.  ISO2002 ID# _3Xi2weziEeiojesOXOKoug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the status report.
/// </summary>
public partial record StatusReportContent8
{
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionCapabilities8? POICapabilities { get; init; } 
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    public PointOfInteractionComponent9[] POIComponent { get; init; } = []; // Warning: Don't know multiplicity.
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
    public TerminalManagementDataSet25[] DataSetRequired { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    public TMSEvent6[] Event { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    public IsoMax140Text[] Errors { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
