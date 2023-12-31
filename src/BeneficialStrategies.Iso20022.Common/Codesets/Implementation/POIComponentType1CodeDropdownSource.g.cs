﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for POIComponentType1Code.  ISO2002 ID# _TT2bMAEcEeCQm6a_G2yO_w_-1074872914.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPOIComponentType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TT2bMAEcEeCQm6a_G2yO_w_-1074872914")]
public partial class POIComponentType1CodeDropdownSource : EnumMetadataManager<POIComponentType1Code,IPOIComponentType1CodeDropdownRow,POIComponentType1CodeDropdownRow>
{
    public POIComponentType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new POIComponentType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
