﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StampDutyType2Code.  ISO2002 ID# _suw7QPpiEeCG_oUHBFcYXA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StampDutyType2CodeDropdownSource"/>.
/// Implements <seealso cref="IStampDutyType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_suw7QPpiEeCG_oUHBFcYXA")]
public partial class StampDutyType2CodeDropdownRow : EnumMetadataItem<StampDutyType2Code>, IStampDutyType2CodeDropdownRow
{
    /// <summary>
    /// Specifies if the stamp duty is applicable.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StampDutyType2CodeDropdownRow(StampDutyType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
