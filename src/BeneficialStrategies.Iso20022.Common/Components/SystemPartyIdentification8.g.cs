﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemPartyIdentification8.  ISO2002 ID# _7KrUEVhLEeih3fUfzR38Ig.
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
/// Unique and unambiguous identification of a party within a system.
/// </summary>
[IsoId("_7KrUEVhLEeih3fUfzR38Ig")]
[DisplayName("System Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemPartyIdentification8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemPartyIdentification8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemPartyIdentification8( PartyIdentification136 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_7VYvQVhLEeih3fUfzR38Ig")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136 Identification { get; init; } 
    #else
    public PartyIdentification136 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_7VYvQ1hLEeih3fUfzR38Ig")]
    [DisplayName("Responsible Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPtyId")]
    #endif
    [IsoXmlTag("RspnsblPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #else
    public PartyIdentification136? ResponsiblePartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
