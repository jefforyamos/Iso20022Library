﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementStatusCode.  ISO2002 ID# _ZMe7udp-Ed-ak6NoX_4Aeg_1523779610.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementStatusCodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZMe7udp-Ed-ak6NoX_4Aeg_1523779610")]
public partial class SettlementStatusCodeDropdownRow : EnumMetadataItem<SettlementStatusCode>, ISettlementStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the settlement of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementStatusCodeDropdownRow(SettlementStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}