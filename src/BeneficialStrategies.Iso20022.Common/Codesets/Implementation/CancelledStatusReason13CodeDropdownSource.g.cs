﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CancelledStatusReason13Code.  ISO2002 ID# _MrDa8f5DEeClUvPNHKL9Zw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICancelledStatusReason13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MrDa8f5DEeClUvPNHKL9Zw")]
public partial class CancelledStatusReason13CodeDropdownSource : EnumMetadataManager<CancelledStatusReason13Code,ICancelledStatusReason13CodeDropdownRow,CancelledStatusReason13CodeDropdownRow>
{
    public CancelledStatusReason13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CancelledStatusReason13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
