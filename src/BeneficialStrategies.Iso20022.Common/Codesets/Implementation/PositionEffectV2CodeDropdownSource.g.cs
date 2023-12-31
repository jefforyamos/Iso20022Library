﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PositionEffectV2Code.  ISO2002 ID# __tJx8tojEeC60axPepSq7g_1840994325.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the resulting position after a trade should be an opening position or closing position.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPositionEffectV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__tJx8tojEeC60axPepSq7g_1840994325")]
public partial class PositionEffectV2CodeDropdownSource : EnumMetadataManager<PositionEffectV2Code,IPositionEffectV2CodeDropdownRow,PositionEffectV2CodeDropdownRow>
{
    public PositionEffectV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PositionEffectV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
