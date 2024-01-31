﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMCounterType1Code.  ISO2002 ID# _-bKw0IqiEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMCounterType1CodeDropdownSource"/>.
/// Implements <seealso cref="IATMCounterType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-bKw0IqiEeS4a4abTJTSSw")]
public partial class ATMCounterType1CodeDropdownRow : EnumMetadataItem<ATMCounterType1Code>, IATMCounterType1CodeDropdownRow
{
    /// <summary>
    /// Type of ATM cassette counters.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMCounterType1CodeDropdownRow(ATMCounterType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
