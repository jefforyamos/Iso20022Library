﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason55Code.  ISO2002 ID# _-IH_MOkIEemm4qhb2yFPOw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason55CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason55CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-IH_MOkIEemm4qhb2yFPOw")]
public partial class RejectionReason55CodeDropdownRow : EnumMetadataItem<RejectionReason55Code>, IRejectionReason55CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason55CodeDropdownRow(RejectionReason55Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
