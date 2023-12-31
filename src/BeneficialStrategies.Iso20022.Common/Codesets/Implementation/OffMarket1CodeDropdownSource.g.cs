﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OffMarket1Code.  ISO2002 ID# _aOfyUdp-Ed-ak6NoX_4Aeg_1810038493.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that the trade was executed off-market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOffMarket1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOfyUdp-Ed-ak6NoX_4Aeg_1810038493")]
public partial class OffMarket1CodeDropdownSource : EnumMetadataManager<OffMarket1Code,IOffMarket1CodeDropdownRow,OffMarket1CodeDropdownRow>
{
    public OffMarket1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OffMarket1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
