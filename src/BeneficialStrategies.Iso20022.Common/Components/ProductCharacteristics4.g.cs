﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProductCharacteristics4.  ISO2002 ID# _Ys-60fFTEee_LsXdoqzkWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
public partial record ProductCharacteristics4
{
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    public Quantity16? ValueMeasure { get; init; } 
    
    #nullable disable
}
