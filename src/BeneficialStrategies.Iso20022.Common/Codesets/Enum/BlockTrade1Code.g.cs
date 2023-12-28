﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BlockTrade1Code.  ISO2002 ID# _begotNp-Ed-ak6NoX_4Aeg_450632861.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the instruction is the parent or a children of a block trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_begotNp-Ed-ak6NoX_4Aeg_450632861")]
[Description(@"Specifies whether the instruction is the parent or a children of a block trade.")]
[DerivedFrom(typeof(BlockTradeCode))]
public enum BlockTrade1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Parent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_begotdp-Ed-ak6NoX_4Aeg_489423628")]
    [Description(@"??")]
    Parent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Child".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_begottp-Ed-ak6NoX_4Aeg_535598920")]
    [Description(@"??")]
    Child,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BlockTrade1CodeMetadataExtensions
{
    private static readonly BlockTrade1CodeDropdownSource _dropdownSource = new BlockTrade1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBlockTrade1CodeDropdownRow GetMetadata(this BlockTrade1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

