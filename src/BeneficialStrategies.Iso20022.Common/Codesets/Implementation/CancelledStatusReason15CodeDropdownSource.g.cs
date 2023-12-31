﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason15Code.  ISO2002 ID# _hb8U8ZHsEeWL7bXuV2k5pg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hb8U8ZHsEeWL7bXuV2k5pg")]
public partial class CancelledStatusReason15CodeDropdownSource : EnumMetadataManager<CancelledStatusReason15Code,ICancelledStatusReason15CodeDropdownRow,CancelledStatusReason15CodeDropdownRow>
{
    public CancelledStatusReason15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
