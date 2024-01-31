﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RoutingTypeCode.  ISO2002 ID# _Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of routing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRoutingTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292")]
public partial class RoutingTypeCodeDropdownSource : EnumMetadataManager<RoutingTypeCode,IRoutingTypeCodeDropdownRow,RoutingTypeCodeDropdownRow>
{
    public RoutingTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RoutingTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
