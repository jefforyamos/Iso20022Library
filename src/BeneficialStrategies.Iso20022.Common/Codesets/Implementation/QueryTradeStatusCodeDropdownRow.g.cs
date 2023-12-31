﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QueryTradeStatusCode.  ISO2002 ID# _LmV-saacEeSR8qifggAitQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry status of the trade.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QueryTradeStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IQueryTradeStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LmV-saacEeSR8qifggAitQ")]
public partial class QueryTradeStatusCodeDropdownRow : EnumMetadataItem<QueryTradeStatusCode>, IQueryTradeStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the inquiry status of the trade.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QueryTradeStatusCodeDropdownRow(QueryTradeStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
