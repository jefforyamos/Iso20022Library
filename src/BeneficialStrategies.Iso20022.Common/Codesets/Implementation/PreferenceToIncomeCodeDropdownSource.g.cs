﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PreferenceToIncomeCode.  ISO2002 ID# _aIOyQNp-Ed-ak6NoX_4Aeg_-2084548748.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPreferenceToIncomeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aIOyQNp-Ed-ak6NoX_4Aeg_-2084548748")]
public partial class PreferenceToIncomeCodeDropdownSource : EnumMetadataManager<PreferenceToIncomeCode,IPreferenceToIncomeCodeDropdownRow,PreferenceToIncomeCodeDropdownRow>
{
    public PreferenceToIncomeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PreferenceToIncomeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
