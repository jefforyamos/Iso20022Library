﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DayTypeCode.  ISO2002 ID# _ay2cldp-Ed-ak6NoX_4Aeg_1145636079.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of day.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DayTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDayTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ay2cldp-Ed-ak6NoX_4Aeg_1145636079")]
public partial class DayTypeCodeDropdownRow : EnumMetadataItem<DayTypeCode>, IDayTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of day.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DayTypeCodeDropdownRow(DayTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
