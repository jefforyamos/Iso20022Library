﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HostCommunicationParameter2.  ISO2002 ID# _dJ5eMQvdEeK9Xewg3qiFQA.
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
/// Configuration parameters to communicate with a host.
/// </summary>
[IsoId("_dJ5eMQvdEeK9Xewg3qiFQA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Host Communication Parameter")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostCommunicationParameter2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostCommunicationParameter2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostCommunicationParameter2( System.String reqHostIdentification )
    {
        HostIdentification = reqHostIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the host.
    /// </summary>
    [IsoId("_dWGHIQvdEeK9Xewg3qiFQA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Host Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text HostIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String HostIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HostIdentification { get; init; } 
    #else
    public System.String HostIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    [IsoId("_dWGHJQvdEeK9Xewg3qiFQA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetworkParameters1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters1? Address { get; init; } 
    #else
    public NetworkParameters1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_dWGHKQvdEeK9Xewg3qiFQA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Key")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey3? Key { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey3? Key { get; init; } 
    #else
    public CryptographicKey3? Key { get; set; } 
    #endif
    
    
    #nullable disable
    
}
