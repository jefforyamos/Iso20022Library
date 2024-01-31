﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCCPayoutType3Code.  ISO2002 ID# _UEfTgKFpEeSpipW1FBSFVg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCCPayoutType3CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCCPayoutType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UEfTgKFpEeSpipW1FBSFVg")]
public partial class DTCCPayoutType3CodeDropdownRow : EnumMetadataItem<DTCCPayoutType3Code>, IDTCCPayoutType3CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCCPayoutType3CodeDropdownRow(DTCCPayoutType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
