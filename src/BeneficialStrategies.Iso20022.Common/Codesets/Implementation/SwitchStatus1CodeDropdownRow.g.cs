﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SwitchStatus1Code.  ISO2002 ID# _QKe20H6rEeePx-IqKegQ8Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a given account switch.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SwitchStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ISwitchStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QKe20H6rEeePx-IqKegQ8Q")]
public partial class SwitchStatus1CodeDropdownRow : EnumMetadataItem<SwitchStatus1Code>, ISwitchStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a given account switch.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SwitchStatus1CodeDropdownRow(SwitchStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
