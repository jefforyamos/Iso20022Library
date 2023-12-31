﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason2Code.  ISO2002 ID# _a0pMVtp-Ed-ak6NoX_4Aeg_-1194630284.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason2CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0pMVtp-Ed-ak6NoX_4Aeg_-1194630284")]
public partial class CancelledStatusReason2CodeDropdownRow : EnumMetadataItem<CancelledStatusReason2Code>, ICancelledStatusReason2CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason2CodeDropdownRow(CancelledStatusReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
