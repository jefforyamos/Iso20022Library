﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMCommandReasonCode.  ISO2002 ID# _s2j4EItGEeSxlKlAGYErFg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason for sending or requesting a maintenance command.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMCommandReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IATMCommandReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_s2j4EItGEeSxlKlAGYErFg")]
public partial class ATMCommandReasonCodeDropdownRow : EnumMetadataItem<ATMCommandReasonCode>, IATMCommandReasonCodeDropdownRow
{
    /// <summary>
    /// Reason for sending or requesting a maintenance command.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMCommandReasonCodeDropdownRow(ATMCommandReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
