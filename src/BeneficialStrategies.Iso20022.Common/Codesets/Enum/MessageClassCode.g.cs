﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MessageClassCode.  ISO2002 ID# _yUpw0Bs_EeqrvK3udMUsNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies a class of messages with the same high level function.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yUpw0Bs_EeqrvK3udMUsNQ")]
[Description(@"Identifies a class of messages with the same high level function.")]
[Derivations(typeof(MessageClass1Code))]
public enum MessageClassCode
{
    /// <summary>
    /// Addendum class of messages.
    /// Encoded/decoded by serializers as "ADDE".
    /// </summary>
    [EnumMember(Value = "ADDE")]
    [IsoId("_5ZRNoBtAEeqrvK3udMUsNQ")]
    [Description(@"Addendum class of messages.")]
    Addendum,
    
    /// <summary>
    /// Amendment class of messages.
    /// Encoded/decoded by serializers as "AMDT".
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_EOQaMBtBEeqrvK3udMUsNQ")]
    [Description(@"Amendment class of messages.")]
    Amendment,
    
    /// <summary>
    /// Authorisation class of messages.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_OBMT4BtBEeqrvK3udMUsNQ")]
    [Description(@"Authorisation class of messages.")]
    Authorisation,
    
    /// <summary>
    /// Card management class of messages.
    /// Encoded/decoded by serializers as "CMGT".
    /// </summary>
    [EnumMember(Value = "CMGT")]
    [IsoId("_d8JUsBtBEeqrvK3udMUsNQ")]
    [Description(@"Card management class of messages.")]
    CardManagement,
    
    /// <summary>
    /// Charge back class of messages.
    /// Encoded/decoded by serializers as "CBCK".
    /// </summary>
    [EnumMember(Value = "CBCK")]
    [IsoId("_okyuYBtBEeqrvK3udMUsNQ")]
    [Description(@"Charge back class of messages.")]
    ChargeBack,
    
    /// <summary>
    /// Fee collection class of messages.
    /// Encoded/decoded by serializers as "FEEC".
    /// </summary>
    [EnumMember(Value = "FEEC")]
    [IsoId("_vc3ZcBtBEeqrvK3udMUsNQ")]
    [Description(@"Fee collection class of messages.")]
    FeeCollection,
    
    /// <summary>
    /// Financial class of messages.
    /// Encoded/decoded by serializers as "FINL".
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_3EZLgBtBEeqrvK3udMUsNQ")]
    [Description(@"Financial class of messages.")]
    Financial,
    
    /// <summary>
    /// Inquiry class of messages.
    /// Encoded/decoded by serializers as "INQY".
    /// </summary>
    [EnumMember(Value = "INQY")]
    [IsoId("_8m6_8BtBEeqrvK3udMUsNQ")]
    [Description(@"Inquiry class of messages.")]
    Inquiry,
    
    /// <summary>
    /// Verification class of messages.
    /// Encoded/decoded by serializers as "VERI".
    /// </summary>
    [EnumMember(Value = "VERI")]
    [IsoId("_BKOMABtCEeqrvK3udMUsNQ")]
    [Description(@"Verification class of messages.")]
    Verification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MessageClassCodeMetadataExtensions
{
    private static readonly MessageClassCodeDropdownSource _dropdownSource = new MessageClassCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMessageClassCodeDropdownRow GetMetadata(this MessageClassCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


