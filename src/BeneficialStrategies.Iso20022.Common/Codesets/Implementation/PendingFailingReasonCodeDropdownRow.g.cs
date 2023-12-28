﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingFailingReasonCode.  ISO2002 ID# _Z-QW5dp-Ed-ak6NoX_4Aeg_-2146608608.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingFailingReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IPendingFailingReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z-QW5dp-Ed-ak6NoX_4Aeg_-2146608608")]
public partial class PendingFailingReasonCodeDropdownRow : EnumMetadataItem<PendingFailingReasonCode>, IPendingFailingReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending or failing settlement. Settlement on the instructed settlement date is still possible, status is pending. Settlement on the instructed settlement date is no longer possible, status is failing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingFailingReasonCodeDropdownRow(PendingFailingReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}