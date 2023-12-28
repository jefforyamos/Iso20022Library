﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason16Code.  ISO2002 ID# _YsVgENB6EeihG9bKfarOOA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the cancellation status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YsVgENB6EeihG9bKfarOOA")]
public partial class CancelledStatusReason16CodeDropdownSource : EnumMetadataManager<CancelledStatusReason16Code,ICancelledStatusReason16CodeDropdownRow,CancelledStatusReason16CodeDropdownRow>
{
    public CancelledStatusReason16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
