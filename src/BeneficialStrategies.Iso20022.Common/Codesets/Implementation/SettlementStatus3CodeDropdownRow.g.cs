﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementStatus3Code.  ISO2002 ID# _GbRzsAF1EeutW5-TpeYJhA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementStatus3CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementStatus3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GbRzsAF1EeutW5-TpeYJhA")]
public partial class SettlementStatus3CodeDropdownRow : EnumMetadataItem<SettlementStatus3Code>, ISettlementStatus3CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the settlement of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementStatus3CodeDropdownRow(SettlementStatus3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}