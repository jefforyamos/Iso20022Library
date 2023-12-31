﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SaleCapabilitiesCode.  ISO2002 ID# _yEJFENtrEeiXqq0XHEoNUA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Hardware capabilities of the Sale Terminal.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISaleCapabilitiesCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yEJFENtrEeiXqq0XHEoNUA")]
public partial class SaleCapabilitiesCodeDropdownSource : EnumMetadataManager<SaleCapabilitiesCode,ISaleCapabilitiesCodeDropdownRow,SaleCapabilitiesCodeDropdownRow>
{
    public SaleCapabilitiesCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SaleCapabilitiesCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
