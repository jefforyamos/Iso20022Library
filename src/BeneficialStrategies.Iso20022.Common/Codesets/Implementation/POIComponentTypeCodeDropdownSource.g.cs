﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for POIComponentTypeCode.  ISO2002 ID# _TVCuEAEcEeCQm6a_G2yO_w_-1692790704.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPOIComponentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVCuEAEcEeCQm6a_G2yO_w_-1692790704")]
public partial class POIComponentTypeCodeDropdownSource : EnumMetadataManager<POIComponentTypeCode,IPOIComponentTypeCodeDropdownRow,POIComponentTypeCodeDropdownRow>
{
    public POIComponentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new POIComponentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
