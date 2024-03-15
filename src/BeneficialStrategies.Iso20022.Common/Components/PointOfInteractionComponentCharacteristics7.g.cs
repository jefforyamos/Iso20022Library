﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PointOfInteractionComponentCharacteristics7.  ISO2002 ID# _S6Jm4S8iEeu125Ip9zFcsQ.
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
/// Physical and logical characteristics of a POI component (Point of Interaction).
/// </summary>
[IsoId("_S6Jm4S8iEeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction Component Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponentCharacteristics7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_TIqkAS8iEeu125Ip9zFcsQ")]
    [DisplayName("Memory")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mmry")]
    #endif
    [IsoXmlTag("Mmry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemoryCharacteristics1? Memory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemoryCharacteristics1? Memory { get; init; } 
    #else
    public MemoryCharacteristics1? Memory { get; set; } 
    #endif
    
    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_TIqkAy8iEeu125Ip9zFcsQ")]
    [DisplayName("Communication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Com")]
    #endif
    [IsoXmlTag("Com")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationCharacteristics5? Communication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationCharacteristics5? Communication { get; init; } 
    #else
    public CommunicationCharacteristics5? Communication { get; set; } 
    #endif
    
    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_TIqkBS8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Access Modules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyAccsMdls")]
    #endif
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SecurityAccessModules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SecurityAccessModules { get; init; } 
    #else
    public System.UInt64? SecurityAccessModules { get; set; } 
    #endif
    
    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_TIqkBy8iEeu125Ip9zFcsQ")]
    [DisplayName("Subscriber Identity Modules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcbrIdntyMdls")]
    #endif
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SubscriberIdentityModules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SubscriberIdentityModules { get; init; } 
    #else
    public System.UInt64? SubscriberIdentityModules { get; set; } 
    #endif
    
    /// <summary>
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_TIqkCS8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyElmt")]
    #endif
    [IsoXmlTag("SctyElmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey15? SecurityElement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey15? SecurityElement { get; init; } 
    #else
    public CryptographicKey15? SecurityElement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
