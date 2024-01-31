﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LocationCategory4Code.  ISO2002 ID# _3eb_cFDdEeu8Rss-tto59A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of integration of the POI terminal in the sale environment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILocationCategory4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3eb_cFDdEeu8Rss-tto59A")]
public partial class LocationCategory4CodeDropdownSource : EnumMetadataManager<LocationCategory4Code,ILocationCategory4CodeDropdownRow,LocationCategory4CodeDropdownRow>
{
    public LocationCategory4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LocationCategory4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
