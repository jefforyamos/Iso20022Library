﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceType6Code.  ISO2002 ID# _ZCf5Q9p-Ed-ak6NoX_4Aeg_-1599060186.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZCf5Q9p-Ed-ak6NoX_4Aeg_-1599060186")]
public partial class SecuritiesBalanceType6CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceType6Code,ISecuritiesBalanceType6CodeDropdownRow,SecuritiesBalanceType6CodeDropdownRow>
{
    public SecuritiesBalanceType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
