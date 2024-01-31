﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMCounterTypeCode.  ISO2002 ID# _vSNNoIqiEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of ATM cassette counters.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMCounterTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IATMCounterTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vSNNoIqiEeS4a4abTJTSSw")]
public partial class ATMCounterTypeCodeDropdownRow : EnumMetadataItem<ATMCounterTypeCode>, IATMCounterTypeCodeDropdownRow
{
    /// <summary>
    /// Type of ATM cassette counters.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMCounterTypeCodeDropdownRow(ATMCounterTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
