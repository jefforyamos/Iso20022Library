﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProductCharacteristics3.  ISO2002 ID# _CYo1scNUEeWGDrnsYu2p6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product characteristic applicable to this trade product.
/// </summary>
[IsoId("_CYo1scNUEeWGDrnsYu2p6g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Product Characteristics")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductCharacteristics3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics of the product.
    /// </summary>
    [IsoId("_ClCS8cNUEeWGDrnsYu2p6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Characteristic")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCharacteristics1Choice_? Characteristic { get; init; } 
    #else
    public ProductCharacteristics1Choice_? Characteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Measurement value for this product characteristic.
    /// </summary>
    [IsoId("_ClCS88NUEeWGDrnsYu2p6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Measure")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity10? ValueMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity10? ValueMeasure { get; init; } 
    #else
    public Quantity10? ValueMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
