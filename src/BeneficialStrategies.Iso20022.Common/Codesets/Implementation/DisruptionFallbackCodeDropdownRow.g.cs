﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DisruptionFallbackCode.  ISO2002 ID# _awUtBtp-Ed-ak6NoX_4Aeg_627416917.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the method used to determine a settlement rate when a disruption event has occurred.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DisruptionFallbackCodeDropdownSource"/>.
/// Implements <seealso cref="IDisruptionFallbackCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_awUtBtp-Ed-ak6NoX_4Aeg_627416917")]
public partial class DisruptionFallbackCodeDropdownRow : EnumMetadataItem<DisruptionFallbackCode>, IDisruptionFallbackCodeDropdownRow
{
    /// <summary>
    /// Identifies the method used to determine a settlement rate when a disruption event has occurred.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DisruptionFallbackCodeDropdownRow(DisruptionFallbackCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
