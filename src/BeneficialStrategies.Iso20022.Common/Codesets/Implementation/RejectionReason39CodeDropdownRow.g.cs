﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason39Code.  ISO2002 ID# _2GP6USwwEeOEV5XHD-BKpw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason39CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason39CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2GP6USwwEeOEV5XHD-BKpw")]
public partial class RejectionReason39CodeDropdownRow : EnumMetadataItem<RejectionReason39Code>, IRejectionReason39CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason39CodeDropdownRow(RejectionReason39Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
