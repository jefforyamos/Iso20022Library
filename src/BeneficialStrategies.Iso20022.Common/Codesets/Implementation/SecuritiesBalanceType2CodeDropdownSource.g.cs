﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceType2Code.  ISO2002 ID# _ZBdXcdp-Ed-ak6NoX_4Aeg_1919950094.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZBdXcdp-Ed-ak6NoX_4Aeg_1919950094")]
public partial class SecuritiesBalanceType2CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceType2Code,ISecuritiesBalanceType2CodeDropdownRow,SecuritiesBalanceType2CodeDropdownRow>
{
    public SecuritiesBalanceType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}