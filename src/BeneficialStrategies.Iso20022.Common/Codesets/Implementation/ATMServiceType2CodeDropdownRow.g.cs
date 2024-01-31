﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMServiceType2Code.  ISO2002 ID# _qqjTwIqnEeS4a4abTJTSSw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of ATM transaction selected by the customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMServiceType2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMServiceType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qqjTwIqnEeS4a4abTJTSSw")]
public partial class ATMServiceType2CodeDropdownRow : EnumMetadataItem<ATMServiceType2Code>, IATMServiceType2CodeDropdownRow
{
    /// <summary>
    /// Describes the type of ATM transaction selected by the customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMServiceType2CodeDropdownRow(ATMServiceType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
