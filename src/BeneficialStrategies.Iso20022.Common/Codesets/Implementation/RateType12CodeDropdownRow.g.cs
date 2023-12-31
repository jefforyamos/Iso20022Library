﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateType12Code.  ISO2002 ID# _ZZJesNp-Ed-ak6NoX_4Aeg_-1551942195.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateType12CodeDropdownSource"/>.
/// Implements <seealso cref="IRateType12CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZJesNp-Ed-ak6NoX_4Aeg_-1551942195")]
public partial class RateType12CodeDropdownRow : EnumMetadataItem<RateType12Code>, IRateType12CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateType12CodeDropdownRow(RateType12Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
