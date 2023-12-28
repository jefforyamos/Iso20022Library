﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ClearingAccountType1Code.  ISO2002 ID# _YZXcu9p-Ed-ak6NoX_4Aeg_-1340826137.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IClearingAccountType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZXcu9p-Ed-ak6NoX_4Aeg_-1340826137")]
public partial class ClearingAccountType1CodeDropdownSource : EnumMetadataManager<ClearingAccountType1Code,IClearingAccountType1CodeDropdownRow,ClearingAccountType1CodeDropdownRow>
{
    public ClearingAccountType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ClearingAccountType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}