﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account18.  ISO2002 ID# _HCkrDx5dEeWE3PufGMdJ3w.
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
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_HCkrDx5dEeWE3PufGMdJ3w")]
[DisplayName("Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Account18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Account18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Account18( AccountIdentification26 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Hh0Lwx5dEeWE3PufGMdJ3w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification26 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification26 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification26 Identification { get; init; } 
    #else
    public AccountIdentification26 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Hh0Lyx5dEeWE3PufGMdJ3w")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification71Choice_? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
