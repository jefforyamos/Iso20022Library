﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SuspendedStatusReason1Code.  ISO2002 ID# _ZQzbA9p-Ed-ak6NoX_4Aeg_689720893.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is suspended.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SuspendedStatusReason1CodeDropdownSource"/>.
/// Implements <seealso cref="ISuspendedStatusReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQzbA9p-Ed-ak6NoX_4Aeg_689720893")]
public partial class SuspendedStatusReason1CodeDropdownRow : EnumMetadataItem<SuspendedStatusReason1Code>, ISuspendedStatusReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is suspended.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SuspendedStatusReason1CodeDropdownRow(SuspendedStatusReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
