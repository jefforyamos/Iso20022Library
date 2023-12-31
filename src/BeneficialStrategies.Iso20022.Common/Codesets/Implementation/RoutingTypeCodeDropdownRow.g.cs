﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RoutingTypeCode.  ISO2002 ID# _Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of routing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RoutingTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IRoutingTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292")]
public partial class RoutingTypeCodeDropdownRow : EnumMetadataItem<RoutingTypeCode>, IRoutingTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates the type of routing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RoutingTypeCodeDropdownRow(RoutingTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
