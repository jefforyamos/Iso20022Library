﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FailingReason3Code.  ISO2002 ID# _ABlNIRqLEeG38P9Gj2JZJw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FailingReason3CodeDropdownSource"/>.
/// Implements <seealso cref="IFailingReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ABlNIRqLEeG38P9Gj2JZJw")]
public partial class FailingReason3CodeDropdownRow : EnumMetadataItem<FailingReason3Code>, IFailingReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FailingReason3CodeDropdownRow(FailingReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
