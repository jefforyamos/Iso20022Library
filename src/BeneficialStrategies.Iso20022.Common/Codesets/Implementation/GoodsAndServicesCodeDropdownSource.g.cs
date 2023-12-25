﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GoodsAndServicesCode.  ISO2002 ID# _1F82kErCEeenp6hmNprBHg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of goods and services purchased.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGoodsAndServicesCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1F82kErCEeenp6hmNprBHg")]
public partial class GoodsAndServicesCodeDropdownSource : EnumMetadataManager<GoodsAndServicesCode,IGoodsAndServicesCodeDropdownRow,GoodsAndServicesCodeDropdownRow>
{
    public GoodsAndServicesCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GoodsAndServicesCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
