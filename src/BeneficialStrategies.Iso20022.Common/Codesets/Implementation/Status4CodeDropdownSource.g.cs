﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Status4Code.  ISO2002 ID# _YgFItdp-Ed-ak6NoX_4Aeg_-2065088389.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YgFItdp-Ed-ak6NoX_4Aeg_-2065088389")]
public partial class Status4CodeDropdownSource : EnumMetadataManager<Status4Code,IStatus4CodeDropdownRow,Status4CodeDropdownRow>
{
    public Status4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Status4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
