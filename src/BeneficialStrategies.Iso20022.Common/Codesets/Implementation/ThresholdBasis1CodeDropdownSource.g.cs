﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ThresholdBasis1Code.  ISO2002 ID# _IRxt4BuOEeyhRdHRjakS2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IThresholdBasis1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IRxt4BuOEeyhRdHRjakS2w")]
public partial class ThresholdBasis1CodeDropdownSource : EnumMetadataManager<ThresholdBasis1Code,IThresholdBasis1CodeDropdownRow,ThresholdBasis1CodeDropdownRow>
{
    public ThresholdBasis1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ThresholdBasis1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
