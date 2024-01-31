﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SustainabilityPreferences1Code.  ISO2002 ID# _DdXhIM0VEeuAE-cYsQdwHQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the product is compatible with investors that have sustainability preferences.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISustainabilityPreferences1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DdXhIM0VEeuAE-cYsQdwHQ")]
public partial class SustainabilityPreferences1CodeDropdownSource : EnumMetadataManager<SustainabilityPreferences1Code,ISustainabilityPreferences1CodeDropdownRow,SustainabilityPreferences1CodeDropdownRow>
{
    public SustainabilityPreferences1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SustainabilityPreferences1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
