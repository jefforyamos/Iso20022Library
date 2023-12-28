﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ThresholdBasis1Code.  ISO2002 ID# _IRxt4BuOEeyhRdHRjakS2w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ThresholdBasis1CodeDropdownSource"/>.
/// Implements <seealso cref="IThresholdBasis1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IRxt4BuOEeyhRdHRjakS2w")]
public partial class ThresholdBasis1CodeDropdownRow : EnumMetadataItem<ThresholdBasis1Code>, IThresholdBasis1CodeDropdownRow
{
    /// <summary>
    /// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ThresholdBasis1CodeDropdownRow(ThresholdBasis1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}