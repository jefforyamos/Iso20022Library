﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMDevice1Code.  ISO2002 ID# _TVx90IqIEeSRT5rEzcAHEw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// ATM device to output message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMDevice1CodeDropdownSource"/>.
/// Implements <seealso cref="IATMDevice1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVx90IqIEeSRT5rEzcAHEw")]
public partial class ATMDevice1CodeDropdownRow : EnumMetadataItem<ATMDevice1Code>, IATMDevice1CodeDropdownRow
{
    /// <summary>
    /// ATM device to output message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMDevice1CodeDropdownRow(ATMDevice1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
