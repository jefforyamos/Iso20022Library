﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProxyAppointmentInformation3.  ISO2002 ID# _7fsShVtgEeSwKe7KuKvXhg.
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
/// Indicates how a proxy is registered.
/// </summary>
[IsoId("_7fsShVtgEeSwKe7KuKvXhg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Proxy Appointment Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProxyAppointmentInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies how to register the proxy.
    /// </summary>
    [IsoId("_79clg1tgEeSwKe7KuKvXhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? RegistrationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationMethod { get; init; } 
    #else
    public System.String? RegistrationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary.
    /// </summary>
    [IsoId("_79clhVtgEeSwKe7KuKvXhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deadline")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? Deadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? Deadline { get; init; } 
    #else
    public DateFormat29Choice_? Deadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary (STP mode).
    /// </summary>
    [IsoId("_79clh1tgEeSwKe7KuKvXhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("STP Deadline")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? STPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? STPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? STPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the issuer.
    /// </summary>
    [IsoId("_79cliVtgEeSwKe7KuKvXhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Deadline")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? MarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? MarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? MarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the proxy person that is authorised by the issuer.
    /// </summary>
    [IsoId("_79cli1tgEeSwKe7KuKvXhg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorised Proxy")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(10)]
    #endif
    public ValueList<Proxy5> AuthorisedProxy { get; init; } = new ValueList<Proxy5>(){};
    
    
    #nullable disable
    
}
