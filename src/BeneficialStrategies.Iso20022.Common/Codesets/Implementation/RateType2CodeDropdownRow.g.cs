﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateType2Code.  ISO2002 ID# _ZZJeuNp-Ed-ak6NoX_4Aeg_-1692318334.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateType2CodeDropdownSource"/>.
/// Implements <seealso cref="IRateType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZJeuNp-Ed-ak6NoX_4Aeg_-1692318334")]
public partial class RateType2CodeDropdownRow : EnumMetadataItem<RateType2Code>, IRateType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateType2CodeDropdownRow(RateType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}