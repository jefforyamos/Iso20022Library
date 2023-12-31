﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason4Code.  ISO2002 ID# _a0yWRtp-Ed-ak6NoX_4Aeg_1964640600.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0yWRtp-Ed-ak6NoX_4Aeg_1964640600")]
public partial class CancelledStatusReason4CodeDropdownSource : EnumMetadataManager<CancelledStatusReason4Code,ICancelledStatusReason4CodeDropdownRow,CancelledStatusReason4CodeDropdownRow>
{
    public CancelledStatusReason4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
