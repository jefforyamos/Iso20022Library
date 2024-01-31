﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OffMarketCode.  ISO2002 ID# _aOfyVNp-Ed-ak6NoX_4Aeg_1937485685.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the trade was executed off-market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOffMarketCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOfyVNp-Ed-ak6NoX_4Aeg_1937485685")]
public partial class OffMarketCodeDropdownSource : EnumMetadataManager<OffMarketCode,IOffMarketCodeDropdownRow,OffMarketCodeDropdownRow>
{
    public OffMarketCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OffMarketCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
