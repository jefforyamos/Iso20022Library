﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BalanceType8Code.  ISO2002 ID# _baC_dNp-Ed-ak6NoX_4Aeg_-528666353.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BalanceType8CodeDropdownSource"/>.
/// Implements <seealso cref="IBalanceType8CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_baC_dNp-Ed-ak6NoX_4Aeg_-528666353")]
public partial class BalanceType8CodeDropdownRow : EnumMetadataItem<BalanceType8Code>, IBalanceType8CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the balance, eg, opening balance.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BalanceType8CodeDropdownRow(BalanceType8Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
