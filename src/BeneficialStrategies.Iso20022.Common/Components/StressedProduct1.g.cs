﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StressedProduct1.  ISO2002 ID# _DU0dAas2Eeayv9XxdmMwKQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument stressed under a stress test scenario.
/// </summary>
[DataContract]
[XmlType]
public partial record StressedProduct1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the product.
    /// </summary>
    [DataMember]
    public required GenericIdentification168 Identification { get; init; } 
    /// <summary>
    /// Maximum move across the curve for the stressed product.
    /// </summary>
    [DataMember]
    public required StressSize1Choice_ MaximumStressSize { get; init; } 
    /// <summary>
    /// Minimum move across the curve for the stressed product.
    /// </summary>
    [DataMember]
    public required StressSize1Choice_ MinimumStressSize { get; init; } 
    
    #nullable disable
}
