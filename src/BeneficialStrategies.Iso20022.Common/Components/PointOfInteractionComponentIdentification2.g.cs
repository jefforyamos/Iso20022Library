﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponentIdentification2.  ISO2002 ID# _fu8XwS8REeu125Ip9zFcsQ.
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
/// Identification of a POI (Point of Interaction) component.
/// </summary>
[IsoId("_fu8XwS8REeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction Component Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponentIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Hierarchical identification of a hardware component inside all the hardware component of the POI. It is composed of all item numbers of the upper level components, separated by the &apos;.&apos; character, ended by the item number of the current component.
    /// </summary>
    [IsoId("_f6KwUS8REeu125Ip9zFcsQ")]
    [DisplayName("Item Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmNb")]
    #endif
    [IsoXmlTag("ItmNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ItemNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemNumber { get; init; } 
    #else
    public System.String? ItemNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the provider of the software, hardware or parameters of the POI component.
    /// </summary>
    [IsoId("_f6KwUy8REeu125Ip9zFcsQ")]
    [DisplayName("Provider Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvdrId")]
    #endif
    [IsoXmlTag("PrvdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProviderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProviderIdentification { get; init; } 
    #else
    public System.String? ProviderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI component assigned by its provider.
    /// </summary>
    [IsoId("_f6KwVS8REeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number identifying an occurrence of an hardware component.
    /// </summary>
    [IsoId("_f6KwVy8REeu125Ip9zFcsQ")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
