﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMServiceType10Code.  ISO2002 ID# _urguca5EEeWCgYcWSNgX5g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of service selected by the customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMServiceType10CodeDropdownSource"/>.
/// Implements <seealso cref="IATMServiceType10CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_urguca5EEeWCgYcWSNgX5g")]
public partial class ATMServiceType10CodeDropdownRow : EnumMetadataItem<ATMServiceType10Code>, IATMServiceType10CodeDropdownRow
{
    /// <summary>
    /// Describes the type of service selected by the customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMServiceType10CodeDropdownRow(ATMServiceType10Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
