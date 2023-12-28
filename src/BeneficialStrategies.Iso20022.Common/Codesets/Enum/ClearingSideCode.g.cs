﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingSideCode.  ISO2002 ID# __1M6s9ojEeC60axPepSq7g_1756834553.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1M6s9ojEeC60axPepSq7g_1756834553")]
[Description(@"Side taken by a party on an order.")]
public enum ClearingSideCode
{
    /// <summary>
    /// Clearing member is on the buying side.
    /// Encoded/decoded by serializers as "BUYI".
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__1M6tNojEeC60axPepSq7g_1642995487")]
    [Description(@"Clearing member is on the buying side.")]
    Buy,
    
    /// <summary>
    /// Clearing member is on the selling side.
    /// Encoded/decoded by serializers as "SELL".
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__1M6tdojEeC60axPepSq7g_937880872")]
    [Description(@"Clearing member is on the selling side.")]
    Sell,
    
    /// <summary>
    /// Clearing member is on the lending side.
    /// Encoded/decoded by serializers as "LEND".
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("__1M6ttojEeC60axPepSq7g_-1133302535")]
    [Description(@"Clearing member is on the lending side.")]
    Lend,
    
    /// <summary>
    /// Clearing member is on the borrowing side.
    /// Encoded/decoded by serializers as "BORW".
    /// </summary>
    [EnumMember(Value = "BORW")]
    [IsoId("__1WEoNojEeC60axPepSq7g_1986473736")]
    [Description(@"Clearing member is on the borrowing side.")]
    Borrow,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingSideCodeMetadataExtensions
{
    private static readonly ClearingSideCodeDropdownSource _dropdownSource = new ClearingSideCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingSideCodeDropdownRow GetMetadata(this ClearingSideCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

