﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMCommand6Code.  ISO2002 ID# _-DDJwV_REeeD0NpJQPACzA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of command performed by the ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMCommand6CodeDropdownSource"/>.
/// Implements <seealso cref="IATMCommand6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-DDJwV_REeeD0NpJQPACzA")]
public partial class ATMCommand6CodeDropdownRow : EnumMetadataItem<ATMCommand6Code>, IATMCommand6CodeDropdownRow
{
    /// <summary>
    /// Type of command performed by the ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMCommand6CodeDropdownRow(ATMCommand6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
