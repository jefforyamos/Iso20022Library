﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionFeatures7Code.  ISO2002 ID# _3oMQgWOQEeW4z96Yfj3Wng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionFeatures7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3oMQgWOQEeW4z96Yfj3Wng")]
public partial class OptionFeatures7CodeDropdownSource : EnumMetadataManager<OptionFeatures7Code,IOptionFeatures7CodeDropdownRow,OptionFeatures7CodeDropdownRow>
{
    public OptionFeatures7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionFeatures7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}