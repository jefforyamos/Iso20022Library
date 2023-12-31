﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GracePeriodUnitTypeCode.  ISO2002 ID# _s_4u99uVEei2qvU6FBLZYA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GracePeriodUnitTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IGracePeriodUnitTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_s_4u99uVEei2qvU6FBLZYA")]
public partial class GracePeriodUnitTypeCodeDropdownRow : EnumMetadataItem<GracePeriodUnitTypeCode>, IGracePeriodUnitTypeCodeDropdownRow
{
    /// <summary>
    /// Contains the details of the grace period applicable to the instalment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GracePeriodUnitTypeCodeDropdownRow(GracePeriodUnitTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
