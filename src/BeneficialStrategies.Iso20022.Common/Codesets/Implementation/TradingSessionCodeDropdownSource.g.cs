﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingSessionCode.  ISO2002 ID# _YrGs9Np-Ed-ak6NoX_4Aeg_-1913582483.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the factors that are/were applied in the event of pre-allocation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingSessionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrGs9Np-Ed-ak6NoX_4Aeg_-1913582483")]
public partial class TradingSessionCodeDropdownSource : EnumMetadataManager<TradingSessionCode,ITradingSessionCodeDropdownRow,TradingSessionCodeDropdownRow>
{
    public TradingSessionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingSessionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
