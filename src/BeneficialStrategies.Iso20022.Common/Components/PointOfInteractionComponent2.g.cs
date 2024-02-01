﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponent2.  ISO2002 ID# _LYLC4H1DEeCF8NjrBemJWQ_1913950683.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI.
/// </summary>
public partial record PointOfInteractionComponent2
{
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    public required POIComponentType2Code POIComponentType { get; init; } 
    /// <summary>
    /// Identification of the software, hardware or system provider of the POI component.
    /// </summary>
    public IsoMax35Text? ManufacturerIdentification { get; init; } 
    /// <summary>
    /// Identification of a model of POI component for a given manufacturer.
    /// </summary>
    public IsoMax35Text? Model { get; init; } 
    /// <summary>
    /// Version of component belonging to a given model.
    /// </summary>
    public IsoMax16Text? VersionNumber { get; init; } 
    /// <summary>
    /// Serial number of a component.
    /// </summary>
    public IsoMax35Text? SerialNumber { get; init; } 
    /// <summary>
    /// Unique approval number for a component, delivered by a certification body.
    /// Usage: More than one approval number could be present, when assigned by different bodies. The certification body identification must be provided within the approval number (for example at the beginning of the value).
    /// </summary>
    public IsoMax70Text[] ApprovalNumber { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
