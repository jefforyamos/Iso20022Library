﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FleetPurchaseType1Code.  ISO2002 ID# _hoJpkDEnEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of codes representing type of fleet purchases.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFleetPurchaseType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hoJpkDEnEemzCpWiCwK4aQ")]
public partial class FleetPurchaseType1CodeDropdownSource : EnumMetadataManager<FleetPurchaseType1Code,IFleetPurchaseType1CodeDropdownRow,FleetPurchaseType1CodeDropdownRow>
{
    public FleetPurchaseType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FleetPurchaseType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
