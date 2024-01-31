﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalServiceResultCode.  ISO2002 ID# _koClUJ1JEeublrfU-wN95w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the result of the service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalServiceResultCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_koClUJ1JEeublrfU-wN95w")]
public partial class AdditionalServiceResultCodeDropdownSource : EnumMetadataManager<AdditionalServiceResultCode,IAdditionalServiceResultCodeDropdownRow,AdditionalServiceResultCodeDropdownRow>
{
    public AdditionalServiceResultCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalServiceResultCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
