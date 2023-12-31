﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceTypeV3Code.  ISO2002 ID# _kKPfmIhAEeOxVLCZ_vEz5w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the securities or investment fund balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceTypeV3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kKPfmIhAEeOxVLCZ_vEz5w")]
public partial class SecuritiesBalanceTypeV3CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceTypeV3Code,ISecuritiesBalanceTypeV3CodeDropdownRow,SecuritiesBalanceTypeV3CodeDropdownRow>
{
    public SecuritiesBalanceTypeV3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceTypeV3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
