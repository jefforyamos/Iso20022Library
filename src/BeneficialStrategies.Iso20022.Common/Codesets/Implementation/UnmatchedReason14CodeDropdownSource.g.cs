﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnmatchedReason14Code.  ISO2002 ID# _xtpD0GXkEeWsrOWU209RUg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnmatchedReason14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xtpD0GXkEeWsrOWU209RUg")]
public partial class UnmatchedReason14CodeDropdownSource : EnumMetadataManager<UnmatchedReason14Code,IUnmatchedReason14CodeDropdownRow,UnmatchedReason14CodeDropdownRow>
{
    public UnmatchedReason14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnmatchedReason14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
