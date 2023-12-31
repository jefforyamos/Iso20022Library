﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingProcessingReason2Code.  ISO2002 ID# _Ln0Pkf4zEeClUvPNHKL9Zw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingProcessingReason2CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingProcessingReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ln0Pkf4zEeClUvPNHKL9Zw")]
public partial class PendingProcessingReason2CodeDropdownRow : EnumMetadataItem<PendingProcessingReason2Code>, IPendingProcessingReason2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingProcessingReason2CodeDropdownRow(PendingProcessingReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
