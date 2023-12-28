﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMServiceType5Code.  ISO2002 ID# _dWX-kYrAEeSgLpgNvMAP2g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of service selected by the customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMServiceType5CodeDropdownSource"/>.
/// Implements <seealso cref="IATMServiceType5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dWX-kYrAEeSgLpgNvMAP2g")]
public partial class ATMServiceType5CodeDropdownRow : EnumMetadataItem<ATMServiceType5Code>, IATMServiceType5CodeDropdownRow
{
    /// <summary>
    /// Describes the type of service selected by the customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMServiceType5CodeDropdownRow(ATMServiceType5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
