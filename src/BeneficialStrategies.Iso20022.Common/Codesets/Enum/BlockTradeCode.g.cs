﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BlockTradeCode.  ISO2002 ID# _bU1IQtp-Ed-ak6NoX_4Aeg_-1631812740.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the instruction is the parent or a children of a block trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bU1IQtp-Ed-ak6NoX_4Aeg_-1631812740")]
[Description(@"Specifies whether the instruction is the parent or a children of a block trade.")]
public enum BlockTradeCode
{
    /// <summary>
    /// Transaction is a block trade parent.
    /// Encoded/decoded by serializers as "BLPA".
    /// </summary>
    [EnumMember(Value = "BLPA")]
    [IsoId("_bU1IQ9p-Ed-ak6NoX_4Aeg_-1631812715")]
    [Description(@"Transaction is a block trade parent.")]
    Parent,
    
    /// <summary>
    /// Transaction is a block trade child.
    /// Encoded/decoded by serializers as "BLCH".
    /// </summary>
    [EnumMember(Value = "BLCH")]
    [IsoId("_bU1IRNp-Ed-ak6NoX_4Aeg_-1631812714")]
    [Description(@"Transaction is a block trade child.")]
    Child,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BlockTradeCodeMetadataExtensions
{
    private static readonly BlockTradeCodeDropdownSource _dropdownSource = new BlockTradeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBlockTradeCodeDropdownRow GetMetadata(this BlockTradeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


