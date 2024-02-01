﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoginResponse3.  ISO2002 ID# _XxarES8SEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Response message.
/// </summary>
public partial record LoginResponse3
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of POI Login.
    /// </summary>
    public required IsoISODateTime POIDateTime { get; init; } 
    /// <summary>
    /// Information related to the software of the POI System which manages the Sale to POI protocol.
    /// </summary>
    public PointOfInteractionComponent11[] POISoftware { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    public ActionMessage8? OutputDisplay { get; init; } 
    
    #nullable disable
}
