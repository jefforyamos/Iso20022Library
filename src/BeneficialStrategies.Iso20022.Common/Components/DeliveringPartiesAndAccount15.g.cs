﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliveringPartiesAndAccount15.  ISO2002 ID# _vr0GB4FvEeWtPe6Crjmeug.
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
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_vr0GB4FvEeWtPe6Crjmeug")]
[DisplayName("Delivering Parties And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveringPartiesAndAccount15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliveringPartiesAndAccount15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliveringPartiesAndAccount15( PartyIdentification102Choice_ reqDepository,PartyIdentificationAndAccount126 reqParty1 )
    {
        Depository = reqDepository;
        Party1 = reqParty1;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_wB_KV4FvEeWtPe6Crjmeug")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification102Choice_ Depository { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification102Choice_ Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification102Choice_ Depository { get; init; } 
    #else
    public PartyIdentification102Choice_ Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_wB_KWYFvEeWtPe6Crjmeug")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty1")]
    #endif
    [IsoXmlTag("Pty1")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount126 Party1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount126 Party1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount126 Party1 { get; init; } 
    #else
    public PartyIdentificationAndAccount126 Party1 { get; set; } 
    #endif
    
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_wB_KW4FvEeWtPe6Crjmeug")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty2")]
    #endif
    [IsoXmlTag("Pty2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount127? Party2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount127? Party2 { get; init; } 
    #else
    public PartyIdentificationAndAccount127? Party2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}
