﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason51Code.  ISO2002 ID# _U-MrYLLMEemDyeh7tbvg1w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason51CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason51CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U-MrYLLMEemDyeh7tbvg1w")]
public partial class RejectionReason51CodeDropdownRow : EnumMetadataItem<RejectionReason51Code>, IRejectionReason51CodeDropdownRow
{
    /// <summary>
    /// Specifies a reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason51CodeDropdownRow(RejectionReason51Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
