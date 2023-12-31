﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason71Code.  ISO2002 ID# _dEaVCitVEeyhipY4f42fZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason71CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason71CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dEaVCitVEeyhipY4f42fZQ")]
public partial class RejectionReason71CodeDropdownRow : EnumMetadataItem<RejectionReason71Code>, IRejectionReason71CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason71CodeDropdownRow(RejectionReason71Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
