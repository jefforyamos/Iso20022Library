﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingDateCode.  ISO2002 ID# __ztF4dojEeC60axPepSq7g_723432947.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the Trading Date is various.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingDateCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__ztF4dojEeC60axPepSq7g_723432947")]
public partial class TradingDateCodeDropdownSource : EnumMetadataManager<TradingDateCode,ITradingDateCodeDropdownRow,TradingDateCodeDropdownRow>
{
    public TradingDateCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingDateCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
