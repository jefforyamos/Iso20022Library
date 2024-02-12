﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReceiptType1Code.  ISO2002 ID# _MQE3AErHEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Way of transmitting receipt information to recipient.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MQE3AErHEeenp6hmNprBHg")]
[Description(@"Way of transmitting receipt information to recipient.")]
[DerivedFrom(typeof(ReceiptTypeCode))]
public enum ReceiptType1Code
{
    /// <summary>
    /// Receipt transmitted by Email.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_SvbgEUrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by Email.")]
    EMail = ReceiptTypeCode.EMail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of channel to transmit receipt information to the recipient.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_S7lFskrHEeenp6hmNprBHg")]
    [Description(@"Other type of channel to transmit receipt information to the recipient.")]
    Other = ReceiptTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receipt in a paper form.
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_TKaL4krHEeenp6hmNprBHg")]
    [Description(@"Receipt in a paper form.")]
    Paper = ReceiptTypeCode.Paper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receipt transmitted by SMS message.
    /// Encoded/decoded by serializers as "SMSM".
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_TV5DIkrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by SMS message.")]
    SMS = ReceiptTypeCode.SMS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receipt transmitted to a Uniform Resource Identifier (URI) address.
    /// Encoded/decoded by serializers as "URID".
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_TnSVIkrHEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted to a Uniform Resource Identifier (URI) address.")]
    UniformResourceIdentifier = ReceiptTypeCode.UniformResourceIdentifier, // same ordinal as derivation source for type conversions
    
}
