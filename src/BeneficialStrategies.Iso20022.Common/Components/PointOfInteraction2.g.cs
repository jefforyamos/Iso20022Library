﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteraction2.  ISO2002 ID# _y7NhQAyUEeK5P9Ihqok3VA.
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
/// Point of interaction (POI) performing the transaction.
/// </summary>
[IsoId("_y7NhQAyUEeK5P9Ihqok3VA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Point Of Interaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteraction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteraction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteraction2( GenericIdentification32 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) for the acquirer or its agent.
    /// </summary>
    [IsoId("_zIHU0QyUEeK5P9Ihqok3VA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification32 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 Identification { get; init; } 
    #else
    public GenericIdentification32 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Common name assigned by the acquirer to the POI system.
    /// </summary>
    [IsoId("_zIHU1QyUEeK5P9Ihqok3VA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("System Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SystemName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemName { get; init; } 
    #else
    public System.String? SystemName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_zIH74AyUEeK5P9Ihqok3VA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GroupIdentification { get; init; } 
    #else
    public System.String? GroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Capabilities of the POI performing the transaction.
    /// </summary>
    [IsoId("_zIH75AyUEeK5P9Ihqok3VA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Capabilities")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionCapabilities1? Capabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities1? Capabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities1? Capabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a component of the POI performing the transaction.
    /// </summary>
    [IsoId("_zIH76AyUEeK5P9Ihqok3VA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Component")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent3? Component { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent3? Component { get; init; } 
    #else
    public PointOfInteractionComponent3? Component { get; set; } 
    #endif
    
    
    #nullable disable
    
}
