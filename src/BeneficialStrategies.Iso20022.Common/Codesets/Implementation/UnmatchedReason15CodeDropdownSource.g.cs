﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnmatchedReason15Code.  ISO2002 ID# _JsEuIOCaEei2UYJ62ws-Fw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnmatchedReason15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JsEuIOCaEei2UYJ62ws-Fw")]
public partial class UnmatchedReason15CodeDropdownSource : EnumMetadataManager<UnmatchedReason15Code,IUnmatchedReason15CodeDropdownRow,UnmatchedReason15CodeDropdownRow>
{
    public UnmatchedReason15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnmatchedReason15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
