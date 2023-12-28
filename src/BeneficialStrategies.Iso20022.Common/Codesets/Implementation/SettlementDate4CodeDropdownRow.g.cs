﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementDate4Code.  ISO2002 ID# _ZLby1dp-Ed-ak6NoX_4Aeg_1690826366.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementDate4CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementDate4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZLby1dp-Ed-ak6NoX_4Aeg_1690826366")]
public partial class SettlementDate4CodeDropdownRow : EnumMetadataItem<SettlementDate4Code>, ISettlementDate4CodeDropdownRow
{
    /// <summary>
    /// Specifies the date of settlement, in coded form.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementDate4CodeDropdownRow(SettlementDate4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}