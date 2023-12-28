﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateBasis1Code.  ISO2002 ID# _N0uXAM5KEeSc85GUbgBycw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a rate basis.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateBasis1CodeDropdownSource"/>.
/// Implements <seealso cref="IRateBasis1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_N0uXAM5KEeSc85GUbgBycw")]
public partial class RateBasis1CodeDropdownRow : EnumMetadataItem<RateBasis1Code>, IRateBasis1CodeDropdownRow
{
    /// <summary>
    /// Specifies a rate basis.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateBasis1CodeDropdownRow(RateBasis1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}