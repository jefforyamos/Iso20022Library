﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CashSettlementSystem2Code.  ISO2002 ID# _a7WRQ9p-Ed-ak6NoX_4Aeg_408258420.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash settlement system used.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICashSettlementSystem2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a7WRQ9p-Ed-ak6NoX_4Aeg_408258420")]
public partial class CashSettlementSystem2CodeDropdownSource : EnumMetadataManager<CashSettlementSystem2Code,ICashSettlementSystem2CodeDropdownRow,CashSettlementSystem2CodeDropdownRow>
{
    public CashSettlementSystem2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CashSettlementSystem2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
