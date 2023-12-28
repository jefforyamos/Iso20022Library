﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GrossDividendRateType3Code.  ISO2002 ID# _XfCfsBLZEeKJ5uSjVyVvug.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGrossDividendRateType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XfCfsBLZEeKJ5uSjVyVvug")]
public partial class GrossDividendRateType3CodeDropdownSource : EnumMetadataManager<GrossDividendRateType3Code,IGrossDividendRateType3CodeDropdownRow,GrossDividendRateType3CodeDropdownRow>
{
    public GrossDividendRateType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GrossDividendRateType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}