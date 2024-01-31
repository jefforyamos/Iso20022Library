﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettledStatusReason2Code.  ISO2002 ID# __AyMYEgWEea9YuSvQGoi-w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Partial settlement status information or information about gating.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettledStatusReason2CodeDropdownSource"/>.
/// Implements <seealso cref="ISettledStatusReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__AyMYEgWEea9YuSvQGoi-w")]
public partial class SettledStatusReason2CodeDropdownRow : EnumMetadataItem<SettledStatusReason2Code>, ISettledStatusReason2CodeDropdownRow
{
    /// <summary>
    /// Partial settlement status information or information about gating.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettledStatusReason2CodeDropdownRow(SettledStatusReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
