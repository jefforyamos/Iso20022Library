﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InRepairStatusReasonCode.  ISO2002 ID# _aWsFB9p-Ed-ak6NoX_4Aeg_1106691227.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a In Repair status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InRepairStatusReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IInRepairStatusReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aWsFB9p-Ed-ak6NoX_4Aeg_1106691227")]
public partial class InRepairStatusReasonCodeDropdownRow : EnumMetadataItem<InRepairStatusReasonCode>, IInRepairStatusReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a In Repair status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InRepairStatusReasonCodeDropdownRow(InRepairStatusReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}