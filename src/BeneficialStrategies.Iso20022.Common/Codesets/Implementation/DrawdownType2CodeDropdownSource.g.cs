﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DrawdownType2Code.  ISO2002 ID# _hZrdkJNwEembCsVG-3f_AA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of drawdown.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDrawdownType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hZrdkJNwEembCsVG-3f_AA")]
public partial class DrawdownType2CodeDropdownSource : EnumMetadataManager<DrawdownType2Code,IDrawdownType2CodeDropdownRow,DrawdownType2CodeDropdownRow>
{
    public DrawdownType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DrawdownType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
