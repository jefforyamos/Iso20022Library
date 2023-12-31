﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnmatchedReason10Code.  ISO2002 ID# _VjPh8SwLEeOqZONeZTLNPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnmatchedReason10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VjPh8SwLEeOqZONeZTLNPw")]
public partial class UnmatchedReason10CodeDropdownSource : EnumMetadataManager<UnmatchedReason10Code,IUnmatchedReason10CodeDropdownRow,UnmatchedReason10CodeDropdownRow>
{
    public UnmatchedReason10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnmatchedReason10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
