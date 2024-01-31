﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingFailingSettlementCode.  ISO2002 ID# _Z_vkptp-Ed-ak6NoX_4Aeg_689720580.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingFailingSettlementCodeDropdownSource"/>.
/// Implements <seealso cref="IPendingFailingSettlementCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z_vkptp-Ed-ak6NoX_4Aeg_689720580")]
public partial class PendingFailingSettlementCodeDropdownRow : EnumMetadataItem<PendingFailingSettlementCode>, IPendingFailingSettlementCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending failing settlement, and the settlement at the instruction settlement date is no longer possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingFailingSettlementCodeDropdownRow(PendingFailingSettlementCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
