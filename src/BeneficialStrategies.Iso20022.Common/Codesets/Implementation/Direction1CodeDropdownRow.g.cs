﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Direction1Code.  ISO2002 ID# _awK8Adp-Ed-ak6NoX_4Aeg_1477351773.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the direction of a payment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Direction1CodeDropdownSource"/>.
/// Implements <seealso cref="IDirection1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_awK8Adp-Ed-ak6NoX_4Aeg_1477351773")]
public partial class Direction1CodeDropdownRow : EnumMetadataItem<Direction1Code>, IDirection1CodeDropdownRow
{
    /// <summary>
    /// Specifies the direction of a payment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Direction1CodeDropdownRow(Direction1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
