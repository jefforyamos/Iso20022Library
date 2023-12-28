﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QueryType3Code.  ISO2002 ID# _ZXqQ9tp-Ed-ak6NoX_4Aeg_1181990652.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the request, that is whether all information be returned or only information that has changed since the last similar request was returned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QueryType3CodeDropdownSource"/>.
/// Implements <seealso cref="IQueryType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXqQ9tp-Ed-ak6NoX_4Aeg_1181990652")]
public partial class QueryType3CodeDropdownRow : EnumMetadataItem<QueryType3Code>, IQueryType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the request, that is whether all information be returned or only information that has changed since the last similar request was returned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QueryType3CodeDropdownRow(QueryType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}