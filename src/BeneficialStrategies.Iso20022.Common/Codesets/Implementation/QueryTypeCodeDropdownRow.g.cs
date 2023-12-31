﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QueryTypeCode.  ISO2002 ID# _ZXza4dp-Ed-ak6NoX_4Aeg_1663250443.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QueryTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IQueryTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXza4dp-Ed-ak6NoX_4Aeg_1663250443")]
public partial class QueryTypeCodeDropdownRow : EnumMetadataItem<QueryTypeCode>, IQueryTypeCodeDropdownRow
{
    /// <summary>
    /// Specifyies the nature of the query, i.e. whether the query requests that all matching items be returned or only new matching items since the last similar query be returned.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QueryTypeCodeDropdownRow(QueryTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
