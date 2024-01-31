﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommissionType6Code.  ISO2002 ID# _a_9rg9p-Ed-ak6NoX_4Aeg_2025119069.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund commission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommissionType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_9rg9p-Ed-ak6NoX_4Aeg_2025119069")]
public partial class CommissionType6CodeDropdownSource : EnumMetadataManager<CommissionType6Code,ICommissionType6CodeDropdownRow,CommissionType6CodeDropdownRow>
{
    public CommissionType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommissionType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
