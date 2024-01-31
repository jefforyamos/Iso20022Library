﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason11Code.  ISO2002 ID# _QcaXgeJxEd-Q6MzBzY5WkA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QcaXgeJxEd-Q6MzBzY5WkA")]
public partial class CancelledStatusReason11CodeDropdownSource : EnumMetadataManager<CancelledStatusReason11Code,ICancelledStatusReason11CodeDropdownRow,CancelledStatusReason11CodeDropdownRow>
{
    public CancelledStatusReason11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
