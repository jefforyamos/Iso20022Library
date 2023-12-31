﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RepoTerminationOption1Code.  ISO2002 ID# _Dix5sCy0Eea35M2x2c9PXw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the termination option for a repurchase agreement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRepoTerminationOption1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Dix5sCy0Eea35M2x2c9PXw")]
public partial class RepoTerminationOption1CodeDropdownSource : EnumMetadataManager<RepoTerminationOption1Code,IRepoTerminationOption1CodeDropdownRow,RepoTerminationOption1CodeDropdownRow>
{
    public RepoTerminationOption1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RepoTerminationOption1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
