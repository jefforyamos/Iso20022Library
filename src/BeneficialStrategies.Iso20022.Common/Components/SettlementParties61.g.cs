﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementParties61.  ISO2002 ID# _bpiM0a2hEeaYS91sTIbkkQ.
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
/// Specifies settlement parties (delivering/receiving).
/// </summary>
[IsoId("_bpiM0a2hEeaYS91sTIbkkQ")]
[DisplayName("Settlement Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementParties61
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// First receiving party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the receiving side of the transaction requests to receive the financial instrument.
    /// </summary>
    [IsoId("_b7F25a2hEeaYS91sTIbkkQ")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120? Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120? Depository { get; init; } 
    #else
    public PartyIdentification120? Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the depository.
    /// </summary>
    [IsoId("_b7F27a2hEeaYS91sTIbkkQ")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty1")]
    #endif
    [IsoXmlTag("Pty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount128? Party1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount128? Party1 { get; init; } 
    #else
    public PartyIdentificationAndAccount128? Party1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the party1.
    /// </summary>
    [IsoId("_b7F29a2hEeaYS91sTIbkkQ")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty2")]
    #endif
    [IsoXmlTag("Pty2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount128? Party2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount128? Party2 { get; init; } 
    #else
    public PartyIdentificationAndAccount128? Party2 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that interacts with the party2.
    /// </summary>
    [IsoId("_b7F3D62hEeaYS91sTIbkkQ")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty3")]
    #endif
    [IsoXmlTag("Pty3")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount128? Party3 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount128? Party3 { get; init; } 
    #else
    public PartyIdentificationAndAccount128? Party3 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
