﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DistributionTypeCode.  ISO2002 ID# _aw6i49p-Ed-ak6NoX_4Aeg_1235409327.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDistributionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aw6i49p-Ed-ak6NoX_4Aeg_1235409327")]
public partial class DistributionTypeCodeDropdownSource : EnumMetadataManager<DistributionTypeCode,IDistributionTypeCodeDropdownRow,DistributionTypeCodeDropdownRow>
{
    public DistributionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DistributionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
