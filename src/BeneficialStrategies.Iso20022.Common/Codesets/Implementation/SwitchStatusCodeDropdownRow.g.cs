﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SwitchStatusCode.  ISO2002 ID# _1fAkkBE2EeafpqhYGpTDnw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a given account switch.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SwitchStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ISwitchStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1fAkkBE2EeafpqhYGpTDnw")]
public partial class SwitchStatusCodeDropdownRow : EnumMetadataItem<SwitchStatusCode>, ISwitchStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a given account switch.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SwitchStatusCodeDropdownRow(SwitchStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
