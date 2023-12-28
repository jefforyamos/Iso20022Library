﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for POIComponentType2Code.  ISO2002 ID# _KTVhw31DEeCF8NjrBemJWQ_-502719027.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Generic component type belonging to a POI (Point of Interaction) Terminal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPOIComponentType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTVhw31DEeCF8NjrBemJWQ_-502719027")]
public partial class POIComponentType2CodeDropdownSource : EnumMetadataManager<POIComponentType2Code,IPOIComponentType2CodeDropdownRow,POIComponentType2CodeDropdownRow>
{
    public POIComponentType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new POIComponentType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}