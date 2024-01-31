﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategoryCode.  ISO2002 ID# _TWrsygEcEeCQm6a_G2yO_w_-1624727429.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set to transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategoryCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TWrsygEcEeCQm6a_G2yO_w_-1624727429")]
public partial class DataSetCategoryCodeDropdownSource : EnumMetadataManager<DataSetCategoryCode,IDataSetCategoryCodeDropdownRow,DataSetCategoryCodeDropdownRow>
{
    public DataSetCategoryCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategoryCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
