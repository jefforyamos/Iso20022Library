﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory15Code.  ISO2002 ID# _186MUQ0aEeqUVL7sB4m7NA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Maintenance service to delegate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_186MUQ0aEeqUVL7sB4m7NA")]
public partial class DataSetCategory15CodeDropdownSource : EnumMetadataManager<DataSetCategory15Code,IDataSetCategory15CodeDropdownRow,DataSetCategory15CodeDropdownRow>
{
    public DataSetCategory15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
