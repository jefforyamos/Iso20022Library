﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponentIdentification2.  ISO2002 ID# _fu8XwS8REeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a POI (Point of Interaction) component.
/// </summary>
public partial record PointOfInteractionComponentIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Hierarchical identification of a hardware component inside all the hardware component of the POI. It is composed of all item numbers of the upper level components, separated by the '.' character, ended by the item number of the current component.
    /// </summary>
    public IsoMax35Text? ItemNumber { get; init; } 
    /// <summary>
    /// Identifies the provider of the software, hardware or parameters of the POI component.
    /// </summary>
    public IsoMax35Text? ProviderIdentification { get; init; } 
    /// <summary>
    /// Identification of the POI component assigned by its provider.
    /// </summary>
    public IsoMax256Text? Identification { get; init; } 
    /// <summary>
    /// Serial number identifying an occurrence of an hardware component.
    /// </summary>
    public IsoMax256Text? SerialNumber { get; init; } 
    
    #nullable disable
}
