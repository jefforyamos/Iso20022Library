﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommissionType5Code.  ISO2002 ID# _VkKxNtp-Ed-ak6NoX_4Aeg_377990975.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommissionType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VkKxNtp-Ed-ak6NoX_4Aeg_377990975")]
public partial class CommissionType5CodeDropdownSource : EnumMetadataManager<CommissionType5Code,ICommissionType5CodeDropdownRow,CommissionType5CodeDropdownRow>
{
    public CommissionType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommissionType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
