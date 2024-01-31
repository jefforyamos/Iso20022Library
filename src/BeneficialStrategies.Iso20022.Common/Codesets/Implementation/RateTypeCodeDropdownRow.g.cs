﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RateTypeCode.  ISO2002 ID# _ZZvUldp-Ed-ak6NoX_4Aeg_233339087.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Any and all rate is sought.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RateTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IRateTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZZvUldp-Ed-ak6NoX_4Aeg_233339087")]
public partial class RateTypeCodeDropdownRow : EnumMetadataItem<RateTypeCode>, IRateTypeCodeDropdownRow
{
    /// <summary>
    /// Any and all rate is sought.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RateTypeCodeDropdownRow(RateTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
