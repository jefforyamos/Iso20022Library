﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMMediaType1Code.  ISO2002 ID# _-L27wIqdEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of media inside an ATM cassette.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMMediaType1CodeDropdownSource"/>.
/// Implements <seealso cref="IATMMediaType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-L27wIqdEeS4a4abTJTSSw")]
public partial class ATMMediaType1CodeDropdownRow : EnumMetadataItem<ATMMediaType1Code>, IATMMediaType1CodeDropdownRow
{
    /// <summary>
    /// Type of media inside an ATM cassette.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMMediaType1CodeDropdownRow(ATMMediaType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}