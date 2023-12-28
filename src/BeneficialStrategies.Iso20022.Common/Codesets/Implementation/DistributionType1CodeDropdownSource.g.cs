﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DistributionType1Code.  ISO2002 ID# _aw6i4dp-Ed-ak6NoX_4Aeg_-1335531039.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDistributionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aw6i4dp-Ed-ak6NoX_4Aeg_-1335531039")]
public partial class DistributionType1CodeDropdownSource : EnumMetadataManager<DistributionType1Code,IDistributionType1CodeDropdownRow,DistributionType1CodeDropdownRow>
{
    public DistributionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DistributionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
