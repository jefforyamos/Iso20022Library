﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason57Code.  ISO2002 ID# _iE664e6KEeqc-LCjwLsUVg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason57CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason57CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iE664e6KEeqc-LCjwLsUVg")]
public partial class RejectionReason57CodeDropdownRow : EnumMetadataItem<RejectionReason57Code>, IRejectionReason57CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason57CodeDropdownRow(RejectionReason57Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}