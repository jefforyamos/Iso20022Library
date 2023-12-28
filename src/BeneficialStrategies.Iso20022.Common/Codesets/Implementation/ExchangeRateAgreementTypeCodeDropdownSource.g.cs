﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExchangeRateAgreementTypeCode.  ISO2002 ID# _c9M7QIZ5EeuSbct6WWD-Ng.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of Exchange Rate agreement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExchangeRateAgreementTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_c9M7QIZ5EeuSbct6WWD-Ng")]
public partial class ExchangeRateAgreementTypeCodeDropdownSource : EnumMetadataManager<ExchangeRateAgreementTypeCode,IExchangeRateAgreementTypeCodeDropdownRow,ExchangeRateAgreementTypeCodeDropdownRow>
{
    public ExchangeRateAgreementTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExchangeRateAgreementTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}