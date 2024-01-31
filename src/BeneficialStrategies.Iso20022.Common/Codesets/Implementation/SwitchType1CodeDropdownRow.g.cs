﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SwitchType1Code.  ISO2002 ID# _wQUvEA2YEeSNWNtJlXOAhg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the switch either full or part for a given account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SwitchType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISwitchType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wQUvEA2YEeSNWNtJlXOAhg")]
public partial class SwitchType1CodeDropdownRow : EnumMetadataItem<SwitchType1Code>, ISwitchType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the switch either full or part for a given account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SwitchType1CodeDropdownRow(SwitchType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
