﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateStatusCode.  ISO2002 ID# _ZY_tttp-Ed-ak6NoX_4Aeg_878479095.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of rate.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IRateStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZY_tttp-Ed-ak6NoX_4Aeg_878479095")]
public partial class RateStatusCodeDropdownRow : EnumMetadataItem<RateStatusCode>, IRateStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of rate.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateStatusCodeDropdownRow(RateStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
