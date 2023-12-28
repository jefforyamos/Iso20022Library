﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionFeatures6Code.  ISO2002 ID# _v3kM0WOQEeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the feature of an option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionFeatures6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v3kM0WOQEeW4z96Yfj3Wng")]
public partial class OptionFeatures6CodeDropdownSource : EnumMetadataManager<OptionFeatures6Code,IOptionFeatures6CodeDropdownRow,OptionFeatures6CodeDropdownRow>
{
    public OptionFeatures6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionFeatures6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
