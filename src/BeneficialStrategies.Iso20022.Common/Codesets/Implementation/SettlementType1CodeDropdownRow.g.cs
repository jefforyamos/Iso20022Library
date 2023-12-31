﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementType1Code.  ISO2002 ID# _ZOH6d9p-Ed-ak6NoX_4Aeg_209112323.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates how an option trade is settled.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZOH6d9p-Ed-ak6NoX_4Aeg_209112323")]
public partial class SettlementType1CodeDropdownRow : EnumMetadataItem<SettlementType1Code>, ISettlementType1CodeDropdownRow
{
    /// <summary>
    /// Indicates how an option trade is settled.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementType1CodeDropdownRow(SettlementType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
