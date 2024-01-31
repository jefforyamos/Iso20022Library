﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DataModificationCode.  ISO2002 ID# _ax9Et9p-Ed-ak6NoX_4Aeg_1251381702.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specified the type of modification to be applied on a data set.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDataModificationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ax9Et9p-Ed-ak6NoX_4Aeg_1251381702")]
public partial class DataModificationCodeDropdownSource : EnumMetadataManager<DataModificationCode,IDataModificationCodeDropdownRow,DataModificationCodeDropdownRow>
{
    public DataModificationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DataModificationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
