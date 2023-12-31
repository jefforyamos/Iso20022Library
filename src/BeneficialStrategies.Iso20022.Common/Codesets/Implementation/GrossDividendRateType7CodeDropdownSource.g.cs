﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GrossDividendRateType7Code.  ISO2002 ID# _jy6uoOXqEemEj48jhmlA0Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGrossDividendRateType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jy6uoOXqEemEj48jhmlA0Q")]
public partial class GrossDividendRateType7CodeDropdownSource : EnumMetadataManager<GrossDividendRateType7Code,IGrossDividendRateType7CodeDropdownRow,GrossDividendRateType7CodeDropdownRow>
{
    public GrossDividendRateType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GrossDividendRateType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
