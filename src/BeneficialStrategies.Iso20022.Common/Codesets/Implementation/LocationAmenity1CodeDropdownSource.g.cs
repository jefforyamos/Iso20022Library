﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LocationAmenity1Code.  ISO2002 ID# _uGACoDEtEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Codes pertaining to the amenities available at the location where the merchant actually performed the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILocationAmenity1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_uGACoDEtEemzCpWiCwK4aQ")]
public partial class LocationAmenity1CodeDropdownSource : EnumMetadataManager<LocationAmenity1Code,ILocationAmenity1CodeDropdownRow,LocationAmenity1CodeDropdownRow>
{
    public LocationAmenity1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new LocationAmenity1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}