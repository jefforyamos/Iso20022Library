﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for VerificationEntity1Code.  ISO2002 ID# _Lxl9oBZOEeiXa46FI4OtcQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of verification entity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVerificationEntity1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Lxl9oBZOEeiXa46FI4OtcQ")]
public partial class VerificationEntity1CodeDropdownSource : EnumMetadataManager<VerificationEntity1Code,IVerificationEntity1CodeDropdownRow,VerificationEntity1CodeDropdownRow>
{
    public VerificationEntity1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new VerificationEntity1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
