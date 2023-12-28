﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TradingCapacity6Code.  ISO2002 ID# __zaK9NojEeC60axPepSq7g_276330764.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__zaK9NojEeC60axPepSq7g_276330764")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[DerivedFrom(typeof(TradingCapacityCode))]
public enum TradingCapacity6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Agent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zaK9dojEeC60axPepSq7g_946389513")]
    [Description(@"??")]
    Agent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ActingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zaK9tojEeC60axPepSq7g_-729579691")]
    [Description(@"??")]
    ActingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossingAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zj78NojEeC60axPepSq7g_-1990766827")]
    [Description(@"??")]
    CrossingAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CrossingPrincipal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zj78dojEeC60axPepSq7g_1386150177")]
    [Description(@"??")]
    CrossingPrincipal,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zj78tojEeC60axPepSq7g_1420967182")]
    [Description(@"??")]
    OtherAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PrincipalAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zj789ojEeC60axPepSq7g_153653596")]
    [Description(@"??")]
    PrincipalAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Principal".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__zj79NojEeC60axPepSq7g_-2025583832")]
    [Description(@"??")]
    Principal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TradingCapacity6CodeMetadataExtensions
{
    private static readonly TradingCapacity6CodeDropdownSource _dropdownSource = new TradingCapacity6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITradingCapacity6CodeDropdownRow GetMetadata(this TradingCapacity6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

