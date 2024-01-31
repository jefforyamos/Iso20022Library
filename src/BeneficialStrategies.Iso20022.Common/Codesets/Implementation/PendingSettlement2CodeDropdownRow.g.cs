﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingSettlement2Code.  ISO2002 ID# _aDKsE9p-Ed-ak6NoX_4Aeg_-1807424402.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingSettlement2CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingSettlement2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aDKsE9p-Ed-ak6NoX_4Aeg_-1807424402")]
public partial class PendingSettlement2CodeDropdownRow : EnumMetadataItem<PendingSettlement2Code>, IPendingSettlement2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is pending settlement, that is, pending delivery or receipt of the financial instrument. Settlement on the instructed settlement date is still possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingSettlement2CodeDropdownRow(PendingSettlement2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
