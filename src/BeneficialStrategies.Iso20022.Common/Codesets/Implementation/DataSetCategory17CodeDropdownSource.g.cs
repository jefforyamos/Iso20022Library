﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory17Code.  ISO2002 ID# _t59j4FEHEeyApZmLzm74zA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory17CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t59j4FEHEeyApZmLzm74zA")]
public partial class DataSetCategory17CodeDropdownSource : EnumMetadataManager<DataSetCategory17Code,IDataSetCategory17CodeDropdownRow,DataSetCategory17CodeDropdownRow>
{
    public DataSetCategory17CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory17CodeDropdownRow(enumValue, memberInfo))
    {
    }
}