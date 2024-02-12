﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponent7.  ISO2002 ID# _oCGYobCZEeapjPTKZHuM2w.
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
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_oCGYobCZEeapjPTKZHuM2w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Point Of Interaction Component")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent7( POIComponentType4Code reqType,PointOfInteractionComponentIdentification1 reqIdentification )
    {
        Type = reqType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_oOnKobCZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType4Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public POIComponentType4Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType4Code Type { get; init; } 
    #else
    public POIComponentType4Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKo7CZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentIdentification1 Identification { get; init; } 
    #else
    public PointOfInteractionComponentIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKpbCZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    #else
    public PointOfInteractionComponentStatus3? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_oOnKp7CZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Standard Compliance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification48? StandardCompliance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification48? StandardCompliance { get; init; } 
    #else
    public GenericIdentification48? StandardCompliance { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKqbCZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Characteristics")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentCharacteristics3? Characteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentCharacteristics3? Characteristics { get; init; } 
    #else
    public PointOfInteractionComponentCharacteristics3? Characteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_oOnKq7CZEeapjPTKZHuM2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Assessment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponentAssessment1? Assessment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponentAssessment1? Assessment { get; init; } 
    #else
    public PointOfInteractionComponentAssessment1? Assessment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
