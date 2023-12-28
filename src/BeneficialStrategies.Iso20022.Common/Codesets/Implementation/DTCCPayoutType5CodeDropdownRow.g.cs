﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCCPayoutType5Code.  ISO2002 ID# _zzlRAZCMEeaSk9d1hvTrHg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCCPayoutType5CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCCPayoutType5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zzlRAZCMEeaSk9d1hvTrHg")]
public partial class DTCCPayoutType5CodeDropdownRow : EnumMetadataItem<DTCCPayoutType5Code>, IDTCCPayoutType5CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCCPayoutType5CodeDropdownRow(DTCCPayoutType5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
