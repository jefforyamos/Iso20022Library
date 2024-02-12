﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EventContext1.  ISO2002 ID# _tONqIN6bEeiwsev40qZGEQ.
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
/// Context of the Retailer Event message.
/// </summary>
[IsoId("_tONqIN6bEeiwsev40qZGEQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Event Context")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventContext1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventContext1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventContext1( RetailerService1Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_7l8ksN6bEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Service Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService1Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RetailerService1Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService1Code ServiceType { get; init; } 
    #else
    public RetailerService1Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("__H8EwN6bEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Component Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent9? ComponentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent9? ComponentIdentification { get; init; } 
    #else
    public PointOfInteractionComponent9? ComponentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_B5dxMN6cEeiwsev40qZGEQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sale Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
