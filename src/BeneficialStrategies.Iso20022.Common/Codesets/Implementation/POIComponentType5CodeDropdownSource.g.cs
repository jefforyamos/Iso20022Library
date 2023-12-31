﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for POIComponentType5Code.  ISO2002 ID# _Ezi00dqiEeearpaEPXv9UA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of component belonging to a POI (Point of Interaction) Terminal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPOIComponentType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ezi00dqiEeearpaEPXv9UA")]
public partial class POIComponentType5CodeDropdownSource : EnumMetadataManager<POIComponentType5Code,IPOIComponentType5CodeDropdownRow,POIComponentType5CodeDropdownRow>
{
    public POIComponentType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new POIComponentType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
