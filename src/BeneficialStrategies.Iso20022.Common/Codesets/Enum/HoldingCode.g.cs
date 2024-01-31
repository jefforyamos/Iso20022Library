﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingCode.  ISO2002 ID# _lwDTkxKfEeKj15WxqwlXPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the holding is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lwDTkxKfEeKj15WxqwlXPw")]
[Description(@"Specifies how the holding is blocked.")]
[Derivations(typeof(Holding1Code))]
public enum HoldingCode
{
    /// <summary>
    /// Partial holding.
    /// Encoded/decoded by serializers as "PRTH".
    /// </summary>
    [EnumMember(Value = "PRTH")]
    [IsoId("_qyrf8BKfEeKj15WxqwlXPw")]
    [Description(@"Partial holding.")]
    PartialHolding,
    
    /// <summary>
    /// Non partial holding.
    /// Encoded/decoded by serializers as "NPRH".
    /// </summary>
    [EnumMember(Value = "NPRH")]
    [IsoId("_q7nZgBKfEeKj15WxqwlXPw")]
    [Description(@"Non partial holding.")]
    NonPartialHolding,
    
    /// <summary>
    /// Certificate.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_5Y4UUBKfEeKj15WxqwlXPw")]
    [Description(@"Certificate.")]
    Certificate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HoldingCodeMetadataExtensions
{
    private static readonly HoldingCodeDropdownSource _dropdownSource = new HoldingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHoldingCodeDropdownRow GetMetadata(this HoldingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


