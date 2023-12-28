﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason28Code.  ISO2002 ID# __oFrwNojEeC60axPepSq7g_-241533173.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason28CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason28CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__oFrwNojEeC60axPepSq7g_-241533173")]
public partial class RejectionReason28CodeDropdownRow : EnumMetadataItem<RejectionReason28Code>, IRejectionReason28CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason28CodeDropdownRow(RejectionReason28Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
