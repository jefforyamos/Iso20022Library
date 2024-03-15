﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommunicationCharacteristics4.  ISO2002 ID# _nWOPkezfEeiojesOXOKoug.
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
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[IsoId("_nWOPkezfEeiojesOXOKoug")]
[DisplayName("Communication Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommunicationCharacteristics4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommunicationCharacteristics4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommunicationCharacteristics4( POICommunicationType2Code reqCommunicationType,System.String reqActive )
    {
        CommunicationType = reqCommunicationType;
        Active = reqActive;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_niOrQezfEeiojesOXOKoug")]
    [DisplayName("Communication Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComTp")]
    #endif
    [IsoXmlTag("ComTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POICommunicationType2Code CommunicationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POICommunicationType2Code CommunicationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POICommunicationType2Code CommunicationType { get; init; } 
    #else
    public POICommunicationType2Code CommunicationType { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_niOrQ-zfEeiojesOXOKoug")]
    [DisplayName("Remote Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmotPty")]
    #endif
    [IsoXmlTag("RmotPty")]
    public SimpleValueList<PartyType7Code> RemoteParty { get; init; } = new SimpleValueList<PartyType7Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _niOrQ-zfEeiojesOXOKoug
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_niOrRezfEeiojesOXOKoug")]
    [DisplayName("Active")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actv")]
    #endif
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Active { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Active { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Active { get; init; } 
    #else
    public System.String Active { get; set; } 
    #endif
    
    /// <summary>
    /// Network parameters of the communication link.
    /// </summary>
    [IsoId("_ufdjIezfEeiojesOXOKoug")]
    [DisplayName("Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Params")]
    #endif
    [IsoXmlTag("Params")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters5? Parameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters5? Parameters { get; init; } 
    #else
    public NetworkParameters5? Parameters { get; set; } 
    #endif
    
    /// <summary>
    /// Physical Interface used by the communication link.
    /// </summary>
    [IsoId("_5sFzoezfEeiojesOXOKoug")]
    [DisplayName("Physical Interface")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysIntrfc")]
    #endif
    [IsoXmlTag("PhysIntrfc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    #else
    public PhysicalInterfaceParameter1? PhysicalInterface { get; set; } 
    #endif
    
    
    #nullable disable
    
}
