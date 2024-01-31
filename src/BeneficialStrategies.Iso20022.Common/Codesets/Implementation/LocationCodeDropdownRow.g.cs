﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LocationCode.  ISO2002 ID# _s14uMKHnEeagRbKvRt3LnA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a location.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LocationCodeDropdownSource"/>.
/// Implements <seealso cref="ILocationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_s14uMKHnEeagRbKvRt3LnA")]
public partial class LocationCodeDropdownRow : EnumMetadataItem<LocationCode>, ILocationCodeDropdownRow
{
    /// <summary>
    /// Specifies a location.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LocationCodeDropdownRow(LocationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
