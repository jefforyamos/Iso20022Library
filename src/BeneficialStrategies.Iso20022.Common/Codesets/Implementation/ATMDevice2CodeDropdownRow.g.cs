﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMDevice2Code.  ISO2002 ID# _1m2agIqtEeSIDtZ76p6McQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of ATM devices.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMDevice2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMDevice2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1m2agIqtEeSIDtZ76p6McQ")]
public partial class ATMDevice2CodeDropdownRow : EnumMetadataItem<ATMDevice2Code>, IATMDevice2CodeDropdownRow
{
    /// <summary>
    /// List of ATM devices.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMDevice2CodeDropdownRow(ATMDevice2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}