﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceTypeV2Code.  ISO2002 ID# _ZDsMEdp-Ed-ak6NoX_4Aeg_29532225.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZDsMEdp-Ed-ak6NoX_4Aeg_29532225")]
public partial class SecuritiesBalanceTypeV2CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceTypeV2Code,ISecuritiesBalanceTypeV2CodeDropdownRow,SecuritiesBalanceTypeV2CodeDropdownRow>
{
    public SecuritiesBalanceTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
