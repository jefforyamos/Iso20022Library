﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResponseMode1Code.  ISO2002 ID# _OqZvQN6rEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OqZvQN6rEeiwsev40qZGEQ")]
[Description(@"Message response awaited by the initiator of the Request.")]
[DerivedFrom(typeof(ResponseModeCode))]
public enum ResponseMode1Code
{
    /// <summary>
    /// The Message Response is immediate, after taking into account the request.
    /// Encoded/decoded by serializers as "IMMD".
    /// </summary>
    [EnumMember(Value = "IMMD")]
    [IsoId("_Q6JkUd6rEeiwsev40qZGEQ")]
    [Description(@"The Message Response is immediate, after taking into account the request.")]
    Immediate = ResponseModeCode.Immediate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Message Response is not required, except in case of error.
    /// Encoded/decoded by serializers as "NREQ".
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_Q-JTgd6rEeiwsev40qZGEQ")]
    [Description(@"The Message Response is not required, except in case of error.")]
    NotRequired = ResponseModeCode.NotRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Print Response is required at the end of print.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_RCfA8d6rEeiwsev40qZGEQ")]
    [Description(@"The Print Response is required at the end of print.")]
    PrintEnd = ResponseModeCode.PrintEnd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Sound Response is required at the end of play.
    /// Encoded/decoded by serializers as "SEND".
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_Er0_EVDkEeu39vke54yxqA")]
    [Description(@"The Sound Response is required at the end of play.")]
    SoundEnd = ResponseModeCode.SoundEnd, // same ordinal as derivation source for type conversions
    
}
