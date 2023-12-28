﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementStatus1Code.  ISO2002 ID# _ZMVKttp-Ed-ak6NoX_4Aeg_-1382213179.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZMVKttp-Ed-ak6NoX_4Aeg_-1382213179")]
public partial class SettlementStatus1CodeDropdownRow : EnumMetadataItem<SettlementStatus1Code>, ISettlementStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the settlement of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementStatus1CodeDropdownRow(SettlementStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
