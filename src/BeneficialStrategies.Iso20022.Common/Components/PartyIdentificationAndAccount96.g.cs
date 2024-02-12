﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount96.  ISO2002 ID# _tkfD8zouEeOr__K5A0LSog.
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
/// Party and account information.
/// </summary>
[IsoId("_tkfD8zouEeOr__K5A0LSog")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Party Identification And Account")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount96
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount96 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount96( PartyIdentification64 reqPartyIdentification,AccountIdentification26 reqAccountIdentification )
    {
        PartyIdentification = reqPartyIdentification;
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_tkfD9TouEeOr__K5A0LSog")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification64 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification64 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification64 PartyIdentification { get; init; } 
    #else
    public PartyIdentification64 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_tkfD9DouEeOr__K5A0LSog")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification26 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AccountIdentification26 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification26 AccountIdentification { get; init; } 
    #else
    public AccountIdentification26 AccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
