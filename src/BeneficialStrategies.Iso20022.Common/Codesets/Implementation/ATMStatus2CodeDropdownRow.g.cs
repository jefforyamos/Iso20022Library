﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMStatus2Code.  ISO2002 ID# _dpBEkIr-EeSvuOJS0mmL0g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Current status of the security device.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dpBEkIr-EeSvuOJS0mmL0g")]
public partial class ATMStatus2CodeDropdownRow : EnumMetadataItem<ATMStatus2Code>, IATMStatus2CodeDropdownRow
{
    /// <summary>
    /// Current status of the security device.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMStatus2CodeDropdownRow(ATMStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
