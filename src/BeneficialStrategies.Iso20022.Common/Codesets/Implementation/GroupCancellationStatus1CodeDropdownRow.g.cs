﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GroupCancellationStatus1Code.  ISO2002 ID# _auruQ9p-Ed-ak6NoX_4Aeg_-1224774658.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of cancellation requests.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GroupCancellationStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IGroupCancellationStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_auruQ9p-Ed-ak6NoX_4Aeg_-1224774658")]
public partial class GroupCancellationStatus1CodeDropdownRow : EnumMetadataItem<GroupCancellationStatus1Code>, IGroupCancellationStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a group of cancellation requests.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GroupCancellationStatus1CodeDropdownRow(GroupCancellationStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}