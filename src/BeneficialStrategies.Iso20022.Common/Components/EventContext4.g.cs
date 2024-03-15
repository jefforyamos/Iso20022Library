﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EventContext4.  ISO2002 ID# _AUB7kVFBEeyApZmLzm74zA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
[IsoId("_AUB7kVFBEeyApZmLzm74zA")]
[DisplayName("Event Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EventContext4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EventContext4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EventContext4( RetailerService1Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_AaaQYVFBEeyApZmLzm74zA")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerService1Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerService1Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService1Code ServiceType { get; init; } 
    #else
    public RetailerService1Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("_AaaQY1FBEeyApZmLzm74zA")]
    [DisplayName("Component Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpntId")]
    #endif
    [IsoXmlTag("CmpntId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent12? ComponentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent12? ComponentIdentification { get; init; } 
    #else
    public PointOfInteractionComponent12? ComponentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_AaaQZVFBEeyApZmLzm74zA")]
    [DisplayName("Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleId")]
    #endif
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
