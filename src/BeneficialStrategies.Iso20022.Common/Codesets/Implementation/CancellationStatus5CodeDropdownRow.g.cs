﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancellationStatus5Code.  ISO2002 ID# _9iJXMJM7EemQB_8XA98K0Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cancellation status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancellationStatus5CodeDropdownSource"/>.
/// Implements <seealso cref="ICancellationStatus5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9iJXMJM7EemQB_8XA98K0Q")]
public partial class CancellationStatus5CodeDropdownRow : EnumMetadataItem<CancellationStatus5Code>, ICancellationStatus5CodeDropdownRow
{
    /// <summary>
    /// Specifies the cancellation status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancellationStatus5CodeDropdownRow(CancellationStatus5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
