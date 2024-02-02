﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteraction6.  ISO2002 ID# _9wj-QI4UEeW6h7rGyYlyTg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a point of interaction.
/// </summary>
[DataContract]
[XmlType]
public partial record PointOfInteraction6
{
    #nullable enable
    
    /// <summary>
    /// Identifier of the terminal manufacturer.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ManufacturerIdentifier { get; init; } 
    /// <summary>
    /// Identifier of the terminal model.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Model { get; init; } 
    /// <summary>
    /// Serial number of the terminal manufacturer.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SerialNumber { get; init; } 
    
    #nullable disable
}
