﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeRegulatoryConditionsCode.  ISO2002 ID# __yXpItojEeC60axPepSq7g_-160167061.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// indicates if the Trade Regulatory Conditions is solicited or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeRegulatoryConditionsCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__yXpItojEeC60axPepSq7g_-160167061")]
public partial class TradeRegulatoryConditionsCodeDropdownSource : EnumMetadataManager<TradeRegulatoryConditionsCode,ITradeRegulatoryConditionsCodeDropdownRow,TradeRegulatoryConditionsCodeDropdownRow>
{
    public TradeRegulatoryConditionsCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeRegulatoryConditionsCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
