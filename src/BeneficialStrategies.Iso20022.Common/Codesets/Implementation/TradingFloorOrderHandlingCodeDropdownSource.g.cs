﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingFloorOrderHandlingCode.  ISO2002 ID# _Yq878Np-Ed-ak6NoX_4Aeg_337179655.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Description of the parameters under which an order must be handled on the floor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingFloorOrderHandlingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yq878Np-Ed-ak6NoX_4Aeg_337179655")]
public partial class TradingFloorOrderHandlingCodeDropdownSource : EnumMetadataManager<TradingFloorOrderHandlingCode,ITradingFloorOrderHandlingCodeDropdownRow,TradingFloorOrderHandlingCodeDropdownRow>
{
    public TradingFloorOrderHandlingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingFloorOrderHandlingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
