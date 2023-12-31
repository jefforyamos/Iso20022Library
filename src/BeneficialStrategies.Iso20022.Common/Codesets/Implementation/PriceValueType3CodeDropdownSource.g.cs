﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PriceValueType3Code.  ISO2002 ID# _aJR7Jdp-Ed-ak6NoX_4Aeg_-611906034.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of value of the price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceValueType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aJR7Jdp-Ed-ak6NoX_4Aeg_-611906034")]
public partial class PriceValueType3CodeDropdownSource : EnumMetadataManager<PriceValueType3Code,IPriceValueType3CodeDropdownRow,PriceValueType3CodeDropdownRow>
{
    public PriceValueType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceValueType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
