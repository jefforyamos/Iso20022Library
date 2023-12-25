﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashSettlementSystemCode.  ISO2002 ID# _a7WRRtp-Ed-ak6NoX_4Aeg_-901576222.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the cash settlement system used.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashSettlementSystemCodeDropdownSource"/>.
/// Implements <seealso cref="ICashSettlementSystemCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a7WRRtp-Ed-ak6NoX_4Aeg_-901576222")]
public partial class CashSettlementSystemCodeDropdownRow : EnumMetadataItem<CashSettlementSystemCode>, ICashSettlementSystemCodeDropdownRow
{
    /// <summary>
    /// Specifies the cash settlement system used.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashSettlementSystemCodeDropdownRow(CashSettlementSystemCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
