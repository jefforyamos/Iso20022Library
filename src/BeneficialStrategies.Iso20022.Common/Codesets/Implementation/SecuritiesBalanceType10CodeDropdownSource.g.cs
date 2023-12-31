﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesBalanceType10Code.  ISO2002 ID# _Y_N7wdp-Ed-ak6NoX_4Aeg_-2001716259.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities balance.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesBalanceType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y_N7wdp-Ed-ak6NoX_4Aeg_-2001716259")]
public partial class SecuritiesBalanceType10CodeDropdownSource : EnumMetadataManager<SecuritiesBalanceType10Code,ISecuritiesBalanceType10CodeDropdownRow,SecuritiesBalanceType10CodeDropdownRow>
{
    public SecuritiesBalanceType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesBalanceType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
