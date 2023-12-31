﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VerificationEntityCode.  ISO2002 ID# _lnn88BZNEeiXa46FI4OtcQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity to perform verification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVerificationEntityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lnn88BZNEeiXa46FI4OtcQ")]
public partial class VerificationEntityCodeDropdownSource : EnumMetadataManager<VerificationEntityCode,IVerificationEntityCodeDropdownRow,VerificationEntityCodeDropdownRow>
{
    public VerificationEntityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new VerificationEntityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
