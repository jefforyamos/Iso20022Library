﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingFloorOrderHandling1Code.  ISO2002 ID# _YqzyBdp-Ed-ak6NoX_4Aeg_530358384.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Description of the parameters under which an order must be handled on the floor.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingFloorOrderHandling1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YqzyBdp-Ed-ak6NoX_4Aeg_530358384")]
public partial class TradingFloorOrderHandling1CodeDropdownSource : EnumMetadataManager<TradingFloorOrderHandling1Code,ITradingFloorOrderHandling1CodeDropdownRow,TradingFloorOrderHandling1CodeDropdownRow>
{
    public TradingFloorOrderHandling1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingFloorOrderHandling1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
