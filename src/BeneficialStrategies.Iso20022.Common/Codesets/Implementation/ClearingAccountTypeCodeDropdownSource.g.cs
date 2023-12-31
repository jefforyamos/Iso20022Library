﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ClearingAccountTypeCode.  ISO2002 ID# _YZhNstp-Ed-ak6NoX_4Aeg_-735267908.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IClearingAccountTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZhNstp-Ed-ak6NoX_4Aeg_-735267908")]
public partial class ClearingAccountTypeCodeDropdownSource : EnumMetadataManager<ClearingAccountTypeCode,IClearingAccountTypeCodeDropdownRow,ClearingAccountTypeCodeDropdownRow>
{
    public ClearingAccountTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ClearingAccountTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
