﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QueryTradeStatusCode.  ISO2002 ID# _LmV-saacEeSR8qifggAitQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry status of the trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LmV-saacEeSR8qifggAitQ")]
[Description(@"Specifies the inquiry status of the trade.")]
[Derivations(typeof(QueryTradeStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum QueryTradeStatusCode
{
    /// <summary>
    /// Query for all trades.
    /// Encoded/decoded by serializers as "QAST".
    /// </summary>
    [EnumMember(Value = "QAST")]
    [IsoId("_kHkRwKacEeSR8qifggAitQ")]
    [Description(@"Query for all trades.")]
    QueryAllStatus,
    
    /// <summary>
    /// Query for new trades.
    /// Encoded/decoded by serializers as "QNTR".
    /// </summary>
    [EnumMember(Value = "QNTR")]
    [IsoId("_kRQZQKacEeSR8qifggAitQ")]
    [Description(@"Query for new trades.")]
    QueryNewTrade,
    
    /// <summary>
    /// Query for trades have been canceled.
    /// Encoded/decoded by serializers as "QCTR".
    /// </summary>
    [EnumMember(Value = "QCTR")]
    [IsoId("_kVkRgKacEeSR8qifggAitQ")]
    [Description(@"Query for trades have been canceled.")]
    QueryCanceledTrade,
    
    /// <summary>
    /// Query for trades have been replaced.
    /// Encoded/decoded by serializers as "QRTR".
    /// </summary>
    [EnumMember(Value = "QRTR")]
    [IsoId("_kXgLMKacEeSR8qifggAitQ")]
    [Description(@"Query for trades have been replaced.")]
    QueryReplacedTrade,
    
    /// <summary>
    /// Query for emergency trades.
    /// Encoded/decoded by serializers as "QETR".
    /// </summary>
    [EnumMember(Value = "QETR")]
    [IsoId("_yRy70KacEeSR8qifggAitQ")]
    [Description(@"Query for emergency trades.")]
    QueryEmergencyTrade,
    
    /// <summary>
    /// Query for cancelling trades.
    /// Encoded/decoded by serializers as "QCIR".
    /// </summary>
    [EnumMember(Value = "QCIR")]
    [IsoId("_8K2roKacEeSR8qifggAitQ")]
    [Description(@"Query for cancelling trades.")]
    QueryCancellingTrade,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QueryTradeStatusCodeMetadataExtensions
{
    private static readonly QueryTradeStatusCodeDropdownSource _dropdownSource = new QueryTradeStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQueryTradeStatusCodeDropdownRow GetMetadata(this QueryTradeStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


