﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason3Code.  ISO2002 ID# _a0yWQtp-Ed-ak6NoX_4Aeg_2105332425.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0yWQtp-Ed-ak6NoX_4Aeg_2105332425")]
public partial class CancelledStatusReason3CodeDropdownSource : EnumMetadataManager<CancelledStatusReason3Code,ICancelledStatusReason3CodeDropdownRow,CancelledStatusReason3CodeDropdownRow>
{
    public CancelledStatusReason3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
