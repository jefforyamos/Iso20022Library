﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingStatus4Code.  ISO2002 ID# _aGJuo9p-Ed-ak6NoX_4Aeg_1263998543.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the state of a payment at the clearing agent side is pending.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingStatus4CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingStatus4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aGJuo9p-Ed-ak6NoX_4Aeg_1263998543")]
public partial class PendingStatus4CodeDropdownRow : EnumMetadataItem<PendingStatus4Code>, IPendingStatus4CodeDropdownRow
{
    /// <summary>
    /// Indicates that the state of a payment at the clearing agent side is pending.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingStatus4CodeDropdownRow(PendingStatus4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
