﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory8Code.  ISO2002 ID# _CmT2wY3JEeWjkqXgn_0Imw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CmT2wY3JEeWjkqXgn_0Imw")]
public partial class DataSetCategory8CodeDropdownSource : EnumMetadataManager<DataSetCategory8Code,IDataSetCategory8CodeDropdownRow,DataSetCategory8CodeDropdownRow>
{
    public DataSetCategory8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}