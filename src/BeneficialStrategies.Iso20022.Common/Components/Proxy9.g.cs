﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Proxy9.  ISO2002 ID# _fWW5K_M7EeqRfth943bvEA.
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
/// Identification of a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_fWW5K_M7EeqRfth943bvEA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Proxy")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proxy9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proxy9( ProxyType2Code reqProxyType )
    {
        ProxyType = reqProxyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_fpZw9fM7EeqRfth943bvEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proxy Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProxyType2Code ProxyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ProxyType2Code ProxyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyType2Code ProxyType { get; init; } 
    #else
    public ProxyType2Code ProxyType { get; set; } 
    #endif
    
    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_fpZw9_M7EeqRfth943bvEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Person Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson43? PersonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson43? PersonDetails { get; init; } 
    #else
    public IndividualPerson43? PersonDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
