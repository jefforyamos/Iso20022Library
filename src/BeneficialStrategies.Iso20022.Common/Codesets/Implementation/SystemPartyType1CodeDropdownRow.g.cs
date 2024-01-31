﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SystemPartyType1Code.  ISO2002 ID# _kp6thO5NEeCisYr99QEiWA_-1109986721.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the party within a system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SystemPartyType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISystemPartyType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kp6thO5NEeCisYr99QEiWA_-1109986721")]
public partial class SystemPartyType1CodeDropdownRow : EnumMetadataItem<SystemPartyType1Code>, ISystemPartyType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the party within a system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SystemPartyType1CodeDropdownRow(SystemPartyType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
