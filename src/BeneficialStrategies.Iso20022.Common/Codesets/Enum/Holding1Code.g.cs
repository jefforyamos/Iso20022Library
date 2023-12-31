﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Holding1Code.  ISO2002 ID# _AFmrABKgEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the holding is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AFmrABKgEeKj15WxqwlXPw")]
[Description(@"Specifies how the holding is blocked.")]
[DerivedFrom(typeof(HoldingCode))]
public enum Holding1Code
{
    /// <summary>
    /// Certificate.
    /// Encoded/decoded by serializers as "Certificate".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_HrQ00RKgEeKj15WxqwlXPw")]
    [Description(@"Certificate.")]
    Certificate,
    
    /// <summary>
    /// Non partial holding.
    /// Encoded/decoded by serializers as "NonPartialHolding".
    /// </summary>
    [EnumMember(Value = "NPRH")]
    [IsoId("_H08VQRKgEeKj15WxqwlXPw")]
    [Description(@"Non partial holding.")]
    NonPartialHolding,
    
    /// <summary>
    /// Partial holding.
    /// Encoded/decoded by serializers as "PartialHolding".
    /// </summary>
    [EnumMember(Value = "PRTH")]
    [IsoId("_IBT9URKgEeKj15WxqwlXPw")]
    [Description(@"Partial holding.")]
    PartialHolding,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Holding1CodeMetadataExtensions
{
    private static readonly Holding1CodeDropdownSource _dropdownSource = new Holding1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHolding1CodeDropdownRow GetMetadata(this Holding1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


