﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FundType2Code.  ISO2002 ID# _e_zPoFKVEee26cwI-oG0JQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// In the case where the reporting counterparty is a UCIT or AIF, an indication whether it is an ETF or a MMF.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFundType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_e_zPoFKVEee26cwI-oG0JQ")]
public partial class FundType2CodeDropdownSource : EnumMetadataManager<FundType2Code,IFundType2CodeDropdownRow,FundType2CodeDropdownRow>
{
    public FundType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FundType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
