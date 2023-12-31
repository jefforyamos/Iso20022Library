﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCCPayoutType1Code.  ISO2002 ID# _1rD7UzL3EeKU9IrkkToqcw_1294109799.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCCPayoutType1CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCCPayoutType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1rD7UzL3EeKU9IrkkToqcw_1294109799")]
public partial class DTCCPayoutType1CodeDropdownRow : EnumMetadataItem<DTCCPayoutType1Code>, IDTCCPayoutType1CodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCCPayoutType1CodeDropdownRow(DTCCPayoutType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
