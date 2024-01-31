﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason6Code.  ISO2002 ID# _a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason6CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525")]
public partial class CancelledStatusReason6CodeDropdownRow : EnumMetadataItem<CancelledStatusReason6Code>, ICancelledStatusReason6CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason6CodeDropdownRow(CancelledStatusReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
