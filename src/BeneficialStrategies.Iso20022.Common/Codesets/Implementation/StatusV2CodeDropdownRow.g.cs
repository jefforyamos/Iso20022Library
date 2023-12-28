﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StatusV2Code.  ISO2002 ID# _k1I4cfNvEeqRfth943bvEA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StatusV2CodeDropdownSource"/>.
/// Implements <seealso cref="IStatusV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_k1I4cfNvEeqRfth943bvEA")]
public partial class StatusV2CodeDropdownRow : EnumMetadataItem<StatusV2Code>, IStatusV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StatusV2CodeDropdownRow(StatusV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}