﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for UnmatchedReason3Code.  ISO2002 ID# _Y6AElNp-Ed-ak6NoX_4Aeg_-290759549.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="UnmatchedReason3CodeDropdownSource"/>.
/// Implements <seealso cref="IUnmatchedReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y6AElNp-Ed-ak6NoX_4Aeg_-290759549")]
public partial class UnmatchedReason3CodeDropdownRow : EnumMetadataItem<UnmatchedReason3Code>, IUnmatchedReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public UnmatchedReason3CodeDropdownRow(UnmatchedReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
