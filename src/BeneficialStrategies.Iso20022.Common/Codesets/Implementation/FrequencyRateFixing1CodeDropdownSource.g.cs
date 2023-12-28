﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FrequencyRateFixing1Code.  ISO2002 ID# _HAxU4I9PEeqMo4JxiuZGSw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the frequency rate fixing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFrequencyRateFixing1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_HAxU4I9PEeqMo4JxiuZGSw")]
public partial class FrequencyRateFixing1CodeDropdownSource : EnumMetadataManager<FrequencyRateFixing1Code,IFrequencyRateFixing1CodeDropdownRow,FrequencyRateFixing1CodeDropdownRow>
{
    public FrequencyRateFixing1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FrequencyRateFixing1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
