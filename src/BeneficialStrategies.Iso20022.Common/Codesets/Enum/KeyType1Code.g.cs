﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for KeyType1Code.  ISO2002 ID# _BuhW0DEtEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the list of key types that may be exchanged.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BuhW0DEtEemzCpWiCwK4aQ")]
[Description(@"Contains the list of key types that may be exchanged.")]
[DerivedFrom(typeof(KeyTypeCode))]
public enum KeyType1Code
{
    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EnKX4TEtEemzCpWiCwK4aQ")]
    [Description(@"Other national")]
    OtherNational,
    
    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_E7SNwTEtEemzCpWiCwK4aQ")]
    [Description(@"Other private")]
    OtherPrivate,
    
    /// <summary>
    /// PIN translation key applicable to the acquirer
    /// Encoded/decoded by serializers as "PINTranslationKeyAcquirer".
    /// </summary>
    [EnumMember(Value = "PTKA")]
    [IsoId("_FP-EUTEtEemzCpWiCwK4aQ")]
    [Description(@"PIN translation key applicable to the acquirer")]
    PINTranslationKeyAcquirer,
    
    /// <summary>
    /// PIN translation key applicable to the issuer
    /// Encoded/decoded by serializers as "PINTranslationKeyIssuer".
    /// </summary>
    [EnumMember(Value = "PTKI")]
    [IsoId("_FluR4TEtEemzCpWiCwK4aQ")]
    [Description(@"PIN translation key applicable to the issuer")]
    PINTranslationKeyIssuer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class KeyType1CodeMetadataExtensions
{
    private static readonly KeyType1CodeDropdownSource _dropdownSource = new KeyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IKeyType1CodeDropdownRow GetMetadata(this KeyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


