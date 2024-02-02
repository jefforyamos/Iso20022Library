﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponentStatus1.  ISO2002 ID# _e-Tb0AxxEeKa_56Jbsi1RQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a POI component (Point of Interaction).
/// </summary>
[DataContract]
[XmlType]
public partial record PointOfInteractionComponentStatus1
{
    #nullable enable
    
    /// <summary>
    /// Current version of the component that might include the release number.
    /// </summary>
    [DataMember]
    public IsoMax35Text? VersionNumber { get; init; } 
    /// <summary>
    /// Current status of the component.
    /// </summary>
    [DataMember]
    public POIComponentStatus1Code? Status { get; init; } 
    
    #nullable disable
}
