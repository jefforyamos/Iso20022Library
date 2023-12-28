﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason13Code.  ISO2002 ID# _MrDa8f5DEeClUvPNHKL9Zw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason13CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason13CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MrDa8f5DEeClUvPNHKL9Zw")]
public partial class CancelledStatusReason13CodeDropdownRow : EnumMetadataItem<CancelledStatusReason13Code>, ICancelledStatusReason13CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason13CodeDropdownRow(CancelledStatusReason13Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}