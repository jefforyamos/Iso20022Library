﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason7Code.  ISO2002 ID# _aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason7CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aDBiJ9p-Ed-ak6NoX_4Aeg_1672936619")]
public partial class PendingReason7CodeDropdownRow : EnumMetadataItem<PendingReason7Code>, IPendingReason7CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason7CodeDropdownRow(PendingReason7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
