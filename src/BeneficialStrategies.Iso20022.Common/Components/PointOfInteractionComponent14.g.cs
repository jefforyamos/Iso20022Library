﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponent14.  ISO2002 ID# _jNiLIXDVEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
public partial record PointOfInteractionComponent14
{
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    public required POIComponentType6Code Type { get; init; } 
    /// <summary>
    /// Additional information regarding the type of the component.
    /// </summary>
    public IsoMax70Text? SubTypeInformation { get; init; } 
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    public required PointOfInteractionComponentIdentification2 Identification { get; init; } 
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    public GenericIdentification48? StandardCompliance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    public PointOfInteractionComponentCharacteristics9? Characteristics { get; init; } 
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    public PointOfInteractionComponentAssessment1? Assessment { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    public PackageType4? Package { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
