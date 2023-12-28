﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEquityAssetClassCode.  ISO2002 ID# _9f_awHBYEeqTZuDtO9NgaQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the asset class of a non-equity financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEquityAssetClassCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9f_awHBYEeqTZuDtO9NgaQ")]
public partial class NonEquityAssetClassCodeDropdownSource : EnumMetadataManager<NonEquityAssetClassCode,INonEquityAssetClassCodeDropdownRow,NonEquityAssetClassCodeDropdownRow>
{
    public NonEquityAssetClassCodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEquityAssetClassCodeDropdownRow(enumValue, memberInfo))
    {
    }
}