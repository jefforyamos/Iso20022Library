﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMMediaType2Code.  ISO2002 ID# _prJ48a4CEeWL1uap3dNhCQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of media inside an ATM cassette.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMMediaType2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMMediaType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_prJ48a4CEeWL1uap3dNhCQ")]
public partial class ATMMediaType2CodeDropdownRow : EnumMetadataItem<ATMMediaType2Code>, IATMMediaType2CodeDropdownRow
{
    /// <summary>
    /// Type of media inside an ATM cassette.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMMediaType2CodeDropdownRow(ATMMediaType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
