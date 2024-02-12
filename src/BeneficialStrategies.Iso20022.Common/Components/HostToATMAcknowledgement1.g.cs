﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HostToATMAcknowledgement1.  ISO2002 ID# _8rvoQItrEeSDLd7nI4Quzw.
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
/// Information related to the acknowledgement from an ATM to contact the ATM manager.
/// </summary>
[IsoId("_8rvoQItrEeSDLd7nI4Quzw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Host To ATM Acknowledgement")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostToATMAcknowledgement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostToATMAcknowledgement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostToATMAcknowledgement1( ATMEnvironment9 reqEnvironment )
    {
        Environment = reqEnvironment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_NJhpUItsEeSDLd7nI4Quzw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment9 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ATMEnvironment9 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment9 Environment { get; init; } 
    #else
    public ATMEnvironment9 Environment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
