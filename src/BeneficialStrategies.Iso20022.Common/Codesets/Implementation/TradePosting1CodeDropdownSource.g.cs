﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradePosting1Code.  ISO2002 ID# _-fsj16MOEeCojJW5vEuTEQ_-1075208421.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the trade is maintained as a separate individual position in the clearing account, or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradePosting1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-fsj16MOEeCojJW5vEuTEQ_-1075208421")]
public partial class TradePosting1CodeDropdownSource : EnumMetadataManager<TradePosting1Code,ITradePosting1CodeDropdownRow,TradePosting1CodeDropdownRow>
{
    public TradePosting1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradePosting1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
