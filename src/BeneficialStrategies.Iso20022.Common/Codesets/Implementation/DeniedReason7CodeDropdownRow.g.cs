﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeniedReason7Code.  ISO2002 ID# _28LGcFhfEeS8HfHHd4stCA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the denied reason.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeniedReason7CodeDropdownSource"/>.
/// Implements <seealso cref="IDeniedReason7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_28LGcFhfEeS8HfHHd4stCA")]
public partial class DeniedReason7CodeDropdownRow : EnumMetadataItem<DeniedReason7Code>, IDeniedReason7CodeDropdownRow
{
    /// <summary>
    /// Specifies the denied reason.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeniedReason7CodeDropdownRow(DeniedReason7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}