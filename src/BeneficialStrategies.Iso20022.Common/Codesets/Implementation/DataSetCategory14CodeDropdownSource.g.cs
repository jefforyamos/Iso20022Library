﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory14Code.  ISO2002 ID# _lk9GcQ0aEeqUVL7sB4m7NA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lk9GcQ0aEeqUVL7sB4m7NA")]
public partial class DataSetCategory14CodeDropdownSource : EnumMetadataManager<DataSetCategory14Code,IDataSetCategory14CodeDropdownRow,DataSetCategory14CodeDropdownRow>
{
    public DataSetCategory14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
