﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QueryOrderStatusCode.  ISO2002 ID# _BfWdUA2NEeSwB74WgTbh4Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry status of order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQueryOrderStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BfWdUA2NEeSwB74WgTbh4Q")]
public partial class QueryOrderStatusCodeDropdownSource : EnumMetadataManager<QueryOrderStatusCode,IQueryOrderStatusCodeDropdownRow,QueryOrderStatusCodeDropdownRow>
{
    public QueryOrderStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new QueryOrderStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
