﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateStatus1Code.  ISO2002 ID# _ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IRateStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZY_ts9p-Ed-ak6NoX_4Aeg_1472885519")]
public partial class RateStatus1CodeDropdownRow : EnumMetadataItem<RateStatus1Code>, IRateStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateStatus1CodeDropdownRow(RateStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}