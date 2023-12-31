﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReasonV3Code.  ISO2002 ID# __9ywuol5EeavwKddCbm3hg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReasonV3CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReasonV3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__9ywuol5EeavwKddCbm3hg")]
public partial class RejectionReasonV3CodeDropdownRow : EnumMetadataItem<RejectionReasonV3Code>, IRejectionReasonV3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReasonV3CodeDropdownRow(RejectionReasonV3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
