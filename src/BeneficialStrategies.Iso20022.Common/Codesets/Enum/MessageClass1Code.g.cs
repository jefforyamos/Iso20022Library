﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageClass1Code.  ISO2002 ID# _IEYhwBtCEeqrvK3udMUsNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies a class of messages with the same high level function.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IEYhwBtCEeqrvK3udMUsNQ")]
[Description(@"Identifies a class of messages with the same high level function.")]
[DerivedFrom(typeof(MessageClassCode))]
public enum MessageClass1Code
{
    /// <summary>
    /// Addendum class of messages.
    /// Encoded/decoded by serializers as "ADDE".
    /// </summary>
    [EnumMember(Value = "ADDE")]
    [IsoId("_MJCC8RtCEeqrvK3udMUsNQ")]
    [Description(@"Addendum class of messages.")]
    Addendum = MessageClassCode.Addendum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amendment class of messages.
    /// Encoded/decoded by serializers as "AMDT".
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_MUMKERtCEeqrvK3udMUsNQ")]
    [Description(@"Amendment class of messages.")]
    Amendment = MessageClassCode.Amendment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation class of messages.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_Mfy9IRtCEeqrvK3udMUsNQ")]
    [Description(@"Authorisation class of messages.")]
    Authorisation = MessageClassCode.Authorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card management class of messages.
    /// Encoded/decoded by serializers as "CMGT".
    /// </summary>
    [EnumMember(Value = "CMGT")]
    [IsoId("_M3wKIRtCEeqrvK3udMUsNQ")]
    [Description(@"Card management class of messages.")]
    CardManagement = MessageClassCode.CardManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge back class of messages.
    /// Encoded/decoded by serializers as "CBCK".
    /// </summary>
    [EnumMember(Value = "CBCK")]
    [IsoId("_NDgHIRtCEeqrvK3udMUsNQ")]
    [Description(@"Charge back class of messages.")]
    ChargeBack = MessageClassCode.ChargeBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee collection class of messages.
    /// Encoded/decoded by serializers as "FEEC".
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_NJmvIRtCEeqrvK3udMUsNQ")]
    [Description(@"Fee collection class of messages.")]
    FeeCollection = MessageClassCode.FeeCollection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial class of messages.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_NPQrMRtCEeqrvK3udMUsNQ")]
    [Description(@"Financial class of messages.")]
    Financial = MessageClassCode.Financial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Inquiry class of messages.
    /// Encoded/decoded by serializers as "INQY".
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_NbTjIRtCEeqrvK3udMUsNQ")]
    [Description(@"Inquiry class of messages.")]
    Inquiry = MessageClassCode.Inquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification class of messages.
    /// Encoded/decoded by serializers as "VERI".
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_NjCi0RtCEeqrvK3udMUsNQ")]
    [Description(@"Verification class of messages.")]
    Verification = MessageClassCode.Verification, // same ordinal as derivation source for type conversions
    
}
