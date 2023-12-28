﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettleStyleCode.  ISO2002 ID# _ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when the option contract settles.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettleStyleCodeDropdownSource"/>.
/// Implements <seealso cref="ISettleStyleCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZOa1Ytp-Ed-ak6NoX_4Aeg_1310457218")]
public partial class SettleStyleCodeDropdownRow : EnumMetadataItem<SettleStyleCode>, ISettleStyleCodeDropdownRow
{
    /// <summary>
    /// Specifies when the option contract settles.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettleStyleCodeDropdownRow(SettleStyleCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}