﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QueryTradeStatus1Code.  ISO2002 ID# _tAngoKadEeSR8qifggAitQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry status of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tAngoKadEeSR8qifggAitQ")]
[Description(@"Specifies the inquiry status of the trade.")]
[DerivedFrom(typeof(QueryTradeStatusCode))]
public enum QueryTradeStatus1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryAllStatus".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vWekwaadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryAllStatus,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryCanceledTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vcIg0aadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryCanceledTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryCancellingTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vhor4aadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryCancellingTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryEmergencyTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vnI28aadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryEmergencyTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryNewTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vsppEaadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryNewTrade,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "QueryReplacedTrade".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vyQh0aadEeSR8qifggAitQ")]
    [Description(@"??")]
    QueryReplacedTrade,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QueryTradeStatus1CodeMetadataExtensions
{
    private static readonly QueryTradeStatus1CodeDropdownSource _dropdownSource = new QueryTradeStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQueryTradeStatus1CodeDropdownRow GetMetadata(this QueryTradeStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


