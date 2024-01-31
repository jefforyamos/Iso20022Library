﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason15Code.  ISO2002 ID# _hb8U8ZHsEeWL7bXuV2k5pg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason15CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason15CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hb8U8ZHsEeWL7bXuV2k5pg")]
public partial class CancelledStatusReason15CodeDropdownRow : EnumMetadataItem<CancelledStatusReason15Code>, ICancelledStatusReason15CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason15CodeDropdownRow(CancelledStatusReason15Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
