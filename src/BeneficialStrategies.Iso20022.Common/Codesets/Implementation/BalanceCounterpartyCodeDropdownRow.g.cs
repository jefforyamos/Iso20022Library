﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceCounterpartyCode.  ISO2002 ID# _bkBa1dp-Ed-ak6NoX_4Aeg_678189971.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of counterparty to be taken into account for calculation of the balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceCounterpartyCodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceCounterpartyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bkBa1dp-Ed-ak6NoX_4Aeg_678189971")]
public partial class BalanceCounterpartyCodeDropdownRow : EnumMetadataItem<BalanceCounterpartyCode>, IBalanceCounterpartyCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of counterparty to be taken into account for calculation of the balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceCounterpartyCodeDropdownRow(BalanceCounterpartyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
