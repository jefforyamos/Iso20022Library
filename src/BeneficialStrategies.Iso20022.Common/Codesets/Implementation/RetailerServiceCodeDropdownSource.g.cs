﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RetailerServiceCode.  ISO2002 ID# _hlqYENt5EeiXqq0XHEoNUA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of services and functions available in ISO20022 Retail messages.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRetailerServiceCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hlqYENt5EeiXqq0XHEoNUA")]
public partial class RetailerServiceCodeDropdownSource : EnumMetadataManager<RetailerServiceCode,IRetailerServiceCodeDropdownRow,RetailerServiceCodeDropdownRow>
{
    public RetailerServiceCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RetailerServiceCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
