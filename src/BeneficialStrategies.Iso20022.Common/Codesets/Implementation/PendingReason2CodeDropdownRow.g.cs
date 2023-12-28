﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason2Code.  ISO2002 ID# _eGdfsf40EeClUvPNHKL9Zw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason2CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eGdfsf40EeClUvPNHKL9Zw")]
public partial class PendingReason2CodeDropdownRow : EnumMetadataItem<PendingReason2Code>, IPendingReason2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending settlement. Settlement on the instructed settlement date is still possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason2CodeDropdownRow(PendingReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}