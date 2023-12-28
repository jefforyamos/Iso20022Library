﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CryptographicKeyType1Code.  ISO2002 ID# _KU0vhH1DEeCF8NjrBemJWQ_-221293967.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of algorithm used by the cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KU0vhH1DEeCF8NjrBemJWQ_-221293967")]
[Description(@"Type of algorithm used by the cryptographic key.")]
[DerivedFrom(typeof(CryptographicKeyTypeCode))]
public enum CryptographicKeyType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DES".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU0vhX1DEeCF8NjrBemJWQ_2128463419")]
    [Description(@"??")]
    DES,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AES".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU0vhn1DEeCF8NjrBemJWQ_-2088353466")]
    [Description(@"??")]
    AES,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RSA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU0vh31DEeCF8NjrBemJWQ_-1222392590")]
    [Description(@"??")]
    RSA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ECC".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU0viH1DEeCF8NjrBemJWQ_-505240776")]
    [Description(@"??")]
    ECC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CryptographicKeyType1CodeMetadataExtensions
{
    private static readonly CryptographicKeyType1CodeDropdownSource _dropdownSource = new CryptographicKeyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICryptographicKeyType1CodeDropdownRow GetMetadata(this CryptographicKeyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


