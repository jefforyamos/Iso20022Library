﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdjustmentDirectionCode.  ISO2002 ID# _bnKOY9p-Ed-ak6NoX_4Aeg_-700576555.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the adjustment is added or substracted to the total amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdjustmentDirectionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bnKOY9p-Ed-ak6NoX_4Aeg_-700576555")]
public partial class AdjustmentDirectionCodeDropdownSource : EnumMetadataManager<AdjustmentDirectionCode,IAdjustmentDirectionCodeDropdownRow,AdjustmentDirectionCodeDropdownRow>
{
    public AdjustmentDirectionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdjustmentDirectionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
