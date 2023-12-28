﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Status9Code.  ISO2002 ID# _2GrRoPNvEeqRfth943bvEA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatus9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2GrRoPNvEeqRfth943bvEA")]
public partial class Status9CodeDropdownSource : EnumMetadataManager<Status9Code,IStatus9CodeDropdownRow,Status9CodeDropdownRow>
{
    public Status9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Status9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
