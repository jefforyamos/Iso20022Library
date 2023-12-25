﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for QuoteResponseTypeCode.  ISO2002 ID# _ZYG85dp-Ed-ak6NoX_4Aeg_336258286.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies the nature of response to a previoulsy addressed quote.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQuoteResponseTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZYG85dp-Ed-ak6NoX_4Aeg_336258286")]
public partial class QuoteResponseTypeCodeDropdownSource : EnumMetadataManager<QuoteResponseTypeCode,IQuoteResponseTypeCodeDropdownRow,QuoteResponseTypeCodeDropdownRow>
{
    public QuoteResponseTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new QuoteResponseTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
