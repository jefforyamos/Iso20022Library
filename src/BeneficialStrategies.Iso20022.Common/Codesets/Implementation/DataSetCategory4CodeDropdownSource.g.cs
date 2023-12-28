﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataSetCategory4Code.  ISO2002 ID# _zmd7kWpKEeSR-ZWLvO-1dg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer to the point of interaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataSetCategory4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zmd7kWpKEeSR-ZWLvO-1dg")]
public partial class DataSetCategory4CodeDropdownSource : EnumMetadataManager<DataSetCategory4Code,IDataSetCategory4CodeDropdownRow,DataSetCategory4CodeDropdownRow>
{
    public DataSetCategory4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataSetCategory4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
