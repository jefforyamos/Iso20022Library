﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason5Code.  ISO2002 ID# _a08HRtp-Ed-ak6NoX_4Aeg_566867564.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason5CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a08HRtp-Ed-ak6NoX_4Aeg_566867564")]
public partial class CancelledStatusReason5CodeDropdownRow : EnumMetadataItem<CancelledStatusReason5Code>, ICancelledStatusReason5CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason5CodeDropdownRow(CancelledStatusReason5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}