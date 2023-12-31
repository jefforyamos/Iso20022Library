﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason2Code.  ISO2002 ID# _a0pMVtp-Ed-ak6NoX_4Aeg_-1194630284.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0pMVtp-Ed-ak6NoX_4Aeg_-1194630284")]
public partial class CancelledStatusReason2CodeDropdownSource : EnumMetadataManager<CancelledStatusReason2Code,ICancelledStatusReason2CodeDropdownRow,CancelledStatusReason2CodeDropdownRow>
{
    public CancelledStatusReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
