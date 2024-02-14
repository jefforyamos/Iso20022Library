﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceSecureInputResponse3.  ISO2002 ID# _-8ZsgS_FEeugIJ3Gvoevmg.
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
/// Response to a secure input request.
/// </summary>
[IsoId("_-8ZsgS_FEeugIJ3Gvoevmg")]
[DisplayName("Device Secure Input Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceSecureInputResponse3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cardholder PIN data when needed.
    /// </summary>
    [IsoId("__I5QYS_FEeugIJ3Gvoevmg")]
    [DisplayName("Cardholder PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrPIN")]
    #endif
    [IsoXmlTag("CrdhldrPIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN8? CardholderPIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN8? CardholderPIN { get; init; } 
    #else
    public OnLinePIN8? CardholderPIN { get; set; } 
    #endif
    
    
    #nullable disable
    
}
