﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingDate1Code.  ISO2002 ID# __zj79dojEeC60axPepSq7g_1662306334.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Trading Date Code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingDate1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__zj79dojEeC60axPepSq7g_1662306334")]
public partial class TradingDate1CodeDropdownSource : EnumMetadataManager<TradingDate1Code,ITradingDate1CodeDropdownRow,TradingDate1CodeDropdownRow>
{
    public TradingDate1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingDate1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
