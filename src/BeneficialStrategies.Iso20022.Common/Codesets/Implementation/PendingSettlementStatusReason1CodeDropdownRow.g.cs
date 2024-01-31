﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingSettlementStatusReason1Code.  ISO2002 ID# _VjSAYdp-Ed-ak6NoX_4Aeg_1304044269.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction settlement pending status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingSettlementStatusReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingSettlementStatusReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VjSAYdp-Ed-ak6NoX_4Aeg_1304044269")]
public partial class PendingSettlementStatusReason1CodeDropdownRow : EnumMetadataItem<PendingSettlementStatusReason1Code>, IPendingSettlementStatusReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a transfer or settlement instruction settlement pending status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingSettlementStatusReason1CodeDropdownRow(PendingSettlementStatusReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
