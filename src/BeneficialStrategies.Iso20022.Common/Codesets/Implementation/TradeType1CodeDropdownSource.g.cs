﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeType1Code.  ISO2002 ID# _YaHqoNp-Ed-ak6NoX_4Aeg_-1681929473.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YaHqoNp-Ed-ak6NoX_4Aeg_-1681929473")]
public partial class TradeType1CodeDropdownSource : EnumMetadataManager<TradeType1Code,ITradeType1CodeDropdownRow,TradeType1CodeDropdownRow>
{
    public TradeType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
