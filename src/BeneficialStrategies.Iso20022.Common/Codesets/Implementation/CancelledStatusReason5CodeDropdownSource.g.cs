﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason5Code.  ISO2002 ID# _a08HRtp-Ed-ak6NoX_4Aeg_566867564.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a08HRtp-Ed-ak6NoX_4Aeg_566867564")]
public partial class CancelledStatusReason5CodeDropdownSource : EnumMetadataManager<CancelledStatusReason5Code,ICancelledStatusReason5CodeDropdownRow,CancelledStatusReason5CodeDropdownRow>
{
    public CancelledStatusReason5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
