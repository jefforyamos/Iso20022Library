﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnmatchedStatusReason1Code.  ISO2002 ID# _Y7f5Z9p-Ed-ak6NoX_4Aeg_689720409.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction/instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnmatchedStatusReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IUnmatchedStatusReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y7f5Z9p-Ed-ak6NoX_4Aeg_689720409")]
public partial class UnmatchedStatusReason1CodeDropdownRow : EnumMetadataItem<UnmatchedStatusReason1Code>, IUnmatchedStatusReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnmatchedStatusReason1CodeDropdownRow(UnmatchedStatusReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}