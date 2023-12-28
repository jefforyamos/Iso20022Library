﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeType3Code.  ISO2002 ID# __yXpJdojEeC60axPepSq7g_-56889578.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of executed order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__yXpJdojEeC60axPepSq7g_-56889578")]
public partial class TradeType3CodeDropdownSource : EnumMetadataManager<TradeType3Code,ITradeType3CodeDropdownRow,TradeType3CodeDropdownRow>
{
    public TradeType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
