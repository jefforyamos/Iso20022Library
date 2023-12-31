﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceType13Code.  ISO2002 ID# _ZAHTo9p-Ed-ak6NoX_4Aeg_-409844332.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceType13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZAHTo9p-Ed-ak6NoX_4Aeg_-409844332")]
public partial class SecuritiesBalanceType13CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceType13Code,ISecuritiesBalanceType13CodeDropdownRow,SecuritiesBalanceType13CodeDropdownRow>
{
    public SecuritiesBalanceType13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceType13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
