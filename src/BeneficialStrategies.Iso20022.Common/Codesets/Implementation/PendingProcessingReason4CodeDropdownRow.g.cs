﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingProcessingReason4Code.  ISO2002 ID# _BYbMigpKEeup4r-PFG2T5Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingProcessingReason4CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingProcessingReason4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BYbMigpKEeup4r-PFG2T5Q")]
public partial class PendingProcessingReason4CodeDropdownRow : EnumMetadataItem<PendingProcessingReason4Code>, IPendingProcessingReason4CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingProcessingReason4CodeDropdownRow(PendingProcessingReason4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}