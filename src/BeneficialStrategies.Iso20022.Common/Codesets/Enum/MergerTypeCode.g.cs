﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MergerTypeCode.  ISO2002 ID# _DppzQFOzEeGs_NnqHXQZkw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Types of merger for the TSE/JASDEC extension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DppzQFOzEeGs_NnqHXQZkw")]
[Description(@"Types of merger for the TSE/JASDEC extension.")]
public enum MergerTypeCode
{
    /// <summary>
    /// The type of merger is an ordinary merger.
    /// Encoded/decoded by serializers as "MRGR".
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_MvsxwFOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is an ordinary merger.")]
    OrdinaryMerger,
    
    /// <summary>
    /// The type of merger is an exchange of shares.
    /// Encoded/decoded by serializers as "EXSH".
    /// </summary>
    [EnumMember(Value = "EXSH")]
    [IsoId("_bCyc4FOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is an exchange of shares.")]
    ExchangeofShares,
    
    /// <summary>
    /// The type of merger is a transfer of shares.
    /// Encoded/decoded by serializers as "TRSH".
    /// </summary>
    [EnumMember(Value = "TRSH")]
    [IsoId("_gOo2sFOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is a transfer of shares.")]
    TransferofShares,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MergerTypeCodeMetadataExtensions
{
    private static readonly MergerTypeCodeDropdownSource _dropdownSource = new MergerTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMergerTypeCodeDropdownRow GetMetadata(this MergerTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

