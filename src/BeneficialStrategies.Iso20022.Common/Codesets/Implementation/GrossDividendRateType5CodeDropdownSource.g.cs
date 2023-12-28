﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GrossDividendRateType5Code.  ISO2002 ID# __sZAr5b8Eee8S7xwGG7Veg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of gross dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGrossDividendRateType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__sZAr5b8Eee8S7xwGG7Veg")]
public partial class GrossDividendRateType5CodeDropdownSource : EnumMetadataManager<GrossDividendRateType5Code,IGrossDividendRateType5CodeDropdownRow,GrossDividendRateType5CodeDropdownRow>
{
    public GrossDividendRateType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GrossDividendRateType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
