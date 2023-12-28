﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionFeaturesCode.  ISO2002 ID# _aPsFJtp-Ed-ak6NoX_4Aeg_322763675.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionFeaturesCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aPsFJtp-Ed-ak6NoX_4Aeg_322763675")]
public partial class OptionFeaturesCodeDropdownSource : EnumMetadataManager<OptionFeaturesCode,IOptionFeaturesCodeDropdownRow,OptionFeaturesCodeDropdownRow>
{
    public OptionFeaturesCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionFeaturesCodeDropdownRow(enumValue, memberInfo))
    {
    }
}