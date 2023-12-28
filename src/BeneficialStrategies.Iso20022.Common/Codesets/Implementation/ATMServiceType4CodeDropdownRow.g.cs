﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMServiceType4Code.  ISO2002 ID# _kpAfsIq1EeSIDtZ76p6McQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service to be offered for a customer at an ATM.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMServiceType4CodeDropdownSource"/>.
/// Implements <seealso cref="IATMServiceType4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kpAfsIq1EeSIDtZ76p6McQ")]
public partial class ATMServiceType4CodeDropdownRow : EnumMetadataItem<ATMServiceType4Code>, IATMServiceType4CodeDropdownRow
{
    /// <summary>
    /// Type of service to be offered for a customer at an ATM.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMServiceType4CodeDropdownRow(ATMServiceType4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
