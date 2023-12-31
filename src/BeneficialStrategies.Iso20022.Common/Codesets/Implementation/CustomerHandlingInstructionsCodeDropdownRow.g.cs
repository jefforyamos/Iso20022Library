﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CustomerHandlingInstructionsCode.  ISO2002 ID# _axg_2dp-Ed-ak6NoX_4Aeg_-38390159.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Codes that apply special information that the Broker / Dealer needs to report, as specified by the customer. Firms that are taking in orders manually but routing for execution electronically and for compliance reporting must capture the client's handling instructions.This is intended for reporting only ( OATS = Order Audit Trail System - Phase III regulatory requirement).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CustomerHandlingInstructionsCodeDropdownSource"/>.
/// Implements <seealso cref="ICustomerHandlingInstructionsCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_axg_2dp-Ed-ak6NoX_4Aeg_-38390159")]
public partial class CustomerHandlingInstructionsCodeDropdownRow : EnumMetadataItem<CustomerHandlingInstructionsCode>, ICustomerHandlingInstructionsCodeDropdownRow
{
    /// <summary>
    /// Codes that apply special information that the Broker / Dealer needs to report, as specified by the customer. Firms that are taking in orders manually but routing for execution electronically and for compliance reporting must capture the client's handling instructions.This is intended for reporting only ( OATS = Order Audit Trail System - Phase III regulatory requirement).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CustomerHandlingInstructionsCodeDropdownRow(CustomerHandlingInstructionsCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
