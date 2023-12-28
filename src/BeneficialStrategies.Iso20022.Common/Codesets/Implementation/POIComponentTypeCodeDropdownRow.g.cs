﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for POIComponentTypeCode.  ISO2002 ID# _TVCuEAEcEeCQm6a_G2yO_w_-1692790704.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="POIComponentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPOIComponentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVCuEAEcEeCQm6a_G2yO_w_-1692790704")]
public partial class POIComponentTypeCodeDropdownRow : EnumMetadataItem<POIComponentTypeCode>, IPOIComponentTypeCodeDropdownRow
{
    /// <summary>
    /// Generic component type belonging to a POI (Point of Interaction) Terminal.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public POIComponentTypeCodeDropdownRow(POIComponentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}