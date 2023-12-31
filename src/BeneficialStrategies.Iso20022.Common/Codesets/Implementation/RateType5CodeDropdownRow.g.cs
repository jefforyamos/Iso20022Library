﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateType5Code.  ISO2002 ID# _ZZmKotp-Ed-ak6NoX_4Aeg_1481923249.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateType5CodeDropdownSource"/>.
/// Implements <seealso cref="IRateType5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZmKotp-Ed-ak6NoX_4Aeg_1481923249")]
public partial class RateType5CodeDropdownRow : EnumMetadataItem<RateType5Code>, IRateType5CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateType5CodeDropdownRow(RateType5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
