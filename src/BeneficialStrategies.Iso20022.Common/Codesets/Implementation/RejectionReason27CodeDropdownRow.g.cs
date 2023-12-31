﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason27Code.  ISO2002 ID# _BhhR0P4vEeClUvPNHKL9Zw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason27CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason27CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BhhR0P4vEeClUvPNHKL9Zw")]
public partial class RejectionReason27CodeDropdownRow : EnumMetadataItem<RejectionReason27Code>, IRejectionReason27CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason27CodeDropdownRow(RejectionReason27Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
