﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalPackageType1.  ISO2002 ID# _zZR7oAueEeqw5uEXxQ9H4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of software packages related to a group of POIComponent of the POI System.
/// </summary>
public partial record TerminalPackageType1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    public PointOfInteractionComponentIdentification1[] POIComponentIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    public PackageType1[] Package { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
