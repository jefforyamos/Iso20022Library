﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason17Code.  ISO2002 ID# _znHxMOBBEeiVRbNQx5-Vhg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason17CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason17CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_znHxMOBBEeiVRbNQx5-Vhg")]
public partial class CancelledStatusReason17CodeDropdownRow : EnumMetadataItem<CancelledStatusReason17Code>, ICancelledStatusReason17CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason17CodeDropdownRow(CancelledStatusReason17Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
