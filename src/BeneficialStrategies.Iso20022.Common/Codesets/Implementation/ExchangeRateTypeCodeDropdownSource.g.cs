﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExchangeRateTypeCode.  ISO2002 ID# _ak11w9p-Ed-ak6NoX_4Aeg_-83850044.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code used to define the type of the currency exchange.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExchangeRateTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ak11w9p-Ed-ak6NoX_4Aeg_-83850044")]
public partial class ExchangeRateTypeCodeDropdownSource : EnumMetadataManager<ExchangeRateTypeCode,IExchangeRateTypeCodeDropdownRow,ExchangeRateTypeCodeDropdownRow>
{
    public ExchangeRateTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExchangeRateTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
