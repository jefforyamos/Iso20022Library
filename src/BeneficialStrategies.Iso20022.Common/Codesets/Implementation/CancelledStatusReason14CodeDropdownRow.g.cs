﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason14Code.  ISO2002 ID# _zfRGYCzzEeOsiuMH68so7Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason14CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason14CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zfRGYCzzEeOsiuMH68so7Q")]
public partial class CancelledStatusReason14CodeDropdownRow : EnumMetadataItem<CancelledStatusReason14Code>, ICancelledStatusReason14CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason14CodeDropdownRow(CancelledStatusReason14Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
