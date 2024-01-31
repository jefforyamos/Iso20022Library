﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancelledStatusReason4Code.  ISO2002 ID# _a0yWRtp-Ed-ak6NoX_4Aeg_1964640600.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancelledStatusReason4CodeDropdownSource"/>.
/// Implements <seealso cref="ICancelledStatusReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a0yWRtp-Ed-ak6NoX_4Aeg_1964640600")]
public partial class CancelledStatusReason4CodeDropdownRow : EnumMetadataItem<CancelledStatusReason4Code>, ICancelledStatusReason4CodeDropdownRow
{
    /// <summary>
    /// Specifies the underlying reason for the cancellation of the associated transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancelledStatusReason4CodeDropdownRow(CancelledStatusReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
