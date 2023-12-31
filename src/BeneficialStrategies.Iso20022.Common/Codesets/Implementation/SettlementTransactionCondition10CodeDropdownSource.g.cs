﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionCondition10Code.  ISO2002 ID# _T_gNcGaIEeWZev0W8F756g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionCondition10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T_gNcGaIEeWZev0W8F756g")]
public partial class SettlementTransactionCondition10CodeDropdownSource : EnumMetadataManager<SettlementTransactionCondition10Code,ISettlementTransactionCondition10CodeDropdownRow,SettlementTransactionCondition10CodeDropdownRow>
{
    public SettlementTransactionCondition10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionCondition10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
