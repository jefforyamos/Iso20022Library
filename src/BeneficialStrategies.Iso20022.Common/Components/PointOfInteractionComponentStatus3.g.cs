﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponentStatus3.  ISO2002 ID# _DSOZQY0TEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a POI component (Point of Interaction).
/// </summary>
public partial record PointOfInteractionComponentStatus3
{
    #nullable enable
    
    /// <summary>
    /// Current version of the component that might include the release number.
    /// </summary>
    public IsoMax256Text? VersionNumber { get; init; } 
    /// <summary>
    /// Current status of the component.
    /// </summary>
    public POIComponentStatus1Code? Status { get; init; } 
    /// <summary>
    /// Expiration date of the component.
    /// </summary>
    public IsoISODate? ExpiryDate { get; init; } 
    
    #nullable disable
}
