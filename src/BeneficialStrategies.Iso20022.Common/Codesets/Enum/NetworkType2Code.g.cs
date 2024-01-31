﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NetworkType2Code.  ISO2002 ID# _9wfkQI39EeWRwov1g9WL_A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of proxy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9wfkQI39EeWRwov1g9WL_A")]
[Description(@"Type of proxy.")]
[DerivedFrom(typeof(NetworkTypeCode))]
public enum NetworkType2Code
{
    /// <summary>
    /// Sock5 proxy.
    /// Encoded/decoded by serializers as "SCK5".
    /// </summary>
    [EnumMember(Value = "SCK5")]
    [IsoId("_BAFFsY3-EeWRwov1g9WL_A")]
    [Description(@"Sock5 proxy.")]
    Sock5 = NetworkTypeCode.Sock5, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sock4 proxy.
    /// Encoded/decoded by serializers as "SCK4".
    /// </summary>
    [EnumMember(Value = "SCK4")]
    [IsoId("_BLtG4Y3-EeWRwov1g9WL_A")]
    [Description(@"Sock4 proxy.")]
    Sock4 = NetworkTypeCode.Sock4, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// HTTP proxy.
    /// Encoded/decoded by serializers as "HTTP".
    /// </summary>
    [EnumMember(Value = "HTTP")]
    [IsoId("_BYqk0Y3-EeWRwov1g9WL_A")]
    [Description(@"HTTP proxy.")]
    HTTP = NetworkTypeCode.HTTP, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NetworkType2CodeMetadataExtensions
{
    private static readonly NetworkType2CodeDropdownSource _dropdownSource = new NetworkType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INetworkType2CodeDropdownRow GetMetadata(this NetworkType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


