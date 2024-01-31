﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Status2Code.  ISO2002 ID# _ZQWvF9p-Ed-ak6NoX_4Aeg_-539683866.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQWvF9p-Ed-ak6NoX_4Aeg_-539683866")]
public partial class Status2CodeDropdownSource : EnumMetadataManager<Status2Code,IStatus2CodeDropdownRow,Status2CodeDropdownRow>
{
    public Status2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Status2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
