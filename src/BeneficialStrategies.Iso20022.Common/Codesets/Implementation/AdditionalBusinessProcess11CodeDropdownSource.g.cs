﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalBusinessProcess11Code.  ISO2002 ID# _csOksRewEeyroI8qKgB7Mg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalBusinessProcess11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_csOksRewEeyroI8qKgB7Mg")]
public partial class AdditionalBusinessProcess11CodeDropdownSource : EnumMetadataManager<AdditionalBusinessProcess11Code,IAdditionalBusinessProcess11CodeDropdownRow,AdditionalBusinessProcess11CodeDropdownRow>
{
    public AdditionalBusinessProcess11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalBusinessProcess11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
