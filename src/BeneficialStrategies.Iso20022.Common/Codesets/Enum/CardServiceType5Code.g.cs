﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardServiceType5Code.  ISO2002 ID# _5BKA0VWXEeeiG_nL4vgKnQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of key exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5BKA0VWXEeeiG_nL4vgKnQ")]
[Description(@"Type of key exchange.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
public enum CardServiceType5Code
{
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as "KYDL".
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_8u0YcX0kEemfrNOe0zHQyg")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey = CardServiceTypeCode.DeliverKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National defined code.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_8u0Yd30kEemfrNOe0zHQyg")]
    [Description(@"National defined code.")]
    OtherNational = CardServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private defined code.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_8u0YeX0kEemfrNOe0zHQyg")]
    [Description(@"Private defined code.")]
    OtherPrivate = CardServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deactivate the specified key.
    /// Encoded/decoded by serializers as "DEKY".
    /// </summary>
    [EnumMember(Value = "DEKY")]
    [IsoId("_XFuv8ZJcEemtzI0l4QED6w")]
    [Description(@"Deactivate the specified key.")]
    DeactivateKey = CardServiceTypeCode.DeactivateKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request new key to be generated and conveyed.
    /// Encoded/decoded by serializers as "RQKY".
    /// </summary>
    [EnumMember(Value = "RQKY")]
    [IsoId("_FFXUMa4bEemYtqDpusmLsQ")]
    [Description(@"Request new key to be generated and conveyed.")]
    RequestKey = CardServiceTypeCode.RequestKey, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardServiceType5CodeMetadataExtensions
{
    private static readonly CardServiceType5CodeDropdownSource _dropdownSource = new CardServiceType5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardServiceType5CodeDropdownRow GetMetadata(this CardServiceType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


