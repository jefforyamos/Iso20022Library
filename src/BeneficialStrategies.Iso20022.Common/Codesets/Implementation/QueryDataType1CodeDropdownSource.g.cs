﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QueryDataType1Code.  ISO2002 ID# _8LOxMKa_EeSxuMLA5o46jQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry type of the data.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQueryDataType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8LOxMKa_EeSxuMLA5o46jQ")]
public partial class QueryDataType1CodeDropdownSource : EnumMetadataManager<QueryDataType1Code,IQueryDataType1CodeDropdownRow,QueryDataType1CodeDropdownRow>
{
    public QueryDataType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new QueryDataType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
