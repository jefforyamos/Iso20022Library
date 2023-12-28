﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SecuritiesSettlementStatus2Code.  ISO2002 ID# _JhIYoUABEeCaq78Ig8ATcA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of settlement of an instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SecuritiesSettlementStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="ISecuritiesSettlementStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JhIYoUABEeCaq78Ig8ATcA")]
public partial class SecuritiesSettlementStatus2CodeDropdownRow : EnumMetadataItem<SecuritiesSettlementStatus2Code>, ISecuritiesSettlementStatus2CodeDropdownRow
{
    /// <summary>
    /// Provides the status of settlement of an instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SecuritiesSettlementStatus2CodeDropdownRow(SecuritiesSettlementStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}