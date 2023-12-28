﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PriceValueType6Code.  ISO2002 ID# _aJk2Ftp-Ed-ak6NoX_4Aeg_-608123494.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the value of a price.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceValueType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aJk2Ftp-Ed-ak6NoX_4Aeg_-608123494")]
public partial class PriceValueType6CodeDropdownSource : EnumMetadataManager<PriceValueType6Code,IPriceValueType6CodeDropdownRow,PriceValueType6CodeDropdownRow>
{
    public PriceValueType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceValueType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}