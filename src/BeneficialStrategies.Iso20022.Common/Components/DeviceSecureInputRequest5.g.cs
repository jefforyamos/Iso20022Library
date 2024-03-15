﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceSecureInputRequest5.  ISO2002 ID# _GLMrAXGeEe2TbaNWBpRZpQ.
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
/// Request a secure input for a PIN.
/// </summary>
[IsoId("_GLMrAXGeEe2TbaNWBpRZpQ")]
[DisplayName("Device Secure Input Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceSecureInputRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceSecureInputRequest5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceSecureInputRequest5( PINRequestType1Code reqPINRequestType )
    {
        PINRequestType = reqPINRequestType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of PIN Service.
    /// </summary>
    [IsoId("_GRb14XGeEe2TbaNWBpRZpQ")]
    [DisplayName("PIN Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINReqTp")]
    #endif
    [IsoXmlTag("PINReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PINRequestType1Code PINRequestType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PINRequestType1Code PINRequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PINRequestType1Code PINRequestType { get; init; } 
    #else
    public PINRequestType1Code PINRequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Identify the PIN verification method and keys.
    /// </summary>
    [IsoId("_GRb143GeEe2TbaNWBpRZpQ")]
    [DisplayName("PIN Verification Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PINVrfctnMtd")]
    #endif
    [IsoXmlTag("PINVrfctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PINVerificationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PINVerificationMethod { get; init; } 
    #else
    public System.String? PINVerificationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_GRb15XGeEe2TbaNWBpRZpQ")]
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
    /// Indicates, when the user press a key, if a beep has to be generated.
    /// </summary>
    [IsoId("_GRb153GeEe2TbaNWBpRZpQ")]
    [DisplayName("Beep Key Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BeepKeyFlg")]
    #endif
    [IsoXmlTag("BeepKeyFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeepKeyFlag { get; init; } 
    #else
    public System.String? BeepKeyFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Enciphered PIN and related information.
    /// </summary>
    [IsoId("_GRb16XGeEe2TbaNWBpRZpQ")]
    [DisplayName("Cardholder PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrPIN")]
    #endif
    [IsoXmlTag("CrdhldrPIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN10? CardholderPIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN10? CardholderPIN { get; init; } 
    #else
    public OnLinePIN10? CardholderPIN { get; set; } 
    #endif
    
    
    #nullable disable
    
}
