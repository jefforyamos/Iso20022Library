﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExchangePolicyCode.  ISO2002 ID# _KR1s8X1DEeCF8NjrBemJWQ_-1574352782.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange policy between parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExchangePolicyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KR1s8X1DEeCF8NjrBemJWQ_-1574352782")]
public partial class ExchangePolicyCodeDropdownSource : EnumMetadataManager<ExchangePolicyCode,IExchangePolicyCodeDropdownRow,ExchangePolicyCodeDropdownRow>
{
    public ExchangePolicyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExchangePolicyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
