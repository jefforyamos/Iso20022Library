﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementStatus2Code.  ISO2002 ID# _waKzmKMOEeCojJW5vEuTEQ_895697870.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_waKzmKMOEeCojJW5vEuTEQ_895697870")]
public partial class SettlementStatus2CodeDropdownRow : EnumMetadataItem<SettlementStatus2Code>, ISettlementStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the settlement of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementStatus2CodeDropdownRow(SettlementStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
