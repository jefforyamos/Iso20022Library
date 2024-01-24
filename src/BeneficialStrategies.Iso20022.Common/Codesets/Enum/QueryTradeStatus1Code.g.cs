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
    /// Query for all trades.
    /// Encoded/decoded by serializers as "QAST".
    /// </summary>
    [EnumMember(Value = "QAST")]
    [IsoId("_vWekwaadEeSR8qifggAitQ")]
    [Description(@"Query for all trades.")]
    QueryAllStatus = QueryTradeStatusCode.QueryAllStatus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for trades have been canceled.
    /// Encoded/decoded by serializers as "QCTR".
    /// </summary>
    [EnumMember(Value = "QCTR")]
    [IsoId("_vcIg0aadEeSR8qifggAitQ")]
    [Description(@"Query for trades have been canceled.")]
    QueryCanceledTrade = QueryTradeStatusCode.QueryCanceledTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for cancelling trades.
    /// Encoded/decoded by serializers as "QCIR".
    /// </summary>
    [EnumMember(Value = "QCIR")]
    [IsoId("_vhor4aadEeSR8qifggAitQ")]
    [Description(@"Query for cancelling trades.")]
    QueryCancellingTrade = QueryTradeStatusCode.QueryCancellingTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for emergency trades.
    /// Encoded/decoded by serializers as "QETR".
    /// </summary>
    [EnumMember(Value = "QETR")]
    [IsoId("_vnI28aadEeSR8qifggAitQ")]
    [Description(@"Query for emergency trades.")]
    QueryEmergencyTrade = QueryTradeStatusCode.QueryEmergencyTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for new trades.
    /// Encoded/decoded by serializers as "QNTR".
    /// </summary>
    [EnumMember(Value = "QNTR")]
    [IsoId("_vsppEaadEeSR8qifggAitQ")]
    [Description(@"Query for new trades.")]
    QueryNewTrade = QueryTradeStatusCode.QueryNewTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Query for trades have been replaced.
    /// Encoded/decoded by serializers as "QRTR".
    /// </summary>
    [EnumMember(Value = "QRTR")]
    [IsoId("_vyQh0aadEeSR8qifggAitQ")]
    [Description(@"Query for trades have been replaced.")]
    QueryReplacedTrade = QueryTradeStatusCode.QueryReplacedTrade, // same ordinal as derivation source for type conversions
    
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


