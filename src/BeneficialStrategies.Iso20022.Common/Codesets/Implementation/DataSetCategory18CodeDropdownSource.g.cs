﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory18Code.  ISO2002 ID# _zT5JgXC7Ee2bmOA3bkVsMg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zT5JgXC7Ee2bmOA3bkVsMg")]
public partial class DataSetCategory18CodeDropdownSource : EnumMetadataManager<DataSetCategory18Code,IDataSetCategory18CodeDropdownRow,DataSetCategory18CodeDropdownRow>
{
    public DataSetCategory18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
