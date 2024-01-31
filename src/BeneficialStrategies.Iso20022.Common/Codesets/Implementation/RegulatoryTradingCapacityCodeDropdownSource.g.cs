﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RegulatoryTradingCapacityCode.  ISO2002 ID# _CeQmoO8bEeSLA89yUYsVSw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory trading capacity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRegulatoryTradingCapacityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CeQmoO8bEeSLA89yUYsVSw")]
public partial class RegulatoryTradingCapacityCodeDropdownSource : EnumMetadataManager<RegulatoryTradingCapacityCode,IRegulatoryTradingCapacityCodeDropdownRow,RegulatoryTradingCapacityCodeDropdownRow>
{
    public RegulatoryTradingCapacityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RegulatoryTradingCapacityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
