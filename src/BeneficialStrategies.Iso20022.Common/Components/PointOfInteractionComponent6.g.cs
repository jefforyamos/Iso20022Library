﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponent6.  ISO2002 ID# _jbxlEY0SEeWRYffwL7E13A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
public partial record PointOfInteractionComponent6
{
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    public required POIComponentType4Code Type { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    public required PointOfInteractionComponentIdentification1 Identification { get; init; } 
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    public GenericIdentification48[] StandardCompliance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    public PointOfInteractionComponentCharacteristics2? Characteristics { get; init; } 
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    public PointOfInteractionComponentAssessment1[] Assessment { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
