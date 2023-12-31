﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Status6Code.  ISO2002 ID# _kpnylO5NEeCisYr99QEiWA_-1778832606.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Status6CodeDropdownSource"/>.
/// Implements <seealso cref="IStatus6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kpnylO5NEeCisYr99QEiWA_-1778832606")]
public partial class Status6CodeDropdownRow : EnumMetadataItem<Status6Code>, IStatus6CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Status6CodeDropdownRow(Status6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
