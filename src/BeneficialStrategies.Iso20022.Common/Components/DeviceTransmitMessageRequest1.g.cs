﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceTransmitMessageRequest1.  ISO2002 ID# _e2-0IN7CEeiwsev40qZGEQ.
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
/// Content of the Request message to transmit.
/// </summary>
[IsoId("_e2-0IN7CEeiwsev40qZGEQ")]
[DisplayName("Device Transmit Message Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceTransmitMessageRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceTransmitMessageRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceTransmitMessageRequest1( NetworkParameters5 reqDestinationAddress,System.UInt64 reqMaximumTransmissionTime,System.Byte[] reqMessageToSend )
    {
        DestinationAddress = reqDestinationAddress;
        MaximumTransmissionTime = reqMaximumTransmissionTime;
        MessageToSend = reqMessageToSend;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transport address.
    /// </summary>
    [IsoId("_wYXAMN7CEeiwsev40qZGEQ")]
    [DisplayName("Destination Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAdr")]
    #endif
    [IsoXmlTag("DstnAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetworkParameters5 DestinationAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetworkParameters5 DestinationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetworkParameters5 DestinationAddress { get; init; } 
    #else
    public NetworkParameters5 DestinationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum time in seconds of transmission.
    /// </summary>
    [IsoId("_3ja4sN7CEeiwsev40qZGEQ")]
    [DisplayName("Maximum Transmission Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxTrnsmssnTm")]
    #endif
    [IsoXmlTag("MaxTrnsmssnTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber MaximumTransmissionTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 MaximumTransmissionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 MaximumTransmissionTime { get; init; } 
    #else
    public System.UInt64 MaximumTransmissionTime { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the timeout to receive an answer.
    /// </summary>
    [IsoId("_Xfnf0O16Eei-V5h0ja04AA")]
    [DisplayName("Maximum Waiting Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxWtgTm")]
    #endif
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumWaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumWaitingTime { get; init; } 
    #else
    public System.UInt64? MaximumWaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the message to be transmitted.
    /// </summary>
    [IsoId("_-hlksN7CEeiwsev40qZGEQ")]
    [DisplayName("Message To Send")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgToSnd")]
    #endif
    [IsoXmlTag("MsgToSnd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax100KBinary MessageToSend { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] MessageToSend { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] MessageToSend { get; init; } 
    #else
    public System.Byte[] MessageToSend { get; set; } 
    #endif
    
    
    #nullable disable
    
}
