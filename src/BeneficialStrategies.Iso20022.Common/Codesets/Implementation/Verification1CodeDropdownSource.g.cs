﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Verification1Code.  ISO2002 ID# _uTRSAGjpEeSDR-pyia6Xtg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the verification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVerification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uTRSAGjpEeSDR-pyia6Xtg")]
public partial class Verification1CodeDropdownSource : EnumMetadataManager<Verification1Code,IVerification1CodeDropdownRow,Verification1CodeDropdownRow>
{
    public Verification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Verification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
