﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DisruptionFallbackCode.  ISO2002 ID# _awUtBtp-Ed-ak6NoX_4Aeg_627416917.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the method used to determine a settlement rate when a disruption event has occurred.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDisruptionFallbackCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_awUtBtp-Ed-ak6NoX_4Aeg_627416917")]
public partial class DisruptionFallbackCodeDropdownSource : EnumMetadataManager<DisruptionFallbackCode,IDisruptionFallbackCodeDropdownRow,DisruptionFallbackCodeDropdownRow>
{
    public DisruptionFallbackCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DisruptionFallbackCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
