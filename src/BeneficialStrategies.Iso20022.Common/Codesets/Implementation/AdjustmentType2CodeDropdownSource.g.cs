﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdjustmentType2Code.  ISO2002 ID# _bnKOZtp-Ed-ak6NoX_4Aeg_-1989744459.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of adjustment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdjustmentType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bnKOZtp-Ed-ak6NoX_4Aeg_-1989744459")]
public partial class AdjustmentType2CodeDropdownSource : EnumMetadataManager<AdjustmentType2Code,IAdjustmentType2CodeDropdownRow,AdjustmentType2CodeDropdownRow>
{
    public AdjustmentType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdjustmentType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
